using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assuit_Minya_contest3
{
    class Queue
    {
        public int front;
        public int rear;
        public int length;
        public long[] arr;
        public Queue()
        {
            arr = new long[5];
            front = length = 0;
            rear = 4;
        }
        public void enqueue(long element)
        {
            rear = (rear + 1) % 5;
            arr[rear] = element;
            length++;
        }
        public void dequeue()
        {
            front = (front + 1) % 5;
;
            length--;
        }

    }
}
