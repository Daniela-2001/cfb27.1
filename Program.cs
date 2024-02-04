namespace aula27._1
{
    internal class Program
    {
        static void Main()
        {
            int n1;
            int n2;
            int n3;

            Console.WriteLine("Digite o primeiro número");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            n3 = Convert.ToInt32(Console.ReadLine());

            soma(n1, n2, n3);
        }

        static void soma(int n1, int n2, int n3)
        {
            int res = n1 + n2 + n3;

            Console.WriteLine("A soma de {0}, {1} e {2} é: {3}", n1, n2, n3, res);
        }
    }
}