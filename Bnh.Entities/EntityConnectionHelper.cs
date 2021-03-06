﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Configuration;

namespace Bnh.Entities
{
    public class EntityConnectionHelper
    {
        public static EntityConnection Get(string schema)
        {
            var b = new EntityConnectionStringBuilder();
            b.Metadata = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", schema);
            b.Provider = "System.Data.SqlClient";
            b.ProviderConnectionString = ConfigurationManager.ConnectionStrings["Bnh.Entities"].ConnectionString + "multipleactiveresultsets=True;App=EntityFramework";

            return new EntityConnection(b.ConnectionString);
        }
    }
}
