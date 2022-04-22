using Newtonsoft.Json;

namespace Test1.Models
{
    public class Action
    {
        [JsonProperty("IdAction")] public int idAction { get; set; }
        [JsonProperty("StartTime")] public DateTime StartTime { get; set; }
        [JsonProperty("EndTime")] public DateTime EndTime { get; set; }
        [JsonProperty("SpecialEquipment")] public bool SpecialEquipment { get; set; }
    }
}
