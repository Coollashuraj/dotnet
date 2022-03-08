using System.Text.Json.Serialization;
namespace dotnet.Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Rpg
    {
        Knights,
        Elephant,
        Soldier
    }
}
