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
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;

namespace SecurityApplication
{
    /// <summary>
    /// Логика взаимодействия для VkSignInWindow.xaml
    /// </summary>
    public partial class VkSignInWindow : Window
    {
        public VkSignInWindow()
        {
            InitializeComponent();
        }

        private void VkSignInButtonClick(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(vkNumberTextBox.Text) || string.IsNullOrEmpty(vkPasswordBox.Password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            var vkApi = new VkApi();

            ulong appId = 6969136;

            try
            {
                vkApi.Authorize(new ApiAuthParams
                {
                    ApplicationId = appId,
                    Login = vkNumberTextBox.Text,
                    Password = vkPasswordBox.Password,
                    Settings = Settings.Offline
                });
            }
            catch(VkApiAuthorizationException)
            {
                MessageBox.Show("Неверные номер телефона или пароль");
                return;
            }
            catch(VkApiException exception)
            {
                MessageBox.Show("Неизвестная ошибка: " + exception.Message);
                return;
            }
            catch(Exception exception)
            {
                MessageBox.Show("Произошла вообще левая ошибка: " + exception.Message);
                return;
            }

            MessageBox.Show("Вы успешно авторизовались");
            Close();
        }
    }
}
