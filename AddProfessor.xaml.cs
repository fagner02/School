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
using System.Windows.Markup;

namespace WpfApp {
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class AddProfessor : Window {
        private School school;
        private TimeSpan time = new TimeSpan(0, 0, 0);
        public AddProfessor(School school) {
            InitializeComponent();
            this.school = school;
            foreach (var x in school.classrooms) {
                ComboBoxItem temp = new ComboBoxItem();
                temp.Content = x.Number;
                scheduleDropDown.Items.Add(x.Number);
            }
            foreach (var x in school.subjects) {
                subjects.Items.Add(x.name);
            }
            time += school.classDuration;
        }

        private void AddScheduleListItem(object sender, RoutedEventArgs e) {
            Grid grid = XamlReader.Parse(XamlWriter.Save(scheduleNameItem)) as Grid;
            Label stamp = grid.Children[0] as Label;
            stamp.Content = time;
            scheduleList.Children.Add(grid);
            time += school.classDuration;
        }

        private void Send(object sender, RoutedEventArgs e) {
            int age;
            int.TryParse(ageText.Text, out age);
            Subject subject = school.subjects.Find(x => x.name == subjects.Text);
            Dictionary<TimeSpan, Classroom> schedule = new Dictionary<TimeSpan, Classroom>();
            TimeSpan tempTime = new TimeSpan(0, 0, 0);
            foreach (Grid x in scheduleList.Children) {
                ComboBox item = x.Children[1] as ComboBox;
                schedule.Add(tempTime, school.classrooms.Find(x => x.Number == item.Text));
                tempTime += school.classDuration;
            }
            Professor professor = new Professor(nameText.Text, subject, schedule);
            professor.age = age;
            school.professors.Add(professor);
            this.Close();
        }
    }
}
