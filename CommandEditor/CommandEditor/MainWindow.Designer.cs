namespace CommandEditor
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新規プロジェクトNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.プロジェクトを保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.データパック出力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainCommand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CommandPanel = new System.Windows.Forms.Panel();
            this.giveForm1 = new CommandEditor.GiveForm();
            this.GenerateTextBox = new System.Windows.Forms.TextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.CommandPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新規プロジェクトNToolStripMenuItem,
            this.toolStripMenuItem1,
            this.プロジェクトを保存ToolStripMenuItem,
            this.名前を付けて保存AToolStripMenuItem,
            this.toolStripMenuItem2,
            this.データパック出力ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 新規プロジェクトNToolStripMenuItem
            // 
            this.新規プロジェクトNToolStripMenuItem.Name = "新規プロジェクトNToolStripMenuItem";
            this.新規プロジェクトNToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.新規プロジェクトNToolStripMenuItem.Text = "新規プロジェクト(&N)...";
            this.新規プロジェクトNToolStripMenuItem.Click += new System.EventHandler(this.新規プロジェクトNToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // プロジェクトを保存ToolStripMenuItem
            // 
            this.プロジェクトを保存ToolStripMenuItem.Name = "プロジェクトを保存ToolStripMenuItem";
            this.プロジェクトを保存ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.プロジェクトを保存ToolStripMenuItem.Text = "プロジェクトを保存(&S)";
            // 
            // 名前を付けて保存AToolStripMenuItem
            // 
            this.名前を付けて保存AToolStripMenuItem.Name = "名前を付けて保存AToolStripMenuItem";
            this.名前を付けて保存AToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.名前を付けて保存AToolStripMenuItem.Text = "名前を付けて保存(A)...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // データパック出力ToolStripMenuItem
            // 
            this.データパック出力ToolStripMenuItem.Name = "データパック出力ToolStripMenuItem";
            this.データパック出力ToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.データパック出力ToolStripMenuItem.Text = "データパック出力";
            // 
            // mainCommand
            // 
            this.mainCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainCommand.FormattingEnabled = true;
            this.mainCommand.Location = new System.Drawing.Point(92, 28);
            this.mainCommand.Name = "mainCommand";
            this.mainCommand.Size = new System.Drawing.Size(324, 20);
            this.mainCommand.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "コマンドの種類";
            // 
            // CommandPanel
            // 
            this.CommandPanel.AutoScroll = true;
            this.CommandPanel.Controls.Add(this.giveForm1);
            this.CommandPanel.Location = new System.Drawing.Point(1, 55);
            this.CommandPanel.Name = "CommandPanel";
            this.CommandPanel.Size = new System.Drawing.Size(759, 340);
            this.CommandPanel.TabIndex = 3;
            // 
            // giveForm1
            // 
            this.giveForm1.Location = new System.Drawing.Point(-1, 0);
            this.giveForm1.Name = "giveForm1";
            this.giveForm1.Size = new System.Drawing.Size(760, 340);
            this.giveForm1.TabIndex = 0;
            // 
            // GenerateTextBox
            // 
            this.GenerateTextBox.Location = new System.Drawing.Point(0, 394);
            this.GenerateTextBox.Multiline = true;
            this.GenerateTextBox.Name = "GenerateTextBox";
            this.GenerateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GenerateTextBox.Size = new System.Drawing.Size(586, 44);
            this.GenerateTextBox.TabIndex = 4;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(592, 415);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 5;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(673, 415);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.GenerateTextBox);
            this.Controls.Add(this.CommandPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainCommand);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "NelCommandEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CommandPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新規プロジェクトNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem プロジェクトを保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem データパック出力ToolStripMenuItem;
        private System.Windows.Forms.ComboBox mainCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CommandPanel;
        private GiveForm giveForm1;
        private System.Windows.Forms.TextBox GenerateTextBox;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

