﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UselessFacts.Models
{
    public class UselessFact
    {
            public string Id { get; set; }
            public string Text { get; set; }
            public string Source { get; set; }
            public string Source_url { get; set; }
            public string Language { get; set; }
            public string Permalink { get; set; }
    }
}
