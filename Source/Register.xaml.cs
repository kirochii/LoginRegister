using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        //Lose focus on window click
        private void window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid_username.Focus();
            grid_password.Focus();
            grid_email.Focus();
        }

        //Navigate to login page
        private void login_txt_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Login();
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

        //Email placeholder
        private void input_email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (input_email.Text == "Email")
            {
                input_email.Text = "";
                input_email.Opacity = 1;
            }
        }

        private void input_email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (input_email.Text == "")
            {
                input_email.Text = "Email";
                input_email.Opacity = 0.5;
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

        //Try register
        private void register(object sender, RoutedEventArgs e)
        {
            string username = input_username.Text;
            string password = input_password.Password;
            string email = input_email.Text;

            var validation_pass = false;

            //Detail validations

            if (password == "" || username == "Username" || email == "Email")
            {
                err_border.Visibility = Visibility.Visible;
                err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                err_msg.Text = "Field cannot be left empty!";
            }
            else if (!Regex.IsMatch(username, @"^[a-zA-Z]+$"))
            {
                err_border.Visibility = Visibility.Visible;
                err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                err_msg.Text = "Username must contain only letters!";
            }
            else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$"))
            {
                err_border.Visibility = Visibility.Visible;
                err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                err_msg.Text = "Incorrect email format!";
            }
            else if (!Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                err_border.Visibility = Visibility.Visible;
                err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                err_msg.Text = "Password must consist of atleast eight characters, one letter and one number!";
            }
            else
            {
                var fileStream = new FileStream("login_credentials.txt", FileMode.Open, FileAccess.Read);
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        //Duplicate account validations
                        if (line.StartsWith("Email: ") && line.Substring("Email: ".Length) == email)
                        {
                            err_border.Visibility = Visibility.Visible;
                            err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                            err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                            err_msg.Text = "Email already registered!";
                            validation_pass = false;
                            break;
                        }

                        if (line.StartsWith("Username: ") && line.Substring("Username: ".Length) == username)
                        {
                            err_border.Visibility = Visibility.Visible;
                            err_border.Background = new SolidColorBrush(Color.FromArgb(255, 255, 221, 223));
                            err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 141, 148));
                            err_msg.Text = "Username already taken!";
                            validation_pass = false;
                            break;
                        }

                        validation_pass = true;
                    }

                    //Registration conditions met
                    if (validation_pass == true)
                    {
                        fileStream.Close();

                        string path = @"login_credentials.txt";

                        //Append details to txt file
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine("");
                            sw.WriteLine("Email: " + email);
                            sw.WriteLine("Username: " + username);
                            sw.WriteLine("Password: " + password);
                        }

                        err_border.Visibility = Visibility.Visible;
                        err_border.Background = new SolidColorBrush(Color.FromArgb(255, 209, 244, 218));
                        err_border.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 143, 228, 164));
                        err_msg.Text = "Registration successful!";

                        input_username.Text = "";
                        input_password.Password = "";
                        input_email.Text = "";

                        input_username_LostFocus(sender, e);
                        input_password_LostFocus(sender, e);
                        input_email_LostFocus(sender, e);
                    }
                }
            }
        }
    }
}
