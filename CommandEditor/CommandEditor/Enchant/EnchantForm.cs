using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor.Enchant
{
    public partial class EnchantForm : UserControl
    {
        public EnchantForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            DataChange();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataDelete();
        }


        private void DataAdd()
        {
            EnchantData enchantData = new EnchantData();
            EnchantSettingForm enchantSettingForm = new EnchantSettingForm(enchantData);

            if(enchantSettingForm.ShowDialog() == DialogResult.OK)
            {
                EnchantListBox.Items.Add(enchantData);
            }
        }

        private void DataChange()
        {
            var selectedItem = (EnchantData)EnchantListBox.SelectedItem;
            int selectIndex = EnchantListBox.SelectedIndex;
            EnchantSettingForm enchantSettingForm = new EnchantSettingForm(selectedItem);

            if (enchantSettingForm.ShowDialog() == DialogResult.OK)
            {
                EnchantListBox.Items.RemoveAt(selectIndex);
                EnchantListBox.Items.Add(selectedItem);
            }
        }

        private void DataDelete()
        {
            var selectedItem = EnchantListBox.SelectedItem;
            EnchantListBox.Items.Remove(selectedItem);
        }
    }
}
