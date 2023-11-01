// Дженеричний клас Calculator<T>
public class Calculator<T>
{
    // Делегати для основних арифметичних операцій
    public delegate T AddDelegate(T x, T y);
    public delegate T SubtractDelegate(T x, T y);
    public delegate T MultiplyDelegate(T x, T y);
    public delegate T DivideDelegate(T x, T y);

    // Методи, які використовують делегати для виконання відповідних арифметичних операцій
    public T Add(T x, T y)
    {
        return AddDelegate((x, y) => x + y);
    }

    public T Subtract(T x, T y)
    {
        return SubtractDelegate((x, y) => x - y);
    }

    public T Multiply(T x, T y)
    {
        return MultiplyDelegate((x, y) => x * y);
    }

    public T Divide(T x, T y)
    {
        return DivideDelegate((x, y) => x / y);
    }
}
