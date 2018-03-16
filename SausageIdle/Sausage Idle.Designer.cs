namespace WindowsFormsApp1
{
    partial class SausageIdle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SausageIdle));
            this.SausageCounter = new System.Windows.Forms.Label();
            this.IdleMode = new System.Windows.Forms.Timer(this.components);
            this.DisplaySausagesPerSec = new System.Windows.Forms.Label();
            this.FixedText1 = new System.Windows.Forms.Label();
            this.DisplayKetchupPrice = new System.Windows.Forms.Label();
            this.DisplayKetchupPerSec = new System.Windows.Forms.Label();
            this.DisplayMustardPerSec = new System.Windows.Forms.Label();
            this.SausagePerClick = new System.Windows.Forms.Label();
            this.DisplayBBQToolsPrice = new System.Windows.Forms.Label();
            this.FixedText2 = new System.Windows.Forms.Label();
            this.ThirtySecCooldown = new System.Windows.Forms.Timer(this.components);
            this.AutoclickActive = new System.Windows.Forms.Timer(this.components);
            this.TenSecDuration = new System.Windows.Forms.Timer(this.components);
            this.AutoclickSecondsLeft = new System.Windows.Forms.Timer(this.components);
            this.DisplayMustardPrice = new System.Windows.Forms.Label();
            this.AutoclickSkill = new System.Windows.Forms.Button();
            this.UpgradeBBQTools = new System.Windows.Forms.Button();
            this.UpgradeMustard = new System.Windows.Forms.Button();
            this.UpgradeKetchup = new System.Windows.Forms.Button();
            this.ClickSausage = new System.Windows.Forms.Button();
            this.SaveGame = new System.Windows.Forms.Button();
            this.DeleteGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SausageCounter
            // 
            this.SausageCounter.AutoSize = true;
            this.SausageCounter.Location = new System.Drawing.Point(58, 207);
            this.SausageCounter.Name = "SausageCounter";
            this.SausageCounter.Size = new System.Drawing.Size(13, 13);
            this.SausageCounter.TabIndex = 1;
            this.SausageCounter.Text = "0";
            // 
            // IdleMode
            // 
            this.IdleMode.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // DisplaySausagesPerSec
            // 
            this.DisplaySausagesPerSec.AutoSize = true;
            this.DisplaySausagesPerSec.Location = new System.Drawing.Point(159, 243);
            this.DisplaySausagesPerSec.Name = "DisplaySausagesPerSec";
            this.DisplaySausagesPerSec.Size = new System.Drawing.Size(28, 13);
            this.DisplaySausagesPerSec.TabIndex = 3;
            this.DisplaySausagesPerSec.Text = "SPS";
            // 
            // FixedText1
            // 
            this.FixedText1.AutoSize = true;
            this.FixedText1.Location = new System.Drawing.Point(35, 243);
            this.FixedText1.Name = "FixedText1";
            this.FixedText1.Size = new System.Drawing.Size(127, 13);
            this.FixedText1.TabIndex = 4;
            this.FixedText1.Text = "Vegan sausages per sec:";
            // 
            // DisplayKetchupPrice
            // 
            this.DisplayKetchupPrice.AutoSize = true;
            this.DisplayKetchupPrice.Location = new System.Drawing.Point(293, 71);
            this.DisplayKetchupPrice.Name = "DisplayKetchupPrice";
            this.DisplayKetchupPrice.Size = new System.Drawing.Size(19, 13);
            this.DisplayKetchupPrice.TabIndex = 6;
            this.DisplayKetchupPrice.Text = "10";
            // 
            // DisplayKetchupPerSec
            // 
            this.DisplayKetchupPerSec.AutoSize = true;
            this.DisplayKetchupPerSec.Location = new System.Drawing.Point(416, 71);
            this.DisplayKetchupPerSec.Name = "DisplayKetchupPerSec";
            this.DisplayKetchupPerSec.Size = new System.Drawing.Size(13, 13);
            this.DisplayKetchupPerSec.TabIndex = 8;
            this.DisplayKetchupPerSec.Text = "0";
            // 
            // DisplayMustardPerSec
            // 
            this.DisplayMustardPerSec.AutoSize = true;
            this.DisplayMustardPerSec.Location = new System.Drawing.Point(416, 243);
            this.DisplayMustardPerSec.Name = "DisplayMustardPerSec";
            this.DisplayMustardPerSec.Size = new System.Drawing.Size(13, 13);
            this.DisplayMustardPerSec.TabIndex = 9;
            this.DisplayMustardPerSec.Text = "0";
            this.DisplayMustardPerSec.Visible = false;
            // 
            // SausagePerClick
            // 
            this.SausagePerClick.AutoSize = true;
            this.SausagePerClick.Location = new System.Drawing.Point(167, 271);
            this.SausagePerClick.Name = "SausagePerClick";
            this.SausagePerClick.Size = new System.Drawing.Size(13, 13);
            this.SausagePerClick.TabIndex = 11;
            this.SausagePerClick.Text = "1";
            // 
            // DisplayBBQToolsPrice
            // 
            this.DisplayBBQToolsPrice.AutoSize = true;
            this.DisplayBBQToolsPrice.Location = new System.Drawing.Point(298, 384);
            this.DisplayBBQToolsPrice.Name = "DisplayBBQToolsPrice";
            this.DisplayBBQToolsPrice.Size = new System.Drawing.Size(31, 13);
            this.DisplayBBQToolsPrice.TabIndex = 12;
            this.DisplayBBQToolsPrice.Text = "1000";
            this.DisplayBBQToolsPrice.Visible = false;
            // 
            // FixedText2
            // 
            this.FixedText2.AutoSize = true;
            this.FixedText2.Location = new System.Drawing.Point(35, 271);
            this.FixedText2.Name = "FixedText2";
            this.FixedText2.Size = new System.Drawing.Size(132, 13);
            this.FixedText2.TabIndex = 13;
            this.FixedText2.Text = "Vegan sausages per click:";
            // 
            // ThirtySecCooldown
            // 
            this.ThirtySecCooldown.Interval = 30000;
            this.ThirtySecCooldown.Tick += new System.EventHandler(this.ThirtySecCooldown_Tick);
            // 
            // AutoclickActive
            // 
            this.AutoclickActive.Interval = 50;
            this.AutoclickActive.Tick += new System.EventHandler(this.AutoclickActive_Tick);
            // 
            // TenSecDuration
            // 
            this.TenSecDuration.Interval = 10000;
            this.TenSecDuration.Tick += new System.EventHandler(this.TenSecDuration_Tick);
            // 
            // AutoclickSecondsLeft
            // 
            this.AutoclickSecondsLeft.Interval = 1000;
            this.AutoclickSecondsLeft.Tick += new System.EventHandler(this.AutoclickSecondsLeft_Tick);
            // 
            // DisplayMustardPrice
            // 
            this.DisplayMustardPrice.AutoSize = true;
            this.DisplayMustardPrice.Location = new System.Drawing.Point(287, 243);
            this.DisplayMustardPrice.Name = "DisplayMustardPrice";
            this.DisplayMustardPrice.Size = new System.Drawing.Size(25, 13);
            this.DisplayMustardPrice.TabIndex = 7;
            this.DisplayMustardPrice.Text = "100";
            this.DisplayMustardPrice.Visible = false;
            // 
            // AutoclickSkill
            // 
            this.AutoclickSkill.AutoSize = true;
            this.AutoclickSkill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoclickSkill.FlatAppearance.BorderSize = 0;
            this.AutoclickSkill.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AutoclickSkill.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AutoclickSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoclickSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoclickSkill.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AutoclickSkill.Image = global::WindowsFormsApp2.Properties.Resources.Grill;
            this.AutoclickSkill.Location = new System.Drawing.Point(61, 337);
            this.AutoclickSkill.Name = "AutoclickSkill";
            this.AutoclickSkill.Size = new System.Drawing.Size(118, 131);
            this.AutoclickSkill.TabIndex = 14;
            this.AutoclickSkill.Text = "Active READY";
            this.AutoclickSkill.UseVisualStyleBackColor = true;
            this.AutoclickSkill.Click += new System.EventHandler(this.AutoclickSkill_Click);
            // 
            // UpgradeBBQTools
            // 
            this.UpgradeBBQTools.AutoSize = true;
            this.UpgradeBBQTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeBBQTools.FlatAppearance.BorderSize = 0;
            this.UpgradeBBQTools.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeBBQTools.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeBBQTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeBBQTools.Image = global::WindowsFormsApp2.Properties.Resources.BBQTools;
            this.UpgradeBBQTools.Location = new System.Drawing.Point(336, 350);
            this.UpgradeBBQTools.Name = "UpgradeBBQTools";
            this.UpgradeBBQTools.Size = new System.Drawing.Size(93, 81);
            this.UpgradeBBQTools.TabIndex = 10;
            this.UpgradeBBQTools.Text = "Clicks";
            this.UpgradeBBQTools.UseVisualStyleBackColor = true;
            this.UpgradeBBQTools.Visible = false;
            this.UpgradeBBQTools.Click += new System.EventHandler(this.Passive1_Click);
            // 
            // UpgradeMustard
            // 
            this.UpgradeMustard.AutoSize = true;
            this.UpgradeMustard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeMustard.Enabled = false;
            this.UpgradeMustard.FlatAppearance.BorderSize = 0;
            this.UpgradeMustard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeMustard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeMustard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeMustard.Image = global::WindowsFormsApp2.Properties.Resources.Mustard;
            this.UpgradeMustard.Location = new System.Drawing.Point(334, 196);
            this.UpgradeMustard.Name = "UpgradeMustard";
            this.UpgradeMustard.Size = new System.Drawing.Size(55, 106);
            this.UpgradeMustard.TabIndex = 5;
            this.UpgradeMustard.Text = "Mustard";
            this.UpgradeMustard.UseVisualStyleBackColor = true;
            this.UpgradeMustard.Visible = false;
            this.UpgradeMustard.Click += new System.EventHandler(this.UpgradeMusatrd_Click);
            this.UpgradeMustard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpgradeMustard_MouseDown);
            this.UpgradeMustard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpgradeMustard_MouseUp);
            // 
            // UpgradeKetchup
            // 
            this.UpgradeKetchup.AutoSize = true;
            this.UpgradeKetchup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeKetchup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpgradeKetchup.Enabled = false;
            this.UpgradeKetchup.FlatAppearance.BorderSize = 0;
            this.UpgradeKetchup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeKetchup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeKetchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeKetchup.Image = global::WindowsFormsApp2.Properties.Resources.Ketchup;
            this.UpgradeKetchup.Location = new System.Drawing.Point(332, 37);
            this.UpgradeKetchup.Name = "UpgradeKetchup";
            this.UpgradeKetchup.Size = new System.Drawing.Size(57, 106);
            this.UpgradeKetchup.TabIndex = 2;
            this.UpgradeKetchup.Text = "Ketchup";
            this.UpgradeKetchup.UseVisualStyleBackColor = true;
            this.UpgradeKetchup.Click += new System.EventHandler(this.UpgradeKetchup_Click);
            this.UpgradeKetchup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpgradeKetchup_MouseDown);
            this.UpgradeKetchup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpgradeKetchup_MouseUp);
            // 
            // ClickSausage
            // 
            this.ClickSausage.AutoSize = true;
            this.ClickSausage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClickSausage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClickSausage.FlatAppearance.BorderSize = 0;
            this.ClickSausage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClickSausage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClickSausage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickSausage.Image = global::WindowsFormsApp2.Properties.Resources.Sausage;
            this.ClickSausage.Location = new System.Drawing.Point(24, 12);
            this.ClickSausage.Name = "ClickSausage";
            this.ClickSausage.Size = new System.Drawing.Size(156, 156);
            this.ClickSausage.TabIndex = 0;
            this.ClickSausage.UseVisualStyleBackColor = true;
            this.ClickSausage.Click += new System.EventHandler(this.ClickSausage_Click);
            this.ClickSausage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickSausage_MouseDown);
            this.ClickSausage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickSausage_MouseUp);
            // 
            // SaveGame
            // 
            this.SaveGame.Location = new System.Drawing.Point(92, 518);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(75, 23);
            this.SaveGame.TabIndex = 15;
            this.SaveGame.Text = "Save";
            this.SaveGame.UseVisualStyleBackColor = true;
            this.SaveGame.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteGame
            // 
            this.DeleteGame.Location = new System.Drawing.Point(290, 518);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(75, 23);
            this.DeleteGame.TabIndex = 16;
            this.DeleteGame.Text = "Delete";
            this.DeleteGame.UseVisualStyleBackColor = true;
            this.DeleteGame.Click += new System.EventHandler(this.DeleteGame_Click);
            // 
            // SausageIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(489, 585);
            this.Controls.Add(this.DeleteGame);
            this.Controls.Add(this.SaveGame);
            this.Controls.Add(this.AutoclickSkill);
            this.Controls.Add(this.FixedText2);
            this.Controls.Add(this.DisplayBBQToolsPrice);
            this.Controls.Add(this.SausagePerClick);
            this.Controls.Add(this.UpgradeBBQTools);
            this.Controls.Add(this.DisplayMustardPerSec);
            this.Controls.Add(this.DisplayKetchupPerSec);
            this.Controls.Add(this.DisplayMustardPrice);
            this.Controls.Add(this.DisplayKetchupPrice);
            this.Controls.Add(this.UpgradeMustard);
            this.Controls.Add(this.FixedText1);
            this.Controls.Add(this.DisplaySausagesPerSec);
            this.Controls.Add(this.UpgradeKetchup);
            this.Controls.Add(this.SausageCounter);
            this.Controls.Add(this.ClickSausage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SausageIdle";
            this.Text = "Sausage Idle";
            this.Load += new System.EventHandler(this.SausageIdle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickSausage;
        private System.Windows.Forms.Label SausageCounter;
        private System.Windows.Forms.Button UpgradeKetchup;
        private System.Windows.Forms.Timer IdleMode;
        private System.Windows.Forms.Label DisplaySausagesPerSec;
        private System.Windows.Forms.Label FixedText1;
        private System.Windows.Forms.Button UpgradeMustard;
        private System.Windows.Forms.Label DisplayKetchupPrice;
        private System.Windows.Forms.Label DisplayKetchupPerSec;
        private System.Windows.Forms.Label DisplayMustardPerSec;
        private System.Windows.Forms.Button UpgradeBBQTools;
        private System.Windows.Forms.Label SausagePerClick;
        private System.Windows.Forms.Label DisplayBBQToolsPrice;
        private System.Windows.Forms.Label FixedText2;
        private System.Windows.Forms.Button AutoclickSkill;
        private System.Windows.Forms.Timer ThirtySecCooldown;
        private System.Windows.Forms.Timer AutoclickActive;
        private System.Windows.Forms.Timer TenSecDuration;
        private System.Windows.Forms.Timer AutoclickSecondsLeft;
        private System.Windows.Forms.Label DisplayMustardPrice;
        private System.Windows.Forms.Button SaveGame;
        private System.Windows.Forms.Button DeleteGame;
    }
}

