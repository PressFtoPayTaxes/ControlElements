using SecurityApplication.DataAccess;
using SecurityApplication.Models;
using SecurityApplication.Services;
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

namespace SecurityApplication
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegistrateButtonClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(newLoginTextBox.Text) || string.IsNullOrEmpty(newPasswordBox.Password) || string.IsNullOrEmpty(repeatPasswordBox.Password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            using (var context = new SecurityContext())
            {
                if (newPasswordBox.Password != repeatPasswordBox.Password)
                {
                    MessageBox.Show("Введённые пароли не совпадают");
                    return;
                }

                foreach (var user in context.Users)
                    if (user.Login == newLoginTextBox.Text)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует");
                        return;
                    }

                var newUser = new User
                {
                    Login = newLoginTextBox.Text,
                    Password = SecurityHasher.HashPassword(newPasswordBox.Password)
                };

                context.Users.Add(newUser);
                context.SaveChanges();
            }
            MessageBox.Show("Вы успешно зарегистрировались");
            Close();
        }
    }
}
