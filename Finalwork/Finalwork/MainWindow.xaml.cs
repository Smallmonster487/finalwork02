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

namespace Finalwork
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        Random persent = new Random();
        int FourCN;
        int ThreeCN;
        int TwoCN;
        int TTCN;

        public MainWindow()
        {
            InitializeComponent();
           
        }

        // 拉桿設定4星卡目標數量
        private void MySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 將拉桿數值顯示到 ValueTxt 
            ValueTxt.Text = MySlider.Value.ToString();
        }
        //按鈕抽一次卡
        private void OneCard_Click(object sender, RoutedEventArgs e)
        {
            int R = persent.Next(0, 100);

            if (R >= 0 && R < 3)
            {
                FourCN += 1;
            }
            else if (R >= 2 && R < 33)
            {
                ThreeCN += 1;
            }
            else if(R>=33 && R < 100)
            {
                TwoCN += 1;
            }
            FourStarN.Text = FourCN.ToString();
            ThreeStarN.Text = ThreeCN.ToString();
            TwoStarN.Text = TwoCN.ToString();
            TTCN = TwoCN + ThreeCN + FourCN;
            TotalCN.Text = TTCN.ToString();

        }
        //按鈕抽10次卡
        private void TenCard_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i< 10; i++) {
                int R = persent.Next(0, 100);

                if (R >= 0 && R < 3)
                {
                    FourCN += 1;
                }
                else if (R >= 2 && R < 33)
                {
                    ThreeCN += 1;
                }
                else if (R >= 33 && R < 100)
                {
                    TwoCN += 1;
                }
                
            }
            FourStarN.Text = FourCN.ToString();
            ThreeStarN.Text = ThreeCN.ToString();
            TwoStarN.Text = TwoCN.ToString();
            TTCN = TwoCN + ThreeCN + FourCN;
            TotalCN.Text = TTCN.ToString();
        }
        //抽到達到設定的4星卡目標數量
        private void ManyCard_Click(object sender, RoutedEventArgs e)
        {
            int CN = Int32.Parse(ValueTxt.Text);
            for (int i = FourCN; i < CN; i = FourCN )
            {
                int R = persent.Next(0, 100);

                if (R >= 0 && R < 3)
                {
                    FourCN += 1;
                }
                else if (R >= 2 && R < 33)
                {
                    ThreeCN += 1;
                }
                else if (R >= 33 && R < 100)
                {
                    TwoCN += 1;
                }

            }
            FourStarN.Text = FourCN.ToString();
            ThreeStarN.Text = ThreeCN.ToString();
            TwoStarN.Text = TwoCN.ToString();
            TTCN = TwoCN + ThreeCN + FourCN;
            TotalCN.Text = TTCN.ToString();
        }
    }
}
