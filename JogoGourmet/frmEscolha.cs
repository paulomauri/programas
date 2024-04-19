using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoGourmet
{
    public partial class frmEscolha : Form
    {
        public string Escolha
        {
            get
            {
                return txtEscolha.Text;
            }
        }

        public frmEscolha()
        {
            InitializeComponent();
        }

        public frmEscolha(string mensagem, string titulo)
        {
            InitializeComponent();
            
            this.lblMensagem.Text = mensagem;
            this.Text= titulo;
        }
    }
}
