using System;
using System.Windows.Forms;

namespace midterm_Q2
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // Get the OpenAI API key from the environment variable
            var apiKey = Environment.GetEnvironmentVariable("OpenApiKey");

            if (string.IsNullOrEmpty(apiKey))
            {
                Console.WriteLine("API key is missing.");
                return;
            }

            // Use the API key with OpenAI API
            

            // Example of making an API call
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Show the LoginForm first
            LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // If login is successful, show the mainForm
                Application.Run(new mainForm());
            }
            else
            {
                // Exit the application if login is not successful or canceled
                Application.Exit();
            }
        }
    }
}
