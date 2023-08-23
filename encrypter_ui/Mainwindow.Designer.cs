namespace encrypter_ui
{
    partial class Mainwindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwindow));
            this.SelectFile = new Sunny.UI.UIButton();
            this.Inpathbox = new Sunny.UI.UITextBox();
            this.uiStyleManager = new Sunny.UI.UIStyleManager(this.components);
            this.Encode = new Sunny.UI.UIRadioButton();
            this.Decode = new Sunny.UI.UIRadioButton();
            this.Label1 = new Sunny.UI.UILabel();
            this.Label2 = new Sunny.UI.UILabel();
            this.Outpathbox = new Sunny.UI.UITextBox();
            this.SelectDir = new Sunny.UI.UIButton();
            this.Runbutton = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // SelectFile
            // 
            this.SelectFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFile.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectFile.Location = new System.Drawing.Point(625, 85);
            this.SelectFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(93, 33);
            this.SelectFile.TabIndex = 0;
            this.SelectFile.Text = "选择文件";
            this.SelectFile.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // Inpathbox
            // 
            this.Inpathbox.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.Inpathbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Inpathbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Inpathbox.Location = new System.Drawing.Point(183, 85);
            this.Inpathbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Inpathbox.MinimumSize = new System.Drawing.Size(1, 16);
            this.Inpathbox.Name = "Inpathbox";
            this.Inpathbox.Padding = new System.Windows.Forms.Padding(5);
            this.Inpathbox.ReadOnly = true;
            this.Inpathbox.ShowText = false;
            this.Inpathbox.Size = new System.Drawing.Size(422, 33);
            this.Inpathbox.TabIndex = 1;
            this.Inpathbox.Text = "请选择需要进行加/解密操作的文件";
            this.Inpathbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inpathbox.Watermark = "";
            // 
            // uiStyleManager
            // 
            this.uiStyleManager.DPIScale = true;
            // 
            // Encode
            // 
            this.Encode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Encode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Encode.Location = new System.Drawing.Point(196, 223);
            this.Encode.MinimumSize = new System.Drawing.Size(1, 1);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(67, 29);
            this.Encode.TabIndex = 2;
            this.Encode.Text = "加密";
            this.Encode.CheckedChanged += new System.EventHandler(this.Encode_CheckedChanged);
            // 
            // Decode
            // 
            this.Decode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Decode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Decode.Location = new System.Drawing.Point(537, 223);
            this.Decode.MinimumSize = new System.Drawing.Size(1, 1);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(64, 29);
            this.Decode.TabIndex = 3;
            this.Decode.Text = "解密";
            this.Decode.CheckedChanged += new System.EventHandler(this.Decode_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(73, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 33);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "待处理文件：";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(73, 139);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "输出路径：";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Outpathbox
            // 
            this.Outpathbox.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.Outpathbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Outpathbox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Outpathbox.Location = new System.Drawing.Point(183, 134);
            this.Outpathbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Outpathbox.MinimumSize = new System.Drawing.Size(1, 16);
            this.Outpathbox.Name = "Outpathbox";
            this.Outpathbox.Padding = new System.Windows.Forms.Padding(5);
            this.Outpathbox.ReadOnly = true;
            this.Outpathbox.ShowText = false;
            this.Outpathbox.Size = new System.Drawing.Size(422, 32);
            this.Outpathbox.TabIndex = 6;
            this.Outpathbox.Text = "默认";
            this.Outpathbox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Outpathbox.Watermark = "";
            this.Outpathbox.WatermarkColor = System.Drawing.Color.GhostWhite;
            // 
            // SelectDir
            // 
            this.SelectDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectDir.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectDir.Location = new System.Drawing.Point(625, 134);
            this.SelectDir.MinimumSize = new System.Drawing.Size(1, 1);
            this.SelectDir.Name = "SelectDir";
            this.SelectDir.Size = new System.Drawing.Size(93, 32);
            this.SelectDir.TabIndex = 7;
            this.SelectDir.Text = "选择文件夹";
            this.SelectDir.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelectDir.Click += new System.EventHandler(this.SelectDir_Click);
            // 
            // Runbutton
            // 
            this.Runbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Runbutton.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Runbutton.Location = new System.Drawing.Point(299, 303);
            this.Runbutton.MinimumSize = new System.Drawing.Size(1, 1);
            this.Runbutton.Name = "Runbutton";
            this.Runbutton.Size = new System.Drawing.Size(206, 89);
            this.Runbutton.TabIndex = 8;
            this.Runbutton.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Runbutton.Visible = false;
            this.Runbutton.Click += new System.EventHandler(this.Runbutton_Click);
            // 
            // Mainwindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.Runbutton);
            this.Controls.Add(this.SelectDir);
            this.Controls.Add(this.Outpathbox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.Inpathbox);
            this.Controls.Add(this.SelectFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainwindow";
            this.Text = "文件加密";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton SelectFile;
        private Sunny.UI.UITextBox Inpathbox;
        private Sunny.UI.UIStyleManager uiStyleManager;
        private Sunny.UI.UIRadioButton Encode;
        private Sunny.UI.UIRadioButton Decode;
        private Sunny.UI.UILabel Label1;
        private Sunny.UI.UILabel Label2;
        private Sunny.UI.UITextBox Outpathbox;
        private Sunny.UI.UIButton SelectDir;
        private Sunny.UI.UIButton Runbutton;
    }
}

