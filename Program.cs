internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Informe o primeiro valor:");
        int valor = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine("Informe o segundo valor:");
        int valor2 = int.Parse(Console.ReadLine().ToString());

        Console.WriteLine("Qual operação você gostaria de fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        int operation = int.Parse(Console.ReadLine().ToString());
        double Resultado = 0;

        switch (operation)
        {
            case 1:
                Resultado = soma(valor, valor2);
                break;
            case 2:
                Resultado = menos(valor, valor2);
                break;
            case 3:
                Resultado = vezes(valor, valor2);
                break;
            case 4:
                Resultado = dividir(valor, valor2);
                break;
            default:
                break;
        }

        Console.WriteLine("O total é: " + Resultado);

    }
    
        private static double soma(int valor, int valor2) => valor + valor2;
        private static double menos(int valor, int valor2) => valor - valor2;
        private static double vezes(int valor, int valor2) => valor * valor2;
        private static double dividir(int valor, int valor2) => valor / valor2;
}