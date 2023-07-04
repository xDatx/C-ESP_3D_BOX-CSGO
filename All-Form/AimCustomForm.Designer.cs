
namespace TGuilit
{
    partial class AimCustomForm
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
            this.CB_Aimbot = new System.Windows.Forms.CheckBox();
            this.CB_Trigger = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CB_Aimbot
            // 
            this.CB_Aimbot.AutoSize = true;
            this.CB_Aimbot.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_Aimbot.Location = new System.Drawing.Point(13, 22);
            this.CB_Aimbot.Name = "CB_Aimbot";
            this.CB_Aimbot.Size = new System.Drawing.Size(74, 20);
            this.CB_Aimbot.TabIndex = 1;
            this.CB_Aimbot.Text = "Aimbot";
            this.CB_Aimbot.UseVisualStyleBackColor = true;
            this.CB_Aimbot.CheckedChanged += new System.EventHandler(this.CB_Aimbot_CheckedChanged);
            // 
            // CB_Trigger
            // 
            this.CB_Trigger.AutoSize = true;
            this.CB_Trigger.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.CB_Trigger.Location = new System.Drawing.Point(13, 77);
            this.CB_Trigger.Name = "CB_Trigger";
            this.CB_Trigger.Size = new System.Drawing.Size(192, 20);
            this.CB_Trigger.TabIndex = 2;
            this.CB_Trigger.Text = "Triggerbot (IsDeveloping)";
            this.CB_Trigger.UseVisualStyleBackColor = true;
            this.CB_Trigger.CheckedChanged += new System.EventHandler(this.CB_Trigger_CheckedChanged);
            // 
            // AimCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CB_Trigger);
            this.Controls.Add(this.CB_Aimbot);
            this.Name = "AimCustomForm";
            this.Size = new System.Drawing.Size(771, 474);
            this.Load += new System.EventHandler(this.AimCustomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CB_Aimbot;
        private System.Windows.Forms.CheckBox CB_Trigger;
    }
}
