using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace WpfTest
{
    internal class Start
    {
        public void Run()
        {
            var app = new Application();
            var window = new Window();

            var panel = new StackPanel();
            var clicker = new Clicker();
            var clicker2 = new Clicker();
            var clicker3 = new Clicker();

            panel.Children.Add(clicker.Panel);
            panel.Children.Add(clicker2.Panel);
            panel.Children.Add(clicker3.Panel);

            window.Content = panel;

            app.Run(window);

        }

    }
}
