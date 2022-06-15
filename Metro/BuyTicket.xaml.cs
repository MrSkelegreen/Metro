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
    /// Логика взаимодействия для BuyTicket.xaml
    /// </summary>
    public partial class BuyTicket : Window
    {
        public string[] methods { get; set; }
        public BuyTicket()
        {
            InitializeComponent();

            User user = Context.userSession;
            DataContext = user;

            methods = new string[] {"Онлайн банк", "Проездной"};
            DataContext = this;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            this.Close();
        }

        private void NextBtn_Click(object sender, RoutedEventArgs e)
        {          

            if(ComboMethod.Text == "Проездной") 
            {
                if(Context.userSession.IdCoupon != null)
                {
                    Coupon coupon = Context.db.Coupons.FirstOrDefault(c => c.Idcoupon == Context.userSession.IdCoupon);
                    if(coupon.Balance >= 20)
                    {
                        coupon.Balance -= 20;
                        Ticket ticket = new Ticket() { Price = 20, Date = DateTime.Today, Iduser = Context.userSession.Id };
                        Context.db.Tickets.Add(ticket);
                        
                        Pay pay = new Pay() { Sum = 20, Date = DateTime.Today, PayType = false, Idcoupon = coupon.Idcoupon};
                        Context.db.Pays.Add(pay);

                        Context.db.SaveChanges();

                        MessageBox.Show($"Билет успешно куплен.\nСпасибо, что пользуетесь услугами нашей компании!");
                        new Menu().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Недостаточно средств");
                    }
                }
                else
                {
                    MessageBox.Show("У вас нет проездного!");
                }
            }

            if(ComboMethod.Text == "Онлайн банк")
            {
                Ticket ticket = new Ticket() { Price = 20, Date = DateTime.Today, Iduser = Context.userSession.Id}; 
                Context.db.Tickets.Add(ticket);
                Context.db.SaveChanges();
                MessageBox.Show($"Билет успешно куплен.\nСпасибо, что пользуетесь услугами нашей компании!");
                new Menu().Show();
                this.Close();
            }
        }
    }
}
