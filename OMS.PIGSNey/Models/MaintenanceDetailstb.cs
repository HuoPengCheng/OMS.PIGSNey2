﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OMS.PIGSNey.Models
{
    /// <summary>
    /// 维修详情表
    /// </summary>
    public class MaintenanceDetailstb
    {
        [Key]
        public int MId { get; set; }
        //订单Id
        public int URDId { get; set; }
        //维修工人Id
        public int UId { get; set; }
    }
}
