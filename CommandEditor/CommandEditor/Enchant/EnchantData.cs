using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor.Enchant
{
    public class EnchantData
    {
        public struct EnchantType
        {
            public string name;
            public string description;
        }

        public static readonly EnchantType[] EnchantTypeList =
        {
            new EnchantType{name = "protection",            description = "ダメージ軽減"},
            new EnchantType{name = "fire_protection",       description = "火炎耐性"},
            new EnchantType{name = "feather_falling",       description = "落下耐性"},
            new EnchantType{name = "blast_protection",      description = "爆発耐性"},
            new EnchantType{name = "projectile_protection", description = "飛び道具耐性"},
            new EnchantType{name = "respiration",           description = "水中呼吸"},
            new EnchantType{name = "aqua_affinity",         description = "水中採掘"},
            new EnchantType{name = "thorns",                description = "棘の鎧"},
            new EnchantType{name = "depth_strider",         description = "水中歩行"},
            new EnchantType{name = "frost_walker",          description = "氷渡り"},
            new EnchantType{name = "binding_curse",         description = "束縛の呪い"},
            new EnchantType{name = "sharpness",             description = "ダメージ増加"},
            new EnchantType{name = "smite",                 description = "アンデット特効"},
            new EnchantType{name = "bane_of_arthropods",    description = "虫特効"},
            new EnchantType{name = "knockback",             description = "ノックバック"},
            new EnchantType{name = "fire_aspect",           description = "火属性"},
            new EnchantType{name = "looting",               description = "ドロップ増加"},
            new EnchantType{name = "sweeping",              description = "範囲ダメージ増加"},
            new EnchantType{name = "efficiency",            description = "効率強化"},
            new EnchantType{name = "silk_touch",            description = "シルクタッチ"},
            new EnchantType{name = "unbreaking",            description = "耐久力"},
            new EnchantType{name = "fortune",               description = "幸運"},
            new EnchantType{name = "power",                 description = "射撃ダメージ増加"},
            new EnchantType{name = "punch",                 description = "パンチ"},
            new EnchantType{name = "flame",                 description = "炎の矢"},
            new EnchantType{name = "infinity",              description = "無限"},
            new EnchantType{name = "luck_of_the_sea",       description = "宝釣り"},
            new EnchantType{name = "lure",                  description = "入れ食い"},
            new EnchantType{name = "mending",               description = "修繕"},
            new EnchantType{name = "vanishing_curse",       description = "消滅の呪い"}
        };

        private int enchantTypeIndex = 0;
        private int enchantLevel = 0;

        public void SetEnchantTypeIndex(int index)
        {
            enchantTypeIndex = index;
        }
        public void SetEnchantLevel(int value)
        {
            enchantLevel = value;
        }

        public int GetEnchantTypeIndex()
        {
            return enchantTypeIndex;
        }
        public int GetEnchantLevel()
        {
            return enchantLevel;
        }

        public override string ToString()
        {
            return EnchantTypeList[enchantTypeIndex].description + ":Lv" + enchantLevel;
        }
    }
}
