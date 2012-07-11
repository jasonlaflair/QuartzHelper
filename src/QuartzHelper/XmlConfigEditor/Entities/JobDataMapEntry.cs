using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class JobDataMapEntry
    {
        [XmlElement("key")]
        public string Key { get; set; }
        [XmlElement("value")]
        public string Value { get; set; }
    }
}