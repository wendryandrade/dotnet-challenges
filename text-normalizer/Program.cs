using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine("==========================");
        Console.WriteLine("Normalizador de Texto");
        Console.WriteLine("==========================");
        Console.WriteLine();

        while (true)
        {
            Console.Write("Digite um texto (ou 'sair'): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
                break;

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine();
                Console.WriteLine("Por favor, digite um texto válido.");
                Console.WriteLine();
                continue;
            }

            string normalized = NormalizeText(input);

            Console.WriteLine();
            Console.WriteLine("Resultado: " + normalized);
            Console.WriteLine();
        }
    }

    static string NormalizeText(string text)
    {
        if (string.IsNullOrEmpty(text))
            return text;

        StringBuilder normalized = new StringBuilder();

        // Flags para rastrear pontuações encontradas e qual apareceu primeiro
        bool hasExclamation = false;
        bool hasQuestion = false;
        bool exclamationFirst = false;

        foreach (char character in text)
        {
            // Verifica se é uma pontuação
            if (character == '!' || character == '?')
            {
                if (character == '!')
                {
                    // Se é a primeira pontuação, marca como primeira
                    if (!hasExclamation && !hasQuestion)
                        exclamationFirst = true;
                    hasExclamation = true;
                }

                if (character == '?')
                {
                    // Se é a primeira pontuação, marca que exclamação não é primeira
                    if (!hasExclamation && !hasQuestion)
                        exclamationFirst = false;
                    hasQuestion = true;
                }
            }
            else
            {
                // Ao encontrar um caractere não-pontuação, adiciona as pontuações acumuladas
                if (hasExclamation || hasQuestion)
                {
                    // Combinação: ambos '?' e '!' encontrados - preserva a ordem
                    if (hasQuestion && hasExclamation)
                    {
                        if (exclamationFirst)
                            normalized.Append("!?");
                        else
                            normalized.Append("?!");
                    }
                    else if (hasQuestion)
                        normalized.Append("?");
                    else
                        normalized.Append("!");

                    // Reseta as flags
                    hasExclamation = false;
                    hasQuestion = false;
                    exclamationFirst = false;
                }

                // Adiciona o caractere atual
                normalized.Append(character);
            }
        }

        // Caso o texto termine com pontuação
        if (hasExclamation || hasQuestion)
        {
            if (hasQuestion && hasExclamation)
            {
                if (exclamationFirst)
                    normalized.Append("!?");
                else
                    normalized.Append("?!");
            }
            else if (hasQuestion)
                normalized.Append("?");
            else
                normalized.Append("!");
        }

        return normalized.ToString();
    }
}