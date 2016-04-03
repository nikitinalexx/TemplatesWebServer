using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebServer.Models
{
    public class TemplateImplementation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public String ImagePath { get; set; }

        [ForeignKey("Template")]
        public int TemplateId { get; set; }
        public Template Template { get; set; }
    }
}