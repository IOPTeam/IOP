﻿using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Data.Configurations
{
    class SendingPointConfiguration : IEntityConfiguration
    {
        public void AddConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SendingPoint>()
                .HasBaseType<StorePlace>();
        }
    }
}
