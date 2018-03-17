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
            this.DisplayGameSaved = new System.Windows.Forms.Label();
            this.SaveMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.GrillCooldownRemainingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SausageCounter
            // 
            this.SausageCounter.AutoSize = true;
            this.SausageCounter.BackColor = System.Drawing.Color.Transparent;
            this.SausageCounter.Location = new System.Drawing.Point(195, 252);
            this.SausageCounter.Name = "SausageCounter";
            this.SausageCounter.Size = new System.Drawing.Size(13, 13);
            this.SausageCounter.TabIndex = 1;
            this.SausageCounter.Text = "0";
            // 
            // IdleMode
            // 
            this.IdleMode.Tick += new System.EventHandler(this.IdleMode_Tick);
            // 
            // DisplaySausagesPerSec
            // 
            this.DisplaySausagesPerSec.AutoSize = true;
            this.DisplaySausagesPerSec.BackColor = System.Drawing.Color.Transparent;
            this.DisplaySausagesPerSec.Location = new System.Drawing.Point(252, 279);
            this.DisplaySausagesPerSec.Name = "DisplaySausagesPerSec";
            this.DisplaySausagesPerSec.Size = new System.Drawing.Size(28, 13);
            this.DisplaySausagesPerSec.TabIndex = 3;
            this.DisplaySausagesPerSec.Text = "SPS";
            // 
            // FixedText1
            // 
            this.FixedText1.AutoSize = true;
            this.FixedText1.BackColor = System.Drawing.Color.Transparent;
            this.FixedText1.Location = new System.Drawing.Point(128, 279);
            this.FixedText1.Name = "FixedText1";
            this.FixedText1.Size = new System.Drawing.Size(127, 13);
            this.FixedText1.TabIndex = 4;
            this.FixedText1.Text = "Vegan sausages per sec:";
            // 
            // DisplayKetchupPrice
            // 
            this.DisplayKetchupPrice.AutoSize = true;
            this.DisplayKetchupPrice.BackColor = System.Drawing.Color.Transparent;
            this.DisplayKetchupPrice.Location = new System.Drawing.Point(446, 129);
            this.DisplayKetchupPrice.Name = "DisplayKetchupPrice";
            this.DisplayKetchupPrice.Size = new System.Drawing.Size(19, 13);
            this.DisplayKetchupPrice.TabIndex = 6;
            this.DisplayKetchupPrice.Text = "10";
            // 
            // DisplayKetchupPerSec
            // 
            this.DisplayKetchupPerSec.AutoSize = true;
            this.DisplayKetchupPerSec.BackColor = System.Drawing.Color.Transparent;
            this.DisplayKetchupPerSec.Location = new System.Drawing.Point(642, 129);
            this.DisplayKetchupPerSec.Name = "DisplayKetchupPerSec";
            this.DisplayKetchupPerSec.Size = new System.Drawing.Size(13, 13);
            this.DisplayKetchupPerSec.TabIndex = 8;
            this.DisplayKetchupPerSec.Text = "0";
            // 
            // DisplayMustardPerSec
            // 
            this.DisplayMustardPerSec.AutoSize = true;
            this.DisplayMustardPerSec.BackColor = System.Drawing.Color.Transparent;
            this.DisplayMustardPerSec.Location = new System.Drawing.Point(600, 279);
            this.DisplayMustardPerSec.Name = "DisplayMustardPerSec";
            this.DisplayMustardPerSec.Size = new System.Drawing.Size(13, 13);
            this.DisplayMustardPerSec.TabIndex = 9;
            this.DisplayMustardPerSec.Text = "0";
            this.DisplayMustardPerSec.Visible = false;
            // 
            // SausagePerClick
            // 
            this.SausagePerClick.AutoSize = true;
            this.SausagePerClick.BackColor = System.Drawing.Color.Transparent;
            this.SausagePerClick.Location = new System.Drawing.Point(260, 307);
            this.SausagePerClick.Name = "SausagePerClick";
            this.SausagePerClick.Size = new System.Drawing.Size(13, 13);
            this.SausagePerClick.TabIndex = 11;
            this.SausagePerClick.Text = "1";
            // 
            // DisplayBBQToolsPrice
            // 
            this.DisplayBBQToolsPrice.AutoSize = true;
            this.DisplayBBQToolsPrice.BackColor = System.Drawing.Color.Transparent;
            this.DisplayBBQToolsPrice.Location = new System.Drawing.Point(471, 408);
            this.DisplayBBQToolsPrice.Name = "DisplayBBQToolsPrice";
            this.DisplayBBQToolsPrice.Size = new System.Drawing.Size(34, 13);
            this.DisplayBBQToolsPrice.TabIndex = 12;
            this.DisplayBBQToolsPrice.Text = "1,000";
            this.DisplayBBQToolsPrice.Visible = false;
            // 
            // FixedText2
            // 
            this.FixedText2.AutoSize = true;
            this.FixedText2.BackColor = System.Drawing.Color.Transparent;
            this.FixedText2.Location = new System.Drawing.Point(128, 307);
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
            this.DisplayMustardPrice.BackColor = System.Drawing.Color.Transparent;
            this.DisplayMustardPrice.Location = new System.Drawing.Point(489, 279);
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
            this.AutoclickSkill.BackColor = System.Drawing.Color.Transparent;
            this.AutoclickSkill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.AutoclickSkill.FlatAppearance.BorderSize = 0;
            this.AutoclickSkill.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.AutoclickSkill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AutoclickSkill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AutoclickSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoclickSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoclickSkill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AutoclickSkill.Image = global::WindowsFormsApp2.Properties.Resources.Grill;
            this.AutoclickSkill.Location = new System.Drawing.Point(137, 327);
            this.AutoclickSkill.Name = "AutoclickSkill";
            this.AutoclickSkill.Size = new System.Drawing.Size(118, 131);
            this.AutoclickSkill.TabIndex = 14;
            this.AutoclickSkill.TabStop = false;
            this.AutoclickSkill.Text = "Grill READY";
            this.AutoclickSkill.UseVisualStyleBackColor = false;
            this.AutoclickSkill.Click += new System.EventHandler(this.AutoclickSkill_Click);
            // 
            // UpgradeBBQTools
            // 
            this.UpgradeBBQTools.AutoSize = true;
            this.UpgradeBBQTools.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeBBQTools.BackColor = System.Drawing.Color.Transparent;
            this.UpgradeBBQTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpgradeBBQTools.FlatAppearance.BorderSize = 0;
            this.UpgradeBBQTools.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.UpgradeBBQTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UpgradeBBQTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UpgradeBBQTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeBBQTools.ForeColor = System.Drawing.Color.Black;
            this.UpgradeBBQTools.Image = global::WindowsFormsApp2.Properties.Resources.BBQTools;
            this.UpgradeBBQTools.Location = new System.Drawing.Point(511, 374);
            this.UpgradeBBQTools.Name = "UpgradeBBQTools";
            this.UpgradeBBQTools.Size = new System.Drawing.Size(93, 81);
            this.UpgradeBBQTools.TabIndex = 10;
            this.UpgradeBBQTools.TabStop = false;
            this.UpgradeBBQTools.Text = "Clicks";
            this.UpgradeBBQTools.UseVisualStyleBackColor = false;
            this.UpgradeBBQTools.Visible = false;
            this.UpgradeBBQTools.Click += new System.EventHandler(this.BBQTools_Click);
            // 
            // UpgradeMustard
            // 
            this.UpgradeMustard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpgradeMustard.AutoSize = true;
            this.UpgradeMustard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeMustard.BackColor = System.Drawing.Color.Transparent;
            this.UpgradeMustard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpgradeMustard.Enabled = false;
            this.UpgradeMustard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpgradeMustard.FlatAppearance.BorderSize = 0;
            this.UpgradeMustard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.UpgradeMustard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UpgradeMustard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UpgradeMustard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeMustard.ForeColor = System.Drawing.Color.Black;
            this.UpgradeMustard.Image = global::WindowsFormsApp2.Properties.Resources.Mustard;
            this.UpgradeMustard.Location = new System.Drawing.Point(527, 230);
            this.UpgradeMustard.Name = "UpgradeMustard";
            this.UpgradeMustard.Size = new System.Drawing.Size(55, 106);
            this.UpgradeMustard.TabIndex = 5;
            this.UpgradeMustard.TabStop = false;
            this.UpgradeMustard.Text = "Mustard";
            this.UpgradeMustard.UseVisualStyleBackColor = false;
            this.UpgradeMustard.Visible = false;
            this.UpgradeMustard.Click += new System.EventHandler(this.UpgradeMusatrd_Click);
            this.UpgradeMustard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpgradeMustard_MouseDown);
            this.UpgradeMustard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpgradeMustard_MouseUp);
            // 
            // UpgradeKetchup
            // 
            this.UpgradeKetchup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpgradeKetchup.AutoSize = true;
            this.UpgradeKetchup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpgradeKetchup.BackColor = System.Drawing.Color.Transparent;
            this.UpgradeKetchup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UpgradeKetchup.Enabled = false;
            this.UpgradeKetchup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.UpgradeKetchup.FlatAppearance.BorderSize = 0;
            this.UpgradeKetchup.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.UpgradeKetchup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UpgradeKetchup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.UpgradeKetchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeKetchup.ForeColor = System.Drawing.Color.Black;
            this.UpgradeKetchup.Image = global::WindowsFormsApp2.Properties.Resources.Ketchup;
            this.UpgradeKetchup.Location = new System.Drawing.Point(527, 73);
            this.UpgradeKetchup.Margin = new System.Windows.Forms.Padding(0);
            this.UpgradeKetchup.Name = "UpgradeKetchup";
            this.UpgradeKetchup.Size = new System.Drawing.Size(57, 106);
            this.UpgradeKetchup.TabIndex = 2;
            this.UpgradeKetchup.TabStop = false;
            this.UpgradeKetchup.Text = "Ketchup";
            this.UpgradeKetchup.UseVisualStyleBackColor = false;
            this.UpgradeKetchup.Click += new System.EventHandler(this.UpgradeKetchup_Click);
            this.UpgradeKetchup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpgradeKetchup_MouseDown);
            this.UpgradeKetchup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpgradeKetchup_MouseUp);
            // 
            // ClickSausage
            // 
            this.ClickSausage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClickSausage.AutoSize = true;
            this.ClickSausage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClickSausage.BackColor = System.Drawing.Color.Transparent;
            this.ClickSausage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClickSausage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClickSausage.FlatAppearance.BorderSize = 0;
            this.ClickSausage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ClickSausage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClickSausage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClickSausage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickSausage.Image = global::WindowsFormsApp2.Properties.Resources.Sausage;
            this.ClickSausage.Location = new System.Drawing.Point(124, 81);
            this.ClickSausage.Margin = new System.Windows.Forms.Padding(0);
            this.ClickSausage.Name = "ClickSausage";
            this.ClickSausage.Size = new System.Drawing.Size(156, 156);
            this.ClickSausage.TabIndex = 0;
            this.ClickSausage.TabStop = false;
            this.ClickSausage.UseVisualStyleBackColor = false;
            this.ClickSausage.Click += new System.EventHandler(this.ClickSausage_Click);
            this.ClickSausage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickSausage_MouseDown);
            this.ClickSausage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickSausage_MouseUp);
            // 
            // SaveGame
            // 
            this.SaveGame.BackColor = System.Drawing.Color.Transparent;
            this.SaveGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveGame.FlatAppearance.BorderSize = 0;
            this.SaveGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveGame.ForeColor = System.Drawing.Color.Transparent;
            this.SaveGame.Image = global::WindowsFormsApp2.Properties.Resources.Save01;
            this.SaveGame.Location = new System.Drawing.Point(12, 20);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(93, 41);
            this.SaveGame.TabIndex = 15;
            this.SaveGame.TabStop = false;
            this.SaveGame.Text = "\r\n";
            this.SaveGame.UseVisualStyleBackColor = false;
            this.SaveGame.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteGame
            // 
            this.DeleteGame.BackColor = System.Drawing.Color.Transparent;
            this.DeleteGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteGame.FlatAppearance.BorderSize = 0;
            this.DeleteGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteGame.Image = global::WindowsFormsApp2.Properties.Resources.Delete;
            this.DeleteGame.Location = new System.Drawing.Point(12, 57);
            this.DeleteGame.Name = "DeleteGame";
            this.DeleteGame.Size = new System.Drawing.Size(93, 39);
            this.DeleteGame.TabIndex = 16;
            this.DeleteGame.TabStop = false;
            this.DeleteGame.UseVisualStyleBackColor = false;
            this.DeleteGame.Click += new System.EventHandler(this.DeleteGame_Click);
            // 
            // DisplayGameSaved
            // 
            this.DisplayGameSaved.AutoSize = true;
            this.DisplayGameSaved.BackColor = System.Drawing.Color.Transparent;
            this.DisplayGameSaved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayGameSaved.Location = new System.Drawing.Point(287, 37);
            this.DisplayGameSaved.Name = "DisplayGameSaved";
            this.DisplayGameSaved.Size = new System.Drawing.Size(132, 24);
            this.DisplayGameSaved.TabIndex = 17;
            this.DisplayGameSaved.Text = "Game saved!";
            this.DisplayGameSaved.Visible = false;
            // 
            // SaveMessageTimer
            // 
            this.SaveMessageTimer.Interval = 1200;
            this.SaveMessageTimer.Tick += new System.EventHandler(this.SaveMessageTimer_Tick);
            // 
            // GrillCooldownRemainingTimer
            // 
            this.GrillCooldownRemainingTimer.Interval = 1000;
            this.GrillCooldownRemainingTimer.Tick += new System.EventHandler(this.GrillCooldownRemainingTimer_Tick);
            // 
            // SausageIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.background02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(706, 498);
            this.Controls.Add(this.DisplayGameSaved);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SausageIdle";
            this.Text = "Sausage Idle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SausageIdle_FormClosing);
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
        private System.Windows.Forms.Label DisplayGameSaved;
        private System.Windows.Forms.Timer SaveMessageTimer;
        private System.Windows.Forms.Timer GrillCooldownRemainingTimer;
    }
}

