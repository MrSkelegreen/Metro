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
    /// Логика взаимодействия для LetterMenu.xaml
    /// </summary>
    public partial class LetterMenu : Window
    {
        public LetterMenu()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new Menu().Show();
            this.Close();
        }

        private void SuggestBtn_Click(object sender, RoutedEventArgs e)
        {
            bool type = true;
            new LetterWindow(type).Show();
            this.Close();
        }

        private void ComplaintBtn_Click(object sender, RoutedEventArgs e)
        {
            bool type = false;
            new LetterWindow(type).Show();
            this.Close();
        }
    }
}
