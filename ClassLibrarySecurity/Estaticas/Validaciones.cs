using ClassLibraryCisepro3.Enums;

namespace ClassLibraryCisepro3.Estaticas
{
    public static class Validaciones
    {
        public static string NombreLogo(TipoConexion tipo, string stp)
        {
            string name;
            switch (tipo)
            {
                case TipoConexion.Asenava:
                    name = stp + "\\logoas.png";
                    break;
                case TipoConexion.Seportpac:
                    name = stp + "\\logose.png";
                    break;
                default:
                    name = stp + "\\logoci.png";
                    break;
            }
            return name;
        }

        public static string NombreCompany(TipoConexion tipo)
        {
            string name;
            switch (tipo)
            {
                case TipoConexion.Asenava:
                    name = "ASENAVA C. LTDA.";
                    break;
                case TipoConexion.Seportpac:
                    name = "SEPORTPAC C. LTDA.";
                    break;
                default:
                    name = "CISEPRO C. LTDA.";
                    break;
            }
            return name;
        }

        public static bool IsNumeroEntero(char c)
        {
            return char.IsDigit(c) || c == (char)8;
        }

        public static bool IsNumeroDecimal(char c, string texto)
        {
            if (c == '.' && texto.Contains(".")) return false;
            return !(!char.IsControl(c) && !char.IsDigit(c) && c != '.' && c != '\b');
        }
    }
}
