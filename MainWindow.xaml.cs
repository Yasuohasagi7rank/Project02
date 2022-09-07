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

namespace Project02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        public void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Person[] persons = new Person[4];
            persons[0] = new Person() { Name = "Василиса", Surname = "Йагович", Patronymic = "Сергеевна", Sex = "жен", Age = 45, FamilyStatus = "не замужем", Child = "нет", Post = "повар", Degree = "высшее" };
            persons[1] = new Person() { Name = "Иван", Surname = "Васильев", Patronymic = "Евгеньевич", Sex = "муж", Age = 35, FamilyStatus = "муж", Child = "да", Post = "начальник", Degree = "высшее" };
            persons[2] = new Person() { Name = "Ярослав", Surname = "Григорян", Patronymic = "Олегович", Sex = "муж", Age = 23, FamilyStatus = "женат", Child = "нет", Post = "зам. начальника", Degree = "высшее" };
            persons[3] = new Person() { Name = "Владимир", Surname = "Дятлов", Patronymic = "Даниилович", Sex = "муж", Age = 60, FamilyStatus = "не женат", Child = "нет", Post = "водитель", Degree = "высшее" };
            Table.ItemsSource = persons;
        }

    }
}

