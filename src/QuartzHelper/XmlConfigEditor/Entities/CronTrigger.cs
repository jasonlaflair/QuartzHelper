using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class CronTrigger : TriggerTypeBase<CronMisfireInstruction>
    {
        [XmlElement("cron-expression")]
        public string CronExpression { get; set; }
        
        [XmlElement("time-zone")]
        public string TimeZone { get; set; }

        [XmlIgnore]
        public override TriggerType TriggerType
        {
            get
            {
                return TriggerType.Cron;
            }
        }
    }
}
