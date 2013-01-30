// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Reference.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B70 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B70 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
public class Reference
{
    // Attributes
    [XmlAttribute("type")]
    public String type;
    [XmlAttribute("title")]
    public String title;
    [XmlAttribute("href")]
    public String href;


    public Reference()
    {

    }

    public Reference(string argType, string argTitle, string argHref)
    {
        type = argType;
        title = argTitle;
        href = argHref;
    }
    // Associations

    /// <summary> 
    /// </summary>
} /* end class Reference */
