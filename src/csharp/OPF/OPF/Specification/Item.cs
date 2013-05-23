// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Item.cs

// In this section you can add your own using directives
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000AC3 begin
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000AC3 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
[XmlRoot(ElementName = "item"), Serializable]
public class Item
{
    public Item(String idArg, String hrefArg, String media_typeArg, String fallBackArg)
    {
        id = idArg;
        href = hrefArg;
        media_type = media_typeArg;
        fallBack = fallBackArg;
    }
    public Item()
    {
    }

    public override string ToString()
    {
        return id + href + media_type + fallBack;
    }
    // Attributes
    [XmlAttribute(AttributeName = "id")]
    public String id;
    [XmlAttribute(AttributeName = "href")]
    public String href
    {
        get;
        set;
    }
    [XmlAttribute(AttributeName = "media_type")]
    public String media_type;
    [XmlAttribute(AttributeName = "fallBack")]
    public String fallBack;

    // Associations

    /// <summary> 
    /// </summary>
} /* end class Item */
