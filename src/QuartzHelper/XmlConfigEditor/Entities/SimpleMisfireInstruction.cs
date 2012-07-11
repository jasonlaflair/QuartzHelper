using System;

namespace QuartzHelper.XmlConfigEditor.Entities
{
    [Serializable]
    public enum SimpleMisfireInstruction
    {
        SmartPolicy,
        RescheduleNextWithExistingCount,
        RescheduleNextWithRemainingCount,
        RescheduleNowWithExistingRepeatCount,
        RescheduleNowWithRemainingRepeatCount,
        FireNow
    }
}