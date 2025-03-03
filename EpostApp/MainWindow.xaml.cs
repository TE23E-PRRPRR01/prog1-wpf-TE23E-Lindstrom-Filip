using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.


using System.Net.Mail;
using System.Net;

namespace EpostApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickaSkicka(object sender, RoutedEventArgs e)
    {
        //Läs av epost och meddelanden
        string epost = tbxEpost.Text;
        string meddelande = tbxMeddelande.Text;

        // koppla upp på en mail-server
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.EnableSsl = true;
        smtp.Credentials = new NetworkCredential("User", "pass");


       if (epost != "" && meddelande != "")
        {
            smtp.Send("Karim@gmail.com","epost","epost från appen","meddelande",);
            lblStatus.Content = "OK ";
        }
        else
        {
            lblStatus.Content = " Du måste ange Epost adress och meddelande (Uhuh)";
        }
    }

}