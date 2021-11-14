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
using System.Windows.Markup;
using SchoolLib;

namespace WpfApp {
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class AddClassroom : Window {
        School school;
        public AddClassroom(School school) {
            this.school = school;
            InitializeComponent();
        }

        private void AddTimeStamp(object sender, RoutedEventArgs e) {
            Grid temp = XamlReader.Parse(XamlWriter.Save(scheduleStamp)) as Grid;
            scheduleList.Children.Add(temp);
        }

        private void Send(object sender, RoutedEventArgs e) {
            int num;
            int.TryParse(numberText.Text, out num);
            int capacity;
            int.TryParse(capacityText.Text, out capacity);
            Classroom temp = new Classroom(num);
            temp.capacity = capacity;
            TimeSpan time = new TimeSpan(0, 0, 0);
            Dictionary<TimeSpan, Subject> schedule = new Dictionary<TimeSpan, Subject>();
          
            foreach(Grid x in scheduleList.Children) {
                schedule.Add(time, new Subject((string)x.Children[1].GetValue(ContentProperty)));
                time += school.classDuration;
            }
            temp.schedule = schedule;
            school.classrooms.Add(temp);
            this.Close();
        }
    }
}
