using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_Homework_Task3
{
    /*Завдання 3
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть колекцію MyList <T>. Реалізуйте в найпростішому наближенні можливість використання її екземпляра аналогічно екзепляра класу List <T>. 
    Мінімально необхідний інтерфейс взаємодії з екземпляром, повинен включати метод додавання елемента, індексатор для отримання значення елемента за вказаним 
    індексом і властивість тільки для читання для отримання загальної кількості елементів. Реалізуйте можливість перебору елементів колекції в циклі foreach.
    */
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(20);

            Console.WriteLine();
            Console.WriteLine($"Кількість елементів : {list.Count}");
            Console.WriteLine(list[0]);

            Console.ReadKey();
        }
    }
}
