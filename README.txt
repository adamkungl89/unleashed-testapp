README

Unleashed Test App 

Run with 'dotnet run --project .\MoneyWordConsole\MoneyWordConsole.csproj [input]' from the command line.
Or 'dotnet publish --configuration Release' and run the 'MoneyWordConsole.exe' in folder 'C:\Dev\UnleashedTest\MoneyWordConsole\bin\Release\net5.0\publish' 

Input is a single argument, with valid forms:
123				(no cents)
123.45			(standard dollars and cents)
000000123.45	(leading zeroes are valid in dollars representation up to 9 digits)
up to 999999999.99
No commas are accepted in large numbers.

Output is in the form 
"nine hundred and ninety-nine thousand, five hundred and fifty-five dollars and thirty-two cents"

Unit tests are provided in MoneyWordTest.UnitTest1 and are designed to cover the range of possible number word combinations, as well as invalid inputs.
Tests can be run with 'dotnet test .\MoneyWordTest\MoneyWordTest.csproj'
