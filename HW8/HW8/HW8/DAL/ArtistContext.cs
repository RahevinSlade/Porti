﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW8.Models;
using System.Data.Entity;

namespace HW8.DAL
{
    public class ArtistContext : DbContext
    {
        public ArtistContext() : base("name=ArtistContext")
        {

        }
        public virtual DbSet<Artist> Artists { get; set; }
    }
}