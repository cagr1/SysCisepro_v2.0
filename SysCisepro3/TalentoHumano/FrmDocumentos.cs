using System;
using System.Windows.Forms;
using ClassLibraryCisepro3.Enums;
using SysCisepro3.Properties;
using System.IO;
using ClassLibraryCisepro3.TalentoHumano;
using System.Data;
using Krypton.Toolkit;

namespace SysCisepro3.TalentoHumano
{
    public partial class FrmDocumentos : KryptonForm
    {
        /// <summary>
        /// CISEPRO 2019
        /// Para cargar documentos importantes del personal
        /// </summary>
        public TipoConexion TipoCon { private get; set; }
        public int IdPersonal;
        public int IdContrato;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ClassDocumentosContrato _objContrato;
        private bool _ready;

        public byte[] _cv;//1
        public byte[] _ci;//2
        public byte[] _cr;//3
        public byte[] _se;//4
        public byte[] _ts;//5
        public byte[] _vs;//6
        public byte[] _es;//7
        public byte[] _am;//8
        public byte[] _pn;//9
        public byte[] _af;//10
        public byte[] _em;//11
        public byte[] _al;//12

        public FrmDocumentos()
        {
            InitializeComponent();
            _cv = null;
            _ci = null;
            _cr = null;
            _se = null;
            _ts = null;
            _vs = null;
            _es = null;
            _am = null;
            _pn = null;
            _af = null;
            _em = null;
            _al = null;
            _ready = false;
            _objContrato = new ClassDocumentosContrato();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog()
            {
                InitialDirectory = @"C:\",  
                Title = "SELECCIONAR DOCUMENTO",  
                CheckFileExists = true,  
                CheckPathExists = true,  
                DefaultExt = "pdf",  
                Filter = "Archivos PDF (*.pdf)|*.pdf",  
                FilterIndex = 2,  
                RestoreDirectory = true,  
                ReadOnlyChecked = true,  
                ShowReadOnly = true  
            };
            label1.Text = string.Empty;            
        }

        private void FrmDocumentos_Load(object sender, EventArgs e)
        {
            Text += " - ID P: " + IdPersonal + " - ID C: " + IdContrato;
            switch (TipoCon)
            {
                case TipoConexion.Seportpac:
                    Icon = Resources.logo_s; 
                    break;
                case TipoConexion.Asenava:
                    Icon = Resources.logo_a; 
                    break;
                default: // CISEPRO
                    Icon = Resources.logo_c; 
                    break;
            }
            CargarDocumentacion();
            _ready = true;
        }

        public void CargarDocumentacion()
        {
            if (IdPersonal == 0) return;
            var docs = _objContrato.SeleccionarDocumentoXContratoId(TipoCon, IdContrato + "");
            foreach (DataRow row in docs.Rows)
            {
                if (row[0].ToString().Equals("CV"))
                {
                    CheckBox1.Checked = true; 
                    txt1.Text = row[2].ToString();
                    CheckBox1.Enabled = false;
                    txt1.Enabled = false;
                    btn1.Enabled = false;
                }
                if (row[0].ToString().Equals("CI"))
                {
                    CheckBox2.Checked = true; 
                    txt2.Text = row[2].ToString();
                    CheckBox2.Enabled = false;
                    txt2.Enabled = false;
                    btn2.Enabled = false;
                }
                if (row[0].ToString().Equals("CR"))
                {
                    CheckBox3.Checked = true; 
                    txt3.Text = row[2].ToString();
                    CheckBox3.Enabled = false;
                    txt3.Enabled = false;
                    btn3.Enabled = false;
                }
                if (row[0].ToString().Equals("SE"))
                {
                    CheckBox4.Checked = true; 
                    txt4.Text = row[2].ToString();
                    CheckBox4.Enabled = false;
                    txt4.Enabled = false;
                    btn4.Enabled = false;
                }
                if (row[0].ToString().Equals("TS"))
                {
                    CheckBox5.Checked = true; 
                    txt5.Text = row[2].ToString();
                    CheckBox5.Enabled = false;
                    txt5.Enabled = false;
                    btn5.Enabled = false;
                }
                if (row[0].ToString().Equals("VS"))
                {
                    CheckBox6.Checked = true; 
                    txt6.Text = row[2].ToString();
                    CheckBox6.Enabled = false;
                    txt6.Enabled = false;
                    btn6.Enabled = false;
                }
                if (row[0].ToString().Equals("ES"))
                {
                    CheckBox7.Checked = true; 
                    txt7.Text = row[2].ToString();
                    CheckBox7.Enabled = false;
                    txt7.Enabled = false;
                    btn7.Enabled = false;
                }
                if (row[0].ToString().Equals("AM"))
                {
                    CheckBox8.Checked = true; 
                    txt8.Text = row[2].ToString();
                    CheckBox8.Enabled = false;
                    txt8.Enabled = false;
                    btn8.Enabled = false;
                }
                if (row[0].ToString().Equals("PN"))
                {
                    CheckBox9.Checked = true; 
                    txt9.Text = row[2].ToString();
                    CheckBox9.Enabled = false;
                    txt9.Enabled = false;
                    btn9.Enabled = false;
                }
                if (row[0].ToString().Equals("AF"))
                {
                    CheckBox10.Checked = true; 
                    txt10.Text = row[2].ToString();
                    CheckBox10.Enabled = false;
                    txt10.Enabled = false;
                    btn10.Enabled = false;
                }
                if (row[0].ToString().Equals("EM"))
                {
                    CheckBox11.Checked = true; 
                    txt11.Text = row[2].ToString();
                    CheckBox11.Enabled = false;
                    txt11.Enabled = false;
                    btn11.Enabled = false;
                }
                if (row[0].ToString().Equals("AL"))
                {
                    CheckBox12.Checked = true; 
                    txt12.Text = row[2].ToString();
                    CheckBox12.Enabled = false;
                    txt12.Enabled = false;
                    btn12.Enabled = false;
                }
            }      
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBox1.Enabled && CheckBox1.Checked) _cv = File.ReadAllBytes(txt1.Text.Trim());
                if (CheckBox2.Enabled && CheckBox2.Checked) _ci = File.ReadAllBytes(txt2.Text.Trim());
                if (CheckBox3.Enabled && CheckBox3.Checked) _cr = File.ReadAllBytes(txt3.Text.Trim());
                if (CheckBox4.Enabled && CheckBox4.Checked) _se = File.ReadAllBytes(txt4.Text.Trim());
                if (CheckBox5.Enabled && CheckBox5.Checked) _ts = File.ReadAllBytes(txt5.Text.Trim());
                if (CheckBox6.Enabled && CheckBox6.Checked) _vs = File.ReadAllBytes(txt6.Text.Trim());
                if (CheckBox7.Enabled && CheckBox7.Checked) _es = File.ReadAllBytes(txt7.Text.Trim());
                if (CheckBox8.Enabled && CheckBox8.Checked) _am = File.ReadAllBytes(txt8.Text.Trim());
                if (CheckBox9.Enabled && CheckBox9.Checked) _pn = File.ReadAllBytes(txt9.Text.Trim());
                if (CheckBox10.Enabled && CheckBox10.Checked) _af = File.ReadAllBytes(txt10.Text.Trim());
                if (CheckBox11.Enabled && CheckBox11.Checked) _em = File.ReadAllBytes(txt11.Text.Trim());
                if (CheckBox12.Enabled && CheckBox12.Checked) _al = File.ReadAllBytes(txt12.Text.Trim());
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var txt = (TextBox)Controls["txt" + (sender as Button).Tag.ToString().Trim()];
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                txt.Text = openFileDialog1.FileName;
                if ((txt.Tag + "").Trim().Length == 0) txt.Tag = "0";
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }

        private TextBox GetTextBoxForTag(string txt)
        {
            if (txt.Equals(txt1.Name)) return txt1;
            if (txt.Equals(txt2.Name)) return txt2;
            if (txt.Equals(txt3.Name)) return txt3;
            if (txt.Equals(txt4.Name)) return txt4;
            if (txt.Equals(txt5.Name)) return txt5;
            if (txt.Equals(txt6.Name)) return txt6;
            if (txt.Equals(txt7.Name)) return txt7;
            if (txt.Equals(txt8.Name)) return txt8;
            if (txt.Equals(txt9.Name)) return txt9;
            if (txt.Equals(txt10.Name)) return txt10;
            if (txt.Equals(txt11.Name)) return txt11;
            if (txt.Equals(txt12.Name)) return txt12;
            return null;
        }
         
        private void CheckBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (!_ready) return;
            try
            {
                var txt = (TextBox)Controls["txt" + (sender as CheckBox).Tag.ToString().Trim()];
                var btn = (Button)Controls["btn" + (sender as CheckBox).Tag.ToString().Trim()];
                txt.Clear();
                if ((txt.Tag + "").Trim().Length == 0 || (txt.Tag + "").Equals("0")) txt.Tag = null;
                btn.Enabled = (sender as CheckBox).Checked;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
        }
    }
}