using BankingApp.Domain.Base;
using System.Collections.Generic;

namespace BankingApp.Domain
{
    public class Account : EntityBase
    {
        public virtual int AccountType { get; set; }

        public virtual decimal Balance { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Card> Cards { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
