using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MapSettingsCustomizer
{
    public partial class MapSettingsCustomizerForm : Form
    {
        public MapSettingsCustomizerForm()
        {
            InitializeComponent();
        }

        private void DirectoryBrowseButton_Click(object sender, EventArgs e)
        {
            if (osuDirectoryBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                DirectoryInputBox.Text = osuDirectoryBrowseDialog.SelectedPath;
            }
        }

        public string ConstructArgs()
        {

            string mode = "";
            if (CreateModeRadioButton.Checked == true)
            {
                mode = "create";
            }
            else if (UpdateModeRadioButton.Checked == true)
            {
                mode = "update";
            }
            else if (DeleteModeRadioButton.Checked == true)
            {
                mode = "delete";
            }

            string name = NameInputBox.Text;
            string path = "\"" + DirectoryInputBox.Text + "\"";

            double fromHP = FromOldHPBar.Value / 10.0;
            double toHP = ToOldHPBar.Value / 10.0;

            double fromCS = FromOldCSBar.Value / 10.0;
            double toCS = ToOldCSBar.Value / 10.0;

            double fromOD = FromOldODBar.Value / 10.0;
            double toOD = ToOldODBar.Value / 10.0;

            double fromAR = FromOldARBar.Value / 10.0;
            double toAR = ToOldARBar.Value / 10.0;

            double newHP = Convert.ToDouble(NewHPBox.Text);
            double newCS = Convert.ToDouble(NewCSBox.Text);
            double newOD = Convert.ToDouble(NewODBox.Text);
            double newAR = Convert.ToDouble(NewARBox.Text);

            bool relHP = NewHPRelative.Checked;
            bool relCS = NewCSRelative.Checked;
            bool relOD = NewODRelative.Checked;
            bool relAR = NewARRelative.Checked;

            string args = "";

            args += "-" + mode + " -name " + name + " -path " + path;

            if (fromHP > 0) { args += " -fromHP " + fromHP; }
            if (toHP < 10) { args += " -toHP " + toHP; }

            if (fromCS > 0) { args += " -fromCS " + fromCS; }
            if (toCS < 10) { args += " -toCS " + toCS; }

            if (fromOD > 0) { args += " -fromOD " + fromOD; }
            if (toOD < 10) { args += " -toOD " + toOD; }

            if (fromAR > 0) { args += " -fromAR " + fromAR; }
            if (toAR < 10) { args += " -toAR " + toAR; }

            args += " -newHP " + newHP
                + " -newCS " + newCS
                + " -newOD " + newOD
                + " -newAR " + newAR;

            if (relHP) { args += " -relHP " + relHP; }
            if (relCS) { args += " -relCS " + relCS; }
            if (relOD) { args += " -relOD " + relOD; }
            if (relAR) { args += " -relAR " + relAR; }

            return args;
        }

        private void ProcessMapsButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (DirectoryInputBox.Text.Length > 0)
            {
                if (NameInputBox.Text.Length > 0)
                {
                    DialogResult answer = DialogResult.No;
                    if (CreateModeRadioButton.Checked == true)
                    {
                        answer = MessageBox.Show("Are you sure you want to create beatmaps called " + NameInputBox.Text + " with the specified settings?", "Create beatmaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else if (UpdateModeRadioButton.Checked == true)
                    {
                        answer = MessageBox.Show("Are you sure you want to update beatmaps called " + NameInputBox.Text + " with the specified settings?", "Update beatmaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    else if (DeleteModeRadioButton.Checked == true)
                    {
                        answer = MessageBox.Show("Are you sure you want to delete beatmaps called " + NameInputBox.Text + " with the specified settings?", "Delete beatmaps", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    if (answer == DialogResult.Yes)
                    {
                        try
                        {
                            string[] Args = Regex.Matches(ConstructArgs(), "(\"[^\"]+\"|[\\S]+)").Cast<Match>().Select(m => m.Value).ToArray();
                            for (int i = 0; i <= Args.Length - 1; i++)
                            {
                                Args[i] = Args[i].Replace("\"", "");
                            }
                            MapSettingsCustomizer.Main(Args);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error:\r\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine("Cancelled");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Beatmap name prefix not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Cancelled");
                }
            }
            else
            {
                MessageBox.Show("Songs folder path not set!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Cancelled");
            }
            Show();
        }

        private void BatchfileSaveDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                string batchfile = ("@ECHO OFF\r\n\"" + Application.ExecutablePath + "\" " + ConstructArgs() + "\r\npause").Trim();
                File.WriteAllText(BatchfileSaveDialog.FileName, batchfile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            BatchfileSaveDialog.FileName = "";
        }

        private void BatchfileSaveButton_Click(object sender, EventArgs e)
        {
            BatchfileSaveDialog.ShowDialog();
        }

        private void NewHPRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (NewHPRelative.Checked)
            {
                NewHPBar.Enabled = false;
                NewHPBox.Text = "0";
            }
            else
            {
                NewHPBar.Enabled = true;
                NewHPBox.Text = Convert.ToString(NewHPBar.Value / 10.0);
            }
        }

        private void NewCSRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (NewCSRelative.Checked)
            {
                NewCSBar.Enabled = false;
                NewCSBox.Text = "0";
            }
            else
            {
                NewCSBar.Enabled = true;
                NewCSBox.Text = Convert.ToString(NewCSBar.Value / 10.0);
            }
        }

        private void NewODRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (NewODRelative.Checked)
            {
                NewODBar.Enabled = false;
                NewODBox.Text = "0";
            }
            else
            {
                NewODBar.Enabled = true;
                NewODBox.Text = Convert.ToString(NewODBar.Value / 10.0);
            }
        }

        private void NewARRelative_CheckedChanged(object sender, EventArgs e)
        {
            if (NewARRelative.Checked)
            {
                NewARBar.Enabled = false;
                NewARBox.Text = "0";
            }
            else
            {
                NewARBar.Enabled = true;
                NewARBox.Text = Convert.ToString(NewARBar.Value / 10.0);
            }
        }

        private void FromOldHPBar_Scroll(object sender, EventArgs e)
        {
            if (FromOldHPBar.Value > ToOldHPBar.Value)
            {
                FromOldHPBar.Value = ToOldHPBar.Value;
            }
            FromOldHPLabel.Text = "From " + FromOldHPBar.Value / 10.0;
        }

        private void FromOldCSBar_Scroll(object sender, EventArgs e)
        {
            if (FromOldCSBar.Value > ToOldCSBar.Value)
            {
                FromOldCSBar.Value = ToOldCSBar.Value;
            }
            FromOldCSLabel.Text = "From " + FromOldCSBar.Value / 10.0;
        }

        private void FromOldODBar_Scroll(object sender, EventArgs e)
        {
            if (FromOldODBar.Value > ToOldODBar.Value)
            {
                FromOldODBar.Value = ToOldODBar.Value;
            }
            FromOldODLabel.Text = "From " + FromOldODBar.Value / 10.0;
        }

        private void FromOldARBar_Scroll(object sender, EventArgs e)
        {
            if (FromOldARBar.Value > ToOldARBar.Value)
            {
                FromOldARBar.Value = ToOldARBar.Value;
            }
            FromOldARLabel.Text = "From " + FromOldARBar.Value / 10.0;
        }

        private void ToOldHPBar_Scroll(object sender, EventArgs e)
        {
            if (ToOldHPBar.Value < FromOldHPBar.Value)
            {
                ToOldHPBar.Value = FromOldHPBar.Value;
            }
            ToOldHPLabel.Text = "To " + ToOldHPBar.Value / 10.0;
        }

        private void ToOldCSBar_Scroll(object sender, EventArgs e)
        {
            if (ToOldCSBar.Value < FromOldCSBar.Value)
            {
                ToOldCSBar.Value = FromOldCSBar.Value;
            }
            ToOldCSLabel.Text = "To " + ToOldCSBar.Value / 10.0;
        }

        private void ToOldODBar_Scroll(object sender, EventArgs e)
        {
            if (ToOldODBar.Value < FromOldODBar.Value)
            {
                ToOldODBar.Value = FromOldODBar.Value;
            }
            ToOldODLabel.Text = "To " + ToOldODBar.Value / 10.0;
        }

        private void ToOldARBar_Scroll(object sender, EventArgs e)
        {
            if (ToOldARBar.Value < FromOldARBar.Value)
            {
                ToOldARBar.Value = FromOldARBar.Value;
            }
            ToOldARLabel.Text = "To " + ToOldARBar.Value / 10.0;
        }

        private void NewHPBar_Scroll(object sender, EventArgs e)
        {
            NewHPBox.Text = Convert.ToString(NewHPBar.Value / 10.0);
        }

        private void NewCSBar_Scroll(object sender, EventArgs e)
        {
            NewCSBox.Text = Convert.ToString(NewCSBar.Value / 10.0);
        }

        private void NewODBar_Scroll(object sender, EventArgs e)
        {
            NewODBox.Text = Convert.ToString(NewODBar.Value / 10.0);
        }

        private void NewARBar_Scroll(object sender, EventArgs e)
        {
            NewARBox.Text = Convert.ToString(NewARBar.Value / 10.0);
        }

        private void DirectoryDetectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] taSongs = Convert.ToString(Microsoft.Win32.Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\osu\\DefaultIcon", "", "\"C\\\",0")).Split(Convert.ToChar("\""));
                DirectoryInputBox.Text = taSongs[1].Replace("osu!.exe", "Songs");
            }
            catch
            {
                MessageBox.Show("Can't find osu! folder from registry!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewHPBox_TextChanged(object sender, EventArgs e)
        {
            if (NewHPRelative.Checked == false)
            {
                double d = 0;
                double.TryParse(NewHPBox.Text, out d);
                if (d > 10)
                {
                    d = 10;
                    NewHPBox.Text = "10";
                    NewHPBox.SelectAll();
                }
                if (d < 0)
                {
                    d = 0;
                    NewHPBox.Text = "0";
                    NewHPBox.SelectAll();
                }
                NewHPBar.Value = Convert.ToInt32(d * 10);
            }
        }

        private void NewCSBox_TextChanged(object sender, EventArgs e)
        {
            if (NewCSRelative.Checked == false)
            {
                double d = 0;
                double.TryParse(NewCSBox.Text, out d);
                if (d > 10)
                {
                    d = 10;
                    NewCSBox.Text = "10";
                    NewCSBox.SelectAll();
                }
                if (d < 0)
                {
                    d = 0;
                    NewCSBox.Text = "0";
                    NewCSBox.SelectAll();
                }
                NewCSBar.Value = Convert.ToInt32(d * 10);
            }
        }

        private void NewODBox_TextChanged(object sender, EventArgs e)
        {
            if (NewODRelative.Checked == false)
            {
                double d = 0;
                double.TryParse(NewODBox.Text, out d);
                if (d > 10)
                {
                    d = 10;
                    NewODBox.Text = "10";
                    NewODBox.SelectAll();
                }
                if (d < 0)
                {
                    d = 0;
                    NewODBox.Text = "0";
                    NewODBox.SelectAll();
                }
                NewODBar.Value = Convert.ToInt32(d * 10);
            }
        }

        private void NewARBox_TextChanged(object sender, EventArgs e)
        {
            if (NewARRelative.Checked == false)
            {
                double d = 0;
                double.TryParse(NewARBox.Text, out d);
                if (d > 10)
                {
                    d = 10;
                    NewARBox.Text = "10";
                    NewARBox.SelectAll();
                }
                if (d < 0)
                {
                    d = 0;
                    NewARBox.Text = "0";
                    NewARBox.SelectAll();
                }
                NewARBar.Value = Convert.ToInt32(d * 10);
            }
        }

        private void DubuLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://osu.ppy.sh/u/Dubu");
        }

        private void JTFLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://osu.ppy.sh/u/JTF195");
        }
    }
}