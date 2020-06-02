namespace CommandEditor.Item
{
    partial class ItemNBTSettingForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.destroyDeleteButton = new System.Windows.Forms.Button();
            this.destroyAddButton = new System.Windows.Forms.Button();
            this.destroyBlockCombBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.canDestroyListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolForm1 = new CommandEditor.Item.ToolForm();
            this.blockForm1 = new CommandEditor.Item.NBTUserForm.BlockForm();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(364, 441);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(283, 441);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 19;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // destroyDeleteButton
            // 
            this.destroyDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destroyDeleteButton.Location = new System.Drawing.Point(364, 89);
            this.destroyDeleteButton.Name = "destroyDeleteButton";
            this.destroyDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.destroyDeleteButton.TabIndex = 39;
            this.destroyDeleteButton.Text = "削除";
            this.destroyDeleteButton.UseVisualStyleBackColor = true;
            // 
            // destroyAddButton
            // 
            this.destroyAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destroyAddButton.Location = new System.Drawing.Point(283, 89);
            this.destroyAddButton.Name = "destroyAddButton";
            this.destroyAddButton.Size = new System.Drawing.Size(75, 23);
            this.destroyAddButton.TabIndex = 38;
            this.destroyAddButton.Text = "追加";
            this.destroyAddButton.UseVisualStyleBackColor = true;
            // 
            // destroyBlockCombBox
            // 
            this.destroyBlockCombBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.destroyBlockCombBox.FormattingEnabled = true;
            this.destroyBlockCombBox.Location = new System.Drawing.Point(134, 91);
            this.destroyBlockCombBox.Name = "destroyBlockCombBox";
            this.destroyBlockCombBox.Size = new System.Drawing.Size(143, 20);
            this.destroyBlockCombBox.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 33);
            this.label2.TabIndex = 36;
            this.label2.Text = "破壊可能ブロック(Adv)";
            // 
            // canDestroyListBox
            // 
            this.canDestroyListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.canDestroyListBox.FormattingEnabled = true;
            this.canDestroyListBox.ItemHeight = 12;
            this.canDestroyListBox.Location = new System.Drawing.Point(134, 9);
            this.canDestroyListBox.Name = "canDestroyListBox";
            this.canDestroyListBox.ScrollAlwaysVisible = true;
            this.canDestroyListBox.Size = new System.Drawing.Size(305, 76);
            this.canDestroyListBox.TabIndex = 35;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.toolForm1);
            this.flowLayoutPanel1.Controls.Add(this.blockForm1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(424, 318);
            this.flowLayoutPanel1.TabIndex = 40;
            // 
            // toolForm1
            // 
            this.toolForm1.Location = new System.Drawing.Point(3, 3);
            this.toolForm1.Name = "toolForm1";
            this.toolForm1.Size = new System.Drawing.Size(212, 58);
            this.toolForm1.TabIndex = 0;
            // 
            // blockForm1
            // 
            this.blockForm1.Location = new System.Drawing.Point(3, 67);
            this.blockForm1.Name = "blockForm1";
            this.blockForm1.Size = new System.Drawing.Size(421, 116);
            this.blockForm1.TabIndex = 1;
            // 
            // ItemNBTSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 466);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.destroyDeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.destroyAddButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.destroyBlockCombBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.canDestroyListBox);
            this.Name = "ItemNBTSettingForm";
            this.Text = "ItemNBTSettingForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button destroyDeleteButton;
        private System.Windows.Forms.Button destroyAddButton;
        private System.Windows.Forms.ComboBox destroyBlockCombBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox canDestroyListBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ToolForm toolForm1;
        private NBTUserForm.BlockForm blockForm1;
    }
}