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
    /// Логика взаимодействия для Goods_page.xaml
    /// </summary>
    public partial class Goods_page : Page
    {
        OzonEntities1 DB = new OzonEntities1();
        public Goods_page()
        {
            InitializeComponent();
            table_grid.ItemsSource = DB.Goods.ToList();
            pack_types.ItemsSource = DB.Goods_categories.ToList();
            pack_types.DisplayMemberPath = "Good_category_name";
        }

        private void Add_but_Click(object sender, RoutedEventArgs e)
        {
            if (good_name.Text != "" && pack_types.SelectedItem != null && float.TryParse(goods_price.Text, out _) && int.TryParse(goods_amount.Text, out _))
            {
                Goods pack = new Goods();
                pack.Good_name = good_name.Text;
                pack.Good_price = int.Parse(goods_price.Text);
                pack.Good_amount = int.Parse(goods_amount.Text);
                pack.Goods_categories = pack_types.SelectedItem as Goods_categories;
                DB.Goods.Add(pack);
                Reload();
            }
        }

        void Reload()
        {
            DB.SaveChanges();
            table_grid.ItemsSource = DB.Goods.ToList();
        }

        private void table_grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (table_grid.SelectedItem != null)
            {
                var pack = table_grid.SelectedItem as Goods;
                pack_types.SelectedItem = pack.Goods_categories;
                good_name.Text = pack.Good_name;
                goods_price.Text = pack.Good_price.ToString();
                goods_amount.Text = pack.Good_amount.ToString();
                pack_types.SelectedItem = (table_grid.SelectedItem as Goods).Goods_categories;
            }
        }

        private void Alt_but_Click(object sender, RoutedEventArgs e)
        {
            if (good_name.Text != "" && pack_types.SelectedItem != null && float.TryParse(goods_price.Text, out _) && int.TryParse(goods_amount.Text, out _))
            {
                var pack = table_grid.SelectedItem as Goods;
                pack.Good_name = good_name.Text;
                pack.Good_price = decimal.Parse(goods_price.Text);
                pack.Good_amount = int.Parse(goods_amount.Text);
                pack.Goods_categories = pack_types.SelectedItem as Goods_categories;
            }
            Reload();
        }

        private void Del_bat_Click(object sender, RoutedEventArgs e)
        {
            if (table_grid.SelectedItem != null)
            {
                try
                {
                    DB.Goods.Remove(table_grid.SelectedItem as Goods);
                    Reload();
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить так как на него ссылаются из других таблиц");
                }
            }
        }
    }
}
