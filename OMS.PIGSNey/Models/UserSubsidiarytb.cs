﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OMS.PIGSNey.Models
{
    //使用明细表
   public class UserSubsidiarytb
    {
        [Key]
        public int USId { get; set; }
        public int UId { get; set; }
        public int TId { get; set; }
        //领取时间
        public DateTime DrawTime { get; set; }
    }
}
