using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultaCEP.WSCorreios;
using Exception = System.Exception;

namespace ConsultaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                // foi colocado um using com o webservice dos correios la emcima para nao ter que usar na hora de instanciar a classe
                AtendeClienteClient correios = new AtendeClienteClient();
                var consulta = correios.consultaCEP(textBoxcep.Text); // o consulta é uma variavel criada para armazenar os dados vindo do site dos correios e o restante é para exibir a busca feita

                labelendereco.Text = consulta.end;
                labelbairro.Text = consulta.bairro;
                labelcidade.Text = consulta.cidade;
                labelestado.Text = consulta.uf;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                
    }
}
