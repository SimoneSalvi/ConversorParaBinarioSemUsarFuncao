internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 0;
        int quociente = 1;
        int[] binario = new int[8];
        int cont = 0;

        Console.WriteLine("Informe o número a ser convertido para binário");
        numero = int.Parse(Console.ReadLine());

        while (quociente >= 1)
        {
            quociente = numero / 2;

            if (numero % 2 == 0)
            {
                binario[cont] = 0;
                cont++;
            }
            else
            {
                binario[cont] = 1;
                cont++;
            }
            numero = quociente;
        }


        Console.WriteLine("Binario: ");
        for (int i = binario.Length-1; i >= 0; i--)
        {
            Console.WriteLine(binario[i]);;
        }
    }
}