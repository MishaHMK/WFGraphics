
namespace Graphics_RGR
{
    partial class Form1
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
            this.pbResult = new System.Windows.Forms.PictureBox();
            this.bDraw = new System.Windows.Forms.Button();
            this.pDel = new System.Windows.Forms.Button();
            this.saveBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.White;
            this.pbResult.Location = new System.Drawing.Point(18, 21);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(484, 300);
            this.pbResult.TabIndex = 3;
            this.pbResult.TabStop = false;
            this.pbResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbResult_MouseDown);
            this.pbResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbResult_MouseMove);
            this.pbResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbResult_MouseUp);
            // 
            // bDraw
            // 
            this.bDraw.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDraw.BackColor = System.Drawing.Color.DarkGreen;
            this.bDraw.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.bDraw.ForeColor = System.Drawing.SystemColors.Control;
            this.bDraw.Location = new System.Drawing.Point(16, 327);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(111, 44);
            this.bDraw.TabIndex = 12;
            this.bDraw.Text = "Листок";
            this.bDraw.UseVisualStyleBackColor = false;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click_1);
            // 
            // pDel
            // 
            this.pDel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pDel.BackColor = System.Drawing.Color.DarkRed;
            this.pDel.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.pDel.ForeColor = System.Drawing.SystemColors.Control;
            this.pDel.Location = new System.Drawing.Point(391, 327);
            this.pDel.Name = "pDel";
            this.pDel.Size = new System.Drawing.Size(111, 44);
            this.pDel.TabIndex = 13;
            this.pDel.Text = "Видалити";
            this.pDel.UseVisualStyleBackColor = false;
            this.pDel.Click += new System.EventHandler(this.pDel_Click);
            // 
            // saveBut
            // 
            this.saveBut.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveBut.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveBut.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.saveBut.ForeColor = System.Drawing.SystemColors.Control;
            this.saveBut.Location = new System.Drawing.Point(210, 327);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(111, 44);
            this.saveBut.TabIndex = 14;
            this.saveBut.Text = "Зберегти";
            this.saveBut.UseVisualStyleBackColor = false;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(522, 379);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.pDel);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.pbResult);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Гуменюк КН-304 РГР";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Button pDel;
        private System.Windows.Forms.Button saveBut;
    }
}

