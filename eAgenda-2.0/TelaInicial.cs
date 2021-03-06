using eAgenda_2._0.TelasCompromisso;
using eAgenda_2._0.TelasContato;
using System;
using System.Windows.Forms;

namespace eAgenda_2._0
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            ListagemTarefas listagemTarefas = new ListagemTarefas();
            listagemTarefas.ShowDialog();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            ListagemContatos listagemContatos = new ListagemContatos();
            listagemContatos.ShowDialog();
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            ListagemCompromissos listagemCompromissos = new ListagemCompromissos();
            listagemCompromissos.ShowDialog();
        }
    }
}
