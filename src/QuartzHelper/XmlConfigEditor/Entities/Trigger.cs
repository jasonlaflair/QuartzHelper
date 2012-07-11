using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class Trigger
    {
        [XmlElement("simple", typeof(SimpleTrigger))]
        [XmlElement("cron", typeof(CronTrigger))]
        [XmlElement("calendar-trigger", typeof(CalendarTrigger))]
        public object TriggerType { get; set; }
    }
}