using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISHTIAQ.Models
{
[MetadataType(typeof(CarMetaData))]

    public partial class Car
    {
        public class CarMetaData
        {
            [DisplayName("CarNumber")]
            public string carno { get; set; }
            [DisplayName("MadeBy")]
            public string make { get; set; }
            [DisplayName("Model")]
            public string model { get; set; }
            [DisplayName("Available")]
            public string available { get; set; }
        }
    }
}