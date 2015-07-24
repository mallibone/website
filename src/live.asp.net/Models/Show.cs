﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace live.asp.net.Models
{
    public class Show
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTimeOffset ShowDate { get; set; }

        public bool IsInFuture => ShowDate > DateTimeOffset.Now;

        public string Url { get; set; }

        public string ThumbnailUrl { get; set; }
    }
}