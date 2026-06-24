using Clinic.App.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.App.DataAccess.Entities
{
    public class ReserveRecord : BaseEntity
    {
        public int PatientId { get; set; }
        public int ReservationId { get; set; }
        public string? Description { get; set; }

        [ForeignKey(name: "ReservationId")]
        public Reservation Reservation { get; set; }

        [ForeignKey(name: "PatientId")]
        public Patient Patient { get; set; }

        public ReservationState ReservationState { get; set; }
        public int PaidPrice { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
