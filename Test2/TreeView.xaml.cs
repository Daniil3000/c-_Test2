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
using System.Windows.Shapes;

namespace Test2
{
    /// <summary>
    /// Interaction logic for TreeView.xaml
    /// </summary>
    public partial class TreeView : Window
    {
        private int counter;
        public TreeView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;

            if(btn.Background != Brushes.Red)
            {
                btn.Background = Brushes.Red;
            }
            else btn.Background = Brushes.Blue;

            if (counter % 2 == 0)
            {
                tvEven.Items.Add(counter);
            }
            else tvOdd.Items.Add(counter);
        }
    }
}
