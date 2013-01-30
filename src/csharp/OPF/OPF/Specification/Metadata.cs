// FILE: C:/Users/user/Documents/ArgoModels/TestGeneration//Metadata.cs

// In this section you can add your own using directives
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A76 begin
    // section -64--88-0-2--2ab567b6:13c5eede592:-8000:0000000000000A76 end

/// <summary>
    ///  -
    /// 
    ///  @see OtherClasses
    ///  @author Bijeshnath R
     /// </summary>
using System;
using System.Xml.Serialization;
// Namespace="dc:http://purl.org/dc/elements/1.1/"
[XmlRoot(ElementName = "metadata",  Namespace = "http://www.idpf.org/2007/opf"),  Serializable]
public class Metadata
{



    // Attributes
    [XmlElement(ElementName = "title", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String title;

    [XmlElement(ElementName = "creator", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String creator;

    [XmlElement(ElementName = "language", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String language;
    [XmlElement(ElementName = "subject", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String subject;
    [XmlElement(ElementName = "description", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String description;
    [XmlElement(ElementName = "publisher", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String publisher;
    [XmlElement(ElementName = "contributor", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String contributor;
    [XmlElement(ElementName = "date", Namespace = "http://purl.org/dc/elements/1.1/")]
    public DateTime date;
    [XmlElement(ElementName = "type", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String type;
    [XmlElement(ElementName = "format", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String format;
    [XmlElement(ElementName = "identifier", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String identifier;
    [XmlElement(ElementName = "source", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String source;
    [XmlElement(ElementName = "relation", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String relation;
    [XmlElement(ElementName = "coverage", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String coverage;
    [XmlElement(ElementName = "rights", Namespace = "http://purl.org/dc/elements/1.1/")]
    public String rights;
    // Associations

    /// <summary> 
    /// </summary>
} /* end class Metadata */
