using System;
using System.Windows.Forms;
using System.Threading;
using ClassLibraryCisepro3.Enums;

namespace SysCisepro3
{
    // EL PROYECTO ORIGINAL ESTABA HECHO EN VB .NET (syscisepro)
    // ALGUNAS OPCIONES ANTIGUAS Y LAS NUEVAS FUERON REALIZADAS EN C# (SysCisepro3)

    // ClassLibraryCisepro contiene las librerias, métodos y funciones de syscisepro
    // ClassLibraryCisepro3 contiene las librerias, métodos y funciones de SysCisepro3

    // LA MAYORÍA DE MÉTODOS EN syscisepro obtiene información de la BD desde sus respectivos PROCEDIMIENTOS ALMACENADOS
    // OTROS MÉTODOS obtienen información de la BD a través de DATASETS, ejecutan sus propias SQL y procesan dichos datos para retornar en DATATABLE, aptos para el uso conveniente.
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // EL MISMO SISTEMA SIRVE PARA LAS 3 EMPRESAS QUE SE MANEJA
            // CAMBIAR EL TIPO SEGUN EL CASO, ANTES DE COMPILAR
            //0 CISEPRO            //1 SEPORTPAC            //2 ASENAVA
            const TipoConexion tipo = (TipoConexion)0;
            const int tiempoNotificacion = 2;

            // CONFIGURACIONES INICIALES DEL PROGRAMA
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES")
            {
                DateTimeFormat = { ShortDatePattern = "dd/MM/yyyy" },
                NumberFormat =
                {
                    CurrencyDecimalSeparator = ".",
                    CurrencyGroupSeparator = ",",
                    NumberDecimalSeparator = ".",
                    NumberGroupSeparator = ","
                }
            };

            // HABILITA ESTILOS VISUALES DE WINDOWS
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmSplash(tipo, tiempoNotificacion));
            Application.Run(new FrmIntro(tipo, tiempoNotificacion));
        }
    }
}
