using CalculatorBrain;

var calculator = new SimpleCalculator();

Console.Write("Give me number: ");
var numberString = Console.ReadLine();

if (!decimal.TryParse(numberString, out decimal num))
{
    throw new IOException("What you have entered is not a number! Try again.");
}

var number = decimal.Parse(numberString);

calculator.SetState(number);
Console.WriteLine("First number 4" + number);

Console.Write("Give me operation (+ , - , * , /): ");
var operation = Console.ReadLine();

Console.Write("Give me second number: ");
numberString = Console.ReadLine();

if (!decimal.TryParse(numberString, out decimal num2))
{
    throw new IOException("What you have entered is not a number! Try again.");
}

number = decimal.Parse(numberString);
Console.WriteLine("Second number " + number);

switch (operation)
{
    case "+":
        calculator.Add(number);
        break;
    case "-":
        calculator.Minus(number);
        break;
    case "*":
        calculator.Multiply(number);
        break;
    case "/":
        calculator.Divide(number);
        break;
    default:
        Console.WriteLine("Sorry, no support for " + operation);
        break;
}

Console.WriteLine($"Result is: {calculator.CurrentState}");
     