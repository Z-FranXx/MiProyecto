using Foundation.Domain.Entities;
using Foundation.Infrastructure.Context;
using Foundation.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Foundation.Infrastructure.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly FoundationContext _context;

        public ActivityRepository(FoundationContext context)
        {
            _context = context;
        }

        public Activity GetActivityById(int activityId)
        {
            return _context.Activities.Find(activityId);
        }

        public IEnumerable<Activity> GetAllActivities()
        {
            return _context.Activities.ToList();
        }

        public void AddActivity(Activity activity)
        {
            _context.Activities.Add(activity);
            _context.SaveChanges();
        }

        public void UpdateActivity(Activity activity)
        {
            _context.Activities.Update(activity);
            _context.SaveChanges();
        }

        public void DeleteActivity(int activityId)
        {
            var activity = _context.Activities.Find(activityId);
            if (activity != null)
            {
                _context.Activities.Remove(activity);
                _context.SaveChanges();
            }
        }
    }
}
