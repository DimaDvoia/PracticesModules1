using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
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
using practice_modules.models;
using System.Security.Policy;
using ClassLibrary1;
using System.Data.Entity;

namespace practice_modules.pages
{
    /// <summary>
    /// Interaction logic for Plain.xaml
    /// </summary>
    public partial class Plain : Page
    {
        public Plain()
        {
            InitializeComponent();
        }

        private void btnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Client(null));
        }
        private int unsuccesful = 0;

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            string login = txtbLogin.Text.Trim();
            string password = pswbPassword.Password.Trim();
            string Hash = Class1.HashPassword1(password);
            var roles = Helper.GetContext().ROLES.Where(d => d.id_role == 2).FirstOrDefault();

           


            if (login.Length > 0 && password.Length > 0)
            {
                if (unsuccesful < 1)
                {
                    var job = Helper.GetContext().ROLES;
                    var user = Helper.GetContext().USERS.Where(u => u.LOGIN == login && u.PASSWORD == Hash).FirstOrDefault();

                    if (user != null)
                    {
                        int role = (int)user.role_id;

                        if (role == 1)
                        {
                            NavigationService.Navigate(new Client(null));
                        }
                        else if (role == 2)
                        {
                            NavigationService.Navigate(new Client(null));
                        }
                        else if (role == 3)
                        {
                            NavigationService.Navigate(new Client(null));
                            MessageBox.Show("Ваша роль:" + job);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким логином не найден");
                        unsuccesful++;
                        txtBlockCaptcha.Text = GetCaptcha(4);
                    }
                }
                else
                {
                    string captcha = txtBlockCaptcha.Text;
                    var user = Helper.GetContext().USERS.Where(u => u.LOGIN == login && u.PASSWORD == password).FirstOrDefault();
                    if (captcha == txtBlockCaptcha.Text)
                    {
                        TextLogin.Text = "Логин";
                        TextPassword.Text = "Пароль";
                        txtBlockCaptcha.Visibility = Visibility.Collapsed;
                        txtboxCaptcha.Visibility = Visibility.Collapsed;
                        txtbLogin.Visibility = Visibility.Visible;
                        pswbPassword.Visibility = Visibility.Visible;
                        txtBlockCaptcha.TextDecorations = null;
                        txtBlockCaptcha.FontStyle = FontStyles.Normal;
                        txtbLogin.Clear();
                        pswbPassword.Clear();
                        txtboxCaptcha.Clear();
                        unsuccesful--;
                        MessageBox.Show("Капча введена верно, попробуйет войти еще раз!");
                    }
                    else
                    {
                        MessageBox.Show("Капча введена неверно");
                        txtboxCaptcha.Text = "";
                        txtBlockCaptcha.Text = GetCaptcha(4);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
        private string GetCaptcha(int length)
        {
            TextLogin.Text = "";
            TextPassword.Text = "Введите зачеркнутый текст";
            txtbLogin.Visibility = Visibility.Collapsed;
            pswbPassword.Visibility = Visibility.Collapsed;
            txtboxCaptcha.Visibility = Visibility.Visible;
            txtBlockCaptcha.Visibility = Visibility.Visible;

            txtBlockCaptcha.TextDecorations = TextDecorations.Strikethrough;

            txtBlockCaptcha.FontStyle = FontStyles.Italic;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnoprstuvwxyz0123456789!@#$%^&*()";
            Random random= new Random();
            return new string(Enumerable.Repeat(chars,length).Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }
    }

