using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor.Enchant
{
    public partial class EnchantSettingForm : Form
    {
        private EnchantData enchantData;

        public EnchantSettingForm(EnchantData enchantData)
        {
            InitializeComponent();

            this.enchantData = enchantData;
            Init();
        }

        private void Init()
        {
            foreach(var item in EnchantData.EnchantTypeList)
            {
                EnchantComboBox.Items.Add(item.description);
            }

            EnchantComboBox.SelectedIndex = enchantData.GetEnchantTypeIndex();
            EnchantLevelNumeric.Value = enchantData.GetEnchantLevel();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            enchantData.SetEnchantTypeIndex(EnchantComboBox.SelectedIndex);
            enchantData.SetEnchantLevel((int)EnchantLevelNumeric.Value);
        }
    }
}
