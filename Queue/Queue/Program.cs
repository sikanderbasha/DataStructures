﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(70);
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();           
            queue.Display();
        }
    }
}
