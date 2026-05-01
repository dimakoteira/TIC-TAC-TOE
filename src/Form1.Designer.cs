namespace TIC_TAC_TOE
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.name1TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name2TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Super Funky", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(237, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 160);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Sprintura Demo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(466, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(299, 94);
            this.button1.TabIndex = 1;
            this.button1.Text = "start the game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PowderBlue;
            this.label2.Location = new System.Drawing.Point(514, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Playes\'s 1 name:";
            // 
            // name1TB
            // 
            this.name1TB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.name1TB.Location = new System.Drawing.Point(465, 279);
            this.name1TB.Name = "name1TB";
            this.name1TB.Size = new System.Drawing.Size(318, 32);
            this.name1TB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PowderBlue;
            this.label3.Location = new System.Drawing.Point(514, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Playes\'s 2 name:";
            // 
            // name2TB
            // 
            this.name2TB.Font = new System.Drawing.Font("Tahoma", 12F);
            this.name2TB.Location = new System.Drawing.Point(465, 393);
            this.name2TB.Name = "name2TB";
            this.name2TB.Size = new System.Drawing.Size(318, 32);
            this.name2TB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TIC_TAC_TOE.Properties.Resources.rm218_bb_07;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1252, 668);
            this.Controls.Add(this.name2TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name1TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name1TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name2TB;
    }
}

