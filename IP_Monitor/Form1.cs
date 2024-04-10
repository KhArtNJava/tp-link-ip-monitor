using CefSharp.WinForms;
using CefSharp;

namespace IP_Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var settings = new CefSettings();
            settings.CachePath = "c:\\temp\\CefSharp\\Cache";
            settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36 /CefSharp Browser" + Cef.CefSharpVersion;
            Cef.Initialize(settings);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("http://192.168.0.1/");
        }
    }
}
