namespace Cifrado_XOR
{
    partial class preferences
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Val256bits = new System.Windows.Forms.RadioButton();
            this.Val128bits = new System.Windows.Forms.RadioButton();
            this.Val192bits = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ModXor2 = new System.Windows.Forms.RadioButton();
            this.ModXor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Val256bits);
            this.groupBox1.Controls.Add(this.Val128bits);
            this.groupBox1.Controls.Add(this.Val192bits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tamaño de bloque";
            // 
            // Val256bits
            // 
            this.Val256bits.AutoSize = true;
            this.Val256bits.Location = new System.Drawing.Point(6, 65);
            this.Val256bits.Name = "Val256bits";
            this.Val256bits.Size = new System.Drawing.Size(63, 17);
            this.Val256bits.TabIndex = 2;
            this.Val256bits.TabStop = true;
            this.Val256bits.Text = "256 Bits";
            this.Val256bits.UseVisualStyleBackColor = true;
            this.Val256bits.CheckedChanged += new System.EventHandler(this.Val256bits_CheckedChanged);
            // 
            // Val128bits
            // 
            this.Val128bits.AutoSize = true;
            this.Val128bits.Location = new System.Drawing.Point(6, 19);
            this.Val128bits.Name = "Val128bits";
            this.Val128bits.Size = new System.Drawing.Size(63, 17);
            this.Val128bits.TabIndex = 1;
            this.Val128bits.TabStop = true;
            this.Val128bits.Text = "128 Bits";
            this.Val128bits.UseVisualStyleBackColor = true;
            this.Val128bits.CheckedChanged += new System.EventHandler(this.Val128bits_CheckedChanged);
            // 
            // Val192bits
            // 
            this.Val192bits.AutoSize = true;
            this.Val192bits.Location = new System.Drawing.Point(6, 42);
            this.Val192bits.Name = "Val192bits";
            this.Val192bits.Size = new System.Drawing.Size(63, 17);
            this.Val192bits.TabIndex = 0;
            this.Val192bits.TabStop = true;
            this.Val192bits.Text = "192 Bits";
            this.Val192bits.UseVisualStyleBackColor = true;
            this.Val192bits.CheckedChanged += new System.EventHandler(this.Val192bits_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ModXor2);
            this.groupBox2.Controls.Add(this.ModXor);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo de cifrado";
            // 
            // ModXor2
            // 
            this.ModXor2.AutoSize = true;
            this.ModXor2.Location = new System.Drawing.Point(6, 42);
            this.ModXor2.Name = "ModXor2";
            this.ModXor2.Size = new System.Drawing.Size(85, 17);
            this.ModXor2.TabIndex = 1;
            this.ModXor2.TabStop = true;
            this.ModXor2.Text = "Double XOR";
            this.ModXor2.UseVisualStyleBackColor = true;
            this.ModXor2.CheckedChanged += new System.EventHandler(this.ModXor2_CheckedChanged);
            // 
            // ModXor
            // 
            this.ModXor.AutoSize = true;
            this.ModXor.Location = new System.Drawing.Point(6, 19);
            this.ModXor.Name = "ModXor";
            this.ModXor.Size = new System.Drawing.Size(48, 17);
            this.ModXor.TabIndex = 0;
            this.ModXor.TabStop = true;
            this.ModXor.Text = "XOR";
            this.ModXor.UseVisualStyleBackColor = true;
            this.ModXor.CheckedChanged += new System.EventHandler(this.ModXor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "*el double XOR realiza dos rondas de cifrado, \r\nmientras que el XOR solo una.\r\n";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(158, 227);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(75, 23);
            this.saveConfig.TabIndex = 3;
            this.saveConfig.Text = "Guardar";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 262);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "preferences";
            this.Text = "Preferencias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Val256bits;
        private System.Windows.Forms.RadioButton Val128bits;
        private System.Windows.Forms.RadioButton Val192bits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton ModXor2;
        private System.Windows.Forms.RadioButton ModXor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveConfig;
    }
}