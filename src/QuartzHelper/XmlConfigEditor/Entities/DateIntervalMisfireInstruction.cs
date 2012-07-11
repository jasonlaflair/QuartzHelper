using System;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public enum DateIntervalMisfireInstruction
    {
        SmartPolicy,
        DoNothing,
        FireOnceNow
    }
}