using Newtonsoft.Json;

namespace Test1.Models
{
    public class FireTruck
    {
        [JsonProperty("IdFireTruck")] public int IdFireTruck { get; set; }
        [JsonProperty("OperationalNumber")] public int OpetarionalNumber { get; set; }
        [JsonProperty("SpecialEquipment")] public bool SpecialEquipment { get; set; }
        [JsonProperty("ActionsList")] public List <Action> Actions { get; set; }

    }
}
