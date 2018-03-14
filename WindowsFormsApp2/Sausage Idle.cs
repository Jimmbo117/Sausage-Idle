using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SausageIdle : Form
    {
        double SausageBank = 0;
        int KetchupSum = 0;
        double KetchupPrice = 10;
        double KetchupThousands = 0;
        int MustardSum = 0;
        double MustardPrice = 100;
        double MustardThousands = 0;
        double SausagePerSec = 0;
        double OneThousand = 1000;
        int ClickValue = 1;
        double Passive1Price = 1000;
        double Passive1Thousands = 0;
        int SecsLeft = 0;
        //string Save = "";

        public SausageIdle()
        {
            InitializeComponent();
            DisplaySausagesPerSec.Text = "0";
            DisplayKetchupPrice.Text = KetchupPrice.ToString("0");
           // FixedText1.Text = UpgradeKetchup.BackColor.ToString();
           // AutoclickSkill.BackColor = Color.Blue;
        }
        private void SausagePlus_Click(object sender, EventArgs e)
        {
            // Gain sausages by clicking, and display output.
            SausageBank = SausageBank + ClickValue;
            SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
            // Unlock new upgrades
            if (SausageBank >= KetchupPrice)
            { UpgradeKetchup.Enabled = true; }
            if (SausageBank >= MustardPrice && KetchupPrice >= 50)
            { UpgradeMustard.Enabled = true; };
            if (SausageBank >= Passive1Price)
            { UpgradePassive1.Visible = true; DisplayPassive1Price.Visible = true; UpgradePassive1.Enabled = true; }

            // Write the string to a file.
            //Save = SPS.ToString();
            //System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Save\\test.txt");
            //file.WriteLine(Save);
        }

        private void Idler_Click(object sender, EventArgs e)
        {
            if (SausageBank >= KetchupPrice)
            {
                Tick.Enabled = true;
                KetchupSum = KetchupSum + 1;
                SausagePerSec = KetchupSum + MustardSum;
                SausageBank = SausageBank - KetchupPrice;
                SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
                DisplaySausagesPerSec.Text = SausagePerSec.ToString("0");
                KetchupPrice = KetchupPrice * 1.2;
                //KetchupPrice = Math.Round(KetchupPrice);

                UpgradeMustard.Visible = true;
                DisplayMustardPrice.Visible = true;
                MustardPerSec.Visible = true;
                KetchupPerSec.Text = KetchupSum.ToString("0") + " SPS";
                UpgradeKetchup.Text = "Ketchup x" + KetchupSum;
            }
            if (SausageBank < KetchupPrice)
            {
                UpgradeKetchup.Enabled = false;
            }
            if (SausageBank < MustardPrice)
            {
                UpgradeMustard.Enabled = false;
            }
            if (SausageBank >= MustardPrice && KetchupSum > 9)
            { UpgradeMustard.Enabled = true; }

            if (KetchupPrice < 1000)
            { DisplayKetchupPrice.Text = KetchupPrice.ToString("0"); }
            if (KetchupPrice >= 1000 && KetchupPrice < 1000000)
            {
                KetchupThousands = KetchupPrice / OneThousand;
                //KetchupThousands = Math.Floor(KetchupThousands);
                DisplayKetchupPrice.Text = KetchupThousands.ToString("0.00") + "k";
            }
            if (SausageBank < Passive1Price)
            {
                UpgradePassive1.Enabled = false;
            }
        }
        private void Tick_Tick(object sender, EventArgs e)
        {
            SausageBank = SausageBank + SausagePerSec / 10;
            SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
            if (SausageBank >= KetchupPrice)
            { UpgradeKetchup.Enabled = true; }
            if (SausageBank >= MustardPrice && KetchupSum > 9)
            { UpgradeMustard.Enabled = true; }
            if (SausageBank >= Passive1Price)
            { UpgradePassive1.Enabled = true; }
            if (SausageBank >= Passive1Price)
            { UpgradePassive1.Visible = true; DisplayPassive1Price.Visible = true; UpgradePassive1.Enabled = true; }

        }

        private void Idler2_Click(object sender, EventArgs e)
        {
            if (SausageBank >= MustardPrice)
            {
                Tick.Enabled = true;
                MustardSum = MustardSum + 5;
                SausagePerSec = KetchupSum + MustardSum;
                SausageBank = SausageBank - MustardPrice;
                SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
                DisplaySausagesPerSec.Text = SausagePerSec.ToString("0");
                MustardPrice = MustardPrice * 1.5;
                //MustardPrice = Math.Round(MustardPrice);
                MustardPerSec.Text = MustardSum.ToString("0") + " SPS";
                UpgradeMustard.Text = "Mustard x" + MustardSum / 5;
            }
            if (SausageBank < KetchupPrice)
            {
                UpgradeKetchup.Enabled = false;
            }
            if (SausageBank < MustardPrice)
            {
                UpgradeMustard.Enabled = false;
            }
            if (MustardPrice < 1000)
            { DisplayMustardPrice.Text = MustardPrice.ToString("0"); }
            if (MustardPrice >= 1000 && MustardPrice < 1000000)
            {
                MustardThousands = MustardPrice / OneThousand;
                //MustardThousands = Math.Floor(MustardThousands);
                DisplayMustardPrice.Text = MustardThousands.ToString("0.00") + "k";
            }
            if (SausageBank < Passive1Price)
            {
                UpgradePassive1.Enabled = false;
            }
        }

        private void Passive1_Click(object sender, EventArgs e)
        {

            if (ClickValue < 5)
            {
                ClickValue = 5;
            }
            else
            {
                ClickValue = ClickValue + 5;
            }
            SausagePerClick.Text = ClickValue.ToString();
            SausageBank = SausageBank - Passive1Price;
            Passive1Price = Passive1Price * 1.5;
            if (Passive1Price < 1000)
            {
                DisplayPassive1Price.Text = Passive1Price.ToString("0");
            }
            else if (Passive1Price > 999 && Passive1Price < 1000000)
            {
                Passive1Thousands = Passive1Price / 1000;
                //MustardThousands = Math.Floor(MustardThousands);
                DisplayPassive1Price.Text = Passive1Thousands.ToString("0.00") + "k";
            }
            UpgradePassive1.Text = "Clicks x" + ClickValue / 5;
            //Passive1Cost = Math.Round(Passive1Cost);
            if (SausageBank < Passive1Price)
            {
                UpgradePassive1.Enabled = false;
            }
            if (SausageBank < KetchupPrice)
            {
                UpgradeKetchup.Enabled = false;
            }
            if (SausageBank < MustardPrice)
            {
                UpgradeMustard.Enabled = false;
            }

        }
        private void AutoclickSkill_Click(object sender, EventArgs e)
        {
            ThirtySecCooldown.Enabled = true;
            AutoclickActive.Enabled = true;
            TenSecDuration.Enabled = true;
            AutoclickSkill.Text = "Active ON 10";
            SecsLeft = 10;
            AutoclickSecondsLeft.Enabled = true;
           // AutoclickSkill.Enabled = true;
           // AutoclickSkill.ForeColor = Color.White;
           // AutoclickSkill.BackColor = Color.Green;
            AutoclickSkill.Enabled = false;
            // AutoclickSkill.Font = new Font(AutoclickSkill.Font, FontStyle.Bold);
            // AutoclickSkill.ForeColor = Color.White;
        }

        private void ThirtySecCooldown_Tick(object sender, EventArgs e)
        {
            AutoclickActive.Enabled = false;
            AutoclickSkill.Enabled = true;
            AutoclickSkill.Text = "Active READY";
           // AutoclickSkill.ForeColor = Color.White;
           // AutoclickSkill.Font = new Font(AutoclickSkill.Font, FontStyle.Bold);
            ThirtySecCooldown.Enabled = false;
        }

        private void AutoclickActive_Tick(object sender, EventArgs e)
        {
            ClickSausage.PerformClick();
        }

        private void TenSecDuration_Tick(object sender, EventArgs e)
        {
            AutoclickActive.Enabled = false;
            AutoclickSecondsLeft.Enabled = false;
            AutoclickSkill.Text = "Active OFF";
            // AutoclickSkill.ForeColor = Color.White;
            // AutoclickSkill.Font = new Font(AutoclickSkill.Font, FontStyle.Bold);
            //AutoclickSkill.BackColor = Color.Red;
            TenSecDuration.Enabled = false;
        }

        private void AutoclickSecondsLeft_Tick(object sender, EventArgs e)
        {
            SecsLeft = SecsLeft -1;
            AutoclickSkill.Text = "Active ON " + SecsLeft;
        }
        private void UpgradeKetchup_MouseDown(object sender, MouseEventArgs e)
        {
            UpgradeKetchup.Image = WindowsFormsApp2.Properties.Resources.ketchopBig1;
        }

        private void UpgradeKetchup_MouseUp(object sender, MouseEventArgs e)
        {
            UpgradeKetchup.Image = WindowsFormsApp2.Properties.Resources.ketchop;
        }

        private void ClickSausage_MouseDown(object sender, MouseEventArgs e)
        {
            ClickSausage.Image = WindowsFormsApp2.Properties.Resources.sausgeBig;
        }

        private void ClickSausage_MouseUp(object sender, MouseEventArgs e)
        {
            ClickSausage.Image = WindowsFormsApp2.Properties.Resources.sausge;
        }

        private void UpgradeMustard_MouseDown(object sender, MouseEventArgs e)
        {
            UpgradeMustard.Image = WindowsFormsApp2.Properties.Resources.mustardBig;
        }

        private void UpgradeMustard_MouseUp(object sender, MouseEventArgs e)
        {
            UpgradeMustard.Image = WindowsFormsApp2.Properties.Resources.mustard;
        }
    }
}
