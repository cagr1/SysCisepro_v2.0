using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using SysCisepro3.Contabilidad.Compras;

namespace SysCisepro3.Reportes
{
    public partial class FormDashboard : KryptonForm
    {

        private static FormDashboard _instance;
        public static FormDashboard Instancia
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new FormDashboard();
                return _instance;
            }
        }
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            string htmlPath = Application.StartupPath + "\\Leer XML Temp\\Dashboard.html";
            WebBrowser1.Navigate(htmlPath);



        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
