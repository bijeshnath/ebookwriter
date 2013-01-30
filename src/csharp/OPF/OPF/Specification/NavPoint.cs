// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//NavPoint.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B01 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B01 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
public class NavPoint
{

    public NavPoint()
    {
    }

    public NavPoint(int argPlayOrder, String argId, String argNavPointClass, NavLabel argLabel, Content argContent)
    {
        playOrder = argPlayOrder;
        id = argId;
        navPointclass = argNavPointClass;
        myNavLabel = argLabel;
        myContent = argContent;
    }

    // Attributes
    [XmlAttribute(AttributeName = "playOrder")]
    public int playOrder;
    [XmlAttribute(AttributeName = "id")]
    public String id;
    [XmlAttribute(AttributeName = "class")]
    public String navPointclass;

    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
    [XmlElement("navLabel")]
    public NavLabel  myNavLabel;

    /// <summary> 
    /// </summary>
    [XmlElement("content")]
    public Content  myContent;
} /* end class NavPoint */
