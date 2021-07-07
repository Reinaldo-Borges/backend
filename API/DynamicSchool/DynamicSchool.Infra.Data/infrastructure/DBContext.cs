using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DynamicSchool.Infra.Data.infrastructure
{
    public class DBContext
    {
        private readonly IConfiguration _configuration;
        public Connection Connection;
        public CustomTransaction Transaction;

      

    }

}
