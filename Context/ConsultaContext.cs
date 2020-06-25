using APIOData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

public class ConsultaContext : DbContext
{
    public DbSet<Consulta> Consulta { get; set; }
    public ConsultaContext() : base()
    {
    }
    public ConsultaContext(DbContextOptions options) : base(options)
    {
    }

    public static implicit operator ConsultaContext(DataContext v)
    {
        throw new NotImplementedException();
    }
}
