# Learning Csharp

# Basics

To print to console `Console.WriteLine(”A String”)` this prints with a newline

- Data types
    - string
        
        string name = “John”, you can get a newline by `\n` to escape unique characters like “ you can put a \ in front of it
        
        someString.Length() gives lenght of string
        
        someString.ToUpper() and .ToLower() puts string in upper and lower case respectively 
        
        someString.Contain(”Another String”) returns a boolean if the string contains the other
        
        someString[index] yields the character at the index of the string
        
        someString.IndexOf(”String”) returns the index where the string starts, can also pass in a single characters and then the index of the first character will be retuned. If not in string returns -1
        
        someString.Substring(index, len) returns substring from index to end, or a certain len if len parameter is given
        
    - storing numbers
        - int
            
            Whole numbers
            
        - float
            
            numbers that arent whole
            
        - double
            
            pretty accurate description of number
            
        - decimal
            
            most accurate way to represent number
            
    - char
        - single character, use single quotation marks like `char grade = 'A'`
    - Boolean
        
        true or false, initiated by `bool`
        

Strings can be concatenated by using `+` between strings

## Math

operators:

 + - * / works as normal

% is the modulus operator

++ and — adds 1 and subtracts 1, 

+= and -= adds one or subtracts an amount from a variable

### Using the math module

Math.Abs(num) yields the absolute value

Math.Pow(a, b) yields a to the power of b

Math.Sqrt(num) this one is pretty obvious

Math.Max(a,b) and Math.Min(a,b) yields largest and smallest number

Math.Round(num) rounds to closes whole number

and many, many more like trigonometry