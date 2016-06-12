﻿using OpenData.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace OpenData.Framework.Entity
{
    public partial class SiteAuth : BaseEntity
    {
        public string AppID { get; set; }
        public string UserID { get; set; }
        public string OpenID { get; set; }
        public string Scope { get; set; }
        public DateTime ExpiredTime { get; set; }

        public string AccessToken { get; set; }
    }
}