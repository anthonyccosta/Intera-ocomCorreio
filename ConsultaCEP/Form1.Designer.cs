namespace ConsultaCEP
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
            this.textBoxcep = new System.Windows.Forms.TextBox();
            this.labelcidade = new System.Windows.Forms.Label();
            this.labelendereco = new System.Windows.Forms.Label();
            this.labelbairro = new System.Windows.Forms.Label();
            this.labelestado = new System.Windows.Forms.Label();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxcep
            // 
            this.textBoxcep.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcep.Location = new System.Drawing.Point(12, 25);
            this.textBoxcep.Multiline = true;
            this.textBoxcep.Name = "textBoxcep";
            this.textBoxcep.Size = new System.Drawing.Size(156, 37);
            this.textBoxcep.TabIndex = 0;
            // 
            // labelcidade
            // 
            this.labelcidade.AutoSize = true;
            this.labelcidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcidade.Location = new System.Drawing.Point(12, 84);
            this.labelcidade.Name = "labelcidade";
            this.labelcidade.Size = new System.Drawing.Size(71, 22);
            this.labelcidade.TabIndex = 1;
            this.labelcidade.Text = "Cidade:";
            // 
            // labelendereco
            // 
            this.labelendereco.AutoSize = true;
            this.labelendereco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendereco.Location = new System.Drawing.Point(12, 122);
            this.labelendereco.Name = "labelendereco";
            this.labelendereco.Size = new System.Drawing.Size(89, 22);
            this.labelendereco.TabIndex = 2;
            this.labelendereco.Text = "Endereço:";
            // 
            // labelbairro
            // 
            this.labelbairro.AutoSize = true;
            this.labelbairro.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbairro.Location = new System.Drawing.Point(12, 158);
            this.labelbairro.Name = "labelbairro";
            this.labelbairro.Size = new System.Drawing.Size(65, 22);
            this.labelbairro.TabIndex = 3;
            this.labelbairro.Text = "Bairro:";
            // 
            // labelestado
            // 
            this.labelestado.AutoSize = true;
            this.labelestado.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestado.Location = new System.Drawing.Point(12, 193);
            this.labelestado.Name = "labelestado";
            this.labelestado.Size = new System.Drawing.Size(70, 22);
            this.labelestado.TabIndex = 4;
            this.labelestado.Text = "Estado:";
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(188, 25);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(109, 37);
            this.buttonConsultar.TabIndex = 5;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 243);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.labelestado);
            this.Controls.Add(this.labelbairro);
            this.Controls.Add(this.labelendereco);
            this.Controls.Add(this.labelcidade);
            this.Controls.Add(this.textBoxcep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxcep;
        private System.Windows.Forms.Label labelcidade;
        private System.Windows.Forms.Label labelendereco;
        private System.Windows.Forms.Label labelbairro;
        private System.Windows.Forms.Label labelestado;
        private System.Windows.Forms.Button buttonConsultar;
    }
}

