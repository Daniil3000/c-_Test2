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

namespace Test2
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        private List<Student> students = new List<Student>();

        Student std1 = new Student() { Id = 1, Name = "Robert" };
        Student std2 = new Student() { Id = 2, Name = "Julia" };
        Student std3 = new Student() { Id = 3, Name = "Sonya" };
        Student std4 = new Student() { Id = 4, Name = "Albert" };
        Student std5 = new Student() { Id = 5, Name = "Synthia" };

        public StudentForm()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtId.Text);

                if (id >= 1 && id <= 5)
                {
                    foreach (Student std in lstStudents.Items)
                    {
                        if (std.Id == id)
                        {
                            MessageBox.Show("Student is already in the list");
                            return;
                        }
                    }
                    switch (id)
                    {
                        case 1:
                            lstStudents.Items.Add(std1);
                            break;
                        case 2:
                            lstStudents.Items.Add(std2);
                            break;
                        case 3:
                            lstStudents.Items.Add(std3);
                            break;
                        case 4:
                            lstStudents.Items.Add(std4);
                            break;
                        case 5:
                            lstStudents.Items.Add(std5);
                            break;
                    }

                }
                else MessageBox.Show("Student with specified id does not exist");
                txtId.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            

        }
    }
}
