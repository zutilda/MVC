using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Models.tbOperation = Operation;
            Models.ResultCalc = ResultCalc;

            cbOperation.SelectedIndex = 0;

        }

        private void cbOperation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Models.Combo = cbOperation.SelectedIndex;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            
            Models.Check(cbOperation.SelectedIndex, One.Text, Two.Text);
        }
    }
}
