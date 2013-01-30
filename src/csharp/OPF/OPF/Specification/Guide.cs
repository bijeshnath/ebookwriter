// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Guide.cs

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

// In this section you can add your own using directives
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A82 begin
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A82 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
[XmlRoot(ElementName = "guide"), Serializable]
public class Guide
{
    // Associations

    /// <summary> 
    /// </summary>
    /*
     @element-type Reference
     */
    [XmlElement("reference")]
    public List<Reference>  myReferences;

    public Guide()
    {
        myReferences = new List<Reference>();
    }

    public void AddReference(Reference arg)
    {
        myReferences.Add(arg);
    }
} /* end class Guide */
