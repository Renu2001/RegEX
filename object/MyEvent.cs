using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object1
{
    delegate void MyEventHandler();
    internal class MyEvent
    {
        public event MyEventHandler SomeEvent;
        public void OnSomeEvent()
        {
            if(SomeEvent != null)
                SomeEvent();
        }
    }
    class EventDemo
    {
        static void handler()
        {
            Console.WriteLine("Event Occured");

        }

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += new MyEventHandler(handler);
            evt.OnSomeEvent();

        }
    }
}
