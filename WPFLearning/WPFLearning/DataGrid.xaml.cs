using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFLearning
{
    /// <summary>
    /// Interaction logic for DataGrid.xaml
    /// </summary>
    public partial class DataGrid : Window
    {
        public DataGrid()
        {
            InitializeComponent();

            

            DataView.ItemsSource = new[] { 
                new Osoba { Imie = "osoba1", Nazwisko = "osoba1", Podwladni = new[] { 
                    new Osoba { Imie = "podwladny1", Nazwisko = "podwladny1"},
                    new Osoba { Imie = "podwladny2", Nazwisko = "podwladny2"},
                } },
                new Osoba { Imie = "osoba2", Nazwisko = "osoba2"},
                new Osoba { Imie = "osoba3", Nazwisko = "osoba3" },
            };
        }
    }

    public class Osoba
    {
        public string Imie {get;set;}
        public string Nazwisko { get; set; }
        public IEnumerable<Osoba> Podwladni { get; set; }
    }

    

}
