namespace Monstros_Terra_ADM
{
    partial class AddArmaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArmaForm));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNomeArma = new System.Windows.Forms.TextBox();
            this.upDwnAtaqueArma = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.upDwnDefesaArma = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxDescriçãoAtaque = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnAtaqueArma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnDefesaArma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Monstros_Terra_ADM.Properties.Resources.cancel16;
            this.btnCancelar.Location = new System.Drawing.Point(292, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.Location = new System.Drawing.Point(206, 219);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(80, 30);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = " Inserir";
            this.btnInserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ataque";
            // 
            // txtBoxNomeArma
            // 
            this.txtBoxNomeArma.Location = new System.Drawing.Point(72, 12);
            this.txtBoxNomeArma.Name = "txtBoxNomeArma";
            this.txtBoxNomeArma.Size = new System.Drawing.Size(300, 20);
            this.txtBoxNomeArma.TabIndex = 12;
            this.txtBoxNomeArma.Enter += new System.EventHandler(this.txtBoxNomeArma_Enter);
            // 
            // upDwnAtaqueArma
            // 
            this.upDwnAtaqueArma.Location = new System.Drawing.Point(72, 38);
            this.upDwnAtaqueArma.Name = "upDwnAtaqueArma";
            this.upDwnAtaqueArma.Size = new System.Drawing.Size(50, 20);
            this.upDwnAtaqueArma.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Defesa";
            // 
            // upDwnDefesaArma
            // 
            this.upDwnDefesaArma.Location = new System.Drawing.Point(72, 64);
            this.upDwnDefesaArma.Name = "upDwnDefesaArma";
            this.upDwnDefesaArma.Size = new System.Drawing.Size(50, 20);
            this.upDwnDefesaArma.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxDescriçãoAtaque);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 123);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // txtBoxDescriçãoAtaque
            // 
            this.txtBoxDescriçãoAtaque.Location = new System.Drawing.Point(7, 19);
            this.txtBoxDescriçãoAtaque.Multiline = true;
            this.txtBoxDescriçãoAtaque.Name = "txtBoxDescriçãoAtaque";
            this.txtBoxDescriçãoAtaque.Size = new System.Drawing.Size(347, 98);
            this.txtBoxDescriçãoAtaque.TabIndex = 16;
            // 
            // AddArmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upDwnDefesaArma);
            this.Controls.Add(this.upDwnAtaqueArma);
            this.Controls.Add(this.txtBoxNomeArma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddArmaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Arma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddArmaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.upDwnAtaqueArma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDwnDefesaArma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNomeArma;
        private System.Windows.Forms.NumericUpDown upDwnAtaqueArma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upDwnDefesaArma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxDescriçãoAtaque;
    }
}