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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLearning
{
    /// <summary>
    /// Interaction logic for DependencyProperyExample.xaml
    /// </summary>
    public partial class DependencyProperyExample : UserControl
    {
        static DependencyProperyExample()
        { 
            DependencyProperyExample.TextProperty = DependencyProperty.Register("Text", 
                typeof(string), 
                typeof(DependencyProperyExample), 
                new FrameworkPropertyMetadata("Brak", FrameworkPropertyMetadataOptions.AffectsRender));
        }

        public DependencyProperyExample()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TextProperty;

        public string Text
        {
            get { return (string)GetValue(DependencyProperyExample.TextProperty); }
            set { SetValue(DependencyProperyExample.TextProperty, value); }
        }
 
    }
}
