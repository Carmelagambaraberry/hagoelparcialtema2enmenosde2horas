namespace hagoelparcialtema1enmenosde2horas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            double basee;
            double radio;
            double altura;
            double volumen;
            double contador;
            int PI;
            PI = (int)3.14;
            contador = 0;
            do
            {

                Console.WriteLine(" Ingrese la altura del cilindro");
                if (double.TryParse(Console.ReadLine(), out altura))
                   
                Console.WriteLine("Ingrese el radio del cilindro");
                if (double.TryParse(Console.ReadLine(), out radio))
                   
                if (altura > 0 && radio > 0)
                area = NewMethod(radio, altura, PI);
                basee = NewMethod1(radio, PI);
                volumen = NewMethod2(basee, altura);
                contador = contador + 1;
                Console.WriteLine("--------------------------------");

            } while (altura>0 && radio>0);

            Console.WriteLine("La cantidad de cilindros ingresados es " + contador);


        }

        private static double NewMethod2(double basee, double altura)
        {
            return basee * altura;
        }

        private static double NewMethod1(double radio, int PI)
        {
            return PI * radio * radio;
        }

        private static double NewMethod(double radio, double altura, int PI)
        {
            return 2 * PI * radio * (altura + radio);
        }
    }
}