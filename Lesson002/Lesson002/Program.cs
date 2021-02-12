using System;

namespace Lesson002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Часть первая - Средняя температура за сутки");
            CalculateAverageTempe();

            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }

        public static void CalculateAverageTempe()
        {
            string Tempo;
            int TMin = 0, TMax = 0, TAverage = 0;
            Console.WriteLine("Введите минимальную температуру за сутки ");
            TMin = GetNumberFromString();

            Console.WriteLine("Введите максимальную температуру за сутки ");
            TMax = GetNumberFromString();

            if( TMin > TMax)
            {
                int Swapperou = TMin;
                TMin = TMax;
                TMax = Swapperou;
            }

            TAverage = ( TMin + TMax ) / 2;
            Console.WriteLine( "Средняя температура за день равна: " + TAverage );
        }

        public static int GetNumberFromString()
        {
            string TempoString;
            int SomeValue;
            //Получаем символы в строке
            TempoString = Console.ReadLine();
            //Проверяем на соответствие типу int
            if( !int.TryParse(TempoString, out SomeValue) )
            {
                SomeValue = 0;
            }
            return SomeValue;
        }
    }
}
