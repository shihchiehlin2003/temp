using System;
using System.Collections.Generic;
using System.Globalization;
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
            txtcm.Text = "";
            txtm.Text = "";
            txtkm.Text = "";
            txtin.Text = "";
            txtft.Text = "";
            txtyard.Text = "";
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtcm_KeyUp(object sender, KeyEventArgs e)
        {

            strInput = txtcm.Text; // 將txtCM文字框的值放入strInput變數

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                txtm.Text = string.Format("{0:0.##########}", douOutput / 100);
                txtkm.Text = string.Format("{0:0.##########}", douOutput / 100000);
                txtin.Text = string.Format("{0:0.##########}", douOutput / 2.54);
                txtft.Text = string.Format("{0:0.##########}", douOutput / 30.48);
                txtyard.Text = string.Format("{0:0.##########}", douOutput / 91.44);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtinfo.Text = "請輸入數字";
                txtcm.Text = "";
            }
        }

    }

    }

