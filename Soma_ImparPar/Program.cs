internal class Program
{
    private static void Main(string[] args)
    {
        int value;
        int somaPar = 0;
        int somaImpar = 0;

        do
        {
            Console.Write("Digite um valor qualquer: ");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (value <= 0)
            {
                Console.WriteLine("Valor inválido. Por favor, aperte ENTER para digitar um valor novamente.");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Digite um valor qualquer: ");
                value = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            if (value >= 1000)
            {
                break;
            }
            if (value % 2 == 0)
            {
                somaPar += value;
            }
            else
            {
                somaImpar += value;
            }
        } while (value > 0);
        Console.WriteLine();

        Console.WriteLine($"Soma dos números pares = {somaPar}");
        Console.WriteLine($"Soma dos números ímpares = {somaImpar}");
    }
}