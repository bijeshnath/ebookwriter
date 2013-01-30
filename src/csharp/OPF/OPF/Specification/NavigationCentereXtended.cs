// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//NavigationCentereXtended.cs

using System.Collections;
using System.Xml.Serialization;
using System;

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000ADE begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000ADE end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
[XmlRoot(ElementName = "ncx", Namespace = "http://www.daisy.org/z3986/2005/ncx/"), Serializable]
public class NavigationCentereXtended
{

    public NavigationCentereXtended()
    {

        myNavMap = new NavMap();
        myPageList = new PageList();
        myNavList = new NavList();
    }

    
    // Associations

    /// <summary> 
    /// </summary>
    [XmlElement("head")]
    public NcxHead  myNcxHead;

    /// <summary> 
    /// </summary>
    [XmlElement("docTitle")]
    public DocTitle  myDocTitle;

    /// <summary> 
    /// </summary>
    [XmlElement("docAuthor")]
    public DocAuthor  myDocAuthor;

    /// <summary> 
    /// </summary>
    [XmlElement("navMap")]
    public NavMap  myNavMap;

    /// <summary> 
    /// </summary>
    [XmlElement("pageList")]
    public PageList  myPageList;
    /*
     @element-type NavList
     */
    [XmlElement("navList")]
    public NavList  myNavList;


    public void AddNavPoint(NavPoint argNavPoint)
    {
        myNavMap.myNavPoints.Add(argNavPoint);
    }

    public void AddPageTarget(PageTarget argPageTarget)
    {
        myPageList.myPageTargets.Add(argPageTarget);
    }


} /* end class NavigationCentereXtended */
