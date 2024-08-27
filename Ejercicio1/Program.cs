namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double pBase, pLado, pAltura; 
            Console.WriteLine("Hello, Parelelogramo!");

            try
            {

                do
                {
                    Console.Write("Ingrese la base:");
                    if (double.TryParse(Console.ReadLine(), out pBase) && (pBase > 0))
                    {
                        break;
                    }
                } while (true);
                do
                {
                    Console.Write("Ingrese el lado:");
                    if (double.TryParse(Console.ReadLine(), out pLado) && (pLado > 0))
                    {
                        break;
                    }
                } while (true);
                do
                {
                    Console.Write("Ingrese la altura:");
                    if (double.TryParse(Console.ReadLine(), out pAltura) && (pAltura > 0))
                    {
                        break;
                    }
                } while (true);
                //Calcular perimetro y superficie
                var perimetro = 2 * (pBase + pLado);
                var superficie = pBase * pAltura;
                //informar datos
                Console.WriteLine($"Perimetro de:{perimetro}");
                Console.WriteLine($"Superficie de:{superficie}");

            }
            catch (Exception)
            {
                Console.WriteLine("Valor mal ingresado!!");
                
            }
            return;

           
        }
    }
}
