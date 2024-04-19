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
    public partial class frmPergunta : Form
    {
        public DialogResult retorno = DialogResult.No;

        public frmPergunta()
        {
            InitializeComponent();
        }

        public frmPergunta(string mensagem, string titulo, MessageBoxButtons buttons)
        {
            InitializeComponent();

            this.Text = titulo;
            this.lblMensagem.Text = mensagem;

            if (buttons == MessageBoxButtons.YesNo)
            {
                this.btnYES.Text= "Sim";
                this.btnNO.Text = "Não";
            }
        }


    }
}
