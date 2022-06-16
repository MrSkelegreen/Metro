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

namespace Metro
{
    /// <summary>
    /// Логика взаимодействия для CouponPayWindow.xaml
    /// </summary>
    public partial class CouponPayWindow : Window
    {
        public decimal paySum { get; set; }
        public CouponPayWindow()
        {
            InitializeComponent();
            User user = Context.userSession;
            Coupon coupon = Context.db.Coupons.FirstOrDefault(c => c.Idcoupon == Context.userSession.IdCoupon);
            DataContext = coupon;
            
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            decimal value = 0;
            if(decimal.TryParse(SumBox.Text, out value))
            {        
                if(value > 0)
                {
                    paySum = value;
                    Coupon coupon = Context.db.Coupons.FirstOrDefault(c => c.Idcoupon == Context.userSession.IdCoupon);
                    DataContext = coupon;
                    coupon.Balance += paySum;
                    Pay pay = new Pay() {Sum = paySum, Date = DateTime.Today, PayType = true, Idcoupon = coupon.Idcoupon};
                    Context.db.Pays.Add(pay);
                    Context.db.SaveChanges();
                    MessageBox.Show("Оплата прошла успешно!");
                    new BalanceWindow().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите корректную сумму");
                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new BalanceWindow().Show();
            this.Close();
        }
    }
}
