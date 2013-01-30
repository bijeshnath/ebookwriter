// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//NavList.cs

// In this section you can add your own using directives
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B49 begin
    // section -64--88-0-3-23d52fc7:13c6411c439:-8000:0000000000000B49 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System.Collections.Generic;
public class NavList
{

    public NavList()
    {
        myNavTargets = new List<NavTarget>();
    }
    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
    public NavLabel myNavLabel;

    /// <summary> 
    /// </summary>
    public List<NavTarget>  myNavTargets;

    public void AddNavTarget(NavTarget argNavTarget)
    {
        myNavTargets.Add(argNavTarget);
    }
} /* end class NavList */
