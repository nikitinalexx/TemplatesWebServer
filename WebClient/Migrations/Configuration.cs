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
        }
    }
}
