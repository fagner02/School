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
    public partial class AddSubject : Window {
        private School school;
        public AddSubject(School school) {
            this.school = school;
            InitializeComponent();
        }

        private void Send(object sender, RoutedEventArgs e) {
            Subject subject = new Subject(nameText.Text);
            subject.description = descriptionText.Text;
            school.subjects.Add(subject);
            this.Close();
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left) {
                if (e.ClickCount == 2) {
                    Adjust();
                } else {
                    this.DragMove();
                }
            }
        }

        public void Adjust() {

            if (WindowState == WindowState.Normal) {
                this.SizeToContent = SizeToContent.Manual;
                WindowState = WindowState.Maximized;
            } else {
                this.SizeToContent = SizeToContent.Width;
                WindowState = WindowState.Normal;
            }

        }

        private void Close(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
