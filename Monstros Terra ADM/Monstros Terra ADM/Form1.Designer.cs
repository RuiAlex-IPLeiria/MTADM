namespace Monstros_Terra_ADM
{
    partial class MTADMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MTADMMenu));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbArmas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRaças = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPersonagens = new System.Windows.Forms.ListBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAddArma = new System.Windows.Forms.Button();
            this.btnAddRaca = new System.Windows.Forms.Button();
            this.btnAddPersonagem = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbArmas);
            this.groupBox3.Location = new System.Drawing.Point(444, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 310);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Armas";
            // 
            // lbArmas
            // 
            this.lbArmas.FormattingEnabled = true;
            this.lbArmas.Location = new System.Drawing.Point(5, 15);
            this.lbArmas.Name = "lbArmas";
            this.lbArmas.Size = new System.Drawing.Size(200, 290);
            this.lbArmas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRaças);
            this.groupBox2.Location = new System.Drawing.Point(228, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 310);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Raças";
            // 
            // lbRaças
            // 
            this.lbRaças.FormattingEnabled = true;
            this.lbRaças.Location = new System.Drawing.Point(5, 15);
            this.lbRaças.Name = "lbRaças";
            this.lbRaças.Size = new System.Drawing.Size(200, 290);
            this.lbRaças.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPersonagens);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 310);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Personagens";
            // 
            // lbPersonagens
            // 
            this.lbPersonagens.FormattingEnabled = true;
            this.lbPersonagens.Location = new System.Drawing.Point(5, 15);
            this.lbPersonagens.Name = "lbPersonagens";
            this.lbPersonagens.Size = new System.Drawing.Size(200, 290);
            this.lbPersonagens.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::Monstros_Terra_ADM.Properties.Resources.delete216;
            this.btnRemover.Location = new System.Drawing.Point(554, 12);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(100, 30);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = " Remover";
            this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAddArma
            // 
            this.btnAddArma.Image = ((System.Drawing.Image)(resources.GetObject("btnAddArma.Image")));
            this.btnAddArma.Location = new System.Drawing.Point(224, 12);
            this.btnAddArma.Name = "btnAddArma";
            this.btnAddArma.Size = new System.Drawing.Size(100, 30);
            this.btnAddArma.TabIndex = 7;
            this.btnAddArma.Text = " Arma";
            this.btnAddArma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddArma.UseVisualStyleBackColor = true;
            this.btnAddArma.Click += new System.EventHandler(this.btnAddArma_Click);
            // 
            // btnAddRaca
            // 
            this.btnAddRaca.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRaca.Image")));
            this.btnAddRaca.Location = new System.Drawing.Point(118, 12);
            this.btnAddRaca.Name = "btnAddRaca";
            this.btnAddRaca.Size = new System.Drawing.Size(100, 30);
            this.btnAddRaca.TabIndex = 8;
            this.btnAddRaca.Text = " Raça";
            this.btnAddRaca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRaca.UseVisualStyleBackColor = true;
            this.btnAddRaca.Click += new System.EventHandler(this.btnAddRaca_Click);
            // 
            // btnAddPersonagem
            // 
            this.btnAddPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPersonagem.Image")));
            this.btnAddPersonagem.Location = new System.Drawing.Point(12, 12);
            this.btnAddPersonagem.Name = "btnAddPersonagem";
            this.btnAddPersonagem.Size = new System.Drawing.Size(100, 30);
            this.btnAddPersonagem.TabIndex = 9;
            this.btnAddPersonagem.Text = " Personagem";
            this.btnAddPersonagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPersonagem.UseVisualStyleBackColor = true;
            this.btnAddPersonagem.Click += new System.EventHandler(this.btnAddPersonagem_Click);
            // 
            // MTADMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 378);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAddArma);
            this.Controls.Add(this.btnAddRaca);
            this.Controls.Add(this.btnAddPersonagem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MTADMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monstros Terra ADM";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAddArma;
        private System.Windows.Forms.Button btnAddRaca;
        private System.Windows.Forms.Button btnAddPersonagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbArmas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbRaças;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbPersonagens;
    }
}

