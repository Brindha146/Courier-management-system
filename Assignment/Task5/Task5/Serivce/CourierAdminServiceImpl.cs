using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Serivce
{
    internal class CourierAdminServiceImpl : CourierUserServiceImpl, iCourierAdminService
    {
        public CourierAdminServiceImpl(CourierCompany company) : base(company)
        {

        }

        public int AddCourierStaff(string name, string contactNumber)
        {
            throw new NotImplementedException();
        }
    }
}
