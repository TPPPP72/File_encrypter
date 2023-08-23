using Sunny.UI;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace encrypter_ui
{
    public partial class Mainwindow : UIForm
    {
        public Mainwindow()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择等待操作的文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dialog.FileName.IndexOf(' ') == -1)
                    Inpathbox.Text = dialog.FileName;
                else
                    Inpathbox.Text = $"\"{dialog.FileName}\"";
            }
        }

        private void SelectDir_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择操作后文件的输出路径";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    if (dialog.SelectedPath.IndexOf(' ') == -1)
                        Outpathbox.Text = dialog.SelectedPath;
                    else
                        Outpathbox.Text = $"\"{dialog.SelectedPath}\"";
                }
        }

        private void Encode_CheckedChanged(object sender, EventArgs e)
        {
            Runbutton.Visible = true;
            Runbutton.Text = "开始加密";
        }

        private void Decode_CheckedChanged(object sender, EventArgs e)
        {
            Runbutton.Visible = true;
            Runbutton.Text = "开始解密";
        }

        private void Runbutton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("encrypt.exe"))
            {
                UIMessageTip.ShowError("未在目录下检测到encrypt.exe");
                return;
            }
            if (Inpathbox.Text.IndexOf('\\') == -1)
            {
                UIMessageTip.ShowError("没有传入输入路径");
                return;
            }
            string password = "";
            UIInputDialog.InputStringDialog(ref password, desc: "请输入密码");
            if (password.Length == 0)
                return;
            Process call = new Process();
            call.StartInfo.FileName = "encrypt.exe";
            call.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            call.StartInfo.CreateNoWindow = true;
            call.StartInfo.UseShellExecute = false;
            call.StartInfo.RedirectStandardOutput = true;
            if (Encode.Checked)
            {
                UIMessageTip.ShowOk("加密中......"); call.StartInfo.Arguments = "encode";
            }
            else
            {
                UIMessageTip.ShowOk("解密中......"); call.StartInfo.Arguments = "decode";
            }
            Runbutton.Visible = false;
            call.StartInfo.Arguments += $" {Inpathbox.Text} {password}";
            if (Outpathbox.Text.IndexOf("\\") != -1)
                call.StartInfo.Arguments += $" {Outpathbox.Text}";
            else
                call.StartInfo.Arguments += $" null";
            call.StartInfo.Arguments += " official-hack";
            call.Start();
            StreamReader reader = call.StandardOutput;
            string output = reader.ReadToEnd();
            call.WaitForExit();
            if (call.ExitCode == 404)
                UINotifier.ShowDialog($"文件处理成功，处理后的文件在：{output}", "文件处理结果");
            else
                UINotifier.ShowDialog($"文件处理异常 返回码{call.ExitCode}", "文件处理结果", UINotifierType.ERROR);
            call.Close();
            Runbutton.Visible = true;
        }
    }
}
