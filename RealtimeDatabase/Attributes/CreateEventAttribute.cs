﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RealtimeDatabase.Attributes
{
    public class CreateEventAttribute : ModelStoreEventAttributeBase
    {
        public CreateEventAttribute(string before = null, string beforeSave = null, string after = null) : base(before, beforeSave, after)
        {

        }
    }
}
