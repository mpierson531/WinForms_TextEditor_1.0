using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp_Test1_TextEditor
{
    internal class JsonInfo
    {
        private string defaultDirectory;
        private string inputDirectory;

        public string DefaultDirectory { get => defaultDirectory; set => defaultDirectory = value; }
        public string InputDirectory { get => inputDirectory; set => inputDirectory = value; }

        public string Serialize(JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize<JsonInfo>(value: this, options);
        }
        public JsonInfo Deserialize(string json)
        {
            return JsonSerializer.Deserialize<JsonInfo>(json);
        }
    }
}
