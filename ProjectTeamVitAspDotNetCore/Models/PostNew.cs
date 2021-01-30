﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectTeamVitAspDotNetCore.Models
{
    public partial class PostNew
    {
        public DateTime CreateTime { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
