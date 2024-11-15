using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.ProcesosSql;
using System.Drawing;
using System.Windows.Forms;

namespace ClassLibraryCisepro3.UsuarioGeneral
{
    public class ClassGeneral : ToolStripProfessionalRenderer
    {
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            // Fill the background with the specified BackColor
            using (SolidBrush brush = new SolidBrush(e.ToolStrip.BackColor))
            {
                e.Graphics.FillRectangle(brush, e.AffectedBounds);
            }
        }

    }
}
