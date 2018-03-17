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
        double KetchupSum = 0;
        double KetchupPrice = 10;
        double KetchupThousands = 0;
        double MustardSum = 0;
        double MustardPrice = 100;
        double MustardThousands = 0;
        double SausagePerSec = 0;
        double ClickValue = 1;
        double BBQPrice = 1000;
        double BBQThousands = 0;
        double SecsLeft = 0;
        double CounterThousands = 0;
        double GrillCooldownLeft = 0;
        bool SaveExists = false;
        public SausageIdle()
        {
            InitializeComponent();
            DisplaySausagesPerSec.Text = "0";
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            SaveExists = (System.IO.File.Exists(appdata + "\\SosejiIdle\\Save.txt") ? true : false);
            if (SaveExists == true)
            {
                string[] SaveData = System.IO.File.ReadAllLines(@appdata + "\\SosejiIdle\\Save.txt");
                double[] LoadedData = Array.ConvertAll(SaveData, new Converter<string, double>(Double.Parse));
                SausageBank = LoadedData[0];
                KetchupSum = LoadedData[1];
                KetchupPrice = LoadedData[2];
                KetchupThousands = LoadedData[3];
                MustardSum = LoadedData[4];
                MustardPrice = LoadedData[5];
                MustardThousands = LoadedData[6];
                SausagePerSec = LoadedData[7];
                ClickValue = LoadedData[8];
                BBQPrice = LoadedData[9];
                BBQThousands = LoadedData[10];
                CounterThousands = LoadedData[11];
                GrillCooldownLeft = LoadedData[12];
            }
        }
        private void SausageIdle_Load(object sender, EventArgs e)
        {
            if (SausageBank > 999)
            { SausageCounter.Text = CounterThousands.ToString("0.00") + "k vegan sausages"; }
            else if (SausageBank > 0)
            {
                SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
            }
            if (KetchupSum > 0)
            {
                UpgradeKetchup.Text = "Ketchup x" + KetchupSum;
                if (SausageBank >= KetchupPrice)
                { UpgradeKetchup.Enabled = true; }
                DisplayKetchupPrice.Text = KetchupPrice.ToString("0");
                DisplayKetchupPerSec.Text = KetchupSum.ToString("0") + " SPS";
                if (KetchupPrice > 999)
                {
                    DisplayKetchupPrice.Text = KetchupThousands.ToString("0.00") + "k";
                }
                else
                {
                    DisplayKetchupPrice.Text = KetchupPrice.ToString("0");
                }
                IdleMode.Enabled = true;
            }
            if (SausageBank >= MustardPrice && KetchupSum > 9 || MustardSum > 0 || SausageBank > 199)
            {
                UpgradeMustard.Visible = true;
                DisplayMustardPrice.Visible = true;
                DisplayMustardPerSec.Visible = true;
                if (SausageBank >= MustardPrice)
                {
                    UpgradeMustard.Enabled = true;
                }
                if (MustardPrice > 999)
                {
                    DisplayMustardPrice.Text = MustardThousands.ToString("0.00") + "k";
                }
                else
                {
                    DisplayMustardPrice.Text = MustardPrice.ToString("0");
                }

                DisplayMustardPerSec.Text = MustardSum.ToString("0") + " SPS";
                UpgradeMustard.Text = "Mustard x" + MustardSum / 5;
            }
            if (ClickValue > 1)
            {
                UpgradeBBQTools.Text = "Clicks x" + ClickValue / 5;
                BBQThousands = BBQPrice / 1000;
                DisplayBBQToolsPrice.Text = BBQThousands.ToString("0.00") + "k";
                UpgradeBBQTools.Visible = true;
                DisplayBBQToolsPrice.Visible = true;
                if (SausageBank < BBQPrice)
                { UpgradeBBQTools.Enabled = false; }
                SausagePerClick.Text = ClickValue.ToString();
            }
            DisplaySausagesPerSec.Text = SausagePerSec.ToString();
            if (GrillCooldownLeft > 0)
            {
                AutoclickSkill.Enabled = false;
                AutoclickSkill.Text = "Grill OFF " + GrillCooldownLeft.ToString();
                GrillCooldownRemainingTimer.Enabled = true;
            }
            if (SausageBank > KetchupPrice)
            { UpgradeKetchup.Enabled = true; }
            if (SausageBank > MustardPrice)
            { UpgradeMustard.Enabled = true; }
            if (SausageBank > BBQPrice)
            { UpgradeBBQTools.Enabled = true; UpgradeBBQTools.Visible = true; DisplayBBQToolsPrice.Visible = true; }
        }

        private void ClickSausage_Click(object sender, EventArgs e)
        {
            // Gain sausages by clicking, and display output.
            SausageBank = SausageBank + ClickValue;
            if (SausageBank > 999)
            {
                CounterThousands = SausageBank / 1000;
                SausageCounter.Text = CounterThousands.ToString("0.00") + "k vegan sausages";
            }
            else
            {
                SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
            }
            // Unlock new upgrades
            if (SausageBank >= KetchupPrice)
            { UpgradeKetchup.Enabled = true; }
            if (SausageBank >= MustardPrice && KetchupPrice >= 50)
            { UpgradeMustard.Enabled = true; };
            if (SausageBank >= BBQPrice)
            { UpgradeBBQTools.Visible = true; DisplayBBQToolsPrice.Visible = true; UpgradeBBQTools.Enabled = true; }
            if (SausageBank >= MustardPrice * 2)
            {
                UpgradeMustard.Visible = true;
                DisplayMustardPrice.Visible = true;
                DisplayMustardPerSec.Visible = true;
                UpgradeMustard.Enabled = true;
            }
        }


        private void UpgradeKetchup_Click(object sender, EventArgs e)
        {
            if (SausageBank >= KetchupPrice)
            {
                IdleMode.Enabled = true;
                KetchupSum = KetchupSum + 1;
                SausagePerSec = KetchupSum + MustardSum;
                SausageBank = SausageBank - KetchupPrice;
                if (SausageBank > 999)
                {
                    CounterThousands = SausageBank / 1000;
                    SausageCounter.Text = CounterThousands.ToString("0.00") + "k vegan sausages";
                }
                else
                {
                    SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
                }
                DisplaySausagesPerSec.Text = SausagePerSec.ToString("0");
                KetchupPrice = KetchupPrice * 1.15;
                DisplayKetchupPerSec.Text = KetchupSum.ToString("0") + " SPS";
                UpgradeKetchup.Text = "Ketchup x" + KetchupSum;
            }
            if (KetchupSum > 9)
            {
                UpgradeMustard.Visible = true;
                DisplayMustardPrice.Visible = true;
                DisplayMustardPerSec.Visible = true;
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
                KetchupThousands = KetchupPrice / 1000;
                DisplayKetchupPrice.Text = KetchupThousands.ToString("0.00") + "k";
            }
            if (SausageBank < BBQPrice)
            {
                UpgradeBBQTools.Enabled = false;
            }
        }

        private void IdleMode_Tick(object sender, EventArgs e)
        {
            SausageBank = SausageBank + SausagePerSec / 10;
            if (SausageBank > 999)
            {
                CounterThousands = SausageBank / 1000;
                SausageCounter.Text = CounterThousands.ToString("0.00") + "k vegan sausages";
            }
            else
            {
                SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
            }
            if (SausageBank >= KetchupPrice)
            { UpgradeKetchup.Enabled = true; }
            if (SausageBank >= MustardPrice && KetchupSum > 9)
            { UpgradeMustard.Enabled = true; }
            if (SausageBank >= BBQPrice)
            { UpgradeBBQTools.Enabled = true; }
            if (SausageBank >= BBQPrice)
            { UpgradeBBQTools.Visible = true; DisplayBBQToolsPrice.Visible = true; UpgradeBBQTools.Enabled = true; }
            if (SausageBank >= MustardPrice * 2)
            {
                UpgradeMustard.Visible = true;
                DisplayMustardPrice.Visible = true;
                DisplayMustardPerSec.Visible = true;
                UpgradeMustard.Enabled = true;
            }

        }

        private void UpgradeMusatrd_Click(object sender, EventArgs e)
        {
            if (SausageBank >= MustardPrice)
            {
                IdleMode.Enabled = true;
                MustardSum = MustardSum + 5;
                SausagePerSec = KetchupSum + MustardSum;
                SausageBank = SausageBank - MustardPrice;
                if (SausageBank > 999)
                {
                    CounterThousands = SausageBank / 1000;
                    SausageCounter.Text = CounterThousands.ToString("0.00") + "k vegan sausages";
                }
                else
                {
                    SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
                }
                DisplaySausagesPerSec.Text = SausagePerSec.ToString("0");
                MustardPrice = MustardPrice * 1.25;
                DisplayMustardPerSec.Text = MustardSum.ToString("0") + " SPS";
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
                MustardThousands = MustardPrice / 1000;
                DisplayMustardPrice.Text = MustardThousands.ToString("0.00") + "k";
            }
            if (SausageBank < BBQPrice)
            {
                UpgradeBBQTools.Enabled = false;
            }
        }

        private void BBQTools_Click(object sender, EventArgs e)
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
            SausageBank = SausageBank - BBQPrice;
            BBQPrice = BBQPrice * 1.4;
            if (BBQPrice < 1000)
            {
                DisplayBBQToolsPrice.Text = BBQPrice.ToString("0");
            }
            else if (BBQPrice > 999 && BBQPrice < 1000000)
            {
                BBQThousands = BBQPrice / 1000;
                DisplayBBQToolsPrice.Text = BBQThousands.ToString("0.00") + "k";
            }
            UpgradeBBQTools.Text = "Clicks x" + ClickValue / 5;
            if (SausageBank < BBQPrice)
            {
                UpgradeBBQTools.Enabled = false;
            }
            if (SausageBank < KetchupPrice)
            {
                UpgradeKetchup.Enabled = false;
            }
            if (SausageBank < MustardPrice)
            {
                UpgradeMustard.Enabled = false;
            }
            if (SausageBank > 999)
            {
                CounterThousands = SausageBank / 1000;
                SausageCounter.Text = CounterThousands.ToString("0.00") + "k vegan sausages";
            }
            else
            {
                SausageCounter.Text = SausageBank.ToString("0") + "  vegan sausages";
            }
        }

        private void AutoclickSkill_Click(object sender, EventArgs e)
        {
            ThirtySecCooldown.Enabled = true;
            AutoclickActive.Enabled = true;
            TenSecDuration.Enabled = true;
            AutoclickSkill.Text = "Grill ON 10";
            SecsLeft = 10;
            AutoclickSecondsLeft.Enabled = true;
            AutoclickSkill.Enabled = false;
            GrillCooldownLeft = 30;
            GrillCooldownRemainingTimer.Enabled = true;
        }

        //Timers
        private void ThirtySecCooldown_Tick(object sender, EventArgs e)
        {
            GrillCooldownRemainingTimer.Enabled = false;
            AutoclickActive.Enabled = false;
            AutoclickSkill.Enabled = true;
            AutoclickSkill.Text = "Grill READY";
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
            TenSecDuration.Enabled = false;
        }

        private void AutoclickSecondsLeft_Tick(object sender, EventArgs e)
        {
            SecsLeft = SecsLeft - 1;
            AutoclickSkill.Text = "Grill ON " + SecsLeft;
        }
        //End of timers

        //Graphics
        private void UpgradeKetchup_MouseDown(object sender, MouseEventArgs e)
        {
            
            UpgradeKetchup.Image = WindowsFormsApp2.Properties.Resources.KetchupBig;
            UpgradeKetchup.Location = new Point(520, 65);
            
        }
        private void UpgradeKetchup_MouseUp(object sender, MouseEventArgs e)
        {
            UpgradeKetchup.Image = WindowsFormsApp2.Properties.Resources.Ketchup;
            UpgradeKetchup.Location = new Point(520, 73);
        }
        private void ClickSausage_MouseDown(object sender, MouseEventArgs e)
        {
            
           ClickSausage.Image = WindowsFormsApp2.Properties.Resources.SausageBig;
           ClickSausage.Location = new Point(112, 71);
           
        }
        private void ClickSausage_MouseUp(object sender, MouseEventArgs e)
        {      
           ClickSausage.Image = WindowsFormsApp2.Properties.Resources.Sausage;
           ClickSausage.Location = new Point(124, 81);           
        }
        private void UpgradeMustard_MouseDown(object sender, MouseEventArgs e)
        {
            UpgradeMustard.Image = WindowsFormsApp2.Properties.Resources.MustardBig;
            UpgradeMustard.Location = new Point(520, 222); 
        }
        private void UpgradeMustard_MouseUp(object sender, MouseEventArgs e)
        {
            UpgradeMustard.Image = WindowsFormsApp2.Properties.Resources.Mustard;
            UpgradeMustard.Location = new Point(520, 230);
        }
        //End of graphics

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Save data to a file 
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] SaveData = { SausageBank.ToString(), KetchupSum.ToString(), KetchupPrice.ToString(), KetchupThousands.ToString(), MustardSum.ToString(), MustardPrice.ToString(), MustardThousands.ToString(), SausagePerSec.ToString(),
            ClickValue.ToString(), BBQPrice.ToString(), BBQThousands.ToString(), CounterThousands.ToString(),GrillCooldownLeft.ToString()};
            System.IO.Directory.CreateDirectory(appdata + "\\SosejiIdle");
            System.IO.File.WriteAllLines(@appdata + "\\SosejiIdle\\Save.txt", SaveData);
            SaveMessageTimer.Enabled = false;
            DisplayGameSaved.Visible = true;
            SaveMessageTimer.Enabled = true;

        }
        private void DeleteGame_Click(object sender, EventArgs e)
        {
            { 
            // Delete savefile
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            if (System.IO.File.Exists(@appdata + "\\SosejiIdle\\Save.txt"))
            {
                DialogResult DeleteEverything = MessageBox.Show("Erase everything and start over? This cannot be undone.", "EXTERMINATE!", MessageBoxButtons.OKCancel);
                if (DeleteEverything == DialogResult.OK)
                {
                    System.IO.File.Delete(@appdata + "\\SosejiIdle\\Save.txt");
                    System.IO.Directory.Delete(@appdata + "\\SosejiIdle", true);

                    //Stop Timers
                    IdleMode.Enabled = false;
                    ThirtySecCooldown.Enabled = false;
                    AutoclickActive.Enabled = false;
                    TenSecDuration.Enabled = false;
                    AutoclickSecondsLeft.Enabled = false;
                    SaveMessageTimer.Enabled = false;

                    //Reset stats
                    SausageBank = 0;
                    KetchupSum = 0;
                    KetchupPrice = 10;
                    KetchupThousands = 0;
                    MustardSum = 0;
                    MustardPrice = 100;
                    MustardThousands = 0;
                    SausagePerSec = 0;
                    ClickValue = 1;
                    BBQPrice = 1000;
                    BBQThousands = 0;
                    SecsLeft = 0;
                    CounterThousands = 0;
                    GrillCooldownLeft = 0;
                    SaveExists = false;

                    //Reset labels and buttons
                    SausageCounter.Text = "0";
                    DisplaySausagesPerSec.Text = "0";
                    SausagePerClick.Text = "0";
                    //Ketchup
                    UpgradeKetchup.Enabled = false;
                    UpgradeKetchup.Text = "Ketchup";
                    DisplayKetchupPerSec.Text = "0";
                    DisplayKetchupPrice.Text = "10";
                    //Mustard
                    UpgradeMustard.Enabled = false;
                    UpgradeMustard.Text = "Mustard";
                    DisplayMustardPerSec.Text = "0";
                    DisplayMustardPrice.Text = "100";
                    //BBQ
                    UpgradeBBQTools.Enabled = false;
                    UpgradeBBQTools.Text = "Clicks";
                    DisplayBBQToolsPrice.Text = "1000";
                    SausagePerClick.Text = "1";
                    //Grill
                    AutoclickSkill.Text = "Grill READY";
                    AutoclickSkill.Enabled = true;

                    DisplayGameSaved.Visible = true;
                    DisplayGameSaved.Text = "Save deleted!";
                    SaveMessageTimer.Enabled = true;
                }
            
        }

                else { MessageBox.Show("No save exists."); }
            }
        }
        private void SaveMessageTimer_Tick(object sender, EventArgs e)
        {
            DisplayGameSaved.Visible = false;
            SaveMessageTimer.Enabled = false;
        }

        private void GrillCooldownRemainingTimer_Tick(object sender, EventArgs e)
        {
            GrillCooldownLeft = GrillCooldownLeft - 1;
            if (TenSecDuration.Enabled == false)
            { AutoclickSkill.Text = "Grill OFF " + GrillCooldownLeft; }
            if (GrillCooldownLeft < 1)
            {
                AutoclickSkill.Enabled = true;
                AutoclickSkill.Text = "Grill READY";
                GrillCooldownRemainingTimer.Enabled = false;
            }
        }

        private void SausageIdle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult CloseGame = MessageBox.Show("Are you sure you want to close the game?", "Goodbye.", MessageBoxButtons.OKCancel);
            if (CloseGame == DialogResult.OK)
            {
                DialogResult WouldYouLikeToSave = MessageBox.Show("Would you like to save first?", "Save before leaving.", MessageBoxButtons.YesNoCancel);
                if (WouldYouLikeToSave == DialogResult.Yes)
                {
                    SaveGame.PerformClick();
                }
                else if (WouldYouLikeToSave == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
