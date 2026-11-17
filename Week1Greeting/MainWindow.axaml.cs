using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Week1Greeting;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnHello_Click(object? sender, RoutedEventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            lblMessage.Content = "Please enter your name";
        }
        else
        {
            lblMessage.Content = "Hello " + txtName.Text.ToUpper();
        }
    }

    private void btnClear_Click(object? sender, RoutedEventArgs e)
    {
        txtName.Text = "";
        lblMessage.Content = "";
    }
}