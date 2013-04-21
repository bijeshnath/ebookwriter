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
            string path = @"C:\Users\Home\Documents\Reader\";
            List<RemoveNode> removeNodes = new List<RemoveNode>();
            RemoveNode rn = new RemoveNode("script", null, null);
            removeNodes.Add(rn);
            rn = new RemoveNode("div", "class", "portal");
            removeNodes.Add(rn);
            Downloader dn = new Downloader(path, @"http://en.wikipedia.org/", removeNodes, "1.html");
            dn.Download();
            string str = "\"" + path + dn.FileName + "\"";
            ProcessStartInfo psi = new ProcessStartInfo(kindleGenExe, str);
           // psi.RedirectStandardOutput = true;
           // psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
            p.WaitForExit();
         //   string strOut = p.StandardOutput.ReadToEnd();
          //  string strErr = p.StandardError.ReadToEnd();


        }
    }
}
