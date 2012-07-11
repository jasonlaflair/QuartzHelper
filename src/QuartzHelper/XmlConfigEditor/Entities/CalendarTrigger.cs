using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class CalendarTrigger : TriggerTypeBase<DateIntervalMisfireInstruction>
    {
        [XmlElement("repeat-interval")]
        public int RepeatInterval { get; set; }

        [XmlElement("repeat-interval-unit")]
        public RepeatIntervalUnit RepeatIntervalUnit { get; set; }

        [XmlIgnore]
        public override TriggerType TriggerType
        {
            get
            {
                return TriggerType.Calendar;
            }
        }
    }
}