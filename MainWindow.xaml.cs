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
            txtmg.Text = "";
            txtg.Text = "";
            txtkg.Text = "";
            txtt.Text = "";
            txtoz.Text = "";
            txtlp.Text = "";
        }

        // 全域變數
        string strInput; // 字串型態的strInput變數
        double douOutput; // double浮點數型態的douOutput變數

        private void txtmg_KeyUp(object sender, KeyEventArgs e)
        {

            strInput = txtmg.Text;

            // 判斷式，如果能夠以double.TryParse成功轉型，那才做數值的計算
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(0, douOutput);
            }
            else
            {
                // 如果無法轉型，則是在說明文字中顯示錯誤訊息，並且將txtCM文字框清除
                txtinfo.Text = "請輸入數字";
                txtmg.Text = "";
            }           
        }

        private void txtg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtg.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(1, douOutput * 1000);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtg.Text = "";
            }
        }

        // 設計一個單位轉換計算的函式，沒有回傳值，設計兩個參數，1.類別參數、2.數值參數
        void caculateAnswer(int _kind, double _value)
        {
            if (_kind != 0)
                txtmg.Text = string.Format("{0:0.##########}", _value);
            if (_kind != 1)
                txtg.Text = string.Format("{0:0.##########}", _value / 1000);
            if (_kind != 2)
                txtkg.Text = string.Format("{0:0.##########}", _value / 100000);
            if (_kind != 3)
                txtt.Text = string.Format("{0:0.##########}", _value / 1000000000);
            if (_kind != 4)
                txtoz.Text = string.Format("{0:0.##########}", _value / 28349.523125);
            if (_kind != 5)
                txtlp.Text = string.Format("{0:0.##########}", _value / 453.59237);
        }

        private void txtkg_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtkg.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(2, douOutput * 1000000);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtkg.Text = "";
            }
        }

        private void txtt_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtt.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(3, douOutput * 1000000000);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtt.Text = "";
            }
        }

        private void txtoz_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtoz.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(4, douOutput * 28349.523125);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtoz.Text = "";
            }
        }

        private void txtlp_KeyUp(object sender, KeyEventArgs e)
        {
            strInput = txtlp.Text;
            if (double.TryParse(strInput, out douOutput) == true)
            {
                caculateAnswer(5, douOutput * 453.59237);
            }
            else
            {
                txtinfo.Text = "請輸入數字";
                txtlp.Text = "";
            }
        }
    }

    }

