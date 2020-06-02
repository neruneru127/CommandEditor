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
using CommandEditor.Item;

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
            ItemData.ItemBaseData.refresh();
            foreach (var item in ItemData.ItemDataList)
            {
                itemCombBox.Items.Add(item.name);
            }

            foreach (var data in HideFlagData.HideFlagBaseList)
            {
                hideFlagListBox.Items.Add(data.description);
            }

        }


        public string GenerateCommand()
        {
            string header = "/give";
            string target = targetSelectForm.GetSelecter();
            string itemData = ItemData.ItemDataList[itemCombBox.SelectedIndex].name;
            string count = itemCountNumric.Value.ToString();

            string itemName = itemNameTextBox.Text;
            List<string> itemDescList = new List<string>(itemDescTextBox.Text.Replace("\r\n", "\n").Split('\n'));
            int hideFlagValue = 0;
            foreach(string data in hideFlagListBox.CheckedItems)
            {
                hideFlagValue += HideFlagData.GetValue(data);
            }

            List<EnchantData> enchantList = enchantForm.GetEnchantDataList();
            int repairCost = (int)repairNumeric.Value;

            List<AbilityData> abilityList = addAbilityForm.GetAbilityDataList();

            // ヘッダ作成
            StringBuilder sb = new StringBuilder();
            sb.Append(header);
            sb.Append(Define.SPACE);
            sb.Append(target);
            sb.Append(Define.SPACE);
            sb.Append(itemData);
            sb.Append(Define.START_BRACKET);

            // アイテム表示名作成
            if(itemName.Length != 0 || itemDescList.Count() != 0 || hideFlagValue != 0)
            {
                sb.Append(Define.ITEM_HEADER);
                sb.Append(Define.COLON);
                sb.Append(Define.START_BRACKET);

                // アイテム名設定
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
    
                    sb.Append(Define.COMMA);
                    
                }

                // アイテム説明設定
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

                    sb.Append(Define.COMMA);
                }

                if(hideFlagValue != 0)
                {
                    sb.Append(Define.ITEM_HIDE_FLAG);
                    sb.Append(Define.COLON);
                    sb.Append(hideFlagValue);

                    sb.Append(Define.COMMA);
                }

                sb.Length = sb.Length - Define.COMMA.Length;

                sb.Append(Define.END_BRACKET);
                sb.Append(Define.COMMA);

            }

            // エンチャント作成
            if(enchantList.Count() > 0)
            {
                sb.Append(Define.ENCHANT_HEADER);
                sb.Append(Define.COLON);
                sb.Append(Define.START_LIST_BRACKET);

                // エンチャントを設定
                foreach(EnchantData enchantData in enchantList)
                {
                    // エンチャントID設定
                    sb.Append(Define.START_BRACKET);
                    sb.Append(Define.ENCHANT_ID);
                    sb.Append(Define.COLON);
                    sb.Append(EnchantData.EnchantBaseList[enchantData.GetEnchantTypeIndex()].name);
                    sb.Append(Define.COMMA);
                    
                    // エンチャントレベル設定
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

            // 修繕コストを設定
            if(repairCost != 0)
            {
                sb.Append(Define.REPAIR_HEADER);
                sb.Append(Define.COLON);
                sb.Append(repairCost);
                sb.Append(Define.COMMA);

            }

            // 追加効果作成
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
                    sb.Append(AbilityData.AbilityBaseList[abilityData.GetAbilityTypeIndex()].parentStr);
                    sb.Append(Define.DOT);
                    sb.Append(AbilityData.AbilityBaseList[abilityData.GetAbilityTypeIndex()].name);
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

                    // 装備箇所を設定
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
            // フッター作成
            // コマンドに付与されている最後のコンマ削除
            sb.Length = sb.Length - Define.COMMA.Length;
            sb.Append(Define.END_BRACKET);
            sb.Append(Define.SPACE);

            // アイテム個数
            sb.Append(count);
            return sb.ToString();
        }

        /// <summary>
        /// 入力されている文字列に応じてCombBoxの中身を変化させる
        /// </summary>
        private void ItemCombBoxSearch()
        {

        }

        private void ItemNBTButton_Click(object sender, EventArgs e)
        {
            //ItemNBTSettingForm settingForm = new ItemNBTSettingForm(
            //    ItemData.ItemDataList[itemCombBox.SelectedIndex].itemType);

            //settingForm.Show();
        }
    }
}
