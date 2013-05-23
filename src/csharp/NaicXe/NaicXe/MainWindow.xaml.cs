using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;

namespace NaicXe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Package ThePackage
        {
            get
            {
                return (Package)GetValue(MainWindow.PackageProperty);
            }
            set
            {
                SetValue(MainWindow.PackageProperty, value);
            }
        }
        public static DependencyProperty PackageProperty;
        
        static MainWindow()
        {
            MainWindow.PackageProperty = DependencyProperty.Register("ThePackage", typeof(Package), typeof(MainWindow), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnPackageChanged)));
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
            
        }
        // Show Pane 1 when hovering over its button
        public void pane1Button_MouseEnter(object sender, RoutedEventArgs e)
        {

        }

        private static void OnPackageChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            MainWindow wnd = (MainWindow)o;
        }


        // Show Pane 2 when hovering over its button
        public void pane2Button_MouseEnter(object sender, RoutedEventArgs e)
        {

        }

        private void pane1Button_MouseEnter(object sender, MouseEventArgs e)
        {

        }






        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            if (openDialog.ShowDialog().Value)
            {
                  //
                 
                StreamReader sr = new StreamReader(openDialog.FileName);
                XmlSerializer ser = new XmlSerializer(typeof(Package));
                ThePackage = (Package)ser.Deserialize(sr);
                sr.Close();
                //txtTitle.Text = ThePackage.myMetadata.title;
            }
        }

        private string theTitle;
        public string TheTitle
        {
            get
            {
                return theTitle;
            }
            set
            {
                theTitle = value;
                
            }

        }
        private void OpenCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }



        private void SaveAsCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void SaveAsCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
