﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DashVector.Models
{
    public class PartitionStats
    {
        [JsonPropertyName("total_doc_count")]
        public string TotalDocCount { get; set; }
    }
}
