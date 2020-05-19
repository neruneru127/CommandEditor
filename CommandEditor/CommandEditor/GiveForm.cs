using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommandEditor.Enchant;
using CommandEditor.AddAbility;

namespace CommandEditor
{
    public partial class GiveForm : UserControl
    {
        public GiveForm()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            foreach(var item in ItemData.ItemTypeList)
            {
                ItemCombBox.Items.Add(item.name);
            }
        }


        public string GenerateCommand()
        {
            string header = "/give";
            string target = targetSelectForm.GetSelecter();
            string itemData = ItemData.ItemTypeList[ItemCombBox.SelectedIndex].name;
            string count = ItemCountNumric.Value.ToString();

            string itemName = ItemNameTextBox.Text;
            List<string> itemDescList = new List<string>(ItemDescTextBox.Text.Replace("\r\n", "\n").Split('\n'));

            List<EnchantData> enchantList = enchantForm.GetEnchantDataList();
            List<AbilityData> abilityList = addAbilityForm.GetAbilityDataList();

            StringBuilder sb = new StringBuilder();
            sb.Append(header);
            sb.Append(Define.SPACE);
            sb.Append(target);
            sb.Append(Define.SPACE);
            sb.Append(itemData);
            sb.Append(Define.START_BRACKET);

            if(itemName.Length != 0 || itemDescList.Count() != 0)
            {
                sb.Append(Define.ITEM_HEADER);
                sb.Append(Define.COLON);
                sb.Append(Define.START_BRACKET);

                if(itemName.Length != 0)
                {
                    sb.Append(Define.ITEM_NAME);
                    sb.Append(Define.COLON);
                    sb.Append(Define.DOUBLE_QUOT);
                    sb.Append(Define.ESCAPE);
                    sb.Append(Define.DOUBLE_QUOT);
                    sb.Append(itemName);
                    sb.Append(Define.ESCAPE);
                    sb.Append(Define.DOUBLE_QUOT);
                    sb.Append(Define.DOUBLE_QUOT);

                    if(itemDescList.Count() != 0)
                    {
                        sb.Append(Define.COMMA);
                    }
                }

                if (itemDescList.Count() != 0)
                {
                    sb.Append(Define.ITEM_DESCRIPTION);
                    sb.Append(Define.COLON);
                    sb.Append(Define.START_LIST_BRACKET);

                    foreach(string descStr in itemDescList)
                    {
                        sb.Append(Define.DOUBLE_QUOT);
                        sb.Append(Define.ESCAPE);
                        sb.Append(Define.DOUBLE_QUOT);
                        sb.Append(descStr);
                        sb.Append(Define.ESCAPE);
                        sb.Append(Define.DOUBLE_QUOT);
                        sb.Append(Define.DOUBLE_QUOT);

                        sb.Append(Define.COMMA);
                    }
                    sb.Length = sb.Length - Define.COMMA.Length;
                    sb.Append(Define.END_LIST_BRACKET);
                }

                sb.Append(Define.END_BRACKET);
                sb.Append(Define.COMMA);

            }

            if(enchantList.Count() > 0)
            {
                sb.Append(Define.ENCHANT_HEADER);
                sb.Append(Define.COLON);
                sb.Append(Define.START_LIST_BRACKET);

                foreach(EnchantData enchantData in enchantList)
                {
                    sb.Append(Define.START_BRACKET);
                    sb.Append(Define.ENCHANT_ID);
                    sb.Append(Define.COLON);
                    sb.Append(EnchantData.EnchantTypeList[enchantData.GetEnchantTypeIndex()].name);
                    sb.Append(Define.COMMA);

                    sb.Append(Define.ENCHANT_LEVEL);
                    sb.Append(Define.COLON);
                    sb.Append(enchantData.GetEnchantLevel());
                    sb.Append(Define.END_BRACKET);
                    sb.Append(Define.COMMA);
                }
                sb.Length = sb.Length - Define.COMMA.Length;
                sb.Append(Define.END_LIST_BRACKET);
                sb.Append(Define.COMMA);
            }

            if(abilityList.Count() > 0)
            {
                sb.Append(Define.ABILITY_HEADER);
                sb.Append(Define.COLON);
                sb.Append(Define.START_LIST_BRACKET);

                foreach(AbilityData abilityData in abilityList)
                {
                    sb.Append(Define.START_BRACKET);
                    sb.Append(Define.ABILITY_NAME);
                    sb.Append(Define.COLON);
                    sb.Append(Define.DOUBLE_QUOT);
                    sb.Append(AbilityData.AbilityTypeList[abilityData.GetAbilityTypeIndex()].parentStr);
                    sb.Append(Define.DOT);
                    sb.Append(AbilityData.AbilityTypeList[abilityData.GetAbilityTypeIndex()].name);
                    sb.Append(Define.DOUBLE_QUOT);
                    sb.Append(Define.COMMA);

                    sb.Append(Define.ABILITY_AMOUT);
                    sb.Append(Define.COLON);
                    sb.Append(abilityData.GetValue());
                    sb.Append(Define.COMMA);

                    sb.Append(Define.ABILITY_OPERATION);
                    sb.Append(Define.COLON);
                    sb.Append(AbilityData.OperationList[abilityData.GetOperationIndex()].name);
                    sb.Append(Define.COMMA);

                    sb.Append(Define.ABILITY_UUID_LEAST);
                    sb.Append(Define.COLON);
                    sb.Append(abilityData.GetUUIDLeast());
                    sb.Append(Define.COMMA);

                    sb.Append(Define.ABILITY_UUID_MOST);
                    sb.Append(Define.COLON);
                    sb.Append(abilityData.GetUUIDMost());

                    if(abilityData.GetSlotIndex() != 0)
                    {
                        sb.Append(Define.COMMA);
                        sb.Append(Define.ABILITY_SLOT);
                        sb.Append(Define.COLON);
                        sb.Append(Define.DOUBLE_QUOT);
                        sb.Append(AbilityData.SlotList[abilityData.GetSlotIndex()].name);
                        sb.Append(Define.DOUBLE_QUOT);
                    }

                    sb.Append(Define.END_BRACKET);
                    sb.Append(Define.COMMA);

                }
                sb.Length = sb.Length - Define.COMMA.Length;
                sb.Append(Define.END_LIST_BRACKET);
                sb.Append(Define.COMMA);

            }
            sb.Length = sb.Length - Define.COMMA.Length;
            sb.Append(Define.END_BRACKET);
            sb.Append(Define.SPACE);
            sb.Append(count);
            return sb.ToString();



            //display: { Name: "\"★生と死のトーテム\"",Lore:["\"自由を失う代わりに死から逃れられるだろう\""]}

        }

        /// <summary>
        /// 入力されている文字列に応じてCombBoxの中身を変化させる
        /// </summary>
        private void ItemCombBoxSearch()
        {

        }
    }
}
