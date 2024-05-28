using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Label = System.Windows.Controls.Label;

namespace WpfTest
{
    internal class Clicker
    {
        private int _count;
        private int _upgrades = 1;
        private int _upgradeCost = 10;
        private Label _label { get; }
        private Button upgrade { get; set; }
        public StackPanel Panel { get; }

        public Clicker()
        {
            Panel = new StackPanel { Orientation = Orientation.Horizontal };
            var button = new Button
            {
                Width = 70,
                Height = 40,
                Content = "Click"
            };
            button.Click += Click;
            Panel.Children.Add(button);

            _label = new Label { Content = 0 };
            Panel.Children.Add(_label);

            upgrade = new Button
            {
                Width = 70,
                Height = 40,
                Content = $"Upgrade: {_upgradeCost}",
            };
            upgrade.Click += Upgrade;
            Panel.Children.Add(upgrade);

            
        }

        public void Click(object sender, RoutedEventArgs e)
        {
            _count += _upgrades;
            _label.Content = _count;
        }

        public void Upgrade(object sender, RoutedEventArgs e)
        {
            if (_count >= _upgradeCost)
            {
                _upgrades++;
                _count -= _upgradeCost;
                _upgradeCost += 5;
                upgrade.Content = $"Upgrade: {_upgradeCost}";
                _label.Content = _count;
            }
        }
    }
    
}
