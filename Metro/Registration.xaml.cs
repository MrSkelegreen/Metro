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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text != "" && PasswordBox.Text != "" && NameBox.Text != "" && LNameBox.Text != "")
            {
                User checkLog = Context.db.Users.FirstOrDefault(u => u.Login == LoginBox.Text);
                if(checkLog == null)
                {
                    User user = new User() { Login = LoginBox.Text, Password = PasswordBox.Text, Firtsname = NameBox.Text, Lastname = LNameBox.Text };
                    MetroContext context = new MetroContext();
                    Context.db.Users.Add(user);     
                    Context.db.SaveChanges();
                    Context.userSession = user;
                    MessageBox.Show("Вы успешно зарегистрировались!");
                    new Menu().Show();
                    new MainWindow().Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой логин занят");
                }
                
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
