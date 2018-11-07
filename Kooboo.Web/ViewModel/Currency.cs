﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kooboo.Web.ViewModel
{
    public class CurrencyViewModel
    {
        public string Code { get; set; }

        public string Symbol
        {
            get
            {
                return Kooboo.Lib.Helper.CurrencyHelper.GetCurrencySymbol(Code);
            }
        }
    }
}
