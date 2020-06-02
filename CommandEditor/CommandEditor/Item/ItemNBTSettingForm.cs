using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandEditor.Item
{
    public partial class ItemNBTSettingForm : Form
    {
        public ItemNBTSettingForm(ItemData.ItemType itemType)
        {
            InitializeComponent();

            SetForm(itemType);
        }

        private void SetForm(ItemData.ItemType itemType)
        {
            switch (itemType)
            {
                case ItemData.ItemType.Tool:
                    break;
                case ItemData.ItemType.LeatherArmor:
                    break;
                case ItemData.ItemType.EnchantBook:
                    break;
                case ItemData.ItemType.Potion:
                    break;
                case ItemData.ItemType.Book:
                    break;
                case ItemData.ItemType.PlayerHead:
                    break;
                case ItemData.ItemType.FireWork:
                    break;
                case ItemData.ItemType.ArmorStand:
                    break;
                case ItemData.ItemType.SpawnEgg:
                    break;
                case ItemData.ItemType.Map:
                    break;
                default:
                    // 何もなしのメッセージ
                    break;
            }
        }
    }
}
