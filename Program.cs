class program
{
    public static void Main(String[] args)
    {
        int[,] numeros = new int[10, 10];

        int k = 1;

        //Rellenar los huecos
        for (int i = 9; i >= 0; i--)
        {
            for (int j = 9; j >= 0; j--)
            {
                numeros[i, j] = k++;

            }
        }
        //Imprimir los numeros
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(numeros[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        //Imprimir numeros de forma ascendente
        for (int i = 9; i >= 0; i--)
        {
            for (int j = 9; j >= 0; j--)
            {
                Console.WriteLine(numeros[i, j]);
            }
        }

    }
}
}