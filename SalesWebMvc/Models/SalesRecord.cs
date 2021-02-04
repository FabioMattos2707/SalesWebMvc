using System;
using SalesWebMvc.Models.Enums;


namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; protected set; }
        public DateTime Date { get; protected set; }
        public double Amount { get; protected set; }
        public Seller Seller { get; protected set; }
        public SalesStatus Status { get; protected set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, Seller seller, SalesStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Status = status;
        }
    }
}
