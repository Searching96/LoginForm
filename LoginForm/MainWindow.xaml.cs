using System;
using System.Linq;
using System.Windows;
using LoginForm.Models;

namespace LoginForm
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            using (var context = new AppDbContext())
            {
                var user = context.AppUsers.FirstOrDefault(u => u.Username == username && u.Passwordd == password);

                if (user != null)
                {
                    MessageBox.Show("Login succesfull", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
