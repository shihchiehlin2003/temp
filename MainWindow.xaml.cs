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

namespace temp
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtcm_KeyUp(object sender, KeyEventArgs e)
        {

            double doucm; //宣告一個double變數，變數名稱叫douCM

            doucm = Convert.ToDouble(txtcm.Text); //從txtCM輸入文字框取得輸入的文字，並且轉換成double的資料型態

            txtm.Text = string.Format("{0:0.##########}", doucm / 100);
            txtkm.Text = string.Format("{0:0.##########}", doucm / 100000);
            txtin.Text = string.Format("{0:0.##########}", doucm / 2.54);
            txtft.Text = string.Format("{0:0.##########}", doucm / 30.48);
            txtyard.Text = string.Format("{0:0.##########}", doucm / 91.44);

        }

    }
}
