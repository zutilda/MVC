using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MVC
{
    public static class Models
    {
        public static List<string> operationList = new List<string> { "+", "-", "*", "/" };
               
        public static TextBlock tbOperation;
        public static TextBlock ResultCalc;
     

        public static int Combo
        {
            set
            {
                tbOperation.Text = operationList[value];
            }
        }
        public static void Check(int index, string tbOne, string tbTwo)
        {
            try
            {
                double one = Convert.ToDouble(tbOne);
                double two = Convert.ToDouble(tbTwo);

                if (index == 3 && two == 0)
                {
                    ResultCalc.Text = "";
                    MessageBox.Show("Ошибка деления на 0");
                }
                else
                {
                    ResultCalc.Text = Result(index, one, two);
                }
            }
            catch
            {
                ResultCalc.Text = "";
                MessageBox.Show("Введите данные корректно");
            }
        }
        public static string Result(int index, double one, double two)
        {
            switch (index)
            {
                case 0:
                    return (one + two).ToString();
                case 1:
                    return (one - two).ToString();
                case 2:
                    return (one * two).ToString();
                case 3:
                    return (one / two).ToString();
                default:
                    return "Ошибка";
            }
        }

    }
}
