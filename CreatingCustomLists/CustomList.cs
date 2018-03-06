using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCustomLists
{
    public class CustomList<T>
    {
        T[] firstArray;
        int capacity;
        int count;

        public CustomList()
        {
            capacity = 10;
            count = 0;
            firstArray = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                return firstArray[index];
            }

            set
            {
                firstArray[index] = value;
            }
        }

        //public int Capacity
        //{
        //    get
        //    {
        //        return capacity;
        //    }            
        //}

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T item)
        {
            if(count >= firstArray.Length)
            {
                T[] newArray = new T[firstArray.Length + 10];
                for (int i = 0; i < firstArray.Length; i++)
                {
                    newArray[i] = firstArray[i];
                }
                firstArray = newArray;
            }

            //newArray[firstArray.Length] = item;  //HAVE IT CREAT A DOUBLE ARRAY NOT WHOLE NEW ONE
            firstArray[count] = item;
            count++;
        }


        public void Remove(T item)
        {
            bool itemHasBeenRemoved = false;
            for (int i = 0; i < count; i++)
            {
                if (firstArray[i].Equals(item))
                {
                    firstArray[i] = firstArray[i + 1];
                    count--;
                    itemHasBeenRemoved = true;
                }
                else if (itemHasBeenRemoved)
                {
                    firstArray[i] = firstArray[i + 1];
                }
            }
            if (itemHasBeenRemoved)
            {
                firstArray[count] = default (T);
            }
        }


        public void IterateArray(T item)
        {

        }

        public void ToString(T item)
        {

        }

        public void OverLoadPlusOperator() 
        {
            //over load + operator so i can add two instances
        }

        public void OverLoadMinusOperator(T item)
        {
            //overload - operator so i can subract
        }

        
        public void Zipper(T item)
        {

        }
    }
}