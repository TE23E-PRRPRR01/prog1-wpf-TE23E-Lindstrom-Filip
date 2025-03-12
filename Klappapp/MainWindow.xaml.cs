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

namespace Klappapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    // Våra variabler
    int maxJulklappar = 0;
    List<string> ListaJulklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        // Koppla List till ListBox
        lsbJulklappar.ItemsSource = ListaJulklappar;

        // lås gränssnitt
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;

    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        //Läs av rutan
        string antal = txbAntal.Text;

        //Första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "VG ange ett heltal";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";

                //Lås gränssnitt
                stpMax.IsEnabled = false;
                stpInmatning.IsEnabled = true;
                stpListan.IsEnabled = true;

            }
            else
            {
                txbStatus.Text = "VG ange ett tal";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        // Läs av textrutorna 
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text;

        ListaJulklappar.Add($"{julklapp} till {mottagare}");
        lsbJulklappar.Items.Refresh();
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {

    }

}
