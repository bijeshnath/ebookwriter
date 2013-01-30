// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//PageList.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B1E begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B1E end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System.Collections.Generic;
using System.Xml.Serialization;
public class PageList
{

    public PageList()
    {
        myPageTargets = new List<PageTarget>();
    }
    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
    [XmlElement("pageTarget")]
    public List<PageTarget>  myPageTargets;

    public void AddPageTarget(PageTarget argPageTarget)
    {
        myPageTargets.Add(argPageTarget);
    }
} /* end class PageList */
