namespace MenuStripMovie
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.komediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fantastikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puanVerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avengersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theConjuringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theOthersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harryPotterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yüzüklerinEfendisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.komediToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.fantastikToolStripMenuItem,
            this.puanVerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // komediToolStripMenuItem
            // 
            this.komediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avengersToolStripMenuItem,
            this.xMenToolStripMenuItem});
            this.komediToolStripMenuItem.Name = "komediToolStripMenuItem";
            this.komediToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.komediToolStripMenuItem.Text = "Bilimkurgu";
            this.komediToolStripMenuItem.Click += new System.EventHandler(this.komediToolStripMenuItem_Click);
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theConjuringToolStripMenuItem,
            this.theOthersToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // fantastikToolStripMenuItem
            // 
            this.fantastikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harryPotterToolStripMenuItem,
            this.yüzüklerinEfendisiToolStripMenuItem});
            this.fantastikToolStripMenuItem.Name = "fantastikToolStripMenuItem";
            this.fantastikToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fantastikToolStripMenuItem.Text = "Fantastik";
            // 
            // puanVerToolStripMenuItem
            // 
            this.puanVerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.puanVerToolStripMenuItem.Name = "puanVerToolStripMenuItem";
            this.puanVerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.puanVerToolStripMenuItem.Text = "Puan Ver";
            // 
            // avengersToolStripMenuItem
            // 
            this.avengersToolStripMenuItem.Name = "avengersToolStripMenuItem";
            this.avengersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.avengersToolStripMenuItem.Text = "Avengers Endgame";
            this.avengersToolStripMenuItem.Click += new System.EventHandler(this.avengersToolStripMenuItem_Click);
            // 
            // xMenToolStripMenuItem
            // 
            this.xMenToolStripMenuItem.Name = "xMenToolStripMenuItem";
            this.xMenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xMenToolStripMenuItem.Text = "X Men 3";
            this.xMenToolStripMenuItem.Click += new System.EventHandler(this.xMenToolStripMenuItem_Click);
            // 
            // theConjuringToolStripMenuItem
            // 
            this.theConjuringToolStripMenuItem.Name = "theConjuringToolStripMenuItem";
            this.theConjuringToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theConjuringToolStripMenuItem.Text = "The Conjuring";
            this.theConjuringToolStripMenuItem.Click += new System.EventHandler(this.theConjuringToolStripMenuItem_Click);
            // 
            // theOthersToolStripMenuItem
            // 
            this.theOthersToolStripMenuItem.Name = "theOthersToolStripMenuItem";
            this.theOthersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theOthersToolStripMenuItem.Text = "The Others";
            this.theOthersToolStripMenuItem.Click += new System.EventHandler(this.theOthersToolStripMenuItem_Click);
            // 
            // harryPotterToolStripMenuItem
            // 
            this.harryPotterToolStripMenuItem.Name = "harryPotterToolStripMenuItem";
            this.harryPotterToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.harryPotterToolStripMenuItem.Text = "Harry Potter ve Melez Prens";
            this.harryPotterToolStripMenuItem.Click += new System.EventHandler(this.harryPotterToolStripMenuItem_Click);
            // 
            // yüzüklerinEfendisiToolStripMenuItem
            // 
            this.yüzüklerinEfendisiToolStripMenuItem.Name = "yüzüklerinEfendisiToolStripMenuItem";
            this.yüzüklerinEfendisiToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.yüzüklerinEfendisiToolStripMenuItem.Text = "Yüzüklerin Efendisi Kralın Dönüşü";
            this.yüzüklerinEfendisiToolStripMenuItem.Click += new System.EventHandler(this.yüzüklerinEfendisiToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 299);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(366, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(129, 134);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(500, 217);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(129, 134);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(404, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(533, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Puan";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(641, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Filmler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem komediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avengersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theConjuringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theOthersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fantastikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harryPotterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yüzüklerinEfendisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puanVerToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}

