namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brochaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pincelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rojoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.figuraToolStripMenuItem,
            this.ordenarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brochaToolStripMenuItem,
            this.pincelToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // brochaToolStripMenuItem
            // 
            this.brochaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.azulToolStripMenuItem,
            this.negroToolStripMenuItem,
            this.blancoToolStripMenuItem,
            this.verdeToolStripMenuItem});
            this.brochaToolStripMenuItem.Name = "brochaToolStripMenuItem";
            this.brochaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.brochaToolStripMenuItem.Text = "Brocha";
            // 
            // azulToolStripMenuItem
            // 
            this.azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            this.azulToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.azulToolStripMenuItem.Text = "Azul";
            this.azulToolStripMenuItem.Click += new System.EventHandler(this.azulToolStripMenuItem_Click);
            // 
            // negroToolStripMenuItem
            // 
            this.negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            this.negroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negroToolStripMenuItem.Text = "Negro";
            this.negroToolStripMenuItem.Click += new System.EventHandler(this.negroToolStripMenuItem_Click);
            // 
            // blancoToolStripMenuItem
            // 
            this.blancoToolStripMenuItem.Name = "blancoToolStripMenuItem";
            this.blancoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blancoToolStripMenuItem.Text = "Blanco";
            this.blancoToolStripMenuItem.Click += new System.EventHandler(this.blancoToolStripMenuItem_Click);
            // 
            // verdeToolStripMenuItem
            // 
            this.verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            this.verdeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verdeToolStripMenuItem.Text = "Verde";
            this.verdeToolStripMenuItem.Click += new System.EventHandler(this.verdeToolStripMenuItem_Click);
            // 
            // pincelToolStripMenuItem
            // 
            this.pincelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blancoToolStripMenuItem1,
            this.rojoToolStripMenuItem,
            this.moradoToolStripMenuItem});
            this.pincelToolStripMenuItem.Name = "pincelToolStripMenuItem";
            this.pincelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pincelToolStripMenuItem.Text = "Pincel";
            // 
            // blancoToolStripMenuItem1
            // 
            this.blancoToolStripMenuItem1.Name = "blancoToolStripMenuItem1";
            this.blancoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.blancoToolStripMenuItem1.Text = "Blanco";
            this.blancoToolStripMenuItem1.Click += new System.EventHandler(this.blancoToolStripMenuItem1_Click);
            // 
            // rojoToolStripMenuItem
            // 
            this.rojoToolStripMenuItem.Name = "rojoToolStripMenuItem";
            this.rojoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rojoToolStripMenuItem.Text = "Rojo";
            this.rojoToolStripMenuItem.Click += new System.EventHandler(this.rojoToolStripMenuItem_Click);
            // 
            // moradoToolStripMenuItem
            // 
            this.moradoToolStripMenuItem.Name = "moradoToolStripMenuItem";
            this.moradoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moradoToolStripMenuItem.Text = "Morado";
            this.moradoToolStripMenuItem.Click += new System.EventHandler(this.moradoToolStripMenuItem_Click);
            // 
            // figuraToolStripMenuItem
            // 
            this.figuraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuadradoToolStripMenuItem,
            this.circuloToolStripMenuItem});
            this.figuraToolStripMenuItem.Name = "figuraToolStripMenuItem";
            this.figuraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.figuraToolStripMenuItem.Text = "Figura";
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.ordenarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(605, 383);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem figuraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brochaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pincelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rojoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moradoToolStripMenuItem;
    }
}

