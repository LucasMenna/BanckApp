using BankingApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Domain
{
    public class Card : EntityBase
    {
        [Required]
        public int CardType { get; set; }

        public virtual Account Account { get; set; }

        [Required]
        public decimal Limit { get; set; }

        [Required]
        public int NumberCard { get; set; }



    }
}
