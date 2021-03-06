﻿namespace ApexLoader.ApexConfig
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Clock
    {
        [JsonPropertyName("auto")]
        public bool Auto { get; set; }

        [JsonPropertyName("date")]
        public int Date { get; set; }

        [JsonPropertyName("dst")]
        public bool Dst { get; set; }

        [JsonPropertyName("timezone")]
        public List<string> Timezone { get; set; }
    }
}