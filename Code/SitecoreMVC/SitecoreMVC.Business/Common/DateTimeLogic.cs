using System;

namespace SitecoreMVC.Business.Common
{
    public class DateTimeLogic : IDateTimeLogic
    {
        public DateTime UtcNow { get { return DateTime.UtcNow; } }
    }
}
