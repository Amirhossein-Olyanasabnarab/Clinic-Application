using Clinic.App.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.App.DataAccess.Entities
{
    public class Patient : BaseEntity
    {
        public string Fullname { get; set; }
        public string Mobile { get; set; }
        public string? Description { get; set; }
        public int Age { get; set; }
        public Gender  Gender { get; set; }
    }
}
