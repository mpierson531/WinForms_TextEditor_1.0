namespace WinFormsApp_Test1_TextEditor
{
    public interface IStorageService
    {
        public string ReadFile(string filePath);
        public void WriteFile(string filePath, string content);
        public StreamWriter CreateFile(string filePath);
    }
}
