using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        public Node head;
      
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.head;
            }
            this.head = node;
            Console.WriteLine(data + " pushed to stack.");
        }

        public void Display()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        public void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine(this.head.data + " poped from the stack");
            this.head = this.head.next;
        }

       
    }
}
