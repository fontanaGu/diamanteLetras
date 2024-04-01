namespace diamanteLetras2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter;
            do
            {
                Console.Write("Digite uma letra de (A a Z): ");
                letter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (Char.IsLetter(letter) && Char.IsUpper(letter))
                {
                    PrintDiamond(letter);
                }
                else
                {
                    Console.WriteLine("Por favor, digite uma letra válida de A a Z.");
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar ou 'Q' para sair.");
            } while (Char.ToUpper(Console.ReadKey().KeyChar) != 'Q');
        }

        public static void PrintDiamond(char letter)
        {
            Console.Clear();
            int letterNumber = letter - 'A' + 1;

            // Parte superior do diamante
            for (int i = 0; i < letterNumber; i++)
            {
                for (int j = 0; j < letterNumber - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write((char)('A' + i));
                }
                Console.WriteLine();
            }

            // Parte inferior do diamante
            for (int i = letterNumber - 2; i >= 0; i--)
            {
                for (int j = 0; j < letterNumber - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write((char)('A' + i));
                }
                Console.WriteLine();
            }
        }
    }
}
