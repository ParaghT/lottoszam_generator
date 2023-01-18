namespace Lottó_szám_generátor
{
    partial class Form1
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
            this.num_1 = new System.Windows.Forms.Label();
            this.num_5 = new System.Windows.Forms.Label();
            this.num_4 = new System.Windows.Forms.Label();
            this.num_3 = new System.Windows.Forms.Label();
            this.num_2 = new System.Windows.Forms.Label();
            this.generalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num_1
            // 
            this.num_1.AutoSize = true;
            this.num_1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_1.Location = new System.Drawing.Point(111, 170);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(39, 54);
            this.num_1.TabIndex = 0;
            this.num_1.Text = "-";
            // 
            // num_5
            // 
            this.num_5.AutoSize = true;
            this.num_5.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_5.Location = new System.Drawing.Point(632, 170);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(39, 54);
            this.num_5.TabIndex = 1;
            this.num_5.Text = "-";
            this.num_5.Click += new System.EventHandler(this.label2_Click);
            // 
            // num_4
            // 
            this.num_4.AutoSize = true;
            this.num_4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_4.Location = new System.Drawing.Point(510, 170);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(39, 54);
            this.num_4.TabIndex = 2;
            this.num_4.Text = "-";
            // 
            // num_3
            // 
            this.num_3.AutoSize = true;
            this.num_3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_3.Location = new System.Drawing.Point(381, 170);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(39, 54);
            this.num_3.TabIndex = 3;
            this.num_3.Text = "-";
            // 
            // num_2
            // 
            this.num_2.AutoSize = true;
            this.num_2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_2.Location = new System.Drawing.Point(233, 170);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(39, 54);
            this.num_2.TabIndex = 4;
            this.num_2.Text = "-";
            // 
            // generalas
            // 
            this.generalas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.generalas.Location = new System.Drawing.Point(199, 292);
            this.generalas.Name = "generalas";
            this.generalas.Size = new System.Drawing.Size(398, 79);
            this.generalas.TabIndex = 5;
            this.generalas.Text = "GENERÁLÁS";
            this.generalas.UseVisualStyleBackColor = true;
            this.generalas.Click += new System.EventHandler(this.generalas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.generalas);
            this.Controls.Add(this.num_2);
            this.Controls.Add(this.num_3);
            this.Controls.Add(this.num_4);
            this.Controls.Add(this.num_5);
            this.Controls.Add(this.num_1);
            this.Name = "Form1";
            this.Text = "Lottó szám generátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label num_1;
        private Label num_5;
        private Label num_4;
        private Label num_3;
        private Label num_2;
        private Button generalas;
    }
}