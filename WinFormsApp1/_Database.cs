using System.Data;
using System.Windows.Forms;
using Кусовая;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class _Database : Form
    {
        public _Database()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(Data.Client1._Name_client, Data.Client1._INN_, Data.Client1._Bank, Data.Client1._Address);

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Text = "Добавление";
            textBox1.Text = "";
            textBox2.Text = "000000000000";
            textBox3.Text = "";
            textBox4.Text = "";
            groupBox1.Visible = true;

            //dataGridView1.Width -= groupBox1.Width;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[1].Value = "000000000000";
            dataGridView1.ReadOnly = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Selected = true;
            row_indx = dataGridView1.RowCount - 1;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            button3.Visible = false;
            dataGridView1.Enabled = false;
        }
        int row_indx;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Text = "Информация о клиенте";
            groupBox1.Visible = true;
            //dataGridView1.Width -= groupBox1.Width;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            row_indx = e.RowIndex;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            button3.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Client client = new Client(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text, textBox4.Text);
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            dataGridView1.Rows[row_indx].Cells[0].Value = client._Name_client;
            dataGridView1.Rows[row_indx].Cells[1].Value = client._INN_;
            dataGridView1.Rows[row_indx].Cells[2].Value = client._Bank;
            dataGridView1.Rows[row_indx].Cells[3].Value = client._Address;
            button3.Visible = true;
            dataGridView1.Enabled = true;
            groupBox1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox2.Text == "000000000000")
            {
                dataGridView1.Rows.RemoveAt(row_indx);
                row_indx--;
                dataGridView1.Enabled = true;
            }
            groupBox1.Visible = false;
            //dataGridView1.Width += groupBox1.Width;
            button3.Visible = true;
        }
    }
}