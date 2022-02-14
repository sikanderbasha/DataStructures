using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        // Node next
        public Node next;
        /// <summary>
        /// Constructor to initilize data variables
        /// </summary>
        /// <param name="data">data that create node</param> 
        public Node(int data)
        {
            this.data = data;
        }
    }
}
