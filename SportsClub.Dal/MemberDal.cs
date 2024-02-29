using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Dal
{
    public class MemberDal
    {
        // CREATE

        // READ ALL
        public List<Member> Read()
        {
            // verbinding met databank maken
            using (var db = new SportsClubDbContext())
            {
                // lijst van members uit db halen
                List<Member> lstMembers = db.Members.ToList();
                return lstMembers;
            }
        }

        // READ SINGLE

        // UPDATE

        // DELETE
    }
}
