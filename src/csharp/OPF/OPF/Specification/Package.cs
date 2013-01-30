// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Package.cs

// In this section you can add your own using directives
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A71 begin
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A71 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;

[XmlRoot(ElementName="package", Namespace="http://www.idpf.org/2007/opf"), Serializable]
public class Package
{
    // Attributes
    [XmlAttribute("unique-identifier")]
    public String unique_identifier;

    [XmlAttribute("version")]
    public String version;

    // Associations

    /// <summary> 
    /// </summary>

    /// <summary> 
    /// </summary>
    [XmlElement("metadata")]
    public Metadata myMetadata;

    /// <summary> 
    /// </summary>
    [XmlElement("manifest")]
    public Manifest myManifest;

    /// <summary> 
    [XmlElement("spine")]
    public Spine mySpine;

    /// <summary> 
    /// </summary>
    [XmlElement("guide")]
    public Guide myGuide;
} /* end class Package */
