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
    /// Логика взаимодействия для LetterWindow.xaml
    /// </summary>
    public partial class LetterWindow : Window
    {
        public bool Ltype { get; set; }
        public LetterWindow(bool type)
        {
            InitializeComponent();
            Ltype = type;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new LetterMenu().Show();
            this.Close();
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if(LetterBox.Text != "")
            {
                Letter letter = new Letter() { Iduser = Context.userSession.Id, LetterType = Ltype, Text = LetterBox.Text };
                Context.db.Letters.Add(letter);
                Context.db.SaveChanges();
                MessageBox.Show("Ваше сообщение отправлено!");
                new Menu().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Напишите что-нибудь");
            }
        }
    }
}
