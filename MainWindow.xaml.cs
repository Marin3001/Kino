using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Data.SqlClient;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    static class globvar1
    {
        public static string chosen1;
    }

    static class globvar2
    {
        public static string chosen2;
    }

    static class globvar3
    {
        public static string chosen3;
    }

    static class globvar4
    {
        public static string chosen4;
    }
    static class globvar5
    {
        public static string chosen5;
    }
    
    static class globvar6
    {
        public static string chosen6;
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        

        

        private void VrijednostGlobvarStudent(object sender, MouseButtonEventArgs e)
        {
            globvar1.chosen1 = "30";
        }

        private void VrijednostGlobvarOdrasla(object sender, MouseButtonEventArgs e)
        {
            globvar1.chosen1 = "40";
        }

        private void VrijednostGlobvarDijete(object sender, MouseButtonEventArgs e)
        {
            globvar1.chosen1 = "20";
        }

        private void izracunajcijenu(object sender, RoutedEventArgs e)
        {
            textbox1.Text = globvar1.chosen1 + " kn";
        }

        private void film1(object sender,MouseButtonEventArgs e)
        {
            globvar2.chosen2 = "Doctor Strange 2";
        }

        private void film2(object sender,MouseButtonEventArgs e)
        {
            globvar2.chosen2 = "The Batman";
        }

        private void film3(object sender, MouseButtonEventArgs e)
        {
            globvar2.chosen2 = "The Lost City";
        }

        private void red1(object sender,MouseButtonEventArgs e)
        {
            globvar3.chosen3 = "Red 1";
        }

        private void red2(object sender, MouseButtonEventArgs e)
        {
            globvar3.chosen3 = "Red 2";
        }

        private void red3(object sender, MouseButtonEventArgs e)
        {
            globvar3.chosen3 = "Red 3";
        }

        private void kino1(object sender, MouseButtonEventArgs e)
        {
            globvar4.chosen4 = "Kino 1";
        }
        private void kino2(object sender, MouseButtonEventArgs e)
        {
            globvar4.chosen4 = "Kino 2";
        }
        private void kino3(object sender, MouseButtonEventArgs e)
        {
            globvar4.chosen4 = "Kino 3";
        }
        private void vrijednost2D(object sender, MouseButtonEventArgs e)
        {
            globvar5.chosen5 = "2D";
        }
        private void vrijednost3D(object sender, MouseButtonEventArgs e)
        {
            globvar5.chosen5 = "3D";
        }
        private void vrijednost4D(object sender, MouseButtonEventArgs e)
        {
            globvar5.chosen5 = "4D";
        }
        
        private void spremiime(object sender, RoutedEventArgs e)
        {
            globvar6.chosen6 = textbox3.Text;
        }
        private void ispisikartu(object sender, RoutedEventArgs e)
        {
            textbox2.Text = "KINO: " + globvar4.chosen4 + "\n"
                + "FILM: " + globvar2.chosen2 + "\n" +
                "TIP PROJEKCIJE: " + globvar5.chosen5 + "\n" +
                "RED: " + globvar3.chosen3 + "\n" +
                "IME: " + globvar6.chosen6 + "\n" +
                "CIJENA: " + globvar1.chosen1 + " KN";
        }
        //private void textbox1_TextChanged(object sender, EventArgs e)
        //{
        //string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database = CSData; Integrated Security = True;Trusted_Connection = True;MulipleActiveResultSets = True";
        //SqlConnection connection = new SqlConnection(ConnectionString);

        //connection.Open();
        //SqlCommand command;
        //SqlDataReader sqlDataReader;

        //command = new SqlCommand();
        //command.Connection = connection;
        //string text = "select ";
        //}
    }
}
