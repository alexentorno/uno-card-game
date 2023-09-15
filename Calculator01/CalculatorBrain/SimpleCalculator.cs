namespace CalculatorBrain;

public class SimpleCalculator : CalculatorBase, IBaseCalculation
{
    public void Add(decimal a)
    {
        CurrentState = +a;
    }

    public void Minus(decimal a)
    {
        CurrentState -= a;
    }

    public void Multiply(decimal a)
    {
        CurrentState *= a;
    }

    public void Divide(decimal a)
    {
        CurrentState /= a;
    }
}