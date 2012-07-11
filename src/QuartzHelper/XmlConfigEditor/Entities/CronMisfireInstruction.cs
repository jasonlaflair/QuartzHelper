using System;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public enum CronMisfireInstruction
    {
        SmartPolicy,
        DoNothing,
        FireOnceNow
    }
}