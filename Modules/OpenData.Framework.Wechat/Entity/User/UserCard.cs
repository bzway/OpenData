﻿using OpenData.Framework.Entity;
using OpenData.Data;
using System;

namespace OpenData.Framework.Entity
{
    public class UserCard : BaseEntity
    {
        public string UUID { get; set; }
        public string UserID { get; set; }
        public string CardNumber { get; set; }
        public GradeType CardGrade { get; set; }
        public string CardName { get; set; }
        public string ValidateCode { get; set; }
        public bool IsUsed { get; set; }
    }
  
}