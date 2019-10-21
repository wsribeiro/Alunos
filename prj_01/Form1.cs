using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace prj_01
{
    public partial class Form1 : Form
    {
        public decimal[] g_notas = new decimal[5] { 0.00m, 0.00m, 0.00m, 0.00m, 0.00m };
        public string[] g_lista = new string[] { };
        public string[] g_nome = new string[1] { "sem nome" };
        public string[] g_status = new string[1] { "sem status" };
        public string CRLF = "\x0D\x0A";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            decimal l_resultado = 0;

            l_resultado = 2019 - Convert.ToDecimal(txt_nascimento.Text);
            lbl_idade.Text = l_resultado.ToString() + txt_anos.Text;
            lbl_idade.Visible = true;

            txt_nome.BackColor = Color.GreenYellow;
            txt_nome.Font = new Font(txt_nome.Font, FontStyle.Bold);

        }



        private void btn_nvisivel_Click(object sender, EventArgs e)
        {
            pnl_primeiro.Visible = false;
        }

        private void btn_visivel_Click(object sender, EventArgs e)
        {
            pnl_primeiro.Visible = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nascimento.Clear();
            txt_nome.Clear();
            txt_nome.BackColor = Color.White;
            txt_nome.Font = new Font(txt_nome.Font, FontStyle.Regular);
            lbl_idade.Visible = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            decimal l_resultado = 0;

            l_resultado = 3.1416m * Convert.ToDecimal(txt_raio.Text) * Convert.ToDecimal(txt_raio.Text);
            lbl_resultado.Text = l_resultado.ToString() + lbl_mm2.Text;
            lbl_resultado.Visible = true;
            btn_raio_limpar.Enabled = true;
            btn_calcular.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_raio_limpar_Click(object sender, EventArgs e)
        {
            txt_raio.Clear();
            lbl_resultado.Visible = false;
            btn_calcular.Enabled = true;
            btn_raio_limpar.Enabled = false;
            txt_raio.Text = "0";
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_raio_KeyPress(object sender, KeyPressEventArgs e)
        {
            btn_calcular.Enabled = true;

        }

        private void txt_n1_Leave(object sender, EventArgs e)
        {
            decimal l_n1 = 0;
            l_n1 = Convert.ToDecimal(txt_n1.Text);

            if (l_n1 > 10.0m || l_n1 < 0)
            {
                MessageBox.Show("Insira uma nota válida!");
                txt_n1.Focus();
            }
        }

        private void btn_calcule_array_Click(object sender, EventArgs e)
        {
            {
                if ((txt_n1.Text.Length == 0) ||
                    (txt_n2.Text.Length == 0) ||
                    (txt_n3.Text.Length == 0) ||
                    (txt_n4.Text.Length == 0))
                {
                    MessageBox.Show("Por gentileza, preencha todos os campos", "Não foi possivel calcular", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                    return;
                }

                g_notas[0] = Convert.ToDecimal(txt_n1.Text);
                g_notas[1] = Convert.ToDecimal(txt_n2.Text);
                g_notas[2] = Convert.ToDecimal(txt_n3.Text);
                g_notas[3] = Convert.ToDecimal(txt_n4.Text);
                g_nome[0] = Convert.ToString(txt_name.Text);


                for (int i = 0; i < 4; i++)
                {
                    g_notas[4] = g_notas[4] + g_notas[i];
                }
                g_notas[4] = g_notas[4] / 4;

                string[] name = txt_name.Text.Split(' ');
                label7.Text = "A média de " + name[0] + " é de " + g_notas[4].ToString() + lbl_if2.Text;
                label7.Visible = true;
                label10.Visible = true;
                btn_calcule_array.Enabled = false;
                btn_calcule.Enabled = false;
                btn_media_limpar.Enabled = true;

                if (g_notas[4] <= 3.0m)
                {
                    lbl_status.Text = "Reprovado";
                    g_status[0] = "reprovado";
                }
                else
                {
                    if (g_notas[4] >= 6.0m)
                    {
                        lbl_status.Text = "Aprovado";
                        g_status[0] = "aprovado";
                    }
                    else
                    {
                        lbl_status.Text = "Exame";
                        g_status[0] = "de exame";

                    }
                    label10.Text = "O status de " + name[0] + " é de " + lbl_status.Text;
                }
            }
        }

        private void txt_n2_Leave(object sender, EventArgs e)
        {
            decimal l_n2 = 0;
            l_n2 = Convert.ToDecimal(txt_n2.Text);

            if (l_n2 > 10.0m || l_n2 < 0)
            {
                MessageBox.Show("Insira uma nota válida!");
                txt_n2.Focus();
            }
        }

        private void txt_n3_Leave(object sender, EventArgs e)
        {
            decimal l_n3 = 0;
            l_n3 = Convert.ToDecimal(txt_n3.Text);

            if (l_n3 > 10.0m || l_n3 < 0)
            {
                MessageBox.Show("Insira uma nota válida!");
                txt_n3.Focus();
            }
        }

        private void txt_n4_Leave(object sender, EventArgs e)
        {
            decimal l_n4 = 0;
            l_n4 = Convert.ToDecimal(txt_n4.Text);

            if (l_n4 > 10.0m || l_n4 < 0)
            {
                MessageBox.Show("Insira uma nota válida!");
                txt_n4.Focus();
            }
        }

        private void btn_calcule_Click(object sender, EventArgs e)
        {
            decimal l_media = 0;

            l_media = (Convert.ToDecimal(txt_n1.Text) +
                Convert.ToDecimal(txt_n2.Text) +
                Convert.ToDecimal(txt_n3.Text) +
                Convert.ToDecimal(txt_n4.Text)) / 4;
            lbl_media.Text = l_media.ToString() + lbl_if2.Text;
            lbl_media.Visible = true;
            lbl_status.Visible = true;
            btn_calcule_array.Enabled = false;
            btn_calcule.Enabled = false;
            btn_media_limpar.Enabled = true;



            if (l_media <= 3.0m)
            {
                lbl_status.Text = "Reprovado";
                lbl_status.ForeColor = Color.Red;
            }
            else
            {
                if (l_media >= 6.0m)
                {
                    lbl_status.Text = "Aprovado";
                    lbl_status.ForeColor = Color.GreenYellow;
                }
                else
                {
                    lbl_status.Text = "Exame";
                    lbl_status.ForeColor = Color.Yellow;
                }
            }


        }

        private void btn_media_limpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)

                g_notas[i] = 0.00m;

            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            txt_n4.Clear();
            txt_name.Clear();
            txt_ra.Clear();

            label10.Visible = false;
            label7.Visible = false;
            lbl_status.Visible = false;
            lbl_media.Visible = false;
            btn_calcule_array.Enabled = true;
            btn_calcule.Enabled = true;
            btn_media_limpar.Enabled = false;

        }

        private void Btn_gravar_registro_Click(object sender, EventArgs e)
        {
            int totalra = 6 - txt_ra.TextLength;
            txt_ra.Text = txt_ra.Text.PadLeft(txt_ra.Text.Length + totalra, '0');

            string l_registro = DateTime.Now.ToString();
            l_registro = txt_ra.Text + "|" +
                txt_name.Text + "|" +
                txt_n1.Text + "|" +
                txt_n2.Text + "|" +
                txt_n3.Text + "|" +
                txt_n4.Text + "|" +
                g_notas[4] + "|" +
                lbl_status.Text + "|" + DateTime.Now + "|";

            try
            {
                StreamWriter l_cadastro_alunos = File.AppendText(txt_label_cadastro.Text);
                l_cadastro_alunos.WriteLine(l_registro);
                l_cadastro_alunos.Flush();
                l_cadastro_alunos.Close();
                MessageBox.Show("Registro Gravado com Sucesso.", "Sucesso na Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Deseja adicionar outro aluno?", "Adicionar outro aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i <= 4; i++)

                        g_notas[i] = 0.00m;

                    txt_n1.Clear();
                    txt_n2.Clear();
                    txt_n3.Clear();
                    txt_n4.Clear();
                    txt_name.Clear();
                    txt_ra.Clear();

                    label7.Visible = false;
                    label10.Visible = false;
                    btn_calcule_array.Enabled = true;
                    btn_calcule.Enabled = true;
                    btn_media_limpar.Enabled = false;
                    txt_name.Focus();

                }
                return;

            }


            catch (Exception erro)
            {

                MessageBox.Show("Erro ao tentar gravar cadastro de alunos." + CRLF + CRLF + erro.ToString(), "Falha de Gravação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_ler_registro_Click(object sender, EventArgs e)
        {
            txt_inf_reg.Clear();
            MessageBox.Show("Para visualizar acesse a aba informações.");
            try
            {
                //Cria uma instância do StreamReader para ler o arquivo
                //A declaração using fecha o stream no fim do escopo
                using (StreamReader sr = new StreamReader(txt_label_cadastro.Text))
                {
                    String linha;
                    //Ler e exibe as linhas até alcançar o fim do arquivo.
                    while ((linha = sr.ReadLine()) != null)
                    {
                        txt_inf_reg.Text += linha + Environment.NewLine;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não é possivel ler o arquivo");
                MessageBox.Show(erro.Message);
            }
        }

        private void Btn_mstr_inf_Click(object sender, EventArgs e)
        {
            txt_inf_reg.Clear();
            if (File.Exists(txt_label_cadastro.Text))
            {
                try
                {
                    //Cria uma instância do StreamReader para ler o arquivo
                    //A declaração using fecha o stream no fim do escopo
                    using (StreamReader sr = new StreamReader(txt_label_cadastro.Text))
                    {
                        String linha;
                        //Ler e exibe as linhas até alcançar o fim do arquivo.
                        while ((linha = sr.ReadLine()) != null)
                        {
                            txt_inf_reg.Text += linha + Environment.NewLine;
                        }
                        {

                            decimal l_resultado = 0;
                            decimal l_contador = 0;
                            int l_contrpvd = 0;
                            int l_contapvd = 0;
                            int l_contexm = 0;
                            {
                                string[] information = txt_inf_reg.Text.Split('|');

                                for (int i = 6; i < information.Length; i = i + 9)
                                {
                                    decimal result = Convert.ToDecimal(information[i]);
                                    l_resultado = l_resultado + result;
                                    l_contador++;
                                    if (result <= 3.0m)
                                    {
                                        l_contrpvd++;
                                    }
                                    else
                                    {
                                        if (result >= 6.0m)
                                        {
                                            l_contapvd++;
                                        }
                                        else
                                        {
                                            l_contexm++;
                                        }

                                    }
                                }
                                l_resultado = l_resultado / l_contador;
                            }
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não é possivel ler o arquivo");
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show(" O arquivo " + txt_label_cadastro.Text + " não foi localizado !", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_lista_Click(object sender, EventArgs e)
        {
            lst_aluno.Items.Clear();
            string l_nome;
            if (File.Exists(txt_label_cadastro.Text))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(txt_label_cadastro.Text))
                    {
                        String linha;
                        while ((linha = sr.ReadLine()) != null)
                        {
                            string[] l_lista = linha.Split('|');
                            l_nome = l_lista[1];
                            lst_aluno.Items.Add(l_nome);
                        }
                    }
                }


                catch (Exception erro)
                {
                    MessageBox.Show("Não é possivel ler o arquivo");
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                MessageBox.Show(" O arquivo " + txt_label_cadastro.Text + " não foi localizado !", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txt_inf_reg_DoubleClick(object sender, EventArgs e)
        {
            string[] g2;
            string rrr = txt_inf_reg.Text.Replace(CRLF, "#");
            g2 = rrr.Split('#');
        }

        private void txt_n1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas uma vírgula");
            }

        }

        private void txt_n2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas uma vírgula");
            }

        }

        private void txt_n3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas uma vírgula");
            }

        }

        private void txt_n4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números");
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas uma vírgula");
            }
        }

        private void btn_mstr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string[] g_lista = File.ReadAllLines(txt_label_cadastro.Text);
            for (int i = 0; i < g_lista.Length ; i++)
            {
                string[] l_informacao = g_lista[i].Split('|');
                decimal l_conf = Convert.ToDecimal(l_informacao[6]);

                if (rbtn_aprvd.Checked && l_conf >= 6.0m)
                {
                    dataGridView1.Rows.Add(l_informacao[0], l_informacao[1], l_informacao[6]);
                }
                else
                {
                    if (rbtn_rprvd.Checked && l_conf <= 3.0m)
                    {
                        dataGridView1.Rows.Add(l_informacao[0], l_informacao[1], l_informacao[6]);
                    }
                    else
                    {
                        if (rbtn_exm.Checked && l_conf > 3.0m && l_conf < 6.0m)
                        {
                            dataGridView1.Rows.Add(l_informacao[0], l_informacao[1], l_informacao[6]);
                        } else
                        {
                            if (rbtn_todos.Checked)
                            {
                                dataGridView1.Rows.Add(l_informacao[0], l_informacao[1], l_informacao[6]);
                            }
                        }
                    }
                }
            }
        }

        private void Lst_aluno_DoubleClick(object sender, EventArgs e)
        {
            int l_aluno = lst_aluno.SelectedIndex;
            string[] g_lista = File.ReadAllLines(txt_label_cadastro.Text);
            string[] l_informacao = g_lista[l_aluno].Split('|');
            string[] name = l_informacao[1].Split(' ');
            txt_name.Text = l_informacao[1];
            txt_ra.Text = l_informacao[0];
            txt_n1.Text = l_informacao[2];
            txt_n2.Text = l_informacao[3];
            txt_n3.Text = l_informacao[4];
            txt_n4.Text = l_informacao[5];
            label7.Text = "A média de " + name[0] + " é de " + l_informacao[6].ToString() + lbl_if2.Text;
            label10.Text = "O status de " + name[0] + " é de " + l_informacao[7].ToString();
            label10.Visible = true;
            label7.Visible = true;

            tabControl1.SelectedIndex = 2;

            btn_edt_aln.Visible = true;

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            txt_inf_reg.ReadOnly = false;
            btn_salvar.Enabled = true;
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string l_registro = txt_inf_reg.Text;

            StreamWriter writer = new StreamWriter(txt_label_cadastro.Text);
            writer.Write(l_registro);
            writer.Flush();
            writer.Close();
            txt_inf_reg.ReadOnly = true;
            btn_salvar.Enabled = false;
            MessageBox.Show("Registro Gravado com Sucesso.", "Sucesso na Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[0])//your specific tabname
            {
                this.Size = new Size(577, 274);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])//your specific tabname
            {
                this.Size = new Size(577, 142);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages[2])//your specific tabname
            {
                this.Size = new Size(577, 363);
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages[3])//your specific tabname
            {
                this.Size = new Size(936, 360);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Size = new Size(577, 274);
        }

        private void Btn_edt_aln_Click(object sender, EventArgs e)
        {

            int l_aluno = lst_aluno.SelectedIndex;
            string[] g_lista = File.ReadAllLines(txt_label_cadastro.Text);
            string[] l_informacao = g_lista[l_aluno].Split('|');
            decimal[] l_vatt = new decimal[5] { 0.00m, 0.00m, 0.00m, 0.00m, 0.00m };

            l_vatt[0] = Convert.ToDecimal(txt_n1.Text);
            l_vatt[1] = Convert.ToDecimal(txt_n2.Text);
            l_vatt[2] = Convert.ToDecimal(txt_n3.Text);
            l_vatt[3] = Convert.ToDecimal(txt_n4.Text);

            for (int i = 0; i < 4; i++)
            {
                l_vatt[4] = l_vatt[4] + l_vatt[i];
            }
            l_vatt[4] = l_vatt[4] / 4;

            if (l_vatt[4] <= 3.0m)
            {
                lbl_status.Text = "Reprovado";
                g_status[0] = "Reprovado";
            }
            else
            {
                if (l_vatt[4] >= 6.0m)
                {
                    lbl_status.Text = "Aprovado";
                    g_status[0] = "Aprovado";
                }
                else
                {
                    lbl_status.Text = "Exame";
                    g_status[0] = "Exame";

                }
            }

            string l_registro = txt_ra.Text + "|" +
               txt_name.Text + "|" +
               txt_n1.Text + "|" +
               txt_n2.Text + "|" +
               txt_n3.Text + "|" +
               txt_n4.Text + "|" +
               l_vatt[4].ToString() + "|" + g_status[0].ToString() + "|Editado: " + DateTime.Now + "|";
            g_lista[l_aluno] = l_registro;

            StreamWriter writer = new StreamWriter(txt_label_cadastro.Text);
            for (int i = 0; i < g_lista.Length; i++)
                writer.WriteLine(g_lista[i].ToString());
            writer.Flush();
            writer.Close();

            btn_edt_aln.Visible = false;
            for (int i = 0; i <= 4; i++)

                g_notas[i] = 0.00m;

            txt_n1.Clear();
            txt_n2.Clear();
            txt_n3.Clear();
            txt_n4.Clear();
            txt_name.Clear();
            txt_ra.Clear();
            label10.Visible = false;
            label7.Visible = false;
            lbl_status.Visible = false;
            lbl_media.Visible = false;
            btn_calcule_array.Enabled = true;
            btn_calcule.Enabled = true;
            btn_media_limpar.Enabled = false;
        }
    }
}








