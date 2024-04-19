using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmJogoGourmet());
        }
    }

    public class Prato
    {
        private string _descricao;
        private string _caracteristica;

        public Prato(string descricao, string caracteristica)
        {
            this._descricao = descricao;
            this._caracteristica = caracteristica;
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }

            set
            {
                _descricao = value;
            }
        }

        public string Caracteristica
        {
            get
            {
                return _caracteristica;
            }

            set
            {
                _caracteristica = value;
            }


        }

    }
}
