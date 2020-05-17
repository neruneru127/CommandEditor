using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor
{
    public partial class TargetSelectForm : UserControl
    {
        public struct TargetSelect
        {
            public string name;
            public string description;
        }

        public static readonly TargetSelect[] TargetSelectList =
        {
            new TargetSelect {name = "@a", description = "すべてのプレイヤー"},
            new TargetSelect {name = "@e", description = "すべてのエンティティ"},
            new TargetSelect {name = "@p", description = "最も近いプレイヤー"},
            new TargetSelect {name = "@r", description = "ランダムなプレイヤー"},
            new TargetSelect {name = "@s", description = "実行したエンティティ"}
        };


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
            foreach(var item in TargetSelectList)
            {
                TargetSelectCombBox.Items.Add(item.name);
            }
        }

        private void NBTSettingButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
