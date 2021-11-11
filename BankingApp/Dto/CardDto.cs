using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingApp.Dto
{
    public class CardDto
    {
        public virtual int CardType { get; set; }

        public virtual decimal Limit { get; set; }
    }
}
