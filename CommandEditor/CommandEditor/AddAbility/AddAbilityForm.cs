using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandEditor.AddAbility;

namespace CommandEditor
{
    public partial class AddAbilityForm : UserControl
    {
        public AddAbilityForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataAdd();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataDelete();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            DataChange();
        }


        private void DataAdd()
        {
            AbilityData abilityData = new AbilityData();
            AbilitySettingForm settingForm = new AbilitySettingForm(abilityData);
            if (settingForm.ShowDialog(this) == DialogResult.OK)
            {
                AddAbilityListBox.Items.Add(abilityData);
            }
             
        }

        private void DataDelete()
        {
            var selectedItem = AddAbilityListBox.SelectedItem;
            AddAbilityListBox.Items.Remove(selectedItem);
        }

        private void DataChange()
        {
            var selectedItem = (AbilityData)AddAbilityListBox.SelectedItem;
            int selectIndex = AddAbilityListBox.SelectedIndex;
            AbilitySettingForm settingForm = new AbilitySettingForm(selectedItem);
            if (settingForm.ShowDialog(this) == DialogResult.OK)
            {
                AddAbilityListBox.Items.RemoveAt(selectIndex);
                AddAbilityListBox.Items.Add(selectedItem);
            }
        }
    }
}
