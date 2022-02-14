﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        internal Node head;
       
        internal void Add(int data)
        {
           
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {              
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
           
            Console.WriteLine("{0} inserted into the list", node.data);
        }   
        internal void Add2(int data)
        {
          
            Node node = new Node(data);         
            if (this.head == null)
                this.head = node;
            else
            {            
                node.next = head;
                this.head = node;
            }
           
            Console.WriteLine("{0} inserted into the list", node.data);
        }     
        internal Node InsertAtParticularPosition(int position, int data)
        {
           
            if (position < 1)               
                Console.WriteLine("Invalid position");
            Console.WriteLine("Inserting " + data + " in positon " + position);          
            if (position == 1)
            {               
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else          
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            return head;
        }     
        internal Node RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            Node firstElement = this.head;
            this.head = this.head.next;
            return firstElement;
        }      
        internal Node RemoveLastNode()
        {            
            if (head == null)
                return null;          
            if (head.next == null)
                return null;
            Node newNode = head;

            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Node lastElement = newNode.next;
            newNode.next = null;
            return lastElement;
        }
        
        internal void Display()
        {
            Node temp = this.head;          
            if (temp == null)
            {              
                Console.WriteLine("Linked list is empty");
                return;
            }           
            Console.WriteLine("Sequence of LinkedList :-");
           
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
