// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//NavMap.cs

using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000AFD begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000AFD end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
public class NavMap
{
    public NavMap()
    {
        myNavPoints = new List<NavPoint>();
    }

    // Associations

    /// <summary> 
    /// </summary>
    /*
     @element-type NavPoint
     */
    [XmlElement("navPoint")]
    public List<NavPoint>  myNavPoints;

    public void AddNavPoint(NavPoint argNavPoint)
    {
        myNavPoints.Add(argNavPoint);
    }
} /* end class NavMap */
