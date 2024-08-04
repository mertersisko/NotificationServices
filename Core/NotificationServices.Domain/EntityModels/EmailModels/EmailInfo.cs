using NotificationServices.Domain.EntityModels.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Domain.EntityModels.EmailModels
{
    public class EmailInfo : BaseCustomerEntity
    {
        public string EmailHost { get; set; }
        public string EmailPort { get; set; }
        public string EmailUsername { get; set; }
        public string EmailPassword { get; set; }
        public bool EnableSsl { get; set; }

    }
}
