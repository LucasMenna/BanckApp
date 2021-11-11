using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Dto
{
    public class TransactionDto
    {
        public virtual int TransactionType { get; set; }

        public virtual int TransactionDate { get; set; }

        public virtual decimal Amount { get; set; }
    }
}
