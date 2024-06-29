using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Domain.Entities;

namespace Foundation.Infrastructure.Interfaces
{
    internal interface IVolunteerRepository
    {
        Volunteer GetVolunteerById(int volunteerId);
        IEnumerable<Volunteer> GetAllVolunteers();
        void AddVolunteer(Volunteer volunteer);
        void UpdateVolunteer(Volunteer volunteer);
        void DeleteVolunteer(int volunteerId);
    }
}
