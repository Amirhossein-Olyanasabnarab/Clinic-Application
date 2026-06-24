using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.App.DataAccess.Entities
{
    public class Reservation : BaseEntity
    {
        public DateTime ReserveDate { get; set; }
        public bool Reserved { get; set; }
    }
}
