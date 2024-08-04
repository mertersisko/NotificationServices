using Microsoft.EntityFrameworkCore;
using NotificationServices.Domain.EntityModels.EmailModels;
using NotificationServices.Domain.EntityModels.PDFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Persistence.NotificationServicesContextes
{
    public class NotificationServicesContext : DbContext
    {
        public NotificationServicesContext(DbContextOptions options): base(options) { }



        #region Email
        public DbSet<EmailInfo> EmailInfos { get; set; }
        #endregion
        #region PDF
        public DbSet<PDFDocument> PDFDocuments { get; set; }
        #endregion
    }

}
