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
    /// Логика взаимодействия для CouponWindow.xaml
    /// </summary>
    public partial class CouponWindow : Window
    {
        public CouponWindow()
        {
            InitializeComponent();
            User user = Context.userSession;
            DataContext = user;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            this.Close();
        }

        private void BalanceBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Context.userSession.IdCoupon != null)
            {
                new BalanceWindow().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("У вас нет проездного");
            }
        }

        private void CouponByeBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Context.userSession.IdCoupon == null)
            {
                new CouponBuyWindow().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("У вас уже есть проездной");
            }
        }
    }
}
