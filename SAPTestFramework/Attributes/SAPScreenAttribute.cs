﻿using SAPFEWSELib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAPAutomation.Framework.Attributes
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Property,AllowMultiple=true)]
    public class SAPGuiScreenAttribute:Attribute
    {
        public int ScreenNumber { get; set; }

        public string Program { get; set; }

        public string TCode { get; set; }
    }
}
