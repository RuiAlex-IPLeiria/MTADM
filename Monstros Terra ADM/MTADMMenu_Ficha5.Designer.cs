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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbArmas = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRaças = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPersonagens = new System.Windows.Forms.ListBox();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarArmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raçaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRemover = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRemover = new System.Windows.Forms.ToolStripMenuItem();
            this.satusTextDados = new System.Windows.Forms.ToolStripStatusLabel();
            this.textCoutDados = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.statusPrincipal.SuspendLayout();
            this.MenuRemover.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbArmas);
            this.groupBox3.Location = new System.Drawing.Point(444, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 310);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Armas";
            // 
            // lbArmas
            // 
            this.lbArmas.ContextMenuStrip = this.MenuRemover;
            this.lbArmas.FormattingEnabled = true;
            this.lbArmas.Location = new System.Drawing.Point(5, 15);
            this.lbArmas.Name = "lbArmas";
            this.lbArmas.Size = new System.Drawing.Size(200, 290);
            this.lbArmas.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRaças);
            this.groupBox2.Location = new System.Drawing.Point(228, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 310);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Raças";
            // 
            // lbRaças
            // 
            this.lbRaças.ContextMenuStrip = this.MenuRemover;
            this.lbRaças.FormattingEnabled = true;
            this.lbRaças.Location = new System.Drawing.Point(5, 15);
            this.lbRaças.Name = "lbRaças";
            this.lbRaças.Size = new System.Drawing.Size(200, 290);
            this.lbRaças.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPersonagens);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 310);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Personagens";
            // 
            // lbPersonagens
            // 
            this.lbPersonagens.ContextMenuStrip = this.MenuRemover;
            this.lbPersonagens.FormattingEnabled = true;
            this.lbPersonagens.Location = new System.Drawing.Point(5, 15);
            this.lbPersonagens.Name = "lbPersonagens";
            this.lbPersonagens.Size = new System.Drawing.Size(200, 290);
            this.lbPersonagens.TabIndex = 0;
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.dadosToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(665, 24);
            this.menuPrincipal.TabIndex = 10;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satusTextDados,
            this.textCoutDados});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 354);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Size = new System.Drawing.Size(665, 22);
            this.statusPrincipal.TabIndex = 11;
            this.statusPrincipal.Text = "statusPrincipal";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.btn_sair);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarArmaToolStripMenuItem,
            this.raçaToolStripMenuItem,
            this.personagemToolStripMenuItem,
            this.toolStripSeparator1,
            this.removerToolStripMenuItem});
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // adicionarArmaToolStripMenuItem
            // 
            this.adicionarArmaToolStripMenuItem.Name = "adicionarArmaToolStripMenuItem";
            this.adicionarArmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adicionarArmaToolStripMenuItem.Text = "Arma";
            this.adicionarArmaToolStripMenuItem.Click += new System.EventHandler(this.btnAddArma_Click);
            // 
            // raçaToolStripMenuItem
            // 
            this.raçaToolStripMenuItem.Name = "raçaToolStripMenuItem";
            this.raçaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.raçaToolStripMenuItem.Text = "Raça";
            this.raçaToolStripMenuItem.Click += new System.EventHandler(this.btnAddRaca_Click);
            // 
            // personagemToolStripMenuItem
            // 
            this.personagemToolStripMenuItem.Name = "personagemToolStripMenuItem";
            this.personagemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.personagemToolStripMenuItem.Text = "Personagem";
            this.personagemToolStripMenuItem.Click += new System.EventHandler(this.btnAddPersonagem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            this.removerToolStripMenuItem.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // MenuRemover
            // 
            this.MenuRemover.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRemover});
            this.MenuRemover.Name = "MenuRemover";
            this.MenuRemover.Size = new System.Drawing.Size(122, 26);
            // 
            // btnRemover
            // 
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(121, 22);
            this.btnRemover.Text = "Remover";
            // 
            // satusTextDados
            // 
            this.satusTextDados.Name = "satusTextDados";
            this.satusTextDados.Size = new System.Drawing.Size(118, 17);
            this.satusTextDados.Text = "toolStripStatusLabel1";
            // 
            // textCoutDados
            // 
            this.textCoutDados.Name = "textCoutDados";
            this.textCoutDados.Size = new System.Drawing.Size(118, 17);
            this.textCoutDados.Text = "toolStripStatusLabel2";
            // 
            // MTADMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 376);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "MTADMMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monstros Terra ADM";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            this.MenuRemover.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbArmas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbRaças;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbPersonagens;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarArmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raçaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personagemToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip MenuRemover;
        private System.Windows.Forms.ToolStripMenuItem btnRemover;
        private System.Windows.Forms.ToolStripStatusLabel satusTextDados;
        private System.Windows.Forms.ToolStripStatusLabel textCoutDados;
    }
}

