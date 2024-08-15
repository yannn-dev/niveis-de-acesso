namespace Niveis_de_acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto p2 = new Ponto(14, 12);

            Console.WriteLine("Distancia entre (p1, p2) = {0}", p1.Distancia(p2));
            Console.ReadKey(); 
        }
    }
}