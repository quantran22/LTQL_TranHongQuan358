using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQL_1721050358.Models
{
    public class LopHoc358
    {
        [Key]
        [Display(Name = "Mã Lớp")]
        public int Malop { get; set; }
        [Display(Name = "Tên Lớp")]
        [StringLength(50)]
        public string TenLop { get; set; }
        public ICollection<THqSinhVien358> hqSinhVien358s { get; set; }

    }
}