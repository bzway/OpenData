﻿#region License
// 
// Copyright (c) 2013, Bzway team
// 
// Licensed under the BSD License
// See the file LICENSE.txt for details.
// 
#endregion

using Microsoft.Owin;
using OpenData.Common.Caching;
using System.Threading.Tasks;

namespace OpenData.Framework.Core
{
    public class FrontPageMiddleware : OwinMiddleware
    {
        public FrontPageMiddleware(OwinMiddleware next)
            : base(next)
        {
        }
        public async override Task Invoke(IOwinContext context)
        {
            await Next.Invoke(context);
        }
    }
}