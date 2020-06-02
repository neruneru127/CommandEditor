namespace CommandEditor.Item.NBTUserForm
{
    partial class BlockForm
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.placeDeleteButton = new System.Windows.Forms.Button();
            this.placeAddButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.placeBlockCombBox = new System.Windows.Forms.ComboBox();
            this.canPlaceListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // placeDeleteButton
            // 
            this.placeDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placeDeleteButton.Location = new System.Drawing.Point(352, 82);
            this.placeDeleteButton.Name = "placeDeleteButton";
            this.placeDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.placeDeleteButton.TabIndex = 42;
            this.placeDeleteButton.Text = "削除";
            this.placeDeleteButton.UseVisualStyleBackColor = true;
            // 
            // placeAddButton
            // 
            this.placeAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placeAddButton.Location = new System.Drawing.Point(271, 82);
            this.placeAddButton.Name = "placeAddButton";
            this.placeAddButton.Size = new System.Drawing.Size(75, 23);
            this.placeAddButton.TabIndex = 41;
            this.placeAddButton.Text = "追加";
            this.placeAddButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "設置可能ブロック(Adv)";
            // 
            // placeBlockCombBox
            // 
            this.placeBlockCombBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placeBlockCombBox.FormattingEnabled = true;
            this.placeBlockCombBox.Location = new System.Drawing.Point(122, 85);
            this.placeBlockCombBox.Name = "placeBlockCombBox";
            this.placeBlockCombBox.Size = new System.Drawing.Size(143, 20);
            this.placeBlockCombBox.TabIndex = 44;
            // 
            // canPlaceListBox
            // 
            this.canPlaceListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.canPlaceListBox.FormattingEnabled = true;
            this.canPlaceListBox.ItemHeight = 12;
            this.canPlaceListBox.Location = new System.Drawing.Point(122, 3);
            this.canPlaceListBox.Name = "canPlaceListBox";
            this.canPlaceListBox.ScrollAlwaysVisible = true;
            this.canPlaceListBox.Size = new System.Drawing.Size(305, 76);
            this.canPlaceListBox.TabIndex = 43;
            // 
            // BlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.placeBlockCombBox);
            this.Controls.Add(this.canPlaceListBox);
            this.Controls.Add(this.placeDeleteButton);
            this.Controls.Add(this.placeAddButton);
            this.Controls.Add(this.label3);
            this.Name = "BlockForm";
            this.Size = new System.Drawing.Size(430, 116);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button placeDeleteButton;
        private System.Windows.Forms.Button placeAddButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox placeBlockCombBox;
        private System.Windows.Forms.ListBox canPlaceListBox;
    }
}
