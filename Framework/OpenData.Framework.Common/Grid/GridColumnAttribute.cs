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

namespace OpenData.Framework.Common.Grid
{
    public class GridColumnAttribute : Attribute
    {
        public string HeaderText { get; set; }
        public string HeaderFormatString { get; set; }
        public string ItemFormatString { get; set; }
        public string Class { get; set; }
        public Type HeaderRenderType { get; set; }
        public Type ItemRenderType { get; set; }
        public Type AlternatingItemRenderType { get; set; }

        public int Order { get; set; }
    }
}
