using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebServer.Models
{
    public class WebServerContext : DbContext
    {    
        public WebServerContext() : base("name=WebServerContext")
        {
        }

        public System.Data.Entity.DbSet<WebServer.Models.Template>
            Templates { get; set; }

        public System.Data.Entity.DbSet<WebServer.Models.TemplateImplementation>
            TemplateImplementations { get; set; }
    }
}
