namespace Ckeckbox
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chk_uno = new System.Windows.Forms.CheckBox();
            this.chk_dos = new System.Windows.Forms.CheckBox();
            this.chk_tres = new System.Windows.Forms.CheckBox();
            this.chk_cuatro = new System.Windows.Forms.CheckBox();
            this.chk_cinco = new System.Windows.Forms.CheckBox();
            this.chk_seis = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chk_uno
            // 
            this.chk_uno.AutoSize = true;
            this.chk_uno.Location = new System.Drawing.Point(0, 40);
            this.chk_uno.Name = "chk_uno";
            this.chk_uno.Size = new System.Drawing.Size(72, 17);
            this.chk_uno.TabIndex = 1;
            this.chk_uno.Text = "Permiso 1";
            this.chk_uno.UseVisualStyleBackColor = true;
            this.chk_uno.CheckedChanged += new System.EventHandler(this.chk_uno_CheckedChanged);
            // 
            // chk_dos
            // 
            this.chk_dos.AutoSize = true;
            this.chk_dos.Location = new System.Drawing.Point(0, 63);
            this.chk_dos.Name = "chk_dos";
            this.chk_dos.Size = new System.Drawing.Size(72, 17);
            this.chk_dos.TabIndex = 2;
            this.chk_dos.Text = "Permiso 2";
            this.chk_dos.UseVisualStyleBackColor = true;
            this.chk_dos.CheckedChanged += new System.EventHandler(this.chk_dos_CheckedChanged);
            // 
            // chk_tres
            // 
            this.chk_tres.AutoSize = true;
            this.chk_tres.Location = new System.Drawing.Point(0, 86);
            this.chk_tres.Name = "chk_tres";
            this.chk_tres.Size = new System.Drawing.Size(72, 17);
            this.chk_tres.TabIndex = 4;
            this.chk_tres.Text = "Permiso 3";
            this.chk_tres.UseVisualStyleBackColor = true;
            this.chk_tres.CheckedChanged += new System.EventHandler(this.chk_tres_CheckedChanged);
            // 
            // chk_cuatro
            // 
            this.chk_cuatro.AutoSize = true;
            this.chk_cuatro.Location = new System.Drawing.Point(0, 109);
            this.chk_cuatro.Name = "chk_cuatro";
            this.chk_cuatro.Size = new System.Drawing.Size(72, 17);
            this.chk_cuatro.TabIndex = 3;
            this.chk_cuatro.Text = "Permiso 4";
            this.chk_cuatro.UseVisualStyleBackColor = true;
            this.chk_cuatro.CheckedChanged += new System.EventHandler(this.chk_cuatro_CheckedChanged);
            // 
            // chk_cinco
            // 
            this.chk_cinco.AutoSize = true;
            this.chk_cinco.Location = new System.Drawing.Point(0, 132);
            this.chk_cinco.Name = "chk_cinco";
            this.chk_cinco.Size = new System.Drawing.Size(72, 17);
            this.chk_cinco.TabIndex = 6;
            this.chk_cinco.Text = "Permiso 5";
            this.chk_cinco.UseVisualStyleBackColor = true;
            this.chk_cinco.CheckedChanged += new System.EventHandler(this.chk_cinco_CheckedChanged);
            // 
            // chk_seis
            // 
            this.chk_seis.AutoSize = true;
            this.chk_seis.Location = new System.Drawing.Point(0, 155);
            this.chk_seis.Name = "chk_seis";
            this.chk_seis.Size = new System.Drawing.Size(72, 17);
            this.chk_seis.TabIndex = 5;
            this.chk_seis.Text = "Permiso 6";
            this.chk_seis.UseVisualStyleBackColor = true;
            this.chk_seis.CheckedChanged += new System.EventHandler(this.chk_seis_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 174);
            this.Controls.Add(this.chk_cinco);
            this.Controls.Add(this.chk_seis);
            this.Controls.Add(this.chk_tres);
            this.Controls.Add(this.chk_cuatro);
            this.Controls.Add(this.chk_dos);
            this.Controls.Add(this.chk_uno);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chk_uno;
        private System.Windows.Forms.CheckBox chk_dos;
        private System.Windows.Forms.CheckBox chk_tres;
        private System.Windows.Forms.CheckBox chk_cuatro;
        private System.Windows.Forms.CheckBox chk_cinco;
        private System.Windows.Forms.CheckBox chk_seis;
    }
}

