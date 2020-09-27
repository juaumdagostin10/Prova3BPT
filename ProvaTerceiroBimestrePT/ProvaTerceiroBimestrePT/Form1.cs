using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaTerceiroBimestrePT
{
    public partial class Form1 : Form
    {

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        List<Torcedor> Torcedores = new List<Torcedor>();
        List<Torcedor> TorcedoresFiltro = new List<Torcedor>();
        private String arquivo = @"C:\Users\vibag\source\repos\save1\pessoa.txt ";

        private Torcedor getTorcedor()
        {
            Torcedor umTorcedor = new Torcedor();
            umTorcedor.Nome = tBNomeIncluir.Text;
            umTorcedor.Apelido = tBApelidoIncluir.Text;
            umTorcedor.Time = tBTimeIncluir.Text;
            umTorcedor.DataNasc = dateIncluir.Value;
            try
            {
                umTorcedor.Nota = LerNumericos.LeFloat(tbNotaTimeIncluir.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
            }
            return umTorcedor;
        }

        private Torcedor getTorcedorAlterar()
        {
            Torcedor umTorcedor = new Torcedor();
            umTorcedor.Nome = tbNomeAlterar.Text;
            umTorcedor.Apelido = tBApelidoALterar.Text;
            umTorcedor.Time = tBTimeAlterar.Text;
            umTorcedor.DataNasc = dateAlterar.Value;
            try
            {
                umTorcedor.Nota = LerNumericos.LeFloat(tBNotaTimeAlterar.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
            }
            return umTorcedor;
        }

        private void LimparCampos()
        {
            tBApelidoIncluir.Clear();
            tBNomeIncluir.Clear();
            tbNotaTimeIncluir.Clear();
            tBTimeIncluir.Clear();
            tBTimeAlterar.Clear();
            tBNotaTimeAlterar.Clear();
            tBApelidoALterar.Clear();
            tbNomeAlterar.Clear();

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Torcedor umTorcedor = getTorcedor();
                Torcedores.Add(umTorcedor);
                LimparCampos();
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnProcurarID_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                richTextBox1.AppendText($"{Torcedores[Convert.ToInt16(textBProcurarName.Text)]}\n");
            }
            catch
            {
                MessageBox.Show($"Não existem torcedores!", "Atenção!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();

                Torcedores.Remove(Torcedores[Convert.ToInt16(textBProcurarName.Text)]);

                Torcedor umTorcedor = getTorcedorAlterar();
                Torcedores.Insert(Convert.ToInt32(textBProcurarName.Text), umTorcedor);
                LimparCampos();

                richTextBox1.AppendText(Convert.ToString(umTorcedor));
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //richTextBox1.Clear();
                //Torcedores.Remove(Torcedores[Convert.ToInt16(textBProcurarName.Text)]);
                const string message = "Você realmente deseja excluir?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                    Torcedores.Remove(Torcedores[Convert.ToInt16(textBProcurarName.Text)]);
                }

            }
            catch
            {
                MessageBox.Show($"Atenção não foi possivel excluir!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {


           
        }
    }
}
