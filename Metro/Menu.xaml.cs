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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            User user = Context.userSession;
            DataContext = user;
        }

        private void TicketBtn_Click(object sender, RoutedEventArgs e)
        {
            new BuyTicket().Show();
            this.Close();
        }

        private void CouponBtn_Click(object sender, RoutedEventArgs e)
        {
            new CouponWindow().Show();
            this.Close();
        }

        private void LetterBtn_Click(object sender, RoutedEventArgs e)
        {
            new LetterMenu().Show();
            this.Close();
        }
    }
}
