﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMS.PIGSNey.Models
{
    public class OMSContext : DbContext
    {
        public OMSContext() { }
        public OMSContext(DbContextOptions<OMSContext> options) : base(options) { }

        public DbSet<ApplyFortb> ApplyFortb { get; set; }
        public DbSet<CommodityDetailstb> CommodityDetailstb { get; set; }
        public DbSet<Complaintb> Complaintb { get; set; }
        public DbSet<Juristb> Juristb { get; set; }
        public DbSet<MaintenanceDetailstb> MaintenanceDetailstb { get; set; }
        public DbSet<Materialstb> Materialstb { get; set; }
        public DbSet<Purchasetb> Purchasetb { get; set; }
        public DbSet<Questiontb> Questiontb { get; set; }
        public DbSet<RealNametb> RealNametb { get; set; }
        public DbSet<Roletb> Roletb { get; set; }
        public DbSet<Tooltb> Tooltb { get; set; }
        public DbSet<UserInfotb> UserInfotb { get; set; }
        public DbSet<UserRepairsDetailstb> UserRepairsDetailstb { get; set; }
        public DbSet<UserSubsidiarytb> UserSubsidiarytb { get; set; }
        public DbSet<Prompttb> prompttb { get; set; }

        public DbSet<AddTool> AddTool { get; set; }

        public DbSet<Audit> Audit { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<wenjuan> wenjuan { get; set; }
    }
}
