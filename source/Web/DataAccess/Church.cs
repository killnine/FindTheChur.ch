using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web;

namespace Web.DataAccess
{
    public class Church
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GeoCoordinate Coordinates { get; set; }
        public CivicAddress Address { get; set; }
        public ICollection<string> PhoneContacts { get; set; }
        public ICollection<ServiceTime> Services { get; set; }
        public string Website { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}