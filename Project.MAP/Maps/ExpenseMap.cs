using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class ExpenseMap:BaseMap<Expense>
    {
        public ExpenseMap()
        {
            ToTable("Expenses");
            Property(x => x.Amount).HasColumnName("Amount").IsRequired();
            Property(x => x.Description).IsOptional();
        }
    }
}
