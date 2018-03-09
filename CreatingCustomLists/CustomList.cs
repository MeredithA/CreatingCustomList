using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCustomLists
{
    public class CustomList<T> : IEnumerable<T>
    {
        T[] firstArray;
        int count;
        int capacity;

        public CustomList() 
        {
            count = 0;
            firstArray = new T[10];
        }

        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                return firstArray[index];
            }

            set
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException();
                }
                firstArray[index] = value;
            }
        }

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

        public override string ToString()
        {
        }

        public static CustomList<T> operator + (CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < customList1.count; i++)
            {
                newList.Add(customList1[i]);
            }

            for (int i = 0; i < customList2.count; i++)
            {
                newList.Add(customList2[i]);
            }
            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            CustomList<T> list = new CustomList<T>();

            for (int i = 0; i < customList1.count; i++)
            {
                list.Add(customList1[i]);
            }

            for (int i = 0; i < customList2.count; i++)
            {
                if (customList2[i].Equals(customList1[i]))
                {
                    list.Remove(customList2[i]);
                }
            }
            return list;
        }

        public CustomList<T> Zipper(CustomList<T> zipperList1, CustomList<T> zipperList2)
        {
            CustomList<T> zippedList = new CustomList<T>();

            for (int i = 0; i < count; i++)
            {
                if (zipperList1[i] != null)
                {
                    zippedList.Add(zipperList1[i]);
                }
                if (zipperList2[i] != null)
                {
                    zippedList.Add(zipperList2[i]);
                }
            }
            return zippedList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            {
                for (int i = 0; i < count; i++)
                {
                    yield return firstArray[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}