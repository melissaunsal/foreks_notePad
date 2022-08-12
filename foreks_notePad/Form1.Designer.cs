namespace foreks_notePad
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.undo = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.saveAs = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_titlee = new System.Windows.Forms.TextBox();
            this.data_update_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Update = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.chk_buyuk_kucuk_duyar = new System.Windows.Forms.CheckBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.undo);
            this.panel1.Controls.Add(this.color_btn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.paste);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.copy);
            this.panel1.Controls.Add(this.newFile);
            this.panel1.Controls.Add(this.cut);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1578, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(517, 40);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 14;
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.undo.FlatAppearance.BorderSize = 0;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.undo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.undo.Image = global::foreks_notePad.Properties.Resources.undo_2_icon_icons_com_62896;
            this.undo.Location = new System.Drawing.Point(346, 0);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(141, 130);
            this.undo.TabIndex = 13;
            this.undo.Text = "Undo";
            this.undo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.undo.UseVisualStyleBackColor = false;
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // color_btn
            // 
            this.color_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.color_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.color_btn.FlatAppearance.BorderSize = 0;
            this.color_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.color_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.color_btn.Image = global::foreks_notePad.Properties.Resources.color_palette_brush_paint_icon_193947__1_;
            this.color_btn.Location = new System.Drawing.Point(1066, 0);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(157, 129);
            this.color_btn.TabIndex = 12;
            this.color_btn.Text = " Color\r\n";
            this.color_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.color_btn.UseVisualStyleBackColor = false;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Image = global::foreks_notePad.Properties.Resources.font_color_40448__1_;
            this.button2.Location = new System.Drawing.Point(836, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 128);
            this.button2.TabIndex = 8;
            this.button2.Text = "Font and Size";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paste
            // 
            this.paste.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.paste.FlatAppearance.BorderSize = 0;
            this.paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paste.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.paste.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paste.Image = global::foreks_notePad.Properties.Resources.paste__1_;
            this.paste.Location = new System.Drawing.Point(157, 4);
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(173, 127);
            this.paste.TabIndex = 7;
            this.paste.Text = "Paste";
            this.paste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.paste.UseVisualStyleBackColor = false;
            this.paste.Click += new System.EventHandler(this.button5_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.exit.Image = global::foreks_notePad.Properties.Resources.delete_102866__1_;
            this.exit.Location = new System.Drawing.Point(1353, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(222, 132);
            this.exit.TabIndex = 6;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.copy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copy.Image = global::foreks_notePad.Properties.Resources._1455554314_line_15_icon_icons_com_53330;
            this.copy.Location = new System.Drawing.Point(637, 4);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(161, 129);
            this.copy.TabIndex = 4;
            this.copy.Text = "Copy";
            this.copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // newFile
            // 
            this.newFile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.newFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newFile.FlatAppearance.BorderSize = 0;
            this.newFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newFile.Image = global::foreks_notePad.Properties.Resources.add_file__3_;
            this.newFile.Location = new System.Drawing.Point(3, 4);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(158, 126);
            this.newFile.TabIndex = 0;
            this.newFile.Text = "New File";
            this.newFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.newFile.UseVisualStyleBackColor = false;
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // cut
            // 
            this.cut.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.cut.FlatAppearance.BorderSize = 0;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cut.Image = global::foreks_notePad.Properties.Resources.cut;
            this.cut.Location = new System.Drawing.Point(493, 1);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(154, 130);
            this.cut.TabIndex = 5;
            this.cut.Text = "Cut";
            this.cut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(464, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 64);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOTEPAD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.read.FlatAppearance.BorderSize = 0;
            this.read.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.read.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.read.Location = new System.Drawing.Point(181, 795);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(167, 65);
            this.read.TabIndex = 8;
            this.read.Text = "Save";
            this.read.UseVisualStyleBackColor = false;
            this.read.Click += new System.EventHandler(this.save_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(132, 436);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(754, 351);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.Text = "";
            this.txtMessage.Click += new System.EventHandler(this.txtMessage_Click);
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "sun.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note:";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.delete.Location = new System.Drawing.Point(1257, 791);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(167, 65);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time.Location = new System.Drawing.Point(116, 287);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 30);
            this.time.TabIndex = 14;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // saveAs
            // 
            this.saveAs.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.saveAs.FlatAppearance.BorderSize = 0;
            this.saveAs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.saveAs.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.saveAs.Location = new System.Drawing.Point(643, 793);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(167, 65);
            this.saveAs.TabIndex = 16;
            this.saveAs.Text = "Save As";
            this.saveAs.UseVisualStyleBackColor = false;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Location = new System.Drawing.Point(-5, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1693, 10);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::foreks_notePad.Properties.Resources.calendar_date_month_schedule_icon_218600;
            this.pictureBox2.Location = new System.Drawing.Point(20, 313);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.Image = global::foreks_notePad.Properties.Resources.notepad;
            this.pictureBox1.Location = new System.Drawing.Point(317, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.time_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.time_lbl.Location = new System.Drawing.Point(126, 333);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(99, 32);
            this.time_lbl.TabIndex = 19;
            this.time_lbl.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_titlee
            // 
            this.txt_titlee.Location = new System.Drawing.Point(132, 394);
            this.txt_titlee.Name = "txt_titlee";
            this.txt_titlee.Size = new System.Drawing.Size(754, 26);
            this.txt_titlee.TabIndex = 20;
            this.txt_titlee.Click += new System.EventHandler(this.txt_titlee_Click);
            this.txt_titlee.TextChanged += new System.EventHandler(this.txt_titlee_TextChanged);
            // 
            // data_update_btn
            // 
            this.data_update_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.data_update_btn.FlatAppearance.BorderSize = 0;
            this.data_update_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.data_update_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_update_btn.Location = new System.Drawing.Point(1005, 791);
            this.data_update_btn.Name = "data_update_btn";
            this.data_update_btn.Size = new System.Drawing.Size(181, 65);
            this.data_update_btn.TabIndex = 21;
            this.data_update_btn.Text = "List Update";
            this.data_update_btn.UseVisualStyleBackColor = false;
            this.data_update_btn.Click += new System.EventHandler(this.data_update_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(15, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Title:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1030, 457);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(379, 304);
            this.listBox1.TabIndex = 23;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Update.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Update.Location = new System.Drawing.Point(405, 791);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(167, 65);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1030, 256);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(263, 46);
            this.txt_search.TabIndex = 24;
            // 
            // chk_buyuk_kucuk_duyar
            // 
            this.chk_buyuk_kucuk_duyar.AutoSize = true;
            this.chk_buyuk_kucuk_duyar.Location = new System.Drawing.Point(1030, 313);
            this.chk_buyuk_kucuk_duyar.Name = "chk_buyuk_kucuk_duyar";
            this.chk_buyuk_kucuk_duyar.Size = new System.Drawing.Size(168, 24);
            this.chk_buyuk_kucuk_duyar.TabIndex = 25;
            this.chk_buyuk_kucuk_duyar.Text = "Büyük/küçük duyar";
            this.chk_buyuk_kucuk_duyar.UseVisualStyleBackColor = true;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_find.FlatAppearance.BorderSize = 0;
            this.btn_find.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_find.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_find.Location = new System.Drawing.Point(1304, 257);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(120, 36);
            this.btn_find.TabIndex = 26;
            this.btn_find.Text = "Search";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1569, 872);
            this.ControlBox = false;
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.chk_buyuk_kucuk_duyar);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_update_btn);
            this.Controls.Add(this.txt_titlee);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveAs);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button paste;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button cut;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Button newFile;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_titlee;
        private System.Windows.Forms.Button data_update_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.CheckBox chk_buyuk_kucuk_duyar;
        private System.Windows.Forms.Button btn_find;
    }
}

