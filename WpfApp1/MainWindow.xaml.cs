using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Demo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public string username;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void UsernameGotFocus(object sender, RoutedEventArgs e)
    {
        EnterUsername.Text = string.Empty;

        if (EnterPassword.Text != string.Empty && EnterPassword.Text != "Enter your password")
        {
            LoginButton.IsEnabled = true;
        }
    }

    private void PasswordGotFocus(object sender, RoutedEventArgs e)
    {
        EnterPassword.Text = string.Empty;

        if (EnterUsername.Text != string.Empty && EnterUsername.Text != "Enter your password")
        {
            LoginButton.IsEnabled = true;
        }
    }

    private void CreateAccount(object sender, RoutedEventArgs e)
    {
        if (EnterUsername.Text != string.Empty && EnterUsername.Text != "Enter your password" && EnterPassword.Text != string.Empty && EnterPassword.Text != "Enter your password")
        {
            User user = new User();

            user.username = EnterUsername.Text;
            user.password = EnterPassword.Text;

            /*
             MainGrid.Children.Remove(EnterUsername);
            MainGrid.Children.Remove(EnterPassword);
            MainGrid.Children.Remove(LoginButton);
            */

            MessageBox.Show($"Your username is {user.username} and your password is {user.password}");
        }
    }
}