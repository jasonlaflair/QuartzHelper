using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class ProcessingDirectives
    {
        [XmlElement(ElementName = "overwrite-existing-data")]
        public bool OverwriteExistingData { get; set; }
        [XmlElement(ElementName = "ignore-duplicates")]
        public bool IgnoreDuplicates { get; set; }
    }
}