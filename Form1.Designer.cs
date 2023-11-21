namespace ExamenSB_U2
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
			this.TraducirBtn = new System.Windows.Forms.Button();
			this.LenguajeNaturalLst = new System.Windows.Forms.ListView();
			this.LineNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CodigoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.VisualBasicLst = new System.Windows.Forms.ListView();
			this.LineNumberVB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CodigoHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AbrirBtn = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lenguajeNaturalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lenguajeTraducidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helloWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.declararVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.forToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.numeroAlCuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.LineasTraducidasLbl = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.LineasNTraducidasLb = new System.Windows.Forms.ToolStripStatusLabel();
			this.lstErrores = new System.Windows.Forms.ListView();
			this.ErrorNLinea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ErrorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label3 = new System.Windows.Forms.Label();
			this.compilatBtn = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TraducirBtn
			// 
			this.TraducirBtn.Location = new System.Drawing.Point(352, 27);
			this.TraducirBtn.Name = "TraducirBtn";
			this.TraducirBtn.Size = new System.Drawing.Size(100, 25);
			this.TraducirBtn.TabIndex = 0;
			this.TraducirBtn.Text = "Traducir";
			this.TraducirBtn.UseVisualStyleBackColor = true;
			this.TraducirBtn.Click += new System.EventHandler(this.TraducirBtn_Click);
			// 
			// LenguajeNaturalLst
			// 
			this.LenguajeNaturalLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineNumber,
            this.CodigoHeader});
			this.LenguajeNaturalLst.FullRowSelect = true;
			this.LenguajeNaturalLst.GridLines = true;
			this.LenguajeNaturalLst.HideSelection = false;
			this.LenguajeNaturalLst.Location = new System.Drawing.Point(15, 56);
			this.LenguajeNaturalLst.Name = "LenguajeNaturalLst";
			this.LenguajeNaturalLst.Size = new System.Drawing.Size(253, 217);
			this.LenguajeNaturalLst.TabIndex = 1;
			this.LenguajeNaturalLst.UseCompatibleStateImageBehavior = false;
			this.LenguajeNaturalLst.View = System.Windows.Forms.View.Details;
			this.LenguajeNaturalLst.SelectedIndexChanged += new System.EventHandler(this.LenguajeNaturalLst_SelectedIndexChanged);
			// 
			// LineNumber
			// 
			this.LineNumber.Text = "N.";
			this.LineNumber.Width = 30;
			// 
			// CodigoHeader
			// 
			this.CodigoHeader.Text = "Codigo";
			this.CodigoHeader.Width = 400;
			// 
			// VisualBasicLst
			// 
			this.VisualBasicLst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LineNumberVB,
            this.CodigoHeader1});
			this.VisualBasicLst.FullRowSelect = true;
			this.VisualBasicLst.GridLines = true;
			this.VisualBasicLst.HideSelection = false;
			this.VisualBasicLst.Location = new System.Drawing.Point(352, 56);
			this.VisualBasicLst.Name = "VisualBasicLst";
			this.VisualBasicLst.Size = new System.Drawing.Size(253, 217);
			this.VisualBasicLst.TabIndex = 2;
			this.VisualBasicLst.UseCompatibleStateImageBehavior = false;
			this.VisualBasicLst.View = System.Windows.Forms.View.Details;
			this.VisualBasicLst.SelectedIndexChanged += new System.EventHandler(this.VisualBasicLst_SelectedIndexChanged);
			// 
			// LineNumberVB
			// 
			this.LineNumberVB.Text = "N.";
			this.LineNumberVB.Width = 30;
			// 
			// CodigoHeader1
			// 
			this.CodigoHeader1.Text = "Codigo";
			this.CodigoHeader1.Width = 400;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Lenguaje natural";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(542, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Visual basic";
			// 
			// AbrirBtn
			// 
			this.AbrirBtn.Location = new System.Drawing.Point(167, 27);
			this.AbrirBtn.Name = "AbrirBtn";
			this.AbrirBtn.Size = new System.Drawing.Size(100, 25);
			this.AbrirBtn.TabIndex = 5;
			this.AbrirBtn.Text = "Actualizar entrada";
			this.AbrirBtn.UseVisualStyleBackColor = true;
			this.AbrirBtn.Click += new System.EventHandler(this.AbrirBtn_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.serviciosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(621, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lenguajeNaturalToolStripMenuItem,
            this.lenguajeTraducidoToolStripMenuItem,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// lenguajeNaturalToolStripMenuItem
			// 
			this.lenguajeNaturalToolStripMenuItem.Name = "lenguajeNaturalToolStripMenuItem";
			this.lenguajeNaturalToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.lenguajeNaturalToolStripMenuItem.Text = "Lenguaje natural";
			this.lenguajeNaturalToolStripMenuItem.Click += new System.EventHandler(this.lenguajeNaturalToolStripMenuItem_Click);
			// 
			// lenguajeTraducidoToolStripMenuItem
			// 
			this.lenguajeTraducidoToolStripMenuItem.Name = "lenguajeTraducidoToolStripMenuItem";
			this.lenguajeTraducidoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.lenguajeTraducidoToolStripMenuItem.Text = "Lenguaje traducido";
			this.lenguajeTraducidoToolStripMenuItem.Click += new System.EventHandler(this.lenguajeTraducidoToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// serviciosToolStripMenuItem
			// 
			this.serviciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosToolStripMenuItem});
			this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
			this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.serviciosToolStripMenuItem.Text = "Servicios";
			// 
			// ejemplosToolStripMenuItem
			// 
			this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloWorldToolStripMenuItem,
            this.declararVariableToolStripMenuItem,
            this.forToolStripMenuItem,
            this.whileToolStripMenuItem,
            this.ifToolStripMenuItem,
            this.numeroAlCuadradoToolStripMenuItem});
			this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
			this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.ejemplosToolStripMenuItem.Text = "Ejemplos";
			// 
			// helloWorldToolStripMenuItem
			// 
			this.helloWorldToolStripMenuItem.Name = "helloWorldToolStripMenuItem";
			this.helloWorldToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.helloWorldToolStripMenuItem.Text = "Hello world!";
			this.helloWorldToolStripMenuItem.Click += new System.EventHandler(this.helloWorldToolStripMenuItem_Click);
			// 
			// declararVariableToolStripMenuItem
			// 
			this.declararVariableToolStripMenuItem.Name = "declararVariableToolStripMenuItem";
			this.declararVariableToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.declararVariableToolStripMenuItem.Text = "Declarar variable";
			this.declararVariableToolStripMenuItem.Click += new System.EventHandler(this.declararVariableToolStripMenuItem_Click);
			// 
			// forToolStripMenuItem
			// 
			this.forToolStripMenuItem.Name = "forToolStripMenuItem";
			this.forToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.forToolStripMenuItem.Text = "For";
			this.forToolStripMenuItem.Click += new System.EventHandler(this.forToolStripMenuItem_Click);
			// 
			// whileToolStripMenuItem
			// 
			this.whileToolStripMenuItem.Name = "whileToolStripMenuItem";
			this.whileToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.whileToolStripMenuItem.Text = "While";
			this.whileToolStripMenuItem.Click += new System.EventHandler(this.whileToolStripMenuItem_Click);
			// 
			// ifToolStripMenuItem
			// 
			this.ifToolStripMenuItem.Name = "ifToolStripMenuItem";
			this.ifToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.ifToolStripMenuItem.Text = "If";
			this.ifToolStripMenuItem.Click += new System.EventHandler(this.ifToolStripMenuItem_Click);
			// 
			// numeroAlCuadradoToolStripMenuItem
			// 
			this.numeroAlCuadradoToolStripMenuItem.Name = "numeroAlCuadradoToolStripMenuItem";
			this.numeroAlCuadradoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.numeroAlCuadradoToolStripMenuItem.Text = "Funcion N^2";
			this.numeroAlCuadradoToolStripMenuItem.Click += new System.EventHandler(this.numeroAlCuadradoToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LineasTraducidasLbl,
            this.toolStripStatusLabel3,
            this.LineasNTraducidasLb});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(621, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
			this.toolStripStatusLabel1.Text = "Lineas traducidas";
			// 
			// LineasTraducidasLbl
			// 
			this.LineasTraducidasLbl.Name = "LineasTraducidasLbl";
			this.LineasTraducidasLbl.Size = new System.Drawing.Size(13, 17);
			this.LineasTraducidasLbl.Text = "0";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(115, 17);
			this.toolStripStatusLabel3.Text = "Lineas no traducidas";
			// 
			// LineasNTraducidasLb
			// 
			this.LineasNTraducidasLb.Name = "LineasNTraducidasLb";
			this.LineasNTraducidasLb.Size = new System.Drawing.Size(13, 17);
			this.LineasNTraducidasLb.Text = "0";
			// 
			// lstErrores
			// 
			this.lstErrores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ErrorNLinea,
            this.ErrorColumn});
			this.lstErrores.HideSelection = false;
			this.lstErrores.Location = new System.Drawing.Point(15, 308);
			this.lstErrores.MultiSelect = false;
			this.lstErrores.Name = "lstErrores";
			this.lstErrores.Size = new System.Drawing.Size(590, 117);
			this.lstErrores.TabIndex = 8;
			this.lstErrores.UseCompatibleStateImageBehavior = false;
			this.lstErrores.View = System.Windows.Forms.View.Details;
			this.lstErrores.SelectedIndexChanged += new System.EventHandler(this.lstErrores_SelectedIndexChanged);
			// 
			// ErrorNLinea
			// 
			this.ErrorNLinea.Text = "N.";
			this.ErrorNLinea.Width = 30;
			// 
			// ErrorColumn
			// 
			this.ErrorColumn.Text = "Lista";
			this.ErrorColumn.Width = 600;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 292);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Errores:";
			// 
			// compilatBtn
			// 
			this.compilatBtn.Location = new System.Drawing.Point(530, 279);
			this.compilatBtn.Name = "compilatBtn";
			this.compilatBtn.Size = new System.Drawing.Size(75, 23);
			this.compilatBtn.TabIndex = 10;
			this.compilatBtn.Text = "Compilar";
			this.compilatBtn.UseVisualStyleBackColor = true;
			this.compilatBtn.Click += new System.EventHandler(this.compilatBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 450);
			this.Controls.Add(this.compilatBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lstErrores);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.AbrirBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VisualBasicLst);
			this.Controls.Add(this.LenguajeNaturalLst);
			this.Controls.Add(this.TraducirBtn);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Examen SB";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TraducirBtn;
        private System.Windows.Forms.ListView LenguajeNaturalLst;
        private System.Windows.Forms.ListView VisualBasicLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AbrirBtn;
        private System.Windows.Forms.ColumnHeader CodigoHeader;
        private System.Windows.Forms.ColumnHeader CodigoHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenguajeNaturalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenguajeTraducidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel LineasTraducidasLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel LineasNTraducidasLb;
        private System.Windows.Forms.ToolStripMenuItem helloWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem declararVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroAlCuadradoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader LineNumber;
        private System.Windows.Forms.ColumnHeader LineNumberVB;
        private System.Windows.Forms.ListView lstErrores;
        private System.Windows.Forms.ColumnHeader ErrorColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button compilatBtn;
        private System.Windows.Forms.ColumnHeader ErrorNLinea;
    }
}

