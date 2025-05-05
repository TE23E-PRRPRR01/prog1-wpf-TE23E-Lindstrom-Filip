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
using Microsoft.Win32.SafeHandles;

namespace Ceasarkryptering;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickKryptera(object sender, RoutedEventArgs e)
    {

        //Läs av 
        string inputText = txbInput.Text;
        string keyText = txbKey.Text;

        // konvertera keytext till heltal (int)
        int.TryParse(keyText, out int key);

        //rensa txbOutput
        txbOutput.Text = "";

        //Gå igenom det man skrivit
        //loopa för bokstav
        foreach (var bokstav in inputText)
        {
            // hitta ascii värde
            int ascii = (int)bokstav;

            // Kryptera dvs skifta framåt
            int asciikryp = ascii + key;
            char bokstavkryp = (char)asciikryp;

            txbOutput.Text += $"{bokstavkryp}";
        }
    }
}