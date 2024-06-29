using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Domain.Entities;
using Foundation.Infrastructure.Context;
using Foundation.Infrastructure.Context;
using Foundation.Infrastructure.Interfaces;

namespace Foundation.Infrastructure.Repositories
{
    public class VolunteerRepository : IVolunteerRepository
    {
        private readonly FoundationContext _context;

        public VolunteerRepository(FoundationContext context)
        {
            _context = context;
        }

        public Volunteer GetVolunteerById(int volunteerId)
        {
            return _context.Volunteers.Find(volunteerId);
        }

        public IEnumerable<Volunteer> GetAllVolunteers()
        {
            return _context.Volunteers.ToList();
        }

        public void AddVolunteer(Volunteer volunteer)
        {
            _context.Volunteers.Add(volunteer);
            _context.SaveChanges();
        }

        public void UpdateVolunteer(Volunteer volunteer)
        {
            _context.Volunteers.Update(volunteer);
            _context.SaveChanges();
        }

        public void DeleteVolunteer(int volunteerId)
        {
            var volunteer = _context.Volunteers.Find(volunteerId);
            if (volunteer != null)
            {
                _context.Volunteers.Remove(volunteer);
                _context.SaveChanges();
            }
        }
    }
}
