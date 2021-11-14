using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SchoolLib;

namespace WpfApp {
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class AddStudent : Window {
        School school;
        public AddStudent(School school) {
            this.school = school;
            InitializeComponent();
            foreach(var x in this.school.classrooms) {
                classrooms.Items.Add(x.Number);
            }
        }

        private void Send(object sender, RoutedEventArgs e) {
            string name = nameText.Text;
            int age;
            int.TryParse(ageText.Text, out age);
            Classroom classroom = school.classrooms.Find(x => x.Number == (string)classrooms.SelectedItem);
            Student student = new Student(name, age, classroom, classroom.schedule);
            school.students.Add(student);
            student.classroom.students.Add(student);
            this.Close();
        }

        private void ClassSelected(object sender, RoutedEventArgs e) {
            Classroom classroom = school.classrooms.Find(x => x.Number == (string)classrooms.SelectedItem);
            schedules.Items.Clear();
            foreach (var x in classroom.schedule) {
                schedules.Items.Add(x.Key + " - " + x.Value.name);
            }
        }
    }
}
