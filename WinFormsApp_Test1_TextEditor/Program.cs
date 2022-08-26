namespace WinFormsApp_Test1_TextEditor
{
    internal static class Program
    {
        public static TextEditor textEditor { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //FileInterface __fileInterface = new FileInterface();
            //TextEditor textEditor1 = new TextEditor(__fileInterface);
            ApplicationConfiguration.Initialize();

            textEditor = new TextEditor();

            Application.Run(textEditor);
        }
    }
}