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
            foreach (var item in AbilityData.AbilityBaseList)
            {
                abilityTypeComboBox.Items.Add(item.name);
            }
            // 計算方法を設定
            foreach(var item in AbilityData.OperationList)
            {
                operationComboBox.Items.Add(item.description);
            }
            // 装備箇所を設定
            foreach(var item in AbilityData.SlotList)
            {
                slotCombBox.Items.Add(item.name);
            }

            abilityNameTextBox.Text = abilityData.GetAbilityName();
            abilityTypeComboBox.SelectedIndex = abilityData.GetAbilityTypeIndex();
            valueNumeric.Value = new decimal(abilityData.GetValue());
            operationComboBox.SelectedIndex = abilityData.GetOperationIndex();
            slotCombBox.SelectedIndex = abilityData.GetSlotIndex();
            uuidMostNumeric.Value = int.Parse(abilityData.GetUUIDMost());   
            uuidLeastNumeric.Value = int.Parse(abilityData.GetUUIDLeast());

        }


        private void OKButton_Click(object sender, EventArgs e)
        {
            // データをセット
            abilityData.SetAbilityName(abilityNameTextBox.Text);
            abilityData.SetAbilityTypeIndex(abilityTypeComboBox.SelectedIndex);
            abilityData.SetValue((float)valueNumeric.Value);
            abilityData.SetOperationIndex(operationComboBox.SelectedIndex);
            abilityData.SetSlotIndex(slotCombBox.SelectedIndex);
            abilityData.SetUUIDMost(uuidMostNumeric.Value.ToString());
            abilityData.SetUUIDLeast(uuidLeastNumeric.Value.ToString());
        }
    }
}
