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
using System.IO;
using System.Xml.Serialization;

namespace Tester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// Author: Bijeshnath R
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Package p = new Package();
            p.unique_identifier = "boo";
            p.version = "1";
            Manifest manifest = new Manifest();
            manifest.AddItem(new Item("id1",".\\test.html","application/xhtml+xml", null));
            manifest.AddItem(new Item("id2", ".\\test.html", "application/xhtml+xml", null));
            manifest.AddItem(new Item("toc", txtNcxFile.Text, "application/x-dtbncx+xml", null));
            p.myManifest = manifest;

            Metadata metadata = new Metadata();
            p.myMetadata = metadata;
            metadata.title = "My title";

            Spine s = new Spine("ncx");
            s.AddItemRef(new ItemRef("id11","yes"));
            s.AddItemRef(new ItemRef("id12","yes"));
            p.mySpine = s;

            Guide g = new Guide();
            g.AddReference(new Reference("toc", "title",txtNcxFile.Text));
            g.AddReference(new Reference("toc1", "title2", ".//ref.html"));

            p.myGuide = g;

            TextWriter tw = serialise(p);
            txtPackage.Text = tw.ToString();
            
            tw.Close();


            NavigationCentereXtended ncx = new NavigationCentereXtended();
            ncx.myDocAuthor = new DocAuthor("John h author");
            ncx.myDocTitle = new DocTitle("My Book..");
            
            ncx.myNavList.AddNavTarget(new NavTarget(new NavLabel("Nav Label 1"), new Content("content.html")));
            ncx.myNavList.AddNavTarget(new NavTarget(new NavLabel("Nav Label 2"), new Content("content2.html")));
            ncx.myNavMap.AddNavPoint(new NavPoint(1, "id1", "point class", new NavLabel("Nav Label 1"), new Content("srctext")));
            ncx.myNavMap.AddNavPoint(new NavPoint(1, "id1", "point class2 ", new NavLabel("Nav Label 2"), new Content("srctext")));

            ncx.myNcxHead = new NcxHead();
            ncx.myNcxHead.myMeta = new Meta("content", "name");

            ncx.myPageList.AddPageTarget(new PageTarget("id1", "type", "value", new NavLabel("txtLabel"), new Content("src1")));
            ncx.myPageList.AddPageTarget(new PageTarget("id2", "type", "value", new NavLabel("txtLabel2"), new Content("src2")));

            TextWriter tw2 = serialise(ncx);
            txtNcx.Text = tw2.ToString();
            tw2.Close();
            
        }

        private TextWriter serialise(object p)
        {
            TextWriter w = new StringWriter();
            XmlSerializer s = new XmlSerializer(p.GetType());
            s.Serialize(w, p);
            w.Flush();
            return w;
        }
    }
}
