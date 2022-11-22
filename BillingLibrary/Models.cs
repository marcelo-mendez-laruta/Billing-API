using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BillingLibrary.Models
{

    public class BillModel
    {
        public int Id { get; set; }
        public int Period { get; set; }
        public string? Category { get; set; }
        public decimal Amount { get; set; }
        public string State { get; set; } = "Pending";
        public int ClientId { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; } = DateTime.Now;

    }
    public class ClientModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<BillModel>? Payments { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? UpdatedOn { get; set; } = DateTime.Now;
    }
}