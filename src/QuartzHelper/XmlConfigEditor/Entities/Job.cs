using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class Job
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("group")]
        public string Group { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("job-type")]
        public string JobType { get; set; }

        [XmlElement("durable")]
        public bool? Durable { get; set; }

        public bool ShouldSerializeDurable()
        {
            return Durable.HasValue;
        }

        [XmlElement("recover")]
        public bool? Recover { get; set; }

        public bool ShouldSerializeRecover()
        {
            return Recover.HasValue;
        }

        [XmlElement("job-data-map")]
        public JobDataMap JobDataMap { get; set; }
    }
}