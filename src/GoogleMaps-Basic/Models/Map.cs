using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMaps_Basic.Models
{
    [Table("Maps")]
    public class Map
    {
        [Key]
        public int Id { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }

        public Map (int latitude, int longitude, int id = 0)
        {
            Latitude = latitude;
            Longitude = longitude;
            Id = id;
        }

        //public int zoom { get; set; }
    }
    //public static Map GetMap ()
}
