namespace eAgenda_2._0.TelasContato
{
    partial class ListagemContatos
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContatos = new System.Windows.Forms.TabPage();
            this.tabContatosOrdenados = new System.Windows.Forms.TabPage();
            this.listContatosOrdenados = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabContatos.SuspendLayout();
            this.tabContatosOrdenados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(194, 11);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 38);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(103, 11);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 38);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 11);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(72, 39);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // listContatos
            // 
            this.listContatos.ItemHeight = 15;
            this.listContatos.Location = new System.Drawing.Point(5, 4);
            this.listContatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(556, 244);
            this.listContatos.TabIndex = 0;
            this.listContatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listContatos_MouseDoubleClick);
            this.listContatos.MouseHover += new System.EventHandler(this.listContatos_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabContatos);
            this.tabControl1.Controls.Add(this.tabContatosOrdenados);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 273);
            this.tabControl1.TabIndex = 13;
            // 
            // tabContatos
            // 
            this.tabContatos.Controls.Add(this.listContatos);
            this.tabContatos.Location = new System.Drawing.Point(4, 24);
            this.tabContatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabContatos.Name = "tabContatos";
            this.tabContatos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabContatos.Size = new System.Drawing.Size(563, 245);
            this.tabContatos.TabIndex = 0;
            this.tabContatos.Text = "Contatos";
            this.tabContatos.UseVisualStyleBackColor = true;
            // 
            // tabContatosOrdenados
            // 
            this.tabContatosOrdenados.Controls.Add(this.listContatosOrdenados);
            this.tabContatosOrdenados.Location = new System.Drawing.Point(4, 24);
            this.tabContatosOrdenados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabContatosOrdenados.Name = "tabContatosOrdenados";
            this.tabContatosOrdenados.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabContatosOrdenados.Size = new System.Drawing.Size(565, 246);
            this.tabContatosOrdenados.TabIndex = 1;
            this.tabContatosOrdenados.Text = "Contatos ordenados";
            this.tabContatosOrdenados.UseVisualStyleBackColor = true;
            // 
            // listContatosOrdenados
            // 
            this.listContatosOrdenados.ItemHeight = 15;
            this.listContatosOrdenados.Location = new System.Drawing.Point(3, 2);
            this.listContatosOrdenados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listContatosOrdenados.Name = "listContatosOrdenados";
            this.listContatosOrdenados.Size = new System.Drawing.Size(556, 244);
            this.listContatosOrdenados.TabIndex = 1;
            // 
            // ListagemContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 338);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ListagemContatos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Contatos";
            this.tabControl1.ResumeLayout(false);
            this.tabContatos.ResumeLayout(false);
            this.tabContatosOrdenados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabContatos;
        private System.Windows.Forms.TabPage tabContatosOrdenados;
        private System.Windows.Forms.ListBox listContatosOrdenados;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}