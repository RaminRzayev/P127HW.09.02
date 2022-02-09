using System;

namespace P127.HW._09._02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*2.Bir string arrayinin icersinde uzunlugu 5 den boyuk olan sozleri ekrana cixardan bir alqoritm yazin*/

            /*            string[] newArr = {"emin", "memmed","xeqani","ali","hesret"};
                        foreach (var letter in newArr)
                        {
                            if (letter.Length>=5)
                            {
                                Console.WriteLine(letter);
                            }
                        }*/


            /*3.Verilmiş tam müsbət n ədədinin rəqəmlərinin cəmini tapan alqoritm(Məsələn: 214 ədədinin rəqəmləri cəmi 2 + 1 + 4 = 7)
             * 
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num>0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);*/

/*
 * 
 * 
 * 
            1. 1 eded daxil edin.Eger o eded 50den kicikdirse o edede qeder 3 - e bolunen,
                50 - 100 araligindadirsa o edede qeder 5e bolunen, 100den boyukdurse o edede qeder 8 e 
                bolunen ededleri ayri bir arrayin icerisine elave edib, bolunen butun ededleri ekrana cixardan 
                bir alqoritm(sinifdeki taskin bir basqa versiyasidir)*/
            



           /* int[] intArr = new int [15];
            int index = 0;
            int num = Convert.ToInt32(Console.ReadLine());


            if (num < 50)
            {
                for (int i = 1; i < num; i++)
                {
                    if (i % 3 == 0)
                    {
                        intArr[index] = i;
                        index++;
                    }
                }
               
            }
            else if (50 < num && num < 100)
            {
                for (int i = 1; i < num; i++)
                {
                    if (i % 5 == 0)
                    {
                        intArr[index] = i;
                        index++;

                    }
                }
               
            }
            else if (num > 100)
            {
                for (int i = 0; i < num; i++)
                {
                    if (i % 8 == 0)
                    {
                        intArr[index] = i;
                        index++;

                    }
                }


            }

            foreach (int item in intArr)
            {
                Console.WriteLine(item);
            }*/






        }
    }
}
