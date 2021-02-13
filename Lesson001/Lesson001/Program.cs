using System;

namespace Lesson001
{
    class Program
    {
        static void Main(string[] args)
        {
            Exsecutor();
        }
        public static void Exsecutor()
        {
            string PrimaPars = "Привет, ", SecundaPars = ", сегодня ";
            string Generalis = PrimaPars + Environment.UserName + SecundaPars + DateTime.Now;
            Console.WriteLine( Generalis );
            Console.WriteLine();
            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.Read();
        }
    }
}
