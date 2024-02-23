﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashVector.Models
{
    public static class CollectionInfo
    {
        public static class DataType
        {
            public const string FLOAT = "FLOAT";
            public const string INT = "INT";
        }

        public static class Metric
        {

            public const string Euclidean = "euclidean";
            public const string Dotproduct = "dotproduct";
            public const string Cosine = "cosine";
        }

    }
}
