using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor.AddAbility
{
    public partial class AbilitySettingForm : Form
    {
        private AbilityData abilityData;

        public AbilitySettingForm(AbilityData abilityData)
        {
            InitializeComponent();

            this.abilityData = abilityData;
            Init();
        }

        private void Init()
        {
            // 能力一覧を設定
            foreach (var item in AbilityData.AbilityTypeList)
            {
                AbilityTypeComboBox.Items.Add(item.name);
            }
            // 計算方法を設定
            foreach(var item in AbilityData.OperationList)
            {
                OperationComboBox.Items.Add(item.description);
            }
            // 装備箇所を設定
            foreach(var item in AbilityData.SlotList)
            {
                SlotCombBox.Items.Add(item.name);
            }

            AbilityNameTextBox.Text = abilityData.GetAbilityName();
            AbilityTypeComboBox.SelectedIndex = abilityData.GetAbilityTypeIndex();
            ValueNumeric.Value = new decimal(abilityData.GetValue());
            OperationComboBox.SelectedIndex = abilityData.GetOperationIndex();
            SlotCombBox.SelectedIndex = abilityData.GetSlotIndex();
            UUIDMostNumeric.Value = int.Parse(abilityData.GetUUIDMost());   
            UUIDLeastNumeric.Value = int.Parse(abilityData.GetUUIDLeast());

        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            // データをセット
            abilityData.SetAbilityName(AbilityNameTextBox.Text);
            abilityData.SetAbilityTypeIndex(AbilityTypeComboBox.SelectedIndex);
            abilityData.SetValue((float)ValueNumeric.Value);
            abilityData.SetOperationIndex(OperationComboBox.SelectedIndex);
            abilityData.SetSlotIndex(SlotCombBox.SelectedIndex);
            abilityData.SetUUIDMost(UUIDMostNumeric.Value.ToString());
            abilityData.SetUUIDLeast(UUIDLeastNumeric.Value.ToString());
        }
    }
}
