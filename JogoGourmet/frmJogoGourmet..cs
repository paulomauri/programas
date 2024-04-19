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
    public partial class frmJogoGourmet : Form
    {
        private Prato _massa = new Prato("Lasanha","");
        private Prato _naoMassa = new Prato("Bolo de Chocolate","");

        private List<Prato> _lstPratosMassa = new List<Prato>();
        private List<Prato> _lstPratosNaoMassa = new List<Prato>();

        public frmJogoGourmet()
        {
            InitializeComponent();

            _lstPratosMassa.Add(_massa);
            _lstPratosNaoMassa.Add(_naoMassa);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (frmPergunta frm = new frmPergunta("O prato que você pensou é massa ?", "Confirmação", MessageBoxButtons.YesNo))
            {
                DialogResult dRes = frm.ShowDialog();

                if (dRes == DialogResult.Yes)
                {
                    advinharPratos(_lstPratosMassa);
                    return;
                }

                advinharPratos(_lstPratosNaoMassa);

            }
        }

        private void advinharPratos(List<Prato> pratos)
        {
            int tamanhoLista  = pratos.Count() - 1;
            int contador = tamanhoLista;
            DialogResult res;

            for (contador = tamanhoLista; contador > 0; contador--)
            {
                res = perguntaPrato(pratos, contador, true);

                if (res == DialogResult.Yes)
                {
                    res = perguntaPrato(pratos, contador, false);

                    if (res == DialogResult.Yes)
                    {
                        acertei();
                        break;
                    }
                    else if ((res == DialogResult.No) && (contador == 0))
                    {
                        adicionarPrato(pratos, contador);
                        break;
                    }
                }
            }

            if (contador == 0)
            {
                var resposta = perguntaPrato(pratos, contador, false);

                if (resposta == DialogResult.Yes)
                {
                    acertei();
                    return;
                }
                adicionarPrato(pratos, contador);
            }

        }


        private DialogResult perguntaPrato(List<Prato> pratos, int contador, bool caracteristica)
        {
            string mensagem;
            if (caracteristica)
            {
                mensagem = "O prato que pensou é " + pratos[contador].Caracteristica + "?"; 
            }
            else 
            { 
                mensagem = "O prato que pensou é " + pratos[contador].Descricao + "?";
            }

            using (frmPergunta frm = new frmPergunta(mensagem, "Confirmação", MessageBoxButtons.YesNo))
            {
                return frm.ShowDialog();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pratos"></param>
        /// <param name="ordemPrato"></param>
        private void adicionarPrato(List<Prato> pratos, int ordemPrato)
        {
            pratos.Add(montaObjetoPratoNovo(pratos, ordemPrato));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pratos"></param>
        /// <param name="ordemPrato"></param>
        /// <returns></returns>
        private Prato montaObjetoPratoNovo(List<Prato> pratos, int ordemPrato)
        {
            string pratoEscolhido = string.Empty;
            string caracteristica = string.Empty;

            using (frmEscolha frmEscolha = new frmEscolha("Qual prato você pensou ?", "Desisto"))
            {
                frmEscolha.ShowDialog();
                pratoEscolhido = frmEscolha.Escolha;
            }

            var mensagem = pratoEscolhido + " é __________ mas " + pratos[ordemPrato].Descricao + " não.";
            using (frmEscolha frmEscolha = new frmEscolha(mensagem, "Complete"))
            {
                frmEscolha.ShowDialog();
                caracteristica = frmEscolha.Escolha;
            }

            Prato prato = new Prato(pratoEscolhido, caracteristica);

            return prato;
        }

        /// <summary>
        /// 
        /// </summary>
        private void acertei()
        {
            MessageBox.Show("Acertei de novo!", "Acertei",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
