using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class NameGroupData
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("group")]
        public string Group { get; set; }
    }
}