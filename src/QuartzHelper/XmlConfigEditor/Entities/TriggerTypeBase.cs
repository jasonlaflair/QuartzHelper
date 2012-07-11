using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    public enum TriggerType
    {
        Cron,
        Simple,
        Calendar
    }

    [Serializable]
    public abstract class TriggerTypeBase<T> where T : struct
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("group")]
        public string Group { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("job-name")]
        public string JobName { get; set; }

        [XmlElement("job-group")]
        public string JobGroup { get; set; }

        [XmlElement("calendar-name")]
        public string CalendarName { get; set; }

        [XmlElement("job-data-map")]
        public JobDataMap JobDataMap { get; set; }

        [XmlIgnore]
        public DateTime? StartTime { get; set; }

        [XmlElement("start-time")]
        public string ProxyStartTime
        {
            get
            {
                return StartTime.HasValue
                           ? StartTime.Value.ToString("yyyy-MM-ddTHH:mm:ss")
                           : null;
            }
            set
            {
                StartTime = string.IsNullOrEmpty(value)
                                ? (DateTime?) null
                                : DateTime.Parse(value);
            }
        }

        [XmlElement("start-time-seconds-in-future")]
        public int? StartTimeSecondsInFuture { get; set; }

        public bool ShouldSerializeStartTimeSecondsInFuture()
        {
            return StartTimeSecondsInFuture.HasValue;
        }

        [XmlIgnore]
        public DateTime? EndTime { get; set; }

        [XmlElement("end-time")]
        public string ProxyEndTime
        {
            get
            {
                return EndTime.HasValue
                           ? EndTime.Value.ToString("yyyy-MM-ddTHH:mm:ss")
                           : null;
            }
            set
            {
                EndTime = string.IsNullOrEmpty(value)
                                ? (DateTime?)null
                                : DateTime.Parse(value);
            }
        }

        [XmlElement("misfire-instruction")]
        public T MisfireInstruction { get; set; }

        [XmlIgnore]
        public abstract TriggerType TriggerType { get; }
    }
}