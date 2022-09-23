using System.Text.Json;

namespace WinFormsApp_Test1_TextEditor
{
    public class JsonInfo : IJsonInfo
    {
        private string defaultDirectory;
        private string inputDirectory;

        public string DefaultDirectory { get => defaultDirectory; set => defaultDirectory = value; }
        public string InputDirectory { get => inputDirectory; set => inputDirectory = value; }

        public string Serialize(JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize<JsonInfo>(value: this, options);
        }
        public JsonInfo Deserialize(string jsonContent)
        {
            return JsonSerializer.Deserialize<JsonInfo>(jsonContent);
        }
    }
}
