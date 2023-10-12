
namespace AtYarisi
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
            this.lblbariyer1 = new System.Windows.Forms.Label();
            this.lblbariyer2 = new System.Windows.Forms.Label();
            this.lblbariyer3 = new System.Windows.Forms.Label();
            this.lblbariyer4 = new System.Windows.Forms.Label();
            this.lblfinish = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.pcrbox1 = new System.Windows.Forms.PictureBox();
            this.pcrbox2 = new System.Windows.Forms.PictureBox();
            this.pcrbox3 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblanlik = new System.Windows.Forms.Label();
            this.lblbaslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbariyer1
            // 
            this.lblbariyer1.BackColor = System.Drawing.Color.Black;
            this.lblbariyer1.Location = new System.Drawing.Point(0, -1);
            this.lblbariyer1.Name = "lblbariyer1";
            this.lblbariyer1.Size = new System.Drawing.Size(1474, 56);
            this.lblbariyer1.TabIndex = 0;
            // 
            // lblbariyer2
            // 
            this.lblbariyer2.BackColor = System.Drawing.Color.Black;
            this.lblbariyer2.Location = new System.Drawing.Point(-1, 159);
            this.lblbariyer2.Name = "lblbariyer2";
            this.lblbariyer2.Size = new System.Drawing.Size(1474, 57);
            this.lblbariyer2.TabIndex = 1;
            // 
            // lblbariyer3
            // 
            this.lblbariyer3.BackColor = System.Drawing.Color.Black;
            this.lblbariyer3.Location = new System.Drawing.Point(-1, 320);
            this.lblbariyer3.Name = "lblbariyer3";
            this.lblbariyer3.Size = new System.Drawing.Size(1474, 55);
            this.lblbariyer3.TabIndex = 1;
            // 
            // lblbariyer4
            // 
            this.lblbariyer4.BackColor = System.Drawing.Color.Black;
            this.lblbariyer4.Location = new System.Drawing.Point(-1, 479);
            this.lblbariyer4.Name = "lblbariyer4";
            this.lblbariyer4.Size = new System.Drawing.Size(1474, 58);
            this.lblbariyer4.TabIndex = 1;
            // 
            // lblfinish
            // 
            this.lblfinish.BackColor = System.Drawing.Color.Black;
            this.lblfinish.Location = new System.Drawing.Point(1400, -4);
            this.lblfinish.Name = "lblfinish";
            this.lblfinish.Size = new System.Drawing.Size(74, 540);
            this.lblfinish.TabIndex = 2;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Crimson;
            this.btnstart.Location = new System.Drawing.Point(120, 605);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(131, 53);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // pcrbox1
            // 
            this.pcrbox1.Image = ((System.Drawing.Image)(resources.GetObject("pcrbox1.Image")));
            this.pcrbox1.Location = new System.Drawing.Point(22, 58);
            this.pcrbox1.Name = "pcrbox1";
            this.pcrbox1.Size = new System.Drawing.Size(158, 98);
            this.pcrbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbox1.TabIndex = 4;
            this.pcrbox1.TabStop = false;
            this.pcrbox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcrbox2
            // 
            this.pcrbox2.Image = ((System.Drawing.Image)(resources.GetObject("pcrbox2.Image")));
            this.pcrbox2.Location = new System.Drawing.Point(22, 219);
            this.pcrbox2.Name = "pcrbox2";
            this.pcrbox2.Size = new System.Drawing.Size(158, 98);
            this.pcrbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbox2.TabIndex = 4;
            this.pcrbox2.TabStop = false;
            this.pcrbox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcrbox3
            // 
            this.pcrbox3.Image = ((System.Drawing.Image)(resources.GetObject("pcrbox3.Image")));
            this.pcrbox3.Location = new System.Drawing.Point(22, 378);
            this.pcrbox3.Name = "pcrbox3";
            this.pcrbox3.Size = new System.Drawing.Size(158, 98);
            this.pcrbox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcrbox3.TabIndex = 4;
            this.pcrbox3.TabStop = false;
            this.pcrbox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblanlik
            // 
            this.lblanlik.BackColor = System.Drawing.Color.Ivory;
            this.lblanlik.Location = new System.Drawing.Point(779, 594);
            this.lblanlik.Name = "lblanlik";
            this.lblanlik.Size = new System.Drawing.Size(477, 81);
            this.lblanlik.TabIndex = 5;
            // 
            // lblbaslik
            // 
            this.lblbaslik.AutoSize = true;
            this.lblbaslik.Location = new System.Drawing.Point(779, 568);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(94, 17);
            this.lblbaslik.TabIndex = 6;
            this.lblbaslik.Text = "CANLI TAKİP:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, 556);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1467, 743);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.lblanlik);
            this.Controls.Add(this.pcrbox3);
            this.Controls.Add(this.pcrbox2);
            this.Controls.Add(this.pcrbox1);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblfinish);
            this.Controls.Add(this.lblbariyer4);
            this.Controls.Add(this.lblbariyer3);
            this.Controls.Add(this.lblbariyer2);
            this.Controls.Add(this.lblbariyer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcrbox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbariyer1;
        private System.Windows.Forms.Label lblbariyer2;
        private System.Windows.Forms.Label lblbariyer3;
        private System.Windows.Forms.Label lblbariyer4;
        private System.Windows.Forms.Label lblfinish;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox pcrbox1;
        private System.Windows.Forms.PictureBox pcrbox2;
        private System.Windows.Forms.PictureBox pcrbox3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblanlik;
        private System.Windows.Forms.Label lblbaslik;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

