// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//ItemRef .cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000AD2 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000AD2 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
public class ItemRef 
{
    public ItemRef()
    {
    }
    public ItemRef(String idrefArg, String linearArg)
    {
        idref = idrefArg;
        linear = linearArg;
    }

    // Attributes
    [XmlAttribute(AttributeName = "idref")]
    public String idref;
    [XmlAttribute(AttributeName = "linear")]
    public String linear;

    // Associations

    /// <summary> 
    /// </summary>
} /* end class ItemRef  */
