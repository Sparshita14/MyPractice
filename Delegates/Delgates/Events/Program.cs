using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        // Delegate type for the event handlers
        public delegate void EventHandler(object sender, EventArgs e);

        // Event declaration
        public event EventHandler MyEvent;

        // Method to raise the event
        protected virtual void OnMyEvent()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
        // Method to handle the event
        private void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event handled");
        }

      

        static void Main(string[] args)
        {
            Program program = new Program();
            program.OnMyEvent();
            program.MyEvent += program.HandleEvent;
           


        }
    }
}
