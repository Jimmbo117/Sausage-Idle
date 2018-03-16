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
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.DisplaySausagesPerSec = new System.Windows.Forms.Label();
            this.FixedText1 = new System.Windows.Forms.Label();
            this.DisplayKetchupPrice = new System.Windows.Forms.Label();
            this.KetchupPerSec = new System.Windows.Forms.Label();
            this.MustardPerSec = new System.Windows.Forms.Label();
            this.SausagePerClick = new System.Windows.Forms.Label();
            this.DisplayPassive1Price = new System.Windows.Forms.Label();
            this.FixedText2 = new System.Windows.Forms.Label();
            this.ThirtySecCooldown = new System.Windows.Forms.Timer(this.components);
            this.AutoclickActive = new System.Windows.Forms.Timer(this.components);
            this.TenSecDuration = new System.Windows.Forms.Timer(this.components);
            this.AutoclickSecondsLeft = new System.Windows.Forms.Timer(this.components);
            this.DisplayMustardPrice = new System.Windows.Forms.Label();
            this.AutoclickSkill = new System.Windows.Forms.Button();
            this.UpgradePassive1 = new System.Windows.Forms.Button();
            this.UpgradeMustard = new System.Windows.Forms.Button();
            this.UpgradeKetchup = new System.Windows.Forms.Button();
            this.ClickSausage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SausageCounter
            // 
            this.SausageCounter.AutoSize = true;
            this.SausageCounter.Location = new System.Drawing.Point(109, 207);
            this.SausageCounter.Name = "SausageCounter";
            this.SausageCounter.Size = new System.Drawing.Size(13, 13);
            this.SausageCounter.TabIndex = 1;
            this.SausageCounter.Text = "0";
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
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
            // KetchupPerSec
            // 
            this.KetchupPerSec.AutoSize = true;
            this.KetchupPerSec.Location = new System.Drawing.Point(416, 71);
            this.KetchupPerSec.Name = "KetchupPerSec";
            this.KetchupPerSec.Size = new System.Drawing.Size(13, 13);
            this.KetchupPerSec.TabIndex = 8;
            this.KetchupPerSec.Text = "0";
            // 
            // MustardPerSec
            // 
            this.MustardPerSec.AutoSize = true;
            this.MustardPerSec.Location = new System.Drawing.Point(416, 243);
            this.MustardPerSec.Name = "MustardPerSec";
            this.MustardPerSec.Size = new System.Drawing.Size(13, 13);
            this.MustardPerSec.TabIndex = 9;
            this.MustardPerSec.Text = "0";
            this.MustardPerSec.Visible = false;
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
            // DisplayPassive1Price
            // 
            this.DisplayPassive1Price.AutoSize = true;
            this.DisplayPassive1Price.Location = new System.Drawing.Point(298, 384);
            this.DisplayPassive1Price.Name = "DisplayPassive1Price";
            this.DisplayPassive1Price.Size = new System.Drawing.Size(31, 13);
            this.DisplayPassive1Price.TabIndex = 12;
            this.DisplayPassive1Price.Text = "1000";
            this.DisplayPassive1Price.Visible = false;
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
            this.AutoclickSkill.FlatAppearance.BorderSize = 0;
            this.AutoclickSkill.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AutoclickSkill.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AutoclickSkill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoclickSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoclickSkill.ForeColor = System.Drawing.SystemColors.InfoText;
            this.AutoclickSkill.Image = global::WindowsFormsApp2.Properties.Resources.grill11;
            this.AutoclickSkill.Location = new System.Drawing.Point(41, 300);
            this.AutoclickSkill.Name = "AutoclickSkill";
            this.AutoclickSkill.Size = new System.Drawing.Size(139, 140);
            this.AutoclickSkill.TabIndex = 14;
            this.AutoclickSkill.Text = "Active READY";
            this.AutoclickSkill.UseVisualStyleBackColor = true;
            this.AutoclickSkill.Click += new System.EventHandler(this.AutoclickSkill_Click);
            // 
            // UpgradePassive1
            // 
            this.UpgradePassive1.FlatAppearance.BorderSize = 0;
            this.UpgradePassive1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpgradePassive1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.UpgradePassive1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradePassive1.Image = global::WindowsFormsApp2.Properties.Resources.BBQtools;
            this.UpgradePassive1.Location = new System.Drawing.Point(335, 344);
            this.UpgradePassive1.Name = "UpgradePassive1";
            this.UpgradePassive1.Size = new System.Drawing.Size(106, 85);
            this.UpgradePassive1.TabIndex = 10;
            this.UpgradePassive1.Text = "Clicks";
            this.UpgradePassive1.UseVisualStyleBackColor = true;
            this.UpgradePassive1.Visible = false;
            this.UpgradePassive1.Click += new System.EventHandler(this.Passive1_Click);
            // 
            // UpgradeMustard
            // 
            this.UpgradeMustard.Enabled = false;
            this.UpgradeMustard.FlatAppearance.BorderSize = 0;
            this.UpgradeMustard.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeMustard.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeMustard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeMustard.Image = global::WindowsFormsApp2.Properties.Resources.mustard;
            this.UpgradeMustard.Location = new System.Drawing.Point(335, 180);
            this.UpgradeMustard.Name = "UpgradeMustard";
            this.UpgradeMustard.Size = new System.Drawing.Size(75, 139);
            this.UpgradeMustard.TabIndex = 5;
            this.UpgradeMustard.Text = "Mustard";
            this.UpgradeMustard.UseVisualStyleBackColor = true;
            this.UpgradeMustard.Visible = false;
            this.UpgradeMustard.Click += new System.EventHandler(this.Idler2_Click);
            this.UpgradeMustard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpgradeMustard_MouseDown);
            this.UpgradeMustard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpgradeMustard_MouseUp);
            // 
            // UpgradeKetchup
            // 
            this.UpgradeKetchup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UpgradeKetchup.Enabled = false;
            this.UpgradeKetchup.FlatAppearance.BorderSize = 0;
            this.UpgradeKetchup.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeKetchup.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.UpgradeKetchup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpgradeKetchup.Image = global::WindowsFormsApp2.Properties.Resources.ketchop;
            this.UpgradeKetchup.Location = new System.Drawing.Point(335, 12);
            this.UpgradeKetchup.Name = "UpgradeKetchup";
            this.UpgradeKetchup.Size = new System.Drawing.Size(75, 130);
            this.UpgradeKetchup.TabIndex = 2;
            this.UpgradeKetchup.Text = "Ketchup 1";
            this.UpgradeKetchup.UseVisualStyleBackColor = true;
            this.UpgradeKetchup.Click += new System.EventHandler(this.Idler_Click);
            this.UpgradeKetchup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpgradeKetchup_MouseDown);
            this.UpgradeKetchup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpgradeKetchup_MouseUp);
            // 
            // ClickSausage
            // 
            this.ClickSausage.FlatAppearance.BorderSize = 0;
            this.ClickSausage.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ClickSausage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ClickSausage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClickSausage.Image = global::WindowsFormsApp2.Properties.Resources.sausge;
            this.ClickSausage.Location = new System.Drawing.Point(22, -2);
            this.ClickSausage.Name = "ClickSausage";
            this.ClickSausage.Size = new System.Drawing.Size(189, 194);
            this.ClickSausage.TabIndex = 0;
            this.ClickSausage.UseVisualStyleBackColor = true;
            this.ClickSausage.Click += new System.EventHandler(this.SausagePlus_Click);
            this.ClickSausage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClickSausage_MouseDown);
            this.ClickSausage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ClickSausage_MouseUp);
            // 
            // SausageIdle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(489, 441);
            this.Controls.Add(this.AutoclickSkill);
            this.Controls.Add(this.FixedText2);
            this.Controls.Add(this.DisplayPassive1Price);
            this.Controls.Add(this.SausagePerClick);
            this.Controls.Add(this.UpgradePassive1);
            this.Controls.Add(this.MustardPerSec);
            this.Controls.Add(this.KetchupPerSec);
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
            this.Name = "SausageIdle";
            this.Text = "Sausage Idle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickSausage;
        private System.Windows.Forms.Label SausageCounter;
        private System.Windows.Forms.Button UpgradeKetchup;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Label DisplaySausagesPerSec;
        private System.Windows.Forms.Label FixedText1;
        private System.Windows.Forms.Button UpgradeMustard;
        private System.Windows.Forms.Label DisplayKetchupPrice;
        private System.Windows.Forms.Label KetchupPerSec;
        private System.Windows.Forms.Label MustardPerSec;
        private System.Windows.Forms.Button UpgradePassive1;
        private System.Windows.Forms.Label SausagePerClick;
        private System.Windows.Forms.Label DisplayPassive1Price;
        private System.Windows.Forms.Label FixedText2;
        private System.Windows.Forms.Button AutoclickSkill;
        private System.Windows.Forms.Timer ThirtySecCooldown;
        private System.Windows.Forms.Timer AutoclickActive;
        private System.Windows.Forms.Timer TenSecDuration;
        private System.Windows.Forms.Timer AutoclickSecondsLeft;
        private System.Windows.Forms.Label DisplayMustardPrice;
    }
}

