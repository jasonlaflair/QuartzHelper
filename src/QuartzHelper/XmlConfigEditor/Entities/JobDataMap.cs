using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class JobDataMap
    {
        [XmlElement("entry")]
        public List<JobDataMapEntry> Entries { get; set; }
    }
}