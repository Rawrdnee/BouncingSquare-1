namespace BouncingSquare
{
    partial class frmBouncingSquare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBouncingSquare));
            this.lblSquareCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSquareCount
            // 
            this.lblSquareCount.AutoSize = true;
            this.lblSquareCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquareCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSquareCount.Location = new System.Drawing.Point(164, 13);
            this.lblSquareCount.Name = "lblSquareCount";
            this.lblSquareCount.Size = new System.Drawing.Size(42, 46);
            this.lblSquareCount.TabIndex = 0;
            this.lblSquareCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count";
            // 
            // pbHeart1
            // 
            this.pbHeart1.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart1.Image")));
            this.pbHeart1.Location = new System.Drawing.Point(39, 74);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(53, 38);
            this.pbHeart1.TabIndex = 3;
            this.pbHeart1.TabStop = false;
            // 
            // pbHeart2
            // 
            this.pbHeart2.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart2.Image")));
            this.pbHeart2.Location = new System.Drawing.Point(96, 74);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(53, 38);
            this.pbHeart2.TabIndex = 4;
            this.pbHeart2.TabStop = false;
            // 
            // pbHeart3
            // 
            this.pbHeart3.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart3.Image")));
            this.pbHeart3.Location = new System.Drawing.Point(153, 74);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(53, 38);
            this.pbHeart3.TabIndex = 5;
            this.pbHeart3.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(31, 126);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(42, 46);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            // 
            // frmBouncingSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(605, 424);
            this.ControlBox = false;
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbHeart3);
            this.Controls.Add(this.pbHeart2);
            this.Controls.Add(this.pbHeart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSquareCount);
            this.KeyPreview = true;
            this.Name = "frmBouncingSquare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSquareCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart3;
        private System.Windows.Forms.Label lblScore;
    }
}

