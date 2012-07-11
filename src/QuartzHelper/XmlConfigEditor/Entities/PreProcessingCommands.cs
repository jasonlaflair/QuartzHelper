using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class PreProcessingCommands
    {
        [XmlElement("delete-job")]
        public List<NameGroupData> DeleteJobs { get; set; }

        [XmlElement("delete-jobs-in-group")]
        public List<string> DeleteJobsInGroup { get; set; }

        [XmlElement("delete-trigger")]
        public List<NameGroupData> DeleteTriggers { get; set; }

        [XmlElement("delete-triggers-in-group")]
        public List<string> DeleteTriggersInGroup { get; set; }
    }
}