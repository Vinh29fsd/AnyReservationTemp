﻿using System.Security.Policy;

namespace AnyReservationTemp.Domain
{
    public class Restaurant : BaseDomainModel
    {
        public string? Location { get; set; }
        public string? ImagePath { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
