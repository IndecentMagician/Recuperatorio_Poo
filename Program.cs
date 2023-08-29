using Recuperatorio_Poo.Entidades;
namespace Recuperatorio_Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Prisma!");
                var p = new PrismaRectangularRecto(10, 12, 30);
                Console.WriteLine(p.MostrarDatos());
                Console.ReadKey();
                var p3 = new PrismaRectangularRecto();
                Console.WriteLine(p3.MostrarDatos());
                Console.ReadKey();
                var p2 = new PrismaRectangularRecto(-1, 12, 3);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}