namespace CommandEditor.Item
{
    partial class ToolForm
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
            this.damageNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unBrakingCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.damageNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // damageNumeric
            // 
            this.damageNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.damageNumeric.Location = new System.Drawing.Point(118, 8);
            this.damageNumeric.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.damageNumeric.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.damageNumeric.Name = "damageNumeric";
            this.damageNumeric.Size = new System.Drawing.Size(91, 19);
            this.damageNumeric.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "消耗量";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "耐久フラグ";
            // 
            // unBrakingCheck
            // 
            this.unBrakingCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unBrakingCheck.AutoSize = true;
            this.unBrakingCheck.Location = new System.Drawing.Point(118, 33);
            this.unBrakingCheck.Name = "unBrakingCheck";
            this.unBrakingCheck.Size = new System.Drawing.Size(15, 14);
            this.unBrakingCheck.TabIndex = 27;
            this.unBrakingCheck.UseVisualStyleBackColor = true;
            // 
            // ToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unBrakingCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.damageNumeric);
            this.Controls.Add(this.label7);
            this.Name = "ToolForm";
            this.Size = new System.Drawing.Size(212, 58);
            ((System.ComponentModel.ISupportInitialize)(this.damageNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown damageNumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox unBrakingCheck;
    }
}
