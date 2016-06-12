﻿#region License
// 
// Copyright (c) 2013, Bzway team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OpenData.Framework.Menu.Configuration
{
    public class MenuItemElementCollection : ConfigurationElementCollection
    {
        [ConfigurationProperty("type", IsRequired = false)]
        public string Type
        {
            get { return (string)this["type"]; }
            set { this["type"] = value; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MenuItemElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MenuItemElement)element).Name;
        }

    }
}