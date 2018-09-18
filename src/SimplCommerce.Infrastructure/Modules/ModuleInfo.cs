﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace SimplCommerce.Infrastructure.Modules
{
    public class ModuleInfo
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsBundledWithHost { get; set; }

        public Version Version { get; set; }

        public string[] Dependencies { get; set; }

        public Assembly Assembly { get; set; }
    }
}
