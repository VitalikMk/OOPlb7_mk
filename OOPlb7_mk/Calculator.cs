// Дженерик клас Calculator<T>, де T може бути будь-яким числовим типом
public class Calculator<T>
{
    // Делегати для основних арифметичних операцій
    public delegate T AddDelegate(T x, T y);
    public delegate T SubtractDelegate(T x, T y);
    public delegate T MultiplyDelegate(T x, T y);
    public delegate T DivideDelegate(T x, T y);

    // Методи, які використовують ці делегати для виконання відповідних арифметичних операцій
    public T Add(T x, T y)
    {
        AddDelegate addDelegate = (x, y) => x + y;
        return addDelegate(x, y);
    }

    public T Subtract(T x, T y)
    {
        SubtractDelegate subtractDelegate = (x, y) => x - y;
        return subtractDelegate(x, y);
    }

    public T Multiply(T x, T y)
    {
        MultiplyDelegate multiplyDelegate = (x, y) => x * y;
        return multiplyDelegate(x, y);
    }

    public T Divide(T x, T y)
    {
        DivideDelegate divideDelegate = (x, y) => x / y;
        return divideDelegate(x, y);
    }
}

// Приклад використання
int x = 10;
int y = 20;

// Додавання
int sum = Calculator<int>.Add(x, y);
Console.WriteLine("x + y = {0}", sum);

// Віднімання
int difference = Calculator<int>.Subtract(x, y);
Console.WriteLine("x - y = {0}", difference);

// Множення
int product = Calculator<int>.Multiply(x, y);
Console.WriteLine("x * y = {0}", product);

// Ділення
int quotient = Calculator<int>.Divide(x, y);
Console.WriteLine("x / y = {0}", quotient);
