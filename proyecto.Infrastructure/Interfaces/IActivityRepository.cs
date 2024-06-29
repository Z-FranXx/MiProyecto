using Foundation.Domain.Entities;
using System.Collections.Generic;
using System.Diagnostics;

namespace Foundation.Infrastructure.Interfaces
{
    public interface IActivityRepository
    {
        Activity GetActivityById(int activityId);
        IEnumerable<Activity> GetAllActivities();
        void AddActivity(Activity activity);
        void UpdateActivity(Activity activity);
        void DeleteActivity(int activityId);
    }
}
