using HtmlSanity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using WebToEbook;

namespace Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private const string kindleGenExe = @"C:\Users\Home\Documents\Reader\kindlegen\kindlegen.exe";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string path = txtOutputDir.Text;
            List<RemoveNode> removeNodes = new List<RemoveNode>();
            RemoveNode rn = new RemoveNode("script", null, null);
            removeNodes.Add(rn);
            rn = new RemoveNode("div", "class", "portal");
            removeNodes.Add(rn);
            Downloader dn = new Downloader(path,txtUrl.Text, removeNodes, txtOutputFile.Text + ".html");
            dn.Download();
            string str = "\"" + path + dn.FileName + "\"";
            ProcessStartInfo psi = new ProcessStartInfo(kindleGenExe, str);

            psi.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();



        }
    }
}
