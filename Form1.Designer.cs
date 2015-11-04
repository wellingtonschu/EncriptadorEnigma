namespace EncriptografadorEnigma
{
    partial class Enigma
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblRotorIStart = new System.Windows.Forms.Label();
            this.lblRotorIIStart = new System.Windows.Forms.Label();
            this.lblRotorIIIStart = new System.Windows.Forms.Label();
            this.txtRotorIStart = new System.Windows.Forms.TextBox();
            this.txtRotorIIStart = new System.Windows.Forms.TextBox();
            this.txtRotorIIIStart = new System.Windows.Forms.TextBox();
            this.rxtOutput = new System.Windows.Forms.RichTextBox();
            this.rxtInput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(9, 57);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(44, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "Entrada";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(306, 57);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(36, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "Saída";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 187);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encripta";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(93, 187);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decripta";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(525, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblRotorIStart
            // 
            this.lblRotorIStart.AutoSize = true;
            this.lblRotorIStart.Location = new System.Drawing.Point(9, 17);
            this.lblRotorIStart.Name = "lblRotorIStart";
            this.lblRotorIStart.Size = new System.Drawing.Size(47, 13);
            this.lblRotorIStart.TabIndex = 9;
            this.lblRotorIStart.Text = "Chave 1";
            // 
            // lblRotorIIStart
            // 
            this.lblRotorIIStart.AutoSize = true;
            this.lblRotorIIStart.Location = new System.Drawing.Point(62, 17);
            this.lblRotorIIStart.Name = "lblRotorIIStart";
            this.lblRotorIIStart.Size = new System.Drawing.Size(47, 13);
            this.lblRotorIIStart.TabIndex = 10;
            this.lblRotorIIStart.Text = "Chave 2";
            // 
            // lblRotorIIIStart
            // 
            this.lblRotorIIIStart.AutoSize = true;
            this.lblRotorIIIStart.Location = new System.Drawing.Point(115, 17);
            this.lblRotorIIIStart.Name = "lblRotorIIIStart";
            this.lblRotorIIIStart.Size = new System.Drawing.Size(47, 13);
            this.lblRotorIIIStart.TabIndex = 11;
            this.lblRotorIIIStart.Text = "Chave 3";
            // 
            // txtRotorIStart
            // 
            this.txtRotorIStart.Location = new System.Drawing.Point(12, 33);
            this.txtRotorIStart.Name = "txtRotorIStart";
            this.txtRotorIStart.Size = new System.Drawing.Size(32, 20);
            this.txtRotorIStart.TabIndex = 12;
            // 
            // txtRotorIIStart
            // 
            this.txtRotorIIStart.Location = new System.Drawing.Point(65, 33);
            this.txtRotorIIStart.Name = "txtRotorIIStart";
            this.txtRotorIIStart.Size = new System.Drawing.Size(32, 20);
            this.txtRotorIIStart.TabIndex = 13;
            // 
            // txtRotorIIIStart
            // 
            this.txtRotorIIIStart.Location = new System.Drawing.Point(118, 33);
            this.txtRotorIIIStart.Name = "txtRotorIIIStart";
            this.txtRotorIIIStart.Size = new System.Drawing.Size(32, 20);
            this.txtRotorIIIStart.TabIndex = 14;
            // 
            // rxtOutput
            // 
            this.rxtOutput.Location = new System.Drawing.Point(309, 73);
            this.rxtOutput.Name = "rxtOutput";
            this.rxtOutput.Size = new System.Drawing.Size(291, 108);
            this.rxtOutput.TabIndex = 15;
            this.rxtOutput.Text = "";
            // 
            // rxtInput
            // 
            this.rxtInput.Location = new System.Drawing.Point(12, 73);
            this.rxtInput.Name = "rxtInput";
            this.rxtInput.Size = new System.Drawing.Size(291, 108);
            this.rxtInput.TabIndex = 16;
            this.rxtInput.Text = "";
            this.rxtInput.TextChanged += new System.EventHandler(this.rxtInput_TextChanged);
            // 
            // Enigma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 216);
            this.Controls.Add(this.rxtInput);
            this.Controls.Add(this.rxtOutput);
            this.Controls.Add(this.txtRotorIIIStart);
            this.Controls.Add(this.txtRotorIIStart);
            this.Controls.Add(this.txtRotorIStart);
            this.Controls.Add(this.lblRotorIIIStart);
            this.Controls.Add(this.lblRotorIIStart);
            this.Controls.Add(this.lblRotorIStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "Enigma";
            this.Text = "Encriptador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblRotorIStart;
        private System.Windows.Forms.Label lblRotorIIStart;
        private System.Windows.Forms.Label lblRotorIIIStart;
        private System.Windows.Forms.TextBox txtRotorIStart;
        private System.Windows.Forms.TextBox txtRotorIIStart;
        private System.Windows.Forms.TextBox txtRotorIIIStart;
        private System.Windows.Forms.RichTextBox rxtOutput;
        private System.Windows.Forms.RichTextBox rxtInput;

    }
}

