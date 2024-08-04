using RegistaPackets.BaseEntityRepository.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Domain.EntityModels.BaseEntities
{
    public class BaseCustomerEntity : BaseEntity
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
    }
}
