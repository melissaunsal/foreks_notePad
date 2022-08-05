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
            this.label1 = new System.Windows.Forms.Label();
            this.read = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.saveAs = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.redo_btn = new System.Windows.Forms.Button();
            this.undo = new System.Windows.Forms.Button();
            this.color_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.paste = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.copy = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.cut = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.redo_btn);
            this.panel1.Controls.Add(this.undo);
            this.panel1.Controls.Add(this.color_btn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.paste);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.copy);
            this.panel1.Controls.Add(this.newFile);
            this.panel1.Controls.Add(this.cut);
            this.panel1.Location = new System.Drawing.Point(-7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1578, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(665, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 82);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOTEPAD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // read
            // 
            this.read.BackColor = System.Drawing.Color.DarkCyan;
            this.read.FlatAppearance.BorderSize = 0;
            this.read.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.read.Location = new System.Drawing.Point(150, 793);
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
            this.label2.Location = new System.Drawing.Point(15, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(977, 791);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkCyan;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(1257, 791);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(167, 65);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(977, 354);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(447, 433);
            this.dataGridView1.TabIndex = 11;
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
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.DarkCyan;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.Update.Location = new System.Drawing.Point(339, 793);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(167, 65);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // saveAs
            // 
            this.saveAs.BackColor = System.Drawing.Color.DarkCyan;
            this.saveAs.FlatAppearance.BorderSize = 0;
            this.saveAs.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.saveAs.Location = new System.Drawing.Point(531, 795);
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(167, 65);
            this.saveAs.TabIndex = 16;
            this.saveAs.Text = "Save As";
            this.saveAs.UseVisualStyleBackColor = false;
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::foreks_notePad.Properties.Resources.calendar_date_month_schedule_icon_218600;
            this.pictureBox2.Location = new System.Drawing.Point(20, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = global::foreks_notePad.Properties.Resources.craft_star_origami_paper_creative_icon_226495__1_;
            this.pictureBox1.Location = new System.Drawing.Point(557, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // redo_btn
            // 
            this.redo_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.redo_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.redo_btn.FlatAppearance.BorderSize = 0;
            this.redo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redo_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.redo_btn.Image = global::foreks_notePad.Properties.Resources.redo_1_icon_icons_com_62889;
            this.redo_btn.Location = new System.Drawing.Point(488, 3);
            this.redo_btn.Name = "redo_btn";
            this.redo_btn.Size = new System.Drawing.Size(148, 123);
            this.redo_btn.TabIndex = 14;
            this.redo_btn.Text = "Redo";
            this.redo_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.redo_btn.UseVisualStyleBackColor = false;
            this.redo_btn.Click += new System.EventHandler(this.redo_btn_Click);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.Color.DarkCyan;
            this.undo.FlatAppearance.BorderSize = 0;
            this.undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
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
            this.color_btn.BackColor = System.Drawing.Color.DarkCyan;
            this.color_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.color_btn.FlatAppearance.BorderSize = 0;
            this.color_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_btn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.color_btn.Image = global::foreks_notePad.Properties.Resources.color_palette_brush_paint_icon_193947__1_;
            this.color_btn.Location = new System.Drawing.Point(1220, 4);
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
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Image = global::foreks_notePad.Properties.Resources.font_color_40448__1_;
            this.button2.Location = new System.Drawing.Point(1004, -1);
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
            this.paste.BackColor = System.Drawing.Color.DarkCyan;
            this.paste.FlatAppearance.BorderSize = 0;
            this.paste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paste.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
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
            this.exit.BackColor = System.Drawing.Color.DarkCyan;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.exit.Image = global::foreks_notePad.Properties.Resources.delete_102866__1_;
            this.exit.Location = new System.Drawing.Point(1374, -1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(201, 132);
            this.exit.TabIndex = 6;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.DarkCyan;
            this.copy.FlatAppearance.BorderSize = 0;
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.copy.Image = global::foreks_notePad.Properties.Resources._1455554314_line_15_icon_icons_com_53330;
            this.copy.Location = new System.Drawing.Point(813, -2);
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
            this.newFile.BackColor = System.Drawing.Color.DarkCyan;
            this.newFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.newFile.FlatAppearance.BorderSize = 0;
            this.newFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newFile.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.cut.BackColor = System.Drawing.Color.DarkCyan;
            this.cut.FlatAppearance.BorderSize = 0;
            this.cut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.cut.Image = global::foreks_notePad.Properties.Resources.cut;
            this.cut.Location = new System.Drawing.Point(632, -1);
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(154, 130);
            this.cut.TabIndex = 5;
            this.cut.Text = "Cut";
            this.cut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cut.UseVisualStyleBackColor = false;
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(132, 354);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(754, 32);
            this.txtTitle.TabIndex = 17;
            this.txtTitle.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1569, 872);
            this.ControlBox = false;
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.saveAs);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button color_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button undo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button saveAs;
        private System.Windows.Forms.Button redo_btn;
        private System.Windows.Forms.RichTextBox txtTitle;
    }
}

