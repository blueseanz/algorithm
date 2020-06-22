using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    public class Stack
    {
        private int p_index;
        private ArrayList list;

        public Stack() 
        {
            list = new ArrayList();
            p_index = -1;
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public void push(object item)
        {
            list.Add(item);
            p_index++;
        }

        public object pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }

        public void clear()
        {
            list.Clear();
            p_index = -1;
        }

        public object peak()
        {
            return list[p_index];
        }
    }
}
