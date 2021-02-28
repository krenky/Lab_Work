using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{



    public class Student
    {
        private string Fam;
        public int[] Ocenki = new int[40];
        private int KolOc;





        public Student(string aFam)


        {
            var result = string.IsNullOrWhiteSpace(aFam);
            Fam = aFam;
            KolOc = 0;
        }

        public string GetFam()
        {
            return Fam;
        }
        public void SetFam(string newFam)
        {
            Fam = newFam;
        }
        public int GetKolOc()
        {
            return KolOc;
        }
        public int GetOcenka(int nom)
        {
            if (KolOc >= nom)
            {
                Console.WriteLine("Добавить нельзя, ты попа");
            }
            return Ocenki[nom];
        }
        public int SetOcenka(int nom, int newOc)
        {
            if (KolOc >= nom)
            {
                Console.WriteLine("Добавить нельзя, ты попа");
            }

            Ocenki[nom] = newOc;

            if (newOc > 5)
            {
                Console.WriteLine("Добавить нельзя, ты попа");
            }



            return Ocenki[nom];
        }

        public static void RemoveAt(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }

            array = newArray;
        }
        public int AddOcenka(ref int Ocenky, ref int newOc, int marc)
        {


            if (newOc > 5)
            {
                Console.WriteLine("Добавить нельзя, ты попа");
            }

            int i = 0;
            Console.WriteLine("Введи");

            marc = Convert.ToInt32(Console.ReadLine());
            Ocenki[i] = int.Parse(Console.ReadLine());
            Console.WriteLine();
            i++;
            marc = Convert.ToInt32(Console.ReadLine());

            Ocenki[KolOc] = newOc;

            return KolOc;

        }
        public float SredBall(ref int[] array, ref int sr, int KolOc, int Sred, int sum = 0)
        {
            int[] newArray = new int[array.Length];

            if (KolOc > 0)
            {


                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array.Length;
                }
                sr = sum / array.Length;

                sr = Sred;

            }
            else
            {
                Console.WriteLine("Нет оценок");
            }
            return sr;

        }
        public string GetData(string Dat)
        {
            return Dat;
        }

        public static void Main(string[] args)
        {
            Student p = new Student("Hyu");
            int[] Ocenki = { 1, 2, 4 };
            int newOc = 0;
            int marc = 4;

            // //int[] Ocenki = new int[40];
            // //Console.WriteLine("Введите индекс");

            // RemoveAt(ref Ocenki, Convert.ToInt32(Console.ReadLine()));
            // Console.WriteLine(Ocenki);
            p.AddOcenka(ref Ocenki[1], ref newOc,  marc);
        
// for (int t = 0; t < Ocenki.Length; t++)
// {
// Console.Write(Ocenki[t] + ",");
// }
        }


    }

}