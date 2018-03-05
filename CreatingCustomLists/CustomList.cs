using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCustomLists
{
    class CustomList<T>
    {
        T[] firstArray;
        public CustomList()
        {
            firstArray = new T[5];
        }



        public void Add(T item)
        {
            T[] newArray = new T[firstArray.Length + 1];
            for (int i = 0; i < firstArray.Length; i++)
            {
                newArray[i] = firstArray[i];
            }
            newArray[firstArray.Length] = item;
            firstArray = newArray;
        }



        public bool Remove(T item){
            if (item == null)
                return false;
            else
            return true;
        }
        public {
        }

        public void IterateArray()
        {

        }

        public void ToString<T>()
        {

        }

        public void OverLoadPlusOperator() 
        {
            //over load + operator so i can add two instances
        }

        public void OverLoadMinusOperator()
        {
            //overload - operator so i can subract
        }

        public void count()
        {

        }

        public void Zipper()
        {

        }
    }
}
