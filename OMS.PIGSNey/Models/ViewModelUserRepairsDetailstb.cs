﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.PIGSNey.Models
{
    public class ViewModelUserRepairsDetailstb
    {
        [Key]
        public int UrdId { get; set; }
        //订单编号自增
        public string Ordernumber { get; set; }
        //商品类型
        public string Type { get; set; }
        //等级
        public int Degree { get; set; }
        //商品型号
        public string Marque { get; set; }
        //报修原因
        public string Cause { get; set; }
        //报修理由
        public string Reason { get; set; }
        //地址(省市区)
        public string Address { get; set; }
        //详细地址
        public string DetailedAddress { get; set; }
        //获取当前时间
        public DateTime Date { get; set; }
        //用户Id(申请人Id)
        public int UId { get; set; }
        //状态
        public int State { get; set; }
        public string UName { get; set; }
        //用户账号
        public string UAccount { get; set; }
        //用户密码
        public string UPwd { get; set; }
        //手机号
        public string UPhone { get; set; }
        //角色id
        public int RId { get; set; }
        //状态
        public int UState { get; set; }
    }
}
