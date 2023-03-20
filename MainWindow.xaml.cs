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
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtinfo.Text = "請輸入數字";
                txtcm.Text = "";
            }           
        }

        private void txtm_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtm.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 100);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtm.Text = "";
            }
        }

        // 設計一個單位轉換計算的函式，沒有回傳值，設計兩個參數，1.類別參數、2.數值參數
        void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtcm.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtm.Text = string.Format("{0:0.##########}", _value / 100);
            if (_kind != 2)
                txtkm.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtin.Text = string.Format("{0:0.##########}", _value / 2.54);
            if (_kind != 4)
                txtft.Text = string.Format("{0:0.##########}", _value / 30.48);
            if (_kind != 5)
                txtyard.Text = string.Format("{0:0.##########}", _value / 91.44);
        }

        private void txtkm_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtkm.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 100000);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtkm.Text = "";
            }
        }

        private void txtin_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtin.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 2.54);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtin.Text = "";
            }
        }

        private void txtft_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtft.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 30.48);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtft.Text = "";
            }
        }

        private void txtyard_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtyard.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 91.44);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtyard.Text = "";
            }
        }
    }

    }

