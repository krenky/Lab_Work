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
using Student;

namespace Student
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<student> Students = new List<student>();
        student student1 = new student();
        int Index = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 Add_window = new Window1();
            Window3 AddMark = new Window3();
            Add_window.ShowDialog();
            if (Add_window.DialogResult == true)
            {
                student1.Name1 = Add_window.name;
                Students.Add(student1);
                AddMark.ShowDialog();
                if (AddMark.DialogResult == true)
                {
                    Students[Index].Marks1.Add(Convert.ToInt32(AddMark.Add_mark));
                }
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 Del_window = new Window2();
            Del_window.ShowDialog();
            if (Del_window.DialogResult == true)
            {
                Students.RemoveAt(Del_window.index);
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            if (Students.Count > 0)
            {
                if (Students.Count == 1)
                {
                    name_set.Content = Students[Index].Name1;
                    markss.Content = Students[Index].Out_marks();
                    Sred.Content = Students[Index].sred();
                }
                else
                {
                    Index--;
                    name_set.Content = Students[Index].Name1;
                    markss.Content = Students[Index].Out_marks();
                    Sred.Content = Students[Index].sred();
                }
            }
            else
            {
                
            }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            if (Students.Count > 0)
            {
                if (Students.Count == 1)
                {
                    name_set.Content = Students[Index].Name1;
                    markss.Content = Students[Index].Out_marks();
                    Sred.Content = Students[Index].sred();
                }
                else
                {
                    Index++;
                    name_set.Content = Students[Index].Name1;
                    markss.Content = Students[Index].Out_marks();
                    Sred.Content = Students[Index].sred();
                }
            }
            else
            {

            }
        }
    }
}
