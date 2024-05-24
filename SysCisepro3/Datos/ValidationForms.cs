using System;
using System.Data;
using System.Drawing;
using System.IO;
using ClassLibraryCisepro3.Enums;
using ClassLibraryCisepro3.UsuarioGeneral; 
using SysCisepro3.Properties;

namespace SysCisepro3.Datos
{
    public static class ValidationForms
    {
        /// <summary>
        /// CISEPRO 2019
        /// VALIDACIONES GENERALES PARA SYSCISEPRO3
        /// </summary>
        public static DataTable GenerarPeriodos(TipoConexion tipoCon, int ini)
        {
            var periodos = new DataTable();
            var u = new ClassUsuarioGeneral();
            var f = u.Now(tipoCon);
            periodos.Columns.Add("PERIODO");
            periodos.Columns.Add("VAL");
            for (var i = 0; i < (f.Year - ini); i++) periodos.Rows.Add((ini + i) + " - " + (ini + 1 + i), (ini + 1 + i));
            return periodos;
        }

        public static string MesEnLetras(int n)
        {
            string ms;
            switch (n)
            {
                default:
                    ms = string.Empty;
                    break;
                case 1:
                    ms = "ENERO";
                    break;
                case 2:
                    ms = "FEBRERO";
                    break;
                case 3:
                    ms = "MARZO";
                    break;
                case 4:
                    ms = "ABRIL";
                    break;
                case 5:
                    ms = "MAYO";
                    break;
                case 6:
                    ms = "JUNIO";
                    break;
                case 7:
                    ms = "JULIO";
                    break;
                case 8:
                    ms = "AGOSTO";
                    break;
                case 9:
                    ms = "SEPTIEMBRE";
                    break;
                case 10:
                    ms = "OCTUBRE";
                    break;
                case 11:
                    ms = "NOVIEMBRE";
                    break;
                case 12:
                    ms = "DICIEMBRE";
                    break;
            }
            return ms;
        }

        public static Image BytesToImage(byte[] buffer)
        {
            return buffer == null ? null : Image.FromStream(new MemoryStream(buffer));
        }

        public static byte[] ImageToBytes(Image image)
        {
            if (image == null) return null;
            var bin = new MemoryStream();
            image.Save(bin, System.Drawing.Imaging.ImageFormat.Jpeg);
            return bin.GetBuffer();
        }

        public static string BitmapToString(Bitmap bmp)
        {
            var ms = new MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var byteImage = ms.ToArray();
            return Convert.ToBase64String(byteImage);
        }

        public static string NumToCharExcel(int i)
        {
            var dividend = i + 1; 
            var columnName = string.Empty;
            while (dividend > 0)
            {
                var modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo) + columnName;
                dividend = (dividend - modulo) / 26;
            }
            return columnName;
        }

        public static Color GetColorSistema(TipoConexion tipo)
        {
            Color color;
            switch (tipo)
            {
                case TipoConexion.Asenava:
                    color = Settings.Default.ColorAsenava;
                    break;
                case TipoConexion.Seportpac:
                    color = Settings.Default.ColorSeportpac;
                    break;
                default:
                    color = Settings.Default.ColorCisepro;
                    break;
            }
            return color;
        }

        public static Bitmap Logo(TipoConexion tipoCon)
        {
            Bitmap img = null;
            switch (tipoCon)
            {
                case TipoConexion.Seportpac:
                    img = new Bitmap(Resources.SeportPac_wall_min, 60, 60);
                    break;
                case TipoConexion.Asenava:
                    img = null;
                    break;
                default: // CISEPRO
                    img = new Bitmap(Resources.Cisepro_wall_min, 60, 60);
                    break;
            }
            return img;
        }
    }
}
