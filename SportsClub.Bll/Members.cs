using SportsClub.Dal;
using SportsClub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsClub.Bll
{
    public class Members
    {
        // CREATE

        // READ ALL
        public List<Member> Read()
        {
            List<Member> lstMembers = new MemberDal().Read();
            return lstMembers;
        }

        // READ SINGLE

        // UPDATE

        // DELETE
    }
}
