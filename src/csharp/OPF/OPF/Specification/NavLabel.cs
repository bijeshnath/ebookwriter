// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//NavLabel.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B07 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B07 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
public class NavLabel
{
    public NavLabel()
    {

    }

    public NavLabel(String argText)
    {
        text = argText;
    }


    // Attributes
    [XmlAttribute(AttributeName = "text")]
    public String text;

    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
} /* end class NavLabel */
