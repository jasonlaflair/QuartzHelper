using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class Schedule
    {
        [XmlElement("job")]
        public List<Job> Jobs { get; set; }

        [XmlElement("trigger")]
        public List<Trigger> Triggers { get; set; }
    }
}