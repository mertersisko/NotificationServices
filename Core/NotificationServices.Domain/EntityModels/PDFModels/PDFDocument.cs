using NotificationServices.Domain.EntityModels.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Domain.EntityModels.PDFModels
{
    public class PDFDocument :BaseCustomerEntity
    {
        public Guid DocumentKey { get; set; }
        public string Name { get; set; }
        public string FullPath { get; set; }
        public string FilePath { get; set; }
    }
}
