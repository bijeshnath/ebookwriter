// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Spine.cs

// In this section you can add your own using directives
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A7E begin
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A7E end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

public class Spine
{
    public Spine()
    {
        myItemRefs = new List<ItemRef>();
    }

    public Spine(String tocArg)
    {
        myItemRefs = new List<ItemRef>();
        toc = tocArg;
    }

    public void AddItemRef(ItemRef itemRef)
    {
        myItemRefs.Add(itemRef);
    }

    // Attributes
    [XmlAttribute(AttributeName = "toc")]
    public String toc;

    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
    [XmlElement("itemref")]
    public List<ItemRef>  myItemRefs ;
} /* end class Spine */
