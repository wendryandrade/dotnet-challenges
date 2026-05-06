class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("==========================");
        Console.WriteLine("Sequência de Fibonacci");
        Console.WriteLine("==========================");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Digite a quantidade de elementos (ou 'sair'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            if (!int.TryParse(input, out int elementCount) || elementCount <= 0)
            {
                Console.WriteLine("Digite um número válido maior que zero.");
                Console.WriteLine();
                continue;
            }

            PrintFibonacci(elementCount);

            Console.WriteLine();
            Console.WriteLine();
        }
    }

    static void PrintFibonacci(int elementCount)
    {
        int previousNumber = 0;
        int currentNumber = 1;

        for (int i = 0; i < elementCount; i++)
        {
            if (i == 0)
            {
                Console.Write(previousNumber);
            }
            else if (i == 1)
            {
                Console.Write(", " + currentNumber);
            }
            else
            {
                int nextNumber = previousNumber + currentNumber;
                Console.Write(", " + nextNumber);

                previousNumber = currentNumber;
                currentNumber = nextNumber;
            }
        }

        Console.WriteLine();
    }
}