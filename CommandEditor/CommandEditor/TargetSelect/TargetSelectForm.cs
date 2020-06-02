using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandEditor.TargetSelect;

namespace CommandEditor
{
    public partial class TargetSelectForm : UserControl
    {
        public TargetSelectForm()
        {
            InitializeComponent();

            Init();
        }

        /// <summary>
        /// 各種変数初期化
        /// </summary>
        private void Init()
        {
            foreach(var item in TargetSelectData.TargetSelectList)
            {
                targetSelectCombBox.Items.Add(item.name);
            }
            targetSelectCombBox.SelectedIndex = 0;
        }

        private void NBTSettingButton_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 現在設定されているセレクタを取得
        /// </summary>
        /// <returns>ターゲットセレクタの文字列</returns>
        public string GetSelecter()
        {
            return TargetSelectData.TargetSelectList[targetSelectCombBox.SelectedIndex].name;
        }
    }
}
