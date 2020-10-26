using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_Homework
{
    class Program
    {
        /*
      Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
      Створіть метод, який в якості аргументу приймає масив цілих чисел і повертає колекцію всіх парних чисел масиву. 
      Для формування колекції використовуйте оператор yield.
      */

        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random newRandom = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = newRandom.Next(10,30);
            }

            Collection myCollection = new Collection();
            
            var parni = myCollection.GetEnumerator(array);
            foreach (var item in parni)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
