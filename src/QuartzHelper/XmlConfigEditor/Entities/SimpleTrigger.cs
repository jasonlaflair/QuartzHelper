using System;
using System.Xml.Serialization;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public class SimpleTrigger : TriggerTypeBase<SimpleMisfireInstruction>
    {
        [XmlElement("repeat-count")]
        public int RepeatCount { get; set; }

        [XmlElement("repeat-interval")]
        public int RepeatInterval { get; set; }

        [XmlIgnore]
        public override TriggerType TriggerType
        {
            get
            {
                return TriggerType.Simple;
            }
        }
    }
}