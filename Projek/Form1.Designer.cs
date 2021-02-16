using System;
using System.Windows.Forms;

namespace Goblox
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GenerateBTN = new System.Windows.Forms.Button();
            this.InputState = new System.Windows.Forms.TextBox();
            this.InputDetail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BantuanDetailInput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Instruction1 = new System.Windows.Forms.Label();
            this.akunPengguna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.AutoSize = true;
            this.GenerateBTN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBTN.Location = new System.Drawing.Point(304, 351);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(146, 36);
            this.GenerateBTN.TabIndex = 0;
            this.GenerateBTN.Text = "Luncurkan";
            this.GenerateBTN.UseVisualStyleBackColor = true;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // InputState
            // 
            this.InputState.Location = new System.Drawing.Point(200, 285);
            this.InputState.Multiline = true;
            this.InputState.Name = "InputState";
            this.InputState.Size = new System.Drawing.Size(360, 34);
            this.InputState.TabIndex = 1;
            // 
            // InputDetail
            // 
            this.InputDetail.Location = new System.Drawing.Point(217, 149);
            this.InputDetail.Multiline = true;
            this.InputDetail.Name = "InputDetail";
            this.InputDetail.Size = new System.Drawing.Size(328, 20);
            this.InputDetail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details Presence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "State Presence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BantuanDetailInput
            // 
            this.BantuanDetailInput.AutoSize = true;
            this.BantuanDetailInput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BantuanDetailInput.Location = new System.Drawing.Point(197, 114);
            this.BantuanDetailInput.Name = "BantuanDetailInput";
            this.BantuanDetailInput.Size = new System.Drawing.Size(363, 16);
            this.BantuanDetailInput.TabIndex = 6;
            this.BantuanDetailInput.Text = "Detail yang akan muncul sebagai subjudul dari rich presence.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "State yang akan muncul sebagai isi konten dari rich presence.";
            // 
            // Instruction1
            // 
            this.Instruction1.AutoSize = true;
            this.Instruction1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction1.Location = new System.Drawing.Point(9, 425);
            this.Instruction1.Name = "Instruction1";
            this.Instruction1.Size = new System.Drawing.Size(401, 16);
            this.Instruction1.TabIndex = 8;
            this.Instruction1.Text = "*Aplikasi discord harus terinstall untuk menggunakan rich presence.";
            // 
            // akunPengguna
            // 
            this.akunPengguna.AutoSize = true;
            this.akunPengguna.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akunPengguna.Location = new System.Drawing.Point(505, 423);
            this.akunPengguna.Name = "akunPengguna";
            this.akunPengguna.Size = new System.Drawing.Size(40, 18);
            this.akunPengguna.TabIndex = 9;
            this.akunPengguna.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.akunPengguna);
            this.Controls.Add(this.Instruction1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BantuanDetailInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputDetail);
            this.Controls.Add(this.InputState);
            this.Controls.Add(this.GenerateBTN);
            this.Name = "Indihum Rich Presence Discord";
            this.Text = "Indihum Rich Presence Discord";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateBTN;
        private TextBox InputState;
        private TextBox InputDetail;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label BantuanDetailInput;
        private Label label3;
        private Label Instruction1;
        private Label akunPengguna;
    }
}

