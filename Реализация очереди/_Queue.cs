using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реализация_очереди
{
    class _Queue<T>
    {
        private List<T> items = new List<T>();
        public _Queue() { }
        public _Queue(T val)
        {
            items.Add(val);
        }
        public T Back
        {
            get
            {
                return items.First();
            }
        }
        public T Front ()
        {
            return items.Last();
        }
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
        public T Peek()
        {
            try
            {
                return this.Front();
            }
            catch
            {
                //throw new Exception("Обращение к пустой очереди!");
                return default(T);
            }
        }
        public void Enqueue(T val)
        {
            items.Insert(0, val);
        }
        public T Dequeue()
        {
            try
            {
                var item = Front();
                items.Remove(item);
                return item;
            }
            catch
            {
                //throw new Exception("Обращение к пустой очереди!");
                return default(T);
            }
        }
        public bool isEmpty()
        {
            if (items.Count == 0)
            {
                return true;
            } else {
                return false;
            }
        }
        public void Clear()
        {
            items.Clear();
        }
        public void printQueue()
        {
            foreach (T item in this.items) Console.WriteLine(item);
        }
    }
}
