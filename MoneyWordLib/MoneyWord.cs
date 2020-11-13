using System;

namespace UnleashedTest {
        
    public static class MoneyWord {
        
        public const int MAX_LHS = 9;

        public static readonly string[] NUMBER_WORDS = {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine",
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"        
        };

        enum Parts {
            Dollars,
            Cents,
        }
        
        public static string convertToWords(string input) {

            if (!validateIsMoneyFormat(input)) {
                return "Error: Bad input";
            }

            //split into right side and left side            
            string rs = "";
            string ls = "";
            if (input.Contains(".")) {
                string[] splat = input.Split(".");
                ls = splat[0];
                rs = splat[1];
            }
            else {
                ls = input;
                rs = "00";
            }
            int numDollars = int.Parse(ls);
            int numCents = int.Parse(rs);

            string wordDollars = "";
            string wordCents = "";
            if (numDollars < 100) {            
                //tens (dollars)
                wordDollars = baseNumber(ls);
            }
            else if (numDollars < 1000) {
                //hundreds (dollars)
                wordDollars = hundredNumber(ls);
            }   
            else if (numDollars < 1000000) {
                //thousands (dollars)
                wordDollars = thousandNumber(ls);
            }  
            else if (numDollars < 1000000000) {
                //thousands (dollars)
                wordDollars = millionNumber(ls);
            }    
            //tens (cents)
            wordCents = baseNumber(rs); 

            //dollars
            //if num == 0, nothing
            if (numDollars == 1) {
                wordDollars += " dollar";
            } 
            else if (numDollars >=2) {
                wordDollars += " dollars";
            }
            //cents
            if (numDollars > 0 && numCents > 0) {
                wordDollars += " and ";
            }
            //if num == 0, nothing
            if (numCents == 1) {
                wordCents += " cent";
            }
            else if (numCents >= 2) {
                wordCents += " cents";
            }
            string output = wordDollars + wordCents;
            if (numDollars == 0 && numCents == 0) {
                output = "zero dollars and zero cents";
            }
            return output;
        }

        private static string millionNumber(string numString) {
            string result = "";
            if (numString.Length >= 7 && numString.Length <= 9) {
                int num = int.Parse(numString);
                int millions = num/1000000;
                int remainder = num%1000000;
                if (millions > 0) {
                    string millionsToString = millions.ToString("D3");
                    result = $"{hundredNumber(millionsToString)} million";
                    if (remainder > 0 && remainder < 100)
                        result += " and ";
                    else if (remainder > 0)
                        result += ", ";
                }
                if (remainder > 0) {
                    result += thousandNumber(numString.Substring(numString.Length-6,6));
                }
            }
            else {
                throw new System.ArgumentException("Error: millionNumber function given number string not 7-9 digits");
            }
            return result;
        }

        private static string thousandNumber(string numString) {
            string result = "";
            if (numString.Length >= 4 && numString.Length <= 6) {
                int num = int.Parse(numString);
                int thousands = num/1000;
                int remainder = num%1000;
                if (thousands > 0) {
                    string thousandsToString = thousands.ToString("D3");
                    result = $"{hundredNumber(thousandsToString)} thousand";
                    if (remainder > 0 && remainder < 100)
                        result += " and ";
                    else if (remainder > 0) 
                        result += ", ";
                }
                if (remainder > 0) {
                    result += hundredNumber(numString.Substring(numString.Length-3,3));
                }
            }
            else {
                throw new System.ArgumentException("Error: thousandNumber function given number string not 4-6 digits");
            }
            return result;
        }

        private static string hundredNumber(string numString) {
            string result = "";
            if (numString.Length == 3) {
                int num = int.Parse(numString);
                int hundreds = num/100;
                int remainder = num%100;
                if (hundreds > 0) {
                    result = $"{NUMBER_WORDS[hundreds]} hundred";
                    if (remainder > 0)
                        result += " and ";
                }
                if (remainder > 0) {
                    result += baseNumber(numString.Substring(1,2));
                }
            }
            else {
                throw new System.ArgumentException("Error: hundredNumber function given number string not 3 digits");
            }
            return result;
        }

        private static string baseNumber(string numString) {
            string result = "";
            int num = int.Parse(numString);
            if (num >= 1 && num <= 19) {
                result = NUMBER_WORDS[num];
            } 
            else if (num >= 20 && num <= 99) {
                int tens = num/10;
                int ones = num%10; 
                result = NUMBER_WORDS[18 + tens];
                if (ones != 0) {
                    result += $"-{NUMBER_WORDS[ones]}";
                }
            }
            //if num == 0, leave empty.
            else if (num != 0) {
                throw new System.ArgumentException("Error: baseNumber function given number outside of 0-99");
            }
            return result;
        }

        private static bool validateIsMoneyFormat(string input) {
            
            Parts thePart = Parts.Dollars;
            int countCentsDigits = 0;
            int length = 0;
            foreach (char ch in input) {
                ++length;
                if (thePart == Parts.Dollars) {
                    //any number of numerical digits, up to a decimal point
                    if (Char.IsNumber(ch)) {
                        if (length > MAX_LHS)
                            return false;
                        continue;
                    }
                    else if (ch == '.') {
                        //first must be a number
                        if (length == 1)
                            return false;
                        //change rules
                        thePart = Parts.Cents;
                        continue;
                    } 
                    else {
                        return false;
                    } 
                }
                else if (thePart == Parts.Cents) {
                    if (Char.IsNumber(ch)) {
                        ++countCentsDigits;
                        continue;
                    }
                    else {
                        return false;
                    } 
                }
            }
            if (thePart == Parts.Cents && countCentsDigits != 2) {
                //must be exactly 2 numerical digits
                return false;
            }

            return true;
        }
    }
}