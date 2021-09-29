using System;

namespace LabRob3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; // для того, щоб консоль розпізнавала українські літери
            double A; // = 3.125;
            int I; // =6006006;
            float C; //= -13.24f;
            bool l; //= false;
            string name; // "Имя";
            
            Console.WriteLine("Введіть A ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть І ");
            I = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть С ");
            C = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введіть l ");
            l = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Введіть Ім'я ");
            name = Console.ReadLine();
            Console.WriteLine("Рузультати форматування \nName = {0, 1} \tl = {1, 5}", name, l);
            System.Console.WriteLine("\nA = {0, 1:f3} \tI = {1, 7} \tC = {2, 6:f2}", A, I, C);
            System.Console.WriteLine("\nЩоб вийти натисніть Enter");
            Console.ReadLine();
            System.Console.ReadLine();

        }
    }
}
