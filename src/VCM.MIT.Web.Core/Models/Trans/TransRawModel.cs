using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCM.MIT.Models.Trans
{
    public class TransRawModel
    {
        [Required]
        [MaxLength(3)]
        public string CompanyCode { get; set; }
        [Required]
        [MaxLength(20)]
        public string AppCode { get; set; }
        [Required]
        [MaxLength(6)]
        public string StoreNo { get; set; }
        [Required]
        [MaxLength(3)]
        public string PosNo { get; set; }
        [Required]
        [MaxLength(20)]
        public string TranNo { get; set; }
        [Required]
        public string RawData { get; set; }
        [MaxLength(20)]
        public string IpAddress { get; set; }
        [MaxLength(20)]
        public string MacAddress { get; set; }
    }
}
