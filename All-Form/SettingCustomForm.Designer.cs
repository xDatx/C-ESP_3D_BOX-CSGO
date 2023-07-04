
namespace TGuilit
{
    partial class SettingCustomForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_Rainbow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_Rainbow
            // 
            this.CB_Rainbow.AutoSize = true;
            this.CB_Rainbow.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Rainbow.Location = new System.Drawing.Point(13, 22);
            this.CB_Rainbow.Name = "CB_Rainbow";
            this.CB_Rainbow.Size = new System.Drawing.Size(112, 20);
            this.CB_Rainbow.TabIndex = 0;
            this.CB_Rainbow.Text = "Rainbow Text";
            this.CB_Rainbow.UseVisualStyleBackColor = true;
            this.CB_Rainbow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SettingCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_Rainbow);
            this.Name = "SettingCustomForm";
            this.Size = new System.Drawing.Size(771, 474);
            this.Load += new System.EventHandler(this.SettingCustomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Rainbow;
    }
}
