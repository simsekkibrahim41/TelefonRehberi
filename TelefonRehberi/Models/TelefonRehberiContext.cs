using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelefonRehberi.Models
{
    public class TelefonRehberiContext:DbContext
    {
        public TelefonRehberiContext(DbContextOptions<TelefonRehberiContext> options) : base(options)
        {
        }


        public DbSet<TelefonRehberi> TelefonRehberleri { get; set; }


    }






}
