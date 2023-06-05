using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2022_02_02__Polymorphie__Devices
{
    class DeviceList
    {
        protected Node first;

        public DeviceList()
        {
            first = null;
        }
 
        public void PushFront(Device device)
        {
            first = new Node(first, device);
        }

        public void Display()
        {

            Node temp = first;
            while(temp != null)
            {
                Console.WriteLine();
                Console.WriteLine(temp.Device.GetType().Name);
                Console.WriteLine(temp.Device.ToString());
                temp = temp.Nodes;
            } 
        }

        internal class Node
        {
            private Node node;
            private Device device;

            public Node(Node node, Device device)
            {
                this.node = node;
                this.device = device;
            }

            public Device Device { get { return device; } set { device = value; } }
            public Node Nodes { get { return node; } set { node = value; } }
        }

        
        




    }
}
