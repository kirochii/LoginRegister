using System;
using System.Collections.Generic;
using System.IO;
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

namespace LoginRegister
{
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        //Lose focus on window click
        private void window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid_username.Focus();
            grid_password.Focus();
        }

        //Navigate to register page
        private void register_txt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Register();
        }

        //Username placeholder
        private void input_username_GotFocus(object sender, RoutedEventArgs e)
        {
            if (input_username.Text == "Username")
            {
                input_username.Text = "";
                input_username.Opacity = 1;
            }
        }

        private void input_username_LostFocus(object sender, RoutedEventArgs e)
        {
            if (input_username.Text == "")
            {
                input_username.Text = "Username";
                input_username.Opacity = 0.5;
            }
        }

        //Password placeholder
        private void input_password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (input_password.Password == "")
            {
                password_placeholder.Text = "";
                password_placeholder.Visibility = Visibility.Hidden;
            }
        }

        private void input_password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (input_password.Password == "")
            {
                password_placeholder.Text = "Password";
                password_placeholder.Visibility = Visibility.Visible;
            }
        }

        //Try login
        private void login(object sender, RoutedEventArgs e)
        {
            //Detail validations
            if (input_password.Password == "" || input_username.Text == "Username")
            {
                err_border.Visibility = Visibility.Visible;
                err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                err_msg.Text = "Field cannot be left empty!";
            }
            else
            {
                var fileStream = new FileStream("login_credentials.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string username = input_username.Text;
                    string password = input_password.Password;
                    var login_success = false;

                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        //Username matched
                        if (line.StartsWith("Username: ") && line.Substring("Username: ".Length) == username)
                        {
                            line = streamReader.ReadLine(); //Read next line

                            //Password matched
                            if (line.StartsWith("Password: ") && line.Substring("Password: ".Length) == password)
                            {
                                err_border.Visibility = Visibility.Visible;
                                err_border.Background = new SolidColorBrush(Color.FromArgb(255, 209, 244, 218));
                                err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 143, 228, 164));
                                err_msg.Text = "Login successful!";

                                input_username.Text = "";
                                input_password.Password = "";

                                input_username_LostFocus(sender, e);
                                input_password_LostFocus(sender, e);

                                login_success = true;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    //Details not matched
                    if (login_success == false)
                    {
                        err_border.Visibility = Visibility.Visible;
                        err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                        err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                        err_msg.Text = "Invalid login!";
                    }
                }
            }
        }
    }
}
