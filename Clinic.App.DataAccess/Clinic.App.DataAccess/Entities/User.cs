using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.App.DataAccess.Entities
{
    public class User : BaseEntity
    {
        public string Fullname { get; set; }
        public string Mobile { get; set; }
    }
}
