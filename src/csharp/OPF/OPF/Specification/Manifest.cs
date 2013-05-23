// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Manifest.cs

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

// In this section you can add your own using directives
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A7A begin
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A7A end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
public class Manifest
{

    public Manifest()
    {
        myItems = new List<Item>();
    }
    // Associations

    /// <summary> 
    /// </summary>
    /*
     @element-type Item
     */
    [XmlElement("item")]
    public List<Item> myItems
    {
        get;
        set;
    }


    public void AddItem(Item arg)
    {
        myItems.Add(arg);
    }


} /* end class Manifest */
