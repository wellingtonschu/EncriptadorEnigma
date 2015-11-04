namespace EncriptografadorEnigma
{
    partial class Encriptografador
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
            this.inicioTextoChave1 = new System.Windows.Forms.TextBox();
            this.inicioTextoChave2 = new System.Windows.Forms.TextBox();
            this.inicioTextoChave3 = new System.Windows.Forms.TextBox();
            this.rxtSaida = new System.Windows.Forms.RichTextBox();
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
            this.btnEncrypt.Click += new System.EventHandler(this.botaoEncriptaClique);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(93, 187);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Decripta";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.botaoDecriptarClique);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(525, 187);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.botaoResetClique);
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
            // inicioTextoChave1
            // 
            this.inicioTextoChave1.Location = new System.Drawing.Point(12, 33);
            this.inicioTextoChave1.Name = "inicioTextoChave1";
            this.inicioTextoChave1.Size = new System.Drawing.Size(32, 20);
            this.inicioTextoChave1.TabIndex = 12;
            // 
            // inicioTextoChave2
            // 
            this.inicioTextoChave2.Location = new System.Drawing.Point(65, 33);
            this.inicioTextoChave2.Name = "inicioTextoChave2";
            this.inicioTextoChave2.Size = new System.Drawing.Size(32, 20);
            this.inicioTextoChave2.TabIndex = 13;
            // 
            // inicioTextoChave3
            // 
            this.inicioTextoChave3.Location = new System.Drawing.Point(118, 33);
            this.inicioTextoChave3.Name = "inicioTextoChave3";
            this.inicioTextoChave3.Size = new System.Drawing.Size(32, 20);
            this.inicioTextoChave3.TabIndex = 14;
            // 
            // rxtSaida
            // 
            this.rxtSaida.Location = new System.Drawing.Point(309, 73);
            this.rxtSaida.Name = "rxtSaida";
            this.rxtSaida.Size = new System.Drawing.Size(291, 108);
            this.rxtSaida.TabIndex = 15;
            this.rxtSaida.Text = "";
            // 
            // rxtInput
            // 
            this.rxtInput.Location = new System.Drawing.Point(12, 73);
            this.rxtInput.Name = "rxtInput";
            this.rxtInput.Size = new System.Drawing.Size(291, 108);
            this.rxtInput.TabIndex = 16;
            this.rxtInput.Text = "";
            this.rxtInput.TextChanged += new System.EventHandler(this.rxtEntradaTextoAlterado);
            // 
            // Encriptografador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 216);
            this.Controls.Add(this.rxtInput);
            this.Controls.Add(this.rxtSaida);
            this.Controls.Add(this.inicioTextoChave3);
            this.Controls.Add(this.inicioTextoChave2);
            this.Controls.Add(this.inicioTextoChave1);
            this.Controls.Add(this.lblRotorIIIStart);
            this.Controls.Add(this.lblRotorIIStart);
            this.Controls.Add(this.lblRotorIStart);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.Name = "Encriptografador";
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
        private System.Windows.Forms.TextBox inicioTextoChave1;
        private System.Windows.Forms.TextBox inicioTextoChave2;
        private System.Windows.Forms.TextBox inicioTextoChave3;
        private System.Windows.Forms.RichTextBox rxtSaida;
        private System.Windows.Forms.RichTextBox rxtInput;

    }
}

