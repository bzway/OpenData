﻿#region License
// 

// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Bzway.Core.AppEngine;

[assembly: System.Web.PreApplicationStartMethod(typeof(Bzway.Website.Web.TemplateEngines.WebForm.AssemblyInitializer), "Initialize")]
namespace Bzway.Website.Web.TemplateEngines.WebForm
{
    public static class AssemblyInitializer
    {
        public static void Initialize()
        {
            ApplicationInitialization.RegisterInitializerMethod(delegate()
            {
                Bzway.Website.Sites.View.TemplateEngines.RegisterEngine(new WebFormTemplateEngine());
            }, 0);
        }
    }
}
