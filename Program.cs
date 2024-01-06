using Microsoft.Extensions.Configuration;

namespace TypeingTest
{
   
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        public static IConfiguration Config { get; private set; }

        //static SQLiteConnection dbConnection = new SQLiteConnection(@"Data Source=C:\Program Files (x86)\myCompany\myScanApp\test. s3db;");
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            //Config = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //    var builder = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            //    Config = builder.Build();
            //    var test = Config.GetConnectionString("database");
            // IConfigurationRoot configuration = builder.Build();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}