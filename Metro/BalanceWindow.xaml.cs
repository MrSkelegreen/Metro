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
    /// Логика взаимодействия для BalanceWindow.xaml
    /// </summary>
    public partial class BalanceWindow : Window
    {
        public BalanceWindow()
        {
            InitializeComponent();
            User user = Context.userSession;           
            Coupon coupon = Context.db.Coupons.FirstOrDefault(c => c.Idcoupon == Context.userSession.IdCoupon);
            DataContext = coupon;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new CouponWindow().Show();
            this.Close();
        }

        private void CouponPayBtn_Click(object sender, RoutedEventArgs e)
        {
            new CouponPayWindow().Show();
            this.Close();
        }
    }
}
