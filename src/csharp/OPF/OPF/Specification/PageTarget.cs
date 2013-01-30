// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//PageTarget.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B22 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B22 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
public class PageTarget
{

    public PageTarget()
    {
    }

    public PageTarget(String argId, String argType, String argValue, NavLabel argNavLabel, Content argContent)
    {
        id = argId;
        type = argType;
        value = argValue;
        myNavLabel = argNavLabel;
        myContent = argContent;
    }

    // Attributes
    [XmlAttribute(AttributeName = "id")]
    public String id;
    [XmlAttribute(AttributeName = "type")]
    public String type;
    [XmlAttribute(AttributeName = "value")]
    public String value;

    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
    [XmlElement("navLabel")]
    public NavLabel myNavLabel;

    /// <summary> 
    /// </summary>
    [XmlElement("content")]
    public Content myContent;
} /* end class PageTarget */
