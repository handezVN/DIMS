﻿using System;
using System.Collections.Generic;

namespace DIMSApis.Models.Data
{
    public partial class Qr
    {
        public int QrId { get; set; }
        public int? UserId { get; set; }
        public int? BookedId { get; set; }
        public string? QrString { get; set; }
        public DateTime? ActiveDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? Status { get; set; }

        public virtual Booking? Booked { get; set; }
        public virtual User? User { get; set; }
    }
}
