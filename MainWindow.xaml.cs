using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2mdk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, RoutedEventArgs e)
        {if (IsStudent.IsChecked == true)
            {
                Student student = new Student();
                InCome.Text = "";
                balence.Text = "";
                student.Name = Name.Text;

                student.Surname = Surname.Text;
                student.Patronymic = Patronymic.Text;
                student.monthScholarship = decimal.Parse(Size.Text);
                InCome.Text += "Имя:" + student.Name;
                InCome.Text += "\n";
                InCome.Text += "Фамилия:" + student.Surname;
                InCome.Text += "\n";
                InCome.Text += "Отчество:" + student.Patronymic;
                InCome.Text += "\n";
                InCome.Text += "Годовой доход:" + student.Income() + " (Рублей)";
                balence.Text = "Без налога";
                Name.Text = "";
                Surname.Text = "";
                Patronymic.Text = "";
                Size.Text = "";
            }

            else if (IsEmployee.IsChecked == true)
            {
                Employee emp = new Employee();
                InCome.Text = "";
                balence.Text = "";
                emp.Name = Name.Text;
                emp.Surname = Surname.Text;
                emp.Patronymic = Patronymic.Text;
                emp.Salery=decimal.Parse(Size.Text);
                InCome.Text += "Имя:" + emp.Name;
                InCome.Text += "\n";
                InCome.Text += "Фамилия:" +emp.Surname;
                InCome.Text += "\n";
                InCome.Text += "Отчество:" +emp.Patronymic;
                InCome.Text += "\n";
                InCome.Text += "Годовой доход:" + emp.Income() + " (Рублей)";
                balence.Text = "Годовой налог составляет: "+emp.Tax() + " (Рублей)";
                Name.Text = "";
                Surname.Text = "";
                Patronymic.Text = "";
                Size.Text = "";

            }



            }

        }
    }
