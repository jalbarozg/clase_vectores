namespace AppVector
{
    partial class frmvector
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
            this.blvalor = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.blresultado = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blvalor
            // 
            this.blvalor.AutoSize = true;
            this.blvalor.Location = new System.Drawing.Point(12, 28);
            this.blvalor.Name = "blvalor";
            this.blvalor.Size = new System.Drawing.Size(31, 13);
            this.blvalor.TabIndex = 0;
            this.blvalor.Text = "Valor";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(62, 18);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(197, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // blresultado
            // 
            this.blresultado.AutoSize = true;
            this.blresultado.Location = new System.Drawing.Point(15, 69);
            this.blresultado.Name = "blresultado";
            this.blresultado.Size = new System.Drawing.Size(55, 13);
            this.blresultado.TabIndex = 3;
            this.blresultado.Text = "Resultado";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(18, 105);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            // 
            // frmvector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.blresultado);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.blvalor);
            this.Name = "frmvector";
            this.Text = "Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blvalor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label blresultado;
        private System.Windows.Forms.Button btnmostrar;
    }
}

