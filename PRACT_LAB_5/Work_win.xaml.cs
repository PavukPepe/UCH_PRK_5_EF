using PRACT_LAB_5.Admin;
using PRACT_LAB_5.PVZ;
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

namespace PRACT_LAB_5
{
    /// <summary>
    /// Логика взаимодействия для Work_win.xaml
    /// </summary>
    public partial class Work_win : Window
    {
        OzonEntities1 DB = new OzonEntities1();
        public Work_win(Users user)
        {
            Roles role = user.Roles;
            InitializeComponent();
            ;
            if (role.Role_id ==Get_post_of_role("HR"))
            {
                role_frame.Content = new HR_page(); 
            }
            else if (role.Role_id == Get_post_of_role("Кладовщик"))
            {
                role_frame.Content = new Storager_page();
            }
            else if (role.Role_id == Get_post_of_role("Покупатель") || role.Role_id == Get_post_of_role("Кандидат"))
            {
                role_frame.Content = new Customer_page(user);
            }
            else if (role.Role_id == Get_post_of_role("Работник ПВЗ"))
            {
                role_frame.Content = new PVZ_page(user);
            }
            else if (role.Role_id == Get_post_of_role("Администратор"))
            {
                role_frame.Content = new Admin_page();
            }
        }

        int Get_post_of_role(string role_name)
        {
           return DB.Roles.ToList().Where(item => item.ID_post == DB.Posts.ToList().Where(iten => iten.Post_name == role_name).First().Post_id).First().Role_id;
        }

        public void CloseToAuth()
        {
            MainWindow n = new MainWindow();
            Close();
            n.Show();
        }
    }
}
