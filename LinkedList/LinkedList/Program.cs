using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();         
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();          
            list = new LinkedList();
            list.Add2(70);
            list.Add2(30);
            list.Add2(56);       
            list.Display();
            list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(2, 30);
            list.Display();          
            Console.WriteLine("First element removed from the List- " + list.RemoveFirstNode().data);
            list.Display();
            list.InsertAtParticularPosition(1, 56);
            list.Display();
            Console.WriteLine("Last element removed from the List- " + list.RemoveLastNode().data);
            list.Display();
            Console.ReadLine();
        }
    }
}
