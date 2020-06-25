using APIOData.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

[Produces("application/json")]
[System.Web.Http.Route("api/consulta")]
public class ConsultaController : ODataController
{
    private ConsultaContext Context { get; set; }
    public ConsultaController(DataContext context)
    {
        this.Context = context ?? throw new ArgumentNullException(nameof(context));
    }
    [System.Web.Http.HttpPost]
    public IActionResult Post([System.Web.Http.FromBody] Consulta model)
    {

        this.Context.Consulta.Add(model);
        this.Context.SaveChanges();
        return Created("/api/consulta/" + model.Id, model);
    }
    [EnableQuery]
    public IQueryable<Consulta> Get() => Context.Consulta.AsQueryable();
}
