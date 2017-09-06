namespace Cifrado_XOR
{
    partial class main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResult = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.entryBoxTxt = new System.Windows.Forms.TextBox();
            this.keyBoxTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultBoxTxt = new System.Windows.Forms.TextBox();
            this.CipherBtn = new System.Windows.Forms.Button();
            this.DecipherBtn = new System.Windows.Forms.Button();
            this.generateKey = new System.Windows.Forms.Button();
            this.labelBlock = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveResult,
            this.openFile,
            this.exitApp});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // saveResult
            // 
            this.saveResult.Name = "saveResult";
            this.saveResult.Size = new System.Drawing.Size(152, 22);
            this.saveResult.Text = "Guardar";
            this.saveResult.Click += new System.EventHandler(this.saveResult_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(152, 22);
            this.openFile.Text = "Abrir archivo";
            // 
            // exitApp
            // 
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(152, 22);
            this.exitApp.Text = "Salir";
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferenceMenu});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // preferenceMenu
            // 
            this.preferenceMenu.Name = "preferenceMenu";
            this.preferenceMenu.Size = new System.Drawing.Size(152, 22);
            this.preferenceMenu.Text = "Preferencias";
            this.preferenceMenu.Click += new System.EventHandler(this.preferenceMenu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.entryBoxTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texto entrante";
            // 
            // entryBoxTxt
            // 
            this.entryBoxTxt.Location = new System.Drawing.Point(6, 19);
            this.entryBoxTxt.MaxLength = 16777216;
            this.entryBoxTxt.Multiline = true;
            this.entryBoxTxt.Name = "entryBoxTxt";
            this.entryBoxTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entryBoxTxt.Size = new System.Drawing.Size(548, 115);
            this.entryBoxTxt.TabIndex = 0;
            // 
            // keyBoxTxt
            // 
            this.keyBoxTxt.Location = new System.Drawing.Point(58, 173);
            this.keyBoxTxt.Name = "keyBoxTxt";
            this.keyBoxTxt.Size = new System.Drawing.Size(413, 20);
            this.keyBoxTxt.TabIndex = 2;
            this.keyBoxTxt.TextChanged += new System.EventHandler(this.keyBoxTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clave:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultBoxTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // resultBoxTxt
            // 
            this.resultBoxTxt.Location = new System.Drawing.Point(6, 19);
            this.resultBoxTxt.Multiline = true;
            this.resultBoxTxt.Name = "resultBoxTxt";
            this.resultBoxTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBoxTxt.Size = new System.Drawing.Size(548, 155);
            this.resultBoxTxt.TabIndex = 0;
            // 
            // CipherBtn
            // 
            this.CipherBtn.Location = new System.Drawing.Point(12, 385);
            this.CipherBtn.Name = "CipherBtn";
            this.CipherBtn.Size = new System.Drawing.Size(75, 45);
            this.CipherBtn.TabIndex = 5;
            this.CipherBtn.Text = "Cifrar";
            this.CipherBtn.UseVisualStyleBackColor = true;
            this.CipherBtn.Click += new System.EventHandler(this.CipherBtn_Click);
            // 
            // DecipherBtn
            // 
            this.DecipherBtn.Location = new System.Drawing.Point(93, 385);
            this.DecipherBtn.Name = "DecipherBtn";
            this.DecipherBtn.Size = new System.Drawing.Size(75, 45);
            this.DecipherBtn.TabIndex = 6;
            this.DecipherBtn.Text = "Descifrar";
            this.DecipherBtn.UseVisualStyleBackColor = true;
            this.DecipherBtn.Click += new System.EventHandler(this.DecipherBtn_Click);
            // 
            // generateKey
            // 
            this.generateKey.Location = new System.Drawing.Point(477, 172);
            this.generateKey.Name = "generateKey";
            this.generateKey.Size = new System.Drawing.Size(95, 20);
            this.generateKey.TabIndex = 7;
            this.generateKey.Text = "Generar Clave";
            this.generateKey.UseVisualStyleBackColor = true;
            this.generateKey.Click += new System.EventHandler(this.generateKey_Click);
            // 
            // labelBlock
            // 
            this.labelBlock.AutoSize = true;
            this.labelBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlock.Location = new System.Drawing.Point(174, 393);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(149, 24);
            this.labelBlock.TabIndex = 9;
            this.labelBlock.Text = "Tamaño bloque:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.labelBlock);
            this.Controls.Add(this.generateKey);
            this.Controls.Add(this.DecipherBtn);
            this.Controls.Add(this.CipherBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyBoxTxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "main";
            this.Text = "Cifrado XOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResult;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem exitApp;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox entryBoxTxt;
        private System.Windows.Forms.TextBox keyBoxTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CipherBtn;
        private System.Windows.Forms.Button DecipherBtn;
        private System.Windows.Forms.TextBox resultBoxTxt;
        private System.Windows.Forms.Button generateKey;
        private System.Windows.Forms.Label labelBlock;
    }
}

