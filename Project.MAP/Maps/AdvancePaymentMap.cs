using Project.ENTİTİES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Maps
{
    public class AdvancePaymentMap:BaseMap<AdvancePayment>
    {

        public AdvancePaymentMap()
        {
            ToTable("AdvancePayment");
            Property(x => x.AdvancePaymentType).IsRequired();
            Property(x => x.Description).IsOptional();
        
        }
     
    }
}
