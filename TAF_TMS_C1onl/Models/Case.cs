using AngleSharp.Dom;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TAF_TMS_C1onl.Models
{
    public class Case
    {
        [JsonPropertyName("section_id")] public int SectionID { get; set; }
        [JsonPropertyName("title")] public string Title { get; set; }
        [JsonPropertyName("type_id")] public int TypeId { get; set; }
        [JsonPropertyName("priority_id")] public int PriorityId { get; set; }

    }

}
