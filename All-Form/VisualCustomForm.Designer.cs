
namespace TGuilit
{
    partial class VisualCustomForm
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
            this.CB_2DESP = new System.Windows.Forms.CheckBox();
            this.CB_Line = new System.Windows.Forms.CheckBox();
            this.CB_RecoilCrosshair = new System.Windows.Forms.CheckBox();
            this.CB_3DESP = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_2DESP
            // 
            this.CB_2DESP.AutoSize = true;
            this.CB_2DESP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_2DESP.Location = new System.Drawing.Point(13, 22);
            this.CB_2DESP.Name = "CB_2DESP";
            this.CB_2DESP.Size = new System.Drawing.Size(68, 20);
            this.CB_2DESP.TabIndex = 0;
            this.CB_2DESP.Text = "2D ESP";
            this.CB_2DESP.UseVisualStyleBackColor = true;
            this.CB_2DESP.CheckedChanged += new System.EventHandler(this.CB_2DESP_CheckedChanged);
            // 
            // CB_Line
            // 
            this.CB_Line.AutoSize = true;
            this.CB_Line.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_Line.Location = new System.Drawing.Point(13, 77);
            this.CB_Line.Name = "CB_Line";
            this.CB_Line.Size = new System.Drawing.Size(78, 20);
            this.CB_Line.TabIndex = 1;
            this.CB_Line.Text = "Line ESP";
            this.CB_Line.UseVisualStyleBackColor = true;
            this.CB_Line.CheckedChanged += new System.EventHandler(this.CB_Line_CheckedChanged);
            // 
            // CB_RecoilCrosshair
            // 
            this.CB_RecoilCrosshair.AutoSize = true;
            this.CB_RecoilCrosshair.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_RecoilCrosshair.Location = new System.Drawing.Point(13, 132);
            this.CB_RecoilCrosshair.Name = "CB_RecoilCrosshair";
            this.CB_RecoilCrosshair.Size = new System.Drawing.Size(132, 20);
            this.CB_RecoilCrosshair.TabIndex = 2;
            this.CB_RecoilCrosshair.Text = "Recoil Crosshair";
            this.CB_RecoilCrosshair.UseVisualStyleBackColor = true;
            this.CB_RecoilCrosshair.CheckedChanged += new System.EventHandler(this.CB_RecoilCrosshair_CheckedChanged);
            // 
            // CB_3DESP
            // 
            this.CB_3DESP.AutoSize = true;
            this.CB_3DESP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_3DESP.Location = new System.Drawing.Point(13, 187);
            this.CB_3DESP.Name = "CB_3DESP";
            this.CB_3DESP.Size = new System.Drawing.Size(68, 20);
            this.CB_3DESP.TabIndex = 3;
            this.CB_3DESP.Text = "3D ESP";
            this.CB_3DESP.UseVisualStyleBackColor = true;
            this.CB_3DESP.CheckedChanged += new System.EventHandler(this.CB_3DESP_CheckedChanged);
            // 
            // VisualCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_3DESP);
            this.Controls.Add(this.CB_RecoilCrosshair);
            this.Controls.Add(this.CB_Line);
            this.Controls.Add(this.CB_2DESP);
            this.Name = "VisualCustomForm";
            this.Size = new System.Drawing.Size(771, 474);
            this.Load += new System.EventHandler(this.VisualCustomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_2DESP;
        private System.Windows.Forms.CheckBox CB_Line;
        private System.Windows.Forms.CheckBox CB_RecoilCrosshair;
        private System.Windows.Forms.CheckBox CB_3DESP;
    }
}
