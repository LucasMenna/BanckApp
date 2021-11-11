using BankingApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Domain
{
    public class Transaction : EntityBase
    {
        [Required]
        public int TransactionType { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Sing { get; set; }

        public virtual Account Account { get; set; }

        public virtual Customer Custom { get; set; }

    }
}
