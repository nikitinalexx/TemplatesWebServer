namespace WebServer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebServer.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebServer.Models.WebServerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebServer.Models.WebServerContext context)
        {
            Template t = new Template();
            t.Name = "Template Name";
            t.Purpose = "Template Purpose";
            t.UmlImagePath = "Template Uml Path";
            t.Description = "Template Description";
            context.Templates.AddOrUpdate(t);

        }
    }
}
