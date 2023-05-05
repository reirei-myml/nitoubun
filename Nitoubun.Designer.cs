
namespace Nitoubun
{
    partial class FrmNitoubun
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConstToubun = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.lblConstCnt = new System.Windows.Forms.Label();
            this.lblPowered = new System.Windows.Forms.Label();
            this.lblConstPowered = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConstToubun
            // 
            this.lblConstToubun.AutoSize = true;
            this.lblConstToubun.Location = new System.Drawing.Point(67, 25);
            this.lblConstToubun.Name = "lblConstToubun";
            this.lblConstToubun.Size = new System.Drawing.Size(134, 37);
            this.lblConstToubun.TabIndex = 0;
            this.lblConstToubun.Text = "2等分を";
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCnt.Location = new System.Drawing.Point(67, 134);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(56, 55);
            this.lblCnt.TabIndex = 1;
            this.lblCnt.Text = "1";
            // 
            // lblConstCnt
            // 
            this.lblConstCnt.AutoSize = true;
            this.lblConstCnt.Location = new System.Drawing.Point(129, 148);
            this.lblConstCnt.Name = "lblConstCnt";
            this.lblConstCnt.Size = new System.Drawing.Size(177, 37);
            this.lblConstCnt.TabIndex = 2;
            this.lblConstCnt.Text = "回　すると";
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPowered.Location = new System.Drawing.Point(67, 261);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(56, 55);
            this.lblPowered.TabIndex = 3;
            this.lblPowered.Text = "2";
            // 
            // lblConstPowered
            // 
            this.lblConstPowered.AutoSize = true;
            this.lblConstPowered.Location = new System.Drawing.Point(129, 275);
            this.lblConstPowered.Name = "lblConstPowered";
            this.lblConstPowered.Size = new System.Drawing.Size(81, 37);
            this.lblConstPowered.TabIndex = 4;
            this.lblConstPowered.Text = "等分";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "になります。";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(67, 475);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(200, 50);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "もう１回！";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(342, 475);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 50);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "リセット";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(976, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "おわり";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(485, 25);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(430, 430);
            this.pBox.TabIndex = 9;
            this.pBox.TabStop = false;
            // 
            // FrmNitoubun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1221, 550);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConstPowered);
            this.Controls.Add(this.lblPowered);
            this.Controls.Add(this.lblConstCnt);
            this.Controls.Add(this.lblCnt);
            this.Controls.Add(this.lblConstToubun);
            this.Controls.Add(this.pBox);
            this.Font = new System.Drawing.Font("UD デジタル 教科書体 NP-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmNitoubun";
            this.Text = "等分";
            this.Load += new System.EventHandler(this.FrmNitoubun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConstToubun;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.Label lblConstCnt;
        private System.Windows.Forms.Label lblPowered;
        private System.Windows.Forms.Label lblConstPowered;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pBox;
    }
}

