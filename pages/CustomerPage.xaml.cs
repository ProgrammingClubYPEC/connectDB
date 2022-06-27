using connectDB.databases;
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

namespace connectDB.pages
{
    /// <summary>
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();

            // проиницилизируем комбобок для роли
            filterComboBox.ItemsSource = Instance.GetContext().user_role.ToList().Prepend(new user_role() { name = "--- select role ---"});
            filterComboBox.SelectedIndex = 0;

            updateData();
        }

        private void updateData()
        {
            var listBoxList = Instance.GetContext().user.ToList();
            var dataGridList = Instance.GetContext().order.ToList();

            // поиск нужного пользователя
            if (!string.IsNullOrEmpty(searchText.Text))
                listBoxList = listBoxList.Where(p => p.surname.Trim().Contains(searchText.Text)).ToList();

            // фильтрация пользователя по роли
            if (filterComboBox.SelectedIndex > 0)
                listBoxList = listBoxList.Where((p) => p.code_role.Equals(filterComboBox.SelectedIndex)).ToList();

            // присвоим модифицированные временные списки нашим элементам вывода
            listBox.ItemsSource = listBoxList;
            dataGrid.ItemsSource = dataGridList;
        }

        private void filterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            updateData();
        }

        private void searchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            updateData();
        }

        private void tabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // заблокируем поиск и фильтрацию на вкладке заказов
            TabItem selectedItem = tabControl.SelectedItem as TabItem;
            if (selectedItem != null)
            {
                bool enabled = !selectedItem.Header.Equals("Orders");
                searchText.IsEnabled = enabled;
                filterComboBox.IsEnabled = enabled;
            }
        }
    }
}
