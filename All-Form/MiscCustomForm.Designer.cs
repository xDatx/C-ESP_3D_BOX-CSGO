
namespace TGuilit
{
    partial class MiscCustomForm
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
            this.CB_Bunny = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_Bunny
            // 
            this.CB_Bunny.AutoSize = true;
            this.CB_Bunny.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_Bunny.Location = new System.Drawing.Point(13, 22);
            this.CB_Bunny.Name = "CB_Bunny";
            this.CB_Bunny.Size = new System.Drawing.Size(101, 20);
            this.CB_Bunny.TabIndex = 0;
            this.CB_Bunny.Text = "Auto Bunny";
            this.CB_Bunny.UseVisualStyleBackColor = true;
            this.CB_Bunny.CheckedChanged += new System.EventHandler(this.CB_Bunny_CheckedChanged);
            // 
            // MiscCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_Bunny);
            this.Name = "MiscCustomForm";
            this.Size = new System.Drawing.Size(771, 474);
            this.Load += new System.EventHandler(this.MiscCustomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Bunny;
    }
}
