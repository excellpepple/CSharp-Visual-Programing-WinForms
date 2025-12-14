namespace GPA_Calculator
{
    internal static class Program
    {
        public static AppContext Appctx { get; private set; } = null!; // public application context

        public static Semester semesterDB; // public database for semester data
        public static string DBPath; // public path for database file

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Appctx = new AppContext();
            Application.Run(Appctx);
        }
    }

    // Was looking for a way to keep the application running until all forms are closed.
    // so i created this with some help from the internet(chatgpt). :)
    // Simple ApplicationContext that exits only when all registered forms have closed.
    public class AppContext : ApplicationContext
    {
        private int _openForms;

        public AppContext()
        {
            // Start with the main form
            var main = new MainForm();
            RegisterForm(main);
        }

        // Call this to show and track any form so the app stays alive until all tracked forms close.
        public void RegisterForm(Form form)
        {
            if (form == null) throw new ArgumentNullException(nameof(form));

            _openForms++;
            form.FormClosed += (s, e) =>
            {
                _openForms--;
                if (_openForms == 0)
                {
                    ExitThread(); // no tracked forms left -> end message loop
                }
            };

            form.Show();
        }
    }
}