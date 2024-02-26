﻿using Staff.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff.Domain.Entities.Staff
{
    [Table("StaffEmploymentType")]
    public class StaffEmploymentType:EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public ICollection<StaffEmploymentDetail> EmploymentDetails { get; set; }
    }
}
