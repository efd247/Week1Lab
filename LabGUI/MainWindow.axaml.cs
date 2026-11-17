using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace LabGUI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ColourCheckBox_Click(object? sender, RoutedEventArgs e)
{
    if (ColourCheckBox.IsChecked == true)
    {
        messageTextBox.Foreground = Brushes.Red;
    }
    else
    {
        messageTextBox.Foreground = Brushes.Black;
    }
}
}