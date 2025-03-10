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

namespace BränbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{

    int poängInne = 0;
    int poängUte = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickFrivarv(object sender, RoutedEventArgs e)
    {
        //Lägg till 5 poäng 
        poängInne += 5;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        txbHistorik.Text += $"\nlag inne + 5 poäng, totalt {poängInne}";

    }

    private void KlickBränning(object sender, RoutedEventArgs e)
    {
        //Lägg till 5 poäng 
        poängInne += 2;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        DateTime nu = DateTime.Now;

        txbHistorik.Text += $"\nlag inne + 2 poäng, totalt {poängInne}";

    }

    private void KlickLyra(object sender, RoutedEventArgs e)
    {
        //Lägg till 5 poäng 
        poängInne += 3;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        DateTime nu = DateTime.Now;

        txbHistorik.Text += $"\nlag inne + 3 poäng, totalt {poängInne}";





    }

    private void KlickVarv(object sender, RoutedEventArgs e)
    {
        //Lägg till 5 poäng 
        poängInne += 1;

        // Skriv ut poängen
        txbInne.Text = $"{poängInne}";

        txbHistorik.Text += $"\nlag inne + 1 poäng, totalt {poängInne}";

    }

}