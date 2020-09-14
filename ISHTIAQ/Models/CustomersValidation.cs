using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISHTIAQ.Models
{
    [MetadataType(typeof(CustomerMetaData))]
    public partial class Customer
    {
        public class CustomerMetaData
        {
            [DisplayName("CustomerName")]
            public string custname { get; set; }
            [DisplayName("Address")]
            public string address { get; set; }
            [DisplayName("Phone")]
            public Nullable<int> mobile { get; set; }
        }
    }
}