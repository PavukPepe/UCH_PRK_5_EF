using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PRACT_LAB_5
{
    /// <summary>
    /// Логика взаимодействия для Registration_win.xaml
    /// </summary>
    public partial class Registration_win : Window
    {
        OzonEntities1 DB = new OzonEntities1();
        public Registration_win()
        {
            InitializeComponent();
            pvz.ItemsSource = DB.Pvzs.ToList();
            pvz.DisplayMemberPath = "Pvz_address";
        }

        private void reg_but_Click(object sender, RoutedEventArgs e)
        {

            if (login.Text != "" && password.Text != "" && password2.Text != "" && password.Text != "" && name.Text != "" && surname.Text != "")
            {
                if (password2.Text != password.Text)
                {
                    MessageBox.Show("Пароли не совпадают");
                    return;
                }
                /*                if (password2.Text.Length < 8)
                                {
                                    MessageBox.Show("Минимальная длина пароля 8 символов");
                                    return;
                                }*/
                try
                {
                    Authorizations auth = new Authorizations();
                    auth.Auth_login = login.Text;
                    auth.Auth_pass = password.Text; 
                    DB.Authorizations.Add(auth);
                    DB.SaveChanges();
                    Users user = new Users();
                    user.User__name = name.Text;
                    user.User__surname = surname.Text;
                    user.User__middlename = middlename.Text;
                    user.Pvzs = pvz.SelectedItem as Pvzs;
                    if (worker.IsChecked == true)
                    {
                        user.Roles = DB.Roles.ToList().Where(item => item.ID_post == DB.Posts.ToList().Where(iten => iten.Post_name == "Кандидат").ToList()[0].Post_id).ToList()[0];
                    }
                    else
                    {
                        user.Roles = DB.Roles.ToList().Where(item => item.ID_post == DB.Posts.ToList().Where(iten => iten.Post_name == "Покупатель").ToList()[0].Post_id).ToList()[0];
                    }
                    user.Authorizations = auth;
                    DB.Users.Add(user);
                    DB.SaveChanges();
                    MessageBox.Show("Вы успешно зарегитсрировались");
                    MainWindow mainWindow = new MainWindow();
                    Close();
                    mainWindow.Show();
                }
                catch 
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
            } 
        }

        private void exit_but_Click(object sender, RoutedEventArgs e)
        {
            Window cuurent_win = Window.GetWindow(this);
            if (cuurent_win != null)
            {
                MainWindow reg = new MainWindow();
                cuurent_win.Close();
                reg.Show();
            }
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox; string text = textBox.Text;
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    textBox.Text = text.Remove(text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; return;
                }
            }
        }

        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox; string text = textBox.Text;
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    textBox.Text = text.Remove(text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; return;
                }
            }
        }

        private void middlename_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox; string text = textBox.Text;
            foreach (char c in text)
            {
                if (!char.IsLetter(c))
                {
                    textBox.Text = text.Remove(text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length; return;
                }
            }
        }

        private void worker_Checked(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
