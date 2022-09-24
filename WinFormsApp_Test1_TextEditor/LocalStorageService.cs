namespace WinFormsApp_Test1_TextEditor
{

    public class LocalStorageService : IStorageService
    {
        public string ReadFile(string filePath)
        {
            using (var stream = new StreamReader(filePath))
            {
                return stream.ReadToEnd();
            }
        }

        public void WriteFile(string filePath, string content)
        {
            using (var fileSave = this.CreateFile($"{filePath}"))
            {
                fileSave.WriteLine(content);
                fileSave.Close();
            }
        }

        public StreamWriter CreateFile(string filePath)
        {
            return File.CreateText(filePath);
        }
    }
}