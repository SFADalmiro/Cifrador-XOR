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
            this.saveConfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(154, 118);
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
            this.ClientSize = new System.Drawing.Size(241, 149);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.groupBox1);
            this.Name = "preferences";
            this.Text = "Preferencias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Val256bits;
        private System.Windows.Forms.RadioButton Val128bits;
        private System.Windows.Forms.RadioButton Val192bits;
        private System.Windows.Forms.Button saveConfig;
    }
}