using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionsArrays
{
    internal class GenericArray<T>
    {
        private T[] arr;
        private int? numberOfItems = null;

        public GenericArray(T[] arr)
        {
            this.arr = arr;
            numberOfItems = 0;
        }

        public T GetElement(int index)
        {
            return arr[index];
        }

        public void SetItem(int index, T item)
        {
            arr[index] = item;
            numberOfItems++;
        }

        public void SwapElements(int index1, int index2)
        {
            T aux = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = aux;
        }

        //varianta asta nu e neaparat recomandata
        //mai bine faceam doua metode cu nume diferite
        //SwapByIndex, SwapByValue
        public void SwapElements<TSwap>(T a, T b) where TSwap : T 
        {

            for (int i = 0; i < numberOfItems; i++)
            {
                if (arr[i].Equals(a))
                {
                    arr[i] = b;
                }
                else if (arr[i].Equals(b))
                {
                    arr[i] = a;
                }
            }
        }
    }
}
