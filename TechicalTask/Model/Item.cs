﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TechicalTask.Model
{
    class Item
    {
        public Item(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
