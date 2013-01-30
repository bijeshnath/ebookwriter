// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Meta.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000AE3 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000AE3 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
public class Meta
{
    // Attributes
    [XmlAttribute(AttributeName = "content")]
    public String content;
    [XmlAttribute(AttributeName = "name")]
    public String name;


    public Meta()
    {

    }

    public Meta(string argContent, string argName)
    {
        content = argContent;
        name = argName;
    }


    // Associations

    /// <summary> 
    /// </summary>
} /* end class Meta */
