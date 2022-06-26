
namespace Lab6_7
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bDraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudY2 = new System.Windows.Forms.NumericUpDown();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX2 = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.nudY3 = new System.Windows.Forms.NumericUpDown();
            this.nudX3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cDraw = new System.Windows.Forms.Button();
            this.radius = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).BeginInit();
            this.SuspendLayout();
            // 
            // pbResult
            // 
            this.pbResult.BackColor = System.Drawing.Color.White;
            this.pbResult.Location = new System.Drawing.Point(2, 21);
            this.pbResult.Name = "pbResult";
            this.pbResult.Size = new System.Drawing.Size(300, 300);
            this.pbResult.TabIndex = 3;
            this.pbResult.TabStop = false;
            this.pbResult.Click += new System.EventHandler(this.pbResult_Click);
            this.pbResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbResult_MouseDown);
            this.pbResult.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbResult_MouseMove);
            this.pbResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbResult_MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(426, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 40);
            this.label4.TabIndex = 15;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(308, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "2";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(309, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 46);
            this.label2.TabIndex = 14;
            this.label2.Text = "1";
            // 
            // bDraw
            // 
            this.bDraw.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bDraw.BackColor = System.Drawing.Color.SteelBlue;
            this.bDraw.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.bDraw.ForeColor = System.Drawing.SystemColors.Control;
            this.bDraw.Location = new System.Drawing.Point(492, 71);
            this.bDraw.Name = "bDraw";
            this.bDraw.Size = new System.Drawing.Size(111, 44);
            this.bDraw.TabIndex = 12;
            this.bDraw.Text = "Відрізок";
            this.bDraw.UseVisualStyleBackColor = false;
            this.bDraw.Click += new System.EventHandler(this.bDraw_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(351, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // nudY2
            // 
            this.nudY2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudY2.Font = new System.Drawing.Font("Gabriola", 15F);
            this.nudY2.Location = new System.Drawing.Point(410, 97);
            this.nudY2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudY2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nudY2.Name = "nudY2";
            this.nudY2.Size = new System.Drawing.Size(67, 50);
            this.nudY2.TabIndex = 7;
            // 
            // nudY
            // 
            this.nudY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudY.Font = new System.Drawing.Font("Gabriola", 15F);
            this.nudY.Location = new System.Drawing.Point(410, 41);
            this.nudY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudY.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(67, 50);
            this.nudY.TabIndex = 8;
            // 
            // nudX2
            // 
            this.nudX2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudX2.Font = new System.Drawing.Font("Gabriola", 15F);
            this.nudX2.Location = new System.Drawing.Point(337, 97);
            this.nudX2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudX2.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nudX2.Name = "nudX2";
            this.nudX2.Size = new System.Drawing.Size(67, 50);
            this.nudX2.TabIndex = 9;
            // 
            // nudX
            // 
            this.nudX.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudX.Font = new System.Drawing.Font("Gabriola", 15F);
            this.nudX.Location = new System.Drawing.Point(337, 41);
            this.nudX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudX.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(67, 50);
            this.nudX.TabIndex = 10;
            this.nudX.ValueChanged += new System.EventHandler(this.nudX_ValueChanged);
            // 
            // nudY3
            // 
            this.nudY3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudY3.Font = new System.Drawing.Font("Gabriola", 15F);
            this.nudY3.Location = new System.Drawing.Point(410, 224);
            this.nudY3.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudY3.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            -2147483648});
            this.nudY3.Name = "nudY3";
            this.nudY3.Size = new System.Drawing.Size(67, 50);
            this.nudY3.TabIndex = 17;
            // 
            // nudX3
            // 
            this.nudX3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudX3.Font = new System.Drawing.Font("Gabriola", 15F);
            this.nudX3.Location = new System.Drawing.Point(337, 224);
            this.nudX3.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudX3.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            -2147483648});
            this.nudX3.Name = "nudX3";
            this.nudX3.Size = new System.Drawing.Size(67, 50);
            this.nudX3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(426, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(351, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 40);
            this.label6.TabIndex = 19;
            this.label6.Text = "X";
            // 
            // cDraw
            // 
            this.cDraw.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cDraw.BackColor = System.Drawing.Color.SteelBlue;
            this.cDraw.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.cDraw.ForeColor = System.Drawing.SystemColors.Control;
            this.cDraw.Location = new System.Drawing.Point(493, 252);
            this.cDraw.Name = "cDraw";
            this.cDraw.Size = new System.Drawing.Size(111, 44);
            this.cDraw.TabIndex = 21;
            this.cDraw.Text = "Коло";
            this.cDraw.UseVisualStyleBackColor = false;
            this.cDraw.Click += new System.EventHandler(this.cDraw_Click);
            // 
            // radius
            // 
            this.radius.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radius.Font = new System.Drawing.Font("Gabriola", 15F);
            this.radius.Location = new System.Drawing.Point(410, 280);
            this.radius.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.radius.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            -2147483648});
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(67, 50);
            this.radius.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gabriola", 13.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(345, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 40);
            this.label7.TabIndex = 23;
            this.label7.Text = "Радіус";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(616, 379);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radius);
            this.Controls.Add(this.cDraw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudY3);
            this.Controls.Add(this.nudX3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudY2);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.nudX2);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.pbResult);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Гуменюк КН-304 Лаб 6-7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudY2;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX2;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.NumericUpDown nudY3;
        private System.Windows.Forms.NumericUpDown nudX3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cDraw;
        private System.Windows.Forms.NumericUpDown radius;
        private System.Windows.Forms.Label label7;
    }
}

