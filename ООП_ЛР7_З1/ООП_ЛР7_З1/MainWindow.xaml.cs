using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ООП_ЛР7_З1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int value = 0, min = 0, max = 0, ave = 0, sum = 0, counter = 0;
            var m = new Matrix2D<int>();
            m.ColCount = int.Parse(TextBox1.Text);
            m.RowCount = int.Parse(TextBox2.Text);
            var args = new MatrixArgument<int>[m.ColCount, m.RowCount];

            Random rnd = new Random();
            for (int i = 0; i < m.ColCount; i++)
            for (int j = 0; j < m.RowCount; j++)
            {
                value = rnd.Next(0, 100);
                args[i, j] = new MatrixArgument<int>(value);
                if (value < min) min = value;
                if (value > max) max = value;
                sum += value;
                counter++;
            }

            m.Arguments = args;
            DataContext = m;
            ave = sum / counter;

            TextBox3.Text = ave.ToString();
            TextBox4.Text = sum.ToString();
            TextBox5.Text = max.ToString();
            TextBox6.Text = min.ToString();

        }
    }
}
