using System.Configuration;
using System.Data;
using System.Windows;

namespace EventApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class MainWindow : Application
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaOk(Object sender, RoutedEventArgs e)
    {
        //LÄs av textrutan
        string text = tbxText.Text;
        MessageBox.Show("Du klickade Ok");
    }

    private void KlickaAvbryt(Object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Du klickade Avbryt");
    }


}

