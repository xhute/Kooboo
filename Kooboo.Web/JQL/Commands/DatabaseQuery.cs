﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Web.JQL
{
 public   class DatabaseQuery : ICommand
    {     
        public DatabaseQuery()
        {
            this.ObjectType = EnumObjectType.Database; 
        }

        public string Table { get; set; }
                                            
        public string Condition { get; set; }

        public string OrderBy { get; set; }

        public bool Ascending { get; set; }

        public int Skip { get; set; }

        public int Take { get; set; }

        public EnumObjectType  ObjectType { get; set; }
    }
}
