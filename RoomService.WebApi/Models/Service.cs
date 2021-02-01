using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomService.Models
{
    public class Service
    {
        public long Id { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string PromoCode { get; set; }
        public bool IsBonusActivated { get; set; }
    }
}
