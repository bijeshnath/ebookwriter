using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using HtmlSanity;
using System.IO;
using HtmlUtils;

namespace WebToEbook
{
    public class Downloader
    {
        string path;
        string link;
        public IEnumerable<RemoveNode> RemoveNodes;
        public Downloader(string argPath, string argLink, IEnumerable<RemoveNode> removeNodes, string fileName )
        {
            path = argPath;
            link = argLink;
            RemoveNodes = removeNodes;
            FileName = fileName;
        }
        public String FileName;
        public void Download()
        {
            HtmlSanitiser sanity = new HtmlSanity.HtmlSanitiser(link);

            sanity.RemoveNodes(RemoveNodes.ToArray());


            string pathFile = path + FileName;


            DownloadImages dn = new DownloadImages(link, path + @"images\");
            dn.Download(sanity.Html);
                        StreamWriter sw = System.IO.File.CreateText(pathFile);
            dn.Document.Save(sw);
            sw.Flush();
            sw.Close();
        }
        
    }
}
