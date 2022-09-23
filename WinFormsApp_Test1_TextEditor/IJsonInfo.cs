using System.Text.Json;

namespace WinFormsApp_Test1_TextEditor
{
    public interface IJsonInfo
    {
        public string DefaultDirectory { get; set; }
        public string InputDirectory { get; set; }

        public string Serialize(JsonSerializerOptions options);
        public JsonInfo Deserialize(string jsonContent);
    }
}
