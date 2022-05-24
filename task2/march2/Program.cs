using System;

namespace march2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            Console.WriteLine("Кол-во сек: ");
            int time = int.Parse(Console.ReadLine());
            int koleb;

            if (time == 12)
            {
                koleb = time * 25;
            }
            else if (time == 7)
            {
                koleb = time * 35;
            }
            else
            {
                koleb = time * 12;
            }
            Console.WriteLine("Кол-во колебаний: ");
            Console.WriteLine(koleb);

            //2 

            Console.WriteLine("До сортировки");

            int[] mass = { 7, 5, 2, 3, 9, 6 };

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
            BubbleSort(mass);
            Console.WriteLine("После сортировки");
            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}