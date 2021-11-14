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
using System.Xaml;
using System.Windows.Markup;
using System.Diagnostics;
using SchoolLib;

namespace WpfApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        char lastGrid;
        School school = new School();
        Grid current;
        ParserContext context = new ParserContext();
        public MainWindow() {
            InitializeComponent();
            context.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
            context.XmlnsDictionary.Add("materialDesign", "http://materialdesigninxaml.net/winfx/xaml/themes");
            context.XmlnsDictionary.Add("smtx", "clr-namespace:ShowMeTheXAML;assembly=ShowMeTheXAML");
            context.XmlnsDictionary.Add("l", "clr-namespace:UIControls;assembly=UIControls");
            context.XmlnsDictionary.Add("d", "http://schemas.microsoft.com/expression/blend/2008");
            context.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
            context.XmlnsDictionary.Add("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
            context.XmlnsDictionary.Add("sys", "clr-namespace:System;assembly=mscorlib");
            context.XmlnsDictionary.Add("xctk", "clr-namespace:Xceed.Wpf.Toolkit;assembly=Xceed.Wpf.Toolkit");
            current = overviewGrid;
            school.studentSchedules.Add(new Dictionary<TimeSpan, Subject>() {
                { new TimeSpan(0, 0, 0), new Subject("maths")}
            });
            school.studentSchedules.Add(new Dictionary<TimeSpan, Subject>() {
                { new TimeSpan(0, 0, 0), new Subject("History")},
                { new TimeSpan(0, 30, 0), new Subject("Biology")}
            });
            school.classrooms.Add(new Classroom(0));
            school.classrooms[0].schedule = school.studentSchedules[0];
            school.classrooms.Add(new Classroom(1));
            school.classrooms[1].schedule = school.studentSchedules[1];
        }

        private void AddStudent(object sender, RoutedEventArgs args) {
            AddStudent window1 = new AddStudent(school);
            window1.ShowDialog();
            SetText();
        }

        private void OpenOverview(object sender, RoutedEventArgs e) {
            HideCurrent(overviewGrid);

            SetText();
        }

        public void HideCurrent(Grid temp) {
            current.Visibility = Visibility.Hidden;
            temp.Visibility = Visibility.Visible;
            current = temp;
        }
        public void SetText() {
            overviewText.Text = $"School Name: {school.name}\r\nNumber of students: {school.students.Count}\r\n" +
            $"Student capacity: 100\r\nNumber of classrooms: {school.classrooms.Count}\r\n" +
            $"Number of professors: {school.professors.Count}\r\nSubjects:\r\n";
            foreach (var x in school.subjects) {
                overviewText.Text += "    " + x.name + "\r\n";
            }
        }

        private void ShowStudents(object sender, RoutedEventArgs e) {
            HideCurrent(studentsGrid);
            lastGrid = 'S';
            studentsList.Items.Clear();
            string str =
            @"<Grid Visibility=""Collapsed""  Height=""Auto"" Width=""475"">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width=""148""></ColumnDefinition>
                    <ColumnDefinition Width=""98""></ColumnDefinition>
                    <ColumnDefinition Width=""247""></ColumnDefinition>
                </Grid.ColumnDefinitions>
                <Label Grid.Column=""0"" Foreground=""White"">Name</Label>
                <Label Grid.Column=""1"" Foreground=""White"">Age</Label>
                <Label Grid.Column=""2"" Foreground=""White"">Classroom</Label>
            </Grid>";
            foreach (var x in school.students) { 
                Encoding encoding = Encoding.UTF8;
                var ecod = new System.IO.MemoryStream(encoding.GetBytes(str));
                Grid grid = (Grid)System.Windows.Markup.XamlReader.Load(ecod, context);
                grid.Visibility = Visibility.Visible;
                grid.Children[0].SetValue(ContentProperty, x.name);
                grid.Children[1].SetValue(ContentProperty, x.age);
                grid.Children[2].SetValue(ContentProperty, x.classroom.Number);
                grid.MouseDown += new MouseButtonEventHandler(ToStudentsDetail);
                studentsList.Items.Add(grid);
            }
        }

        private void ShowClassrooms(object sender, RoutedEventArgs e) {
            HideCurrent(classroomsGrid);
            lastGrid = 'C';
            classroomList.Items.Clear();
            string str =
            @"<Grid Visibility=""Visible""  HorizontalAlignment='Stretch' Height=""Auto"" Width=""475"">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width=""17*""></ColumnDefinition>
                    <ColumnDefinition Width=""24*""></ColumnDefinition>
                    <ColumnDefinition Width=""58*""></ColumnDefinition>
                </Grid.ColumnDefinitions>
                <Label Grid.Column=""0"" Foreground=""White"">Number</Label>
                <Label Grid.Column=""1"" Foreground=""White"">Capacity</Label>
                <Label Grid.Column=""2"" Foreground=""White"">Students</Label>
            </Grid>";
            foreach (var x in school.classrooms) {
                Encoding encoding = Encoding.UTF8;
                var ecod = new System.IO.MemoryStream(encoding.GetBytes(str));
                Grid grid = (Grid)System.Windows.Markup.XamlReader.Load(ecod, context);
                grid.Visibility = Visibility.Visible;
                grid.Children[0].SetValue(ContentProperty, x.Number);
                grid.Children[1].SetValue(ContentProperty, x.capacity);
                grid.Children[2].SetValue(ContentProperty, x.students.Count);
                grid.MouseDown += new MouseButtonEventHandler(ToClassroomDetail);
                classroomList.Items.Add(grid);
            }
        }

        private void ToStudentsDetail(object sender, MouseButtonEventArgs e) {
            Grid obj = (Grid)sender;
            Student student = school.students.Find(x => x.name == (string)obj.Children[0].GetValue(ContentProperty));
            HideCurrent(studentDetailGrid);
            detailName.Content = student.name;
            detailAge.Content = student.age;
            detailClassroom.Content = student.classroom.Number;
            detailSchedule.Text = "";
            foreach (var x in student.schedule) {
                detailSchedule.Text += x.Key + " - " + x.Value.name + "\n"; 
            }
        }

        private void ToClassroomDetail(object sender, MouseButtonEventArgs e) {
            Grid obj = (Grid)sender;
            Classroom classroom = school.classrooms.Find(x => x.Number == (string)obj.Children[0].GetValue(ContentProperty));
            HideCurrent(classroomDetailGrid);
            detailClassNumber.Content = classroom.Number;
            detailClassCapacity.Content = classroom.capacity;
            detailClassStudentNumber.Content = classroom.students.Count;
            detailClassStudents.Items.Clear();
            string str = 
            @"<Grid Visibility=""Visible""  Height=""Auto"" Width=""370"">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width=""8*""></ColumnDefinition>
                    <ColumnDefinition Width=""1*""></ColumnDefinition>
                    <ColumnDefinition Width=""1*""></ColumnDefinition>
                </Grid.ColumnDefinitions>
                <Label Grid.Column=""0"" Foreground=""White"">Number</Label>
                <Label Grid.Column=""1"" Foreground=""White"">Capacity</Label>
                <Label Grid.Column=""2"" Foreground=""White"">Students</Label>
            </Grid>";
            
            foreach (var x in classroom.students) {
                Encoding encoding = Encoding.UTF8;
                var ecod = new System.IO.MemoryStream(encoding.GetBytes(str));
                Grid grid = (Grid)System.Windows.Markup.XamlReader.Load(ecod, context);
                grid.Visibility = Visibility.Visible;
                grid.Children[0].SetValue(ContentProperty, x.name);
                grid.Children[1].SetValue(ContentProperty, x.age);
                grid.Children[2].SetValue(ContentProperty, x.classroom.Number);
                grid.MouseDown += new MouseButtonEventHandler(ToStudentsDetail);
                detailClassStudents.Items.Add(grid);
            }
        }

        private void BackFromDetails(object sender, RoutedEventArgs e) {
            if(lastGrid == 'S') {
                ShowStudents(sender, e);
            }
            if (lastGrid == 'C') {
                ShowClassrooms(sender, e);
            }
        }

        private void AddClassroom(object sender, RoutedEventArgs e) {
            AddClassroom addClassroom = new AddClassroom(school);
            addClassroom.ShowDialog();
        }

        private void ToClose(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e) {
            Trace.WriteLine(((Rectangle)sender).ActualWidth);
            if(e.ChangedButton == MouseButton.Left) {
                if (e.ClickCount == 2) {
                    Adjust();
                } else {
                    Application.Current.MainWindow.DragMove();
                }
            }
        }
        
        public void Adjust() {
            if (WindowState == WindowState.Normal) {
                WindowState = WindowState.Maximized;
            } else {
                WindowState = WindowState.Normal;
            }
        }
    }
}