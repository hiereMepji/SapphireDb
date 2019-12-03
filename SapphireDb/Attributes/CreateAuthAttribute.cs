﻿using System;

namespace SapphireDb.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CreateAuthAttribute : AuthAttributeBase
    {
        public CreateAuthAttribute()
        {

        }

        public CreateAuthAttribute(string[] roles) : base(roles)
        {
        }

        public CreateAuthAttribute(string function) : base(function)
        {
        }
    }
}