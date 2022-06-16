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
    /// Логика взаимодействия для CouponBuyWindow.xaml
    /// </summary>
    public partial class CouponBuyWindow : Window
    {
        public CouponBuyWindow()
        {
            InitializeComponent();
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {
            Coupon coupon = new Coupon() {Balance = 20, EndDate = DateTime.Today.AddYears(5)};
            Context.db.Coupons.Add(coupon);
            Context.db.SaveChanges();
            User user = Context.userSession;
            DataContext = user;
            user.IdCoupon = coupon.Idcoupon;
            Context.db.SaveChanges();
            MessageBox.Show("Проездной успешно куплен");
            new CouponWindow().Show();
            this.Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new CouponWindow().Show();
            this.Close();
        }
    }
}
