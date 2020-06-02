using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor.Enchant
{
    public class EnchantData
    {
        public struct EnchantBaseData
        {
            public string name;
            public string description;
        }

        public static readonly EnchantBaseData[] EnchantBaseList =
        {
            new EnchantBaseData{name = "protection",            description = "ダメージ軽減"},
            new EnchantBaseData{name = "fire_protection",       description = "火炎耐性"},
            new EnchantBaseData{name = "feather_falling",       description = "落下耐性"},
            new EnchantBaseData{name = "blast_protection",      description = "爆発耐性"},
            new EnchantBaseData{name = "projectile_protection", description = "飛び道具耐性"},
            new EnchantBaseData{name = "respiration",           description = "水中呼吸"},
            new EnchantBaseData{name = "aqua_affinity",         description = "水中採掘"},
            new EnchantBaseData{name = "thorns",                description = "棘の鎧"},
            new EnchantBaseData{name = "depth_strider",         description = "水中歩行"},
            new EnchantBaseData{name = "frost_walker",          description = "氷渡り"},
            new EnchantBaseData{name = "binding_curse",         description = "束縛の呪い"},
            new EnchantBaseData{name = "sharpness",             description = "ダメージ増加"},
            new EnchantBaseData{name = "smite",                 description = "アンデット特効"},
            new EnchantBaseData{name = "bane_of_arthropods",    description = "虫特効"},
            new EnchantBaseData{name = "knockback",             description = "ノックバック"},
            new EnchantBaseData{name = "fire_aspect",           description = "火属性"},
            new EnchantBaseData{name = "looting",               description = "ドロップ増加"},
            new EnchantBaseData{name = "sweeping",              description = "範囲ダメージ増加"},
            new EnchantBaseData{name = "efficiency",            description = "効率強化"},
            new EnchantBaseData{name = "silk_touch",            description = "シルクタッチ"},
            new EnchantBaseData{name = "unbreaking",            description = "耐久力"},
            new EnchantBaseData{name = "fortune",               description = "幸運"},
            new EnchantBaseData{name = "power",                 description = "射撃ダメージ増加"},
            new EnchantBaseData{name = "punch",                 description = "パンチ"},
            new EnchantBaseData{name = "flame",                 description = "炎の矢"},
            new EnchantBaseData{name = "infinity",              description = "無限"},
            new EnchantBaseData{name = "luck_of_the_sea",       description = "宝釣り"},
            new EnchantBaseData{name = "lure",                  description = "入れ食い"},
            new EnchantBaseData{name = "mending",               description = "修繕"},
            new EnchantBaseData{name = "vanishing_curse",       description = "消滅の呪い"},
            new EnchantBaseData{name = "impaling",              description = "水生特効"},
            new EnchantBaseData{name = "riptide",               description = "激流"},
            new EnchantBaseData{name = "loyalty",               description = "忠誠"},
            new EnchantBaseData{name = "channeling",            description = "召雷"},
            new EnchantBaseData{name = "multishot",             description = "拡散"},
            new EnchantBaseData{name = "piercing",              description = "貫通"},
            new EnchantBaseData{name = "quick_charge",          description = "高速装填"},
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
            return EnchantBaseList[enchantTypeIndex].description + ":Lv" + enchantLevel;
        }
    }
}
