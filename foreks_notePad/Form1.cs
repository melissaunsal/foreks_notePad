using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace foreks_notePad
{
    public partial class Form1 : Form
    {

        string folderName;
        string openFilePath = null;
        bool justSaved = false;
        String path = String.Empty;
        public Form1()
        {

            InitializeComponent();

        }



        public string bul;
        public int Buyuk_Kucuk_Esle = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
               
               
                txtMessage.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();

      
               
            }
         }
        public Form1(string openWithPath)
        {
           

            if (openWithPath != string.Empty)
            {
                openFilePath = openWithPath;
                //Open the file
                try
                {
                    txtMessage.LoadFile(openFilePath, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    txtMessage.LoadFile(openFilePath, RichTextBoxStreamType.PlainText);
                }

                this.Text = openFilePath;
            }

            justSaved = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            DirectoryInfo dinfo = new DirectoryInfo(@"C:\\Users\\ADMIN\\Documents\\Visual Studio 2017\\Backup Files\\foreks_notePad\\empy");
            //  listBox1.DataSource = Directory.GetDirectories(rootDirectory)
            //.Select(Path.GetFileName).ToList();
            //  listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            folderName = dinfo.FullName;
            foreach (FileInfo file in Files)
            {
                listBox1.Items.Add(file.Name);
                
            }
          
            timer1.Start();
            //FillGrid();
         

        }
       

        private void newFile_Click(object sender, EventArgs e)
        {
       
            txtMessage.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (txt_titlee.Text == "")
            {

                MessageBox.Show("It cannot be blank.");

                return;
            }
               else if (txt_titlee.Text != null)
            {
            
                StreamWriter sw = new StreamWriter(@"C: \Users\ADMIN\Documents\Visual Studio 2017\Backup Files\foreks_notePad\empy\" + txt_titlee.Text + ".txt", true);

                sw.WriteLine(txtMessage.Text);
      
                sw.Close();
              
                txtMessage.Clear();
                txt_titlee.Clear();
         
    
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
    



        }
        void AramaTemizle()
        {
            // Bulunan kelimenin arkaplan rengini değiştirdiğimiz için, aramayı temizle işlemi gerekiyor.
            txtMessage.SelectionStart = 0;
            txtMessage.SelectAll();
            txtMessage.SelectionBackColor = Color.White;
        }

        private void delete_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
              
                string filepath = Path.Combine(folderName, listBox1.Items[listBox1.SelectedIndex].ToString());
                if (File.Exists(filepath))
                    File.Delete(filepath);

                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
              
            }

        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (txtMessage.SelectedText != "")

                txtMessage.Cut();
           else  if (txt_titlee.SelectedText != "")

                txt_titlee.Cut();

        }

        private void copy_Click(object sender, EventArgs e)
        {
            if (txtMessage.SelectionLength > 0)

                txtMessage.Copy();
            else if (txt_titlee.SelectionLength > 0)
                txt_titlee.Copy();

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
            else if(txt_titlee.CanUndo==true)
            {
                txt_titlee.Undo();
                txt_titlee.ClearUndo();
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



               



            }
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
     
            txtMessage.SelectionColor = col.Color;
     


        }

        private void Update_Click(object sender, EventArgs e)
        {
 
     

        }

        private void redo_btn_Click(object sender, EventArgs e)
        {


            txtMessage.Redo();

               
           
        
        }

        private void saveAs_Click(object sender, EventArgs e)
        {

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*|doc files (*.doc)|*.doc|docx files (*.docx)|*.docx";
            saveFileDialog1.FilterIndex = 4;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                file.WriteLine(txtMessage.Text);
                file.Close();
            }

        }

        private void txt_read_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            bool justSaved = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.time_lbl.Text = dateTime.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_update_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\\Users\\ADMIN\\Documents\\Visual Studio 2017\\Backup Files\\foreks_notePad\\empy");

            FileInfo[] Files = dinfo.GetFiles("*.txt");
            folderName = dinfo.FullName;
            foreach (FileInfo file in Files)
            {
                listBox1.Items.Add(file.Name);


            }

        }
            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

         


        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    txtMessage.LoadFile(op.FileName, RichTextBoxStreamType.RichText);
                }
                catch (Exception ex)
                {
                    txtMessage.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                }

                justSaved = true;
                op.FileName = txt_titlee.Text;
                openFilePath = op.FileName;
                this.Text = op.FileName;
            }

        }

        private void txt_titlee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_titlee_Click(object sender, EventArgs e)
        {

        }

        private void txtMessage_Click(object sender, EventArgs e)
        {

        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            bul = txt_search.Text;
            if (chk_buyuk_kucuk_duyar.CheckState == CheckState.Checked)
                Buyuk_Kucuk_Esle = 1;

            AramaTemizle(); 
            string kelime = txt_search.Text;

         
            Regex reg;
            if (Buyuk_Kucuk_Esle == 1)
                reg = new Regex(kelime); // Büyük küçük eşleşmesine bakılır.
            else
                reg = new Regex(kelime, RegexOptions.IgnoreCase); // IgnoreCase büyük küçük eşleşmeye bakmamasını söyler.

            int sayac = 0;
            foreach (Match find in reg.Matches(txtMessage.Text))
            {
                txtMessage.Select(find.Index, find.Length);
                txtMessage.SelectionBackColor = Color.Yellow;
                sayac++;
            }
            if (sayac == 0)
            {
       
                MessageBox.Show("Metin içerisinde ( " + kelime + " ) bulunamadı.");
            }
            else
            {
                MessageBox.Show("Metin içerisinde ( " + kelime + " )  " + sayac + " adet bulundu.");
            }
        }
    }

 
    
}
