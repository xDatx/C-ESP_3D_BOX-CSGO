
namespace TGuilit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Pan_DLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PN_Slec = new System.Windows.Forms.Panel();
            this.PN_Setting = new System.Windows.Forms.Button();
            this.BTN_Misc = new System.Windows.Forms.Button();
            this.BTN_Visual = new System.Windows.Forms.Button();
            this.BTN_Aim = new System.Windows.Forms.Button();
            this.Pan_DTop = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Timer(this.components);
            this.RainText = new System.Windows.Forms.Timer(this.components);
            this.End_Button = new System.Windows.Forms.Button();
            this.visualCustomForm1 = new TGuilit.VisualCustomForm();
            this.miscCustomForm1 = new TGuilit.MiscCustomForm();
            this.aimCustomForm1 = new TGuilit.AimCustomForm();
            this.firstCustomControl1 = new TGuilit.SettingCustomForm();
            this.Pan_DLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pan_DLeft
            // 
            this.Pan_DLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Pan_DLeft.Controls.Add(this.pictureBox1);
            this.Pan_DLeft.Controls.Add(this.PN_Slec);
            this.Pan_DLeft.Controls.Add(this.PN_Setting);
            this.Pan_DLeft.Controls.Add(this.BTN_Misc);
            this.Pan_DLeft.Controls.Add(this.BTN_Visual);
            this.Pan_DLeft.Controls.Add(this.BTN_Aim);
            this.Pan_DLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pan_DLeft.Location = new System.Drawing.Point(0, 0);
            this.Pan_DLeft.Name = "Pan_DLeft";
            this.Pan_DLeft.Size = new System.Drawing.Size(194, 539);
            this.Pan_DLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TGuilit.Properties.Resources.fox;
            this.pictureBox1.Location = new System.Drawing.Point(45, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PN_Slec
            // 
            this.PN_Slec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(163)))), ((int)(((byte)(32)))));
            this.PN_Slec.Location = new System.Drawing.Point(0, 94);
            this.PN_Slec.Name = "PN_Slec";
            this.PN_Slec.Size = new System.Drawing.Size(10, 54);
            this.PN_Slec.TabIndex = 2;
            // 
            // PN_Setting
            // 
            this.PN_Setting.FlatAppearance.BorderSize = 0;
            this.PN_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PN_Setting.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.PN_Setting.ForeColor = System.Drawing.Color.White;
            this.PN_Setting.Image = global::TGuilit.Properties.Resources.setting_icon_25px;
            this.PN_Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PN_Setting.Location = new System.Drawing.Point(15, 337);
            this.PN_Setting.Name = "PN_Setting";
            this.PN_Setting.Size = new System.Drawing.Size(179, 54);
            this.PN_Setting.TabIndex = 5;
            this.PN_Setting.Text = "           Settings";
            this.PN_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PN_Setting.UseVisualStyleBackColor = true;
            this.PN_Setting.Click += new System.EventHandler(this.PN_Setting_Click);
            // 
            // BTN_Misc
            // 
            this.BTN_Misc.FlatAppearance.BorderSize = 0;
            this.BTN_Misc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Misc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_Misc.ForeColor = System.Drawing.Color.White;
            this.BTN_Misc.Image = global::TGuilit.Properties.Resources.lightning_01__1_;
            this.BTN_Misc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Misc.Location = new System.Drawing.Point(15, 254);
            this.BTN_Misc.Name = "BTN_Misc";
            this.BTN_Misc.Size = new System.Drawing.Size(179, 54);
            this.BTN_Misc.TabIndex = 4;
            this.BTN_Misc.Text = "           Misc";
            this.BTN_Misc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Misc.UseVisualStyleBackColor = true;
            this.BTN_Misc.Click += new System.EventHandler(this.BTN_Misc_Click);
            // 
            // BTN_Visual
            // 
            this.BTN_Visual.FlatAppearance.BorderSize = 0;
            this.BTN_Visual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Visual.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_Visual.ForeColor = System.Drawing.Color.White;
            this.BTN_Visual.Image = global::TGuilit.Properties.Resources.pngaaa_com_448848__1_;
            this.BTN_Visual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Visual.Location = new System.Drawing.Point(15, 175);
            this.BTN_Visual.Name = "BTN_Visual";
            this.BTN_Visual.Size = new System.Drawing.Size(179, 54);
            this.BTN_Visual.TabIndex = 3;
            this.BTN_Visual.Text = "           Visual";
            this.BTN_Visual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Visual.UseVisualStyleBackColor = true;
            this.BTN_Visual.Click += new System.EventHandler(this.BTN_Visual_Click);
            // 
            // BTN_Aim
            // 
            this.BTN_Aim.FlatAppearance.BorderSize = 0;
            this.BTN_Aim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Aim.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.BTN_Aim.ForeColor = System.Drawing.Color.White;
            this.BTN_Aim.Image = global::TGuilit.Properties.Resources.icons8_aim_25;
            this.BTN_Aim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Aim.Location = new System.Drawing.Point(15, 94);
            this.BTN_Aim.Name = "BTN_Aim";
            this.BTN_Aim.Size = new System.Drawing.Size(179, 54);
            this.BTN_Aim.TabIndex = 2;
            this.BTN_Aim.Text = "           Aim";
            this.BTN_Aim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Aim.UseVisualStyleBackColor = true;
            this.BTN_Aim.Click += new System.EventHandler(this.BTN_Aim_Click);
            // 
            // Pan_DTop
            // 
            this.Pan_DTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(163)))), ((int)(((byte)(32)))));
            this.Pan_DTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pan_DTop.Location = new System.Drawing.Point(194, 0);
            this.Pan_DTop.Name = "Pan_DTop";
            this.Pan_DTop.Size = new System.Drawing.Size(771, 10);
            this.Pan_DTop.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.Interval = 10;
            this.SidePanel.Tick += new System.EventHandler(this.SidePanel_Tick);
            // 
            // RainText
            // 
            this.RainText.Enabled = true;
            this.RainText.Interval = 1;
            this.RainText.Tick += new System.EventHandler(this.RainText_Tick);
            // 
            // End_Button
            // 
            this.End_Button.FlatAppearance.BorderSize = 0;
            this.End_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.End_Button.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.End_Button.ForeColor = System.Drawing.Color.White;
            this.End_Button.Image = global::TGuilit.Properties.Resources.pngwing_com__2_;
            this.End_Button.Location = new System.Drawing.Point(917, 17);
            this.End_Button.Name = "End_Button";
            this.End_Button.Size = new System.Drawing.Size(36, 34);
            this.End_Button.TabIndex = 2;
            this.End_Button.UseVisualStyleBackColor = true;
            this.End_Button.Click += new System.EventHandler(this.End_Button_Click);
            // 
            // visualCustomForm1
            // 
            this.visualCustomForm1.Location = new System.Drawing.Point(194, 65);
            this.visualCustomForm1.Name = "visualCustomForm1";
            this.visualCustomForm1.Size = new System.Drawing.Size(771, 474);
            this.visualCustomForm1.TabIndex = 6;
            // 
            // miscCustomForm1
            // 
            this.miscCustomForm1.Location = new System.Drawing.Point(194, 62);
            this.miscCustomForm1.Name = "miscCustomForm1";
            this.miscCustomForm1.Size = new System.Drawing.Size(771, 474);
            this.miscCustomForm1.TabIndex = 5;
            // 
            // aimCustomForm1
            // 
            this.aimCustomForm1.Location = new System.Drawing.Point(194, 65);
            this.aimCustomForm1.Name = "aimCustomForm1";
            this.aimCustomForm1.Size = new System.Drawing.Size(771, 474);
            this.aimCustomForm1.TabIndex = 4;
            // 
            // firstCustomControl1
            // 
            this.firstCustomControl1.Location = new System.Drawing.Point(194, 65);
            this.firstCustomControl1.Name = "firstCustomControl1";
            this.firstCustomControl1.Size = new System.Drawing.Size(771, 474);
            this.firstCustomControl1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(965, 539);
            this.Controls.Add(this.visualCustomForm1);
            this.Controls.Add(this.miscCustomForm1);
            this.Controls.Add(this.aimCustomForm1);
            this.Controls.Add(this.firstCustomControl1);
            this.Controls.Add(this.End_Button);
            this.Controls.Add(this.Pan_DTop);
            this.Controls.Add(this.Pan_DLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TGuilit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Pan_DLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pan_DLeft;
        private System.Windows.Forms.Button BTN_Aim;
        private System.Windows.Forms.Panel Pan_DTop;
        private System.Windows.Forms.Button PN_Setting;
        private System.Windows.Forms.Button BTN_Misc;
        private System.Windows.Forms.Button BTN_Visual;
        private System.Windows.Forms.Panel PN_Slec;
        private System.Windows.Forms.Button End_Button;
        private SettingCustomForm firstCustomControl1;
        private System.Windows.Forms.Timer SidePanel;
        public System.Windows.Forms.Timer RainText;
        private AimCustomForm aimCustomForm1;
        private MiscCustomForm miscCustomForm1;
        private VisualCustomForm visualCustomForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

