using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfTest
{
    internal class Program
    {
        private int Counter = 0;
        [STAThread]
        public static void Main(string[] args)
        {
            var start = new Start();
            start.Run();

        }

        

    }
}
