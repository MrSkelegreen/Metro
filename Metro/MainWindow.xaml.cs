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

namespace Metro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }      

        private void LgnBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = Context.db.Users.FirstOrDefault(q => q.Login == LoginBox.Text && q.Password == PasswordBox.Text);
            if (user != null)
            {
                Context.userLogin = user.Login;
                Context.userSession = user;
                Context.db.SaveChanges();
                new Menu().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введён неверный логин или пароль");
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            
        }
    }
}
