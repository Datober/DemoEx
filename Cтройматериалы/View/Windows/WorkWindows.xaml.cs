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

namespace Cтройматериалы.View
{
    /// <summary>
    /// Логика взаимодействия для WorkWindows.xaml
    /// </summary>
    public partial class WorkWindows : Window
    {
        public WorkWindows()
        {
            InitializeComponent();
        }

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            //Кнопка позволяет добавить данные из БД
        }
    }
    //Данное окно считывает информацию из БД, позволяя пользователю выбрать, удалить товар и редактировать его
}
