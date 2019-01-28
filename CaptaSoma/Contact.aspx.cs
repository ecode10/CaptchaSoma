using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CaptaSoma
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RandomSoma();
            }
        }

        private void RandomSoma()
        {
            Random random = new Random();

            var _primeiroValor = random.Next(0, 10);
            var _segundoValor = random.Next(5, 15);

            lblSoma.Text = _primeiroValor + "+" + _segundoValor;
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            var _soma = lblSoma.Text.Split('+');
            var _primeiroValor = _soma[0];
            var _segundoValor = _soma[1];

            var _somaTotal = int.Parse(_primeiroValor) +
                int.Parse(_segundoValor);

            if (!txtSoma.Text.Equals(_somaTotal.ToString()))
            {
                lblResultado.Text = "Wrong, try again";
                return;
            }

            string _nome = txtNome.Text;
            string _email = txtEmail.Text;
            string _descricao = txtDescricao.Text;

            enviarEmail(_nome, _email, _descricao);
            limpaCampos();
        }

        private void limpaCampos()
        {
            lblResultado.Text = "Email enviado com sucesso.";
            txtDescricao.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
        }

        #region "Envia email "
        private void enviarEmail(string nome, string email, string descricao)
        {
            
        }
        #endregion
    }
}