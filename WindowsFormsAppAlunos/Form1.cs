using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);
            txtCurso.Text = "";
            txtNome.Text = "";
            txtNome.Focus();
            lblTotal.Text = dgvAlunos.RowCount.ToString();
            MessageBox.Show("Aluno incluído", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);
            lblTotal.Text = dgvAlunos.RowCount.ToString();
            MessageBox.Show("Aluno excluído", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Clear();
            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            dgvAlunos.SelectedCells[0].Value = txtAlteracao.Text;
            MessageBox.Show("Aluno alterado", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {
                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
            }
        }
    }
}
