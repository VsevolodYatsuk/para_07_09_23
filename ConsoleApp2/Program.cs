using System;

class EvenNumber
{
    private int value;

    public EvenNumber(int value)
    {
        this.value = value;
    }

    public static bool operator true(EvenNumber even)
    {
        return even.value % 2 == 0;
    }

    public static bool operator false(EvenNumber even)
    {
        return even.value % 2 != 0;
    }
}

class Program
{
    static void Main()
    {
        EvenNumber even1 = new EvenNumber(4);
        EvenNumber even2 = new EvenNumber(7);

        if (even1)
            Console.WriteLine("Четное число");
        else
            Console.WriteLine("Нечетное число");

        if (even2)
            Console.WriteLine("Четное число");
        else
            Console.WriteLine("Нечетное число");
    }
}
