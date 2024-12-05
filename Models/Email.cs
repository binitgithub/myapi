using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myapi.Models
{
    public class Email
    {
    public int EmailId { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public DateTime SentDate { get; set; }

    // Relationships
    public int? LeadId { get; set; }
    public Lead Lead { get; set; }
    }
}