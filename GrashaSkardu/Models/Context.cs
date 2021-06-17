using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrashaSkardu.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>dbContextOptions):base(dbContextOptions){

    }
}
