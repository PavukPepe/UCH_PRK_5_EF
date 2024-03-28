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

namespace PRACT_LAB_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OzonEntities1 DB = new OzonEntities1();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ent_but_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text != "" && pass.Password != "")
            {
                if (DB.Authorizations.ToList().Where(item => item.Auth_login == login.Text && item.Auth_pass == pass.Password).ToList().Count() > 0)
                {
                    Work_win win = new Work_win((DB.Authorizations.ToList().Where(item => item.Auth_login == login.Text && item.Auth_pass == pass.Password).ToList()[0]).Users.ToList()[0] as Users);
                    Close();
                    win.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }


        }

        private void reg_but_Click(object sender, RoutedEventArgs e)
        {
            Registration_win win = new Registration_win();
            Close();
            win.Show();
        }
    }
}
