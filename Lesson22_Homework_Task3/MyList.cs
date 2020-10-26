using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22_Homework_Task3
{
    class MyList<T>
    {
        T[] list = null;

        public T this[int index]
        {
            get
            {
                return list[index];
            }
        }

        public int Count => list.Length;

        public void Add(T a)
        {
            T[] newList = new T[list.Length + 1];
            newList[newList.Length - 1] = a;
            list = newList;
        }
        public void Clear()
        {
            list = new T[0];
        }
        // до цього місця скопіював з Lesson19_HW_Task3 з мінімальними поправками, падає з помилкою 
        public bool Contains(T item)
        {
            foreach (T element in list)
            {
                if (element.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}


