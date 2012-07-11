using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    [XmlRoot("job-scheduling-data", Namespace = "http://quartznet.sourceforge.net/JobSchedulingData")]
    public class JobSchedulingData
    {
        [XmlAttribute("version")]
        public string Version { get; set; }

        [XmlElement("pre-processing-commands")]
        public PreProcessingCommands PreProcessing { get; set; }

        [XmlElement("processing-directives")]
        public ProcessingDirectives Directives { get; set; }

        [XmlElement("schedule")]
        public Schedule Schedule { get; set; }
    }
}