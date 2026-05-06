using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("==========================");
        Console.WriteLine("Verificador de Palíndromos");
        Console.WriteLine("==========================");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("Digite uma palavra, frase ou números (ou 'sair'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            // Mensagem de entrada vazia
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine();
                Console.WriteLine("Entrada vazia. Por favor, digite algo.");
                Console.WriteLine();
                Console.WriteLine();
                continue;
            }

            bool isPalindrome = IsPalindrome(input);

            Console.WriteLine();
            Console.WriteLine(isPalindrome ? "É palíndromo" : "Não é palíndromo");
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    static bool IsPalindrome(string text)
    {
        if (string.IsNullOrEmpty(text))
            return false;

        StringBuilder cleanText = new StringBuilder();

        // Remove espaços e deixa minúsculo
        foreach (char character in text)
        {
            if (char.IsLetterOrDigit(character))
            {
                cleanText.Append(char.ToLower(character));
            }
        }

        string processedText = cleanText.ToString();

        int startIndex = 0;
        int endIndex = processedText.Length - 1;

        // Compara início com o fim
        while (startIndex < endIndex)
        {
            if (processedText[startIndex] != processedText[endIndex])
                return false;

            startIndex++;
            endIndex--;
        }

        return true;
    }
}