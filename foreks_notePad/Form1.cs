using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foreks_notePad
{
    public partial class Form1 : Form
    {
        DataTable table;

        string openFilePath = null;
        bool justSaved = false;
        public Form1()
        {
            InitializeComponent();
        }

        int indexRow;


        private void button5_Click(object sender, EventArgs e)
        {


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongDateString();

            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));
            dataGridView1.DataSource = table;

        }

        private void newFile_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;

                if (index > -1)
                {
                    txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                    txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
                }
            }
            else
            {
                MessageBox.Show("There are no recorded notes.", ".:: WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            else
            {
                MessageBox.Show("There are no recorded notes.", ".:: WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (txtMessage.SelectedText != "")

                txtMessage.Cut();
            else if (txtTitle.SelectedText != "")

                txtTitle.Cut();

        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (txtMessage.SelectionLength > 0)

                txtMessage.Copy();
            else if (txtTitle.SelectionLength > 0)
                txtTitle.Copy();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void undo_Click(object sender, EventArgs e)
        {

            if (txtMessage.CanUndo == true)
            {

                txtMessage.Undo();

                txtMessage.ClearUndo();
            }
            else if (txtTitle.CanUndo == true)
            {
                txtTitle.Undo();

                txtTitle.ClearUndo();
            }
        }

        private void time_Click(object sender, EventArgs e)
        {
            // time.Text = DateTime.Now.ToLongDateString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {

                txtMessage.Font = fd.Font;



                txtTitle.Font = fd.Font;



            }
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            txtMessage.SelectionColor = col.Color;
            txtTitle.ForeColor = col.Color;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {

                DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
                newDataRow.Cells[0].Value = txtTitle.Text;
                newDataRow.Cells[1].Value = txtMessage.Text;
            }
            else
            {
                MessageBox.Show("There are no recorded notes.", ".:: WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
         

                txtMessage.Redo();

               
           
        
        }

        private void saveAs_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "text files (*.txt)|*.txt | all files *.* | *.*";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                txtMessage.SaveFile || txtTitle.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);
                txtMessage.SaveFile(savefile.FileName, RichTextBoxStreamType.PlainText);

            }


        }
      
    }

 
    
}
