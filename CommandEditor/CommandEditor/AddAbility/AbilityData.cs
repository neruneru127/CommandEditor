using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor.AddAbility
{
    public class AbilityData
    {
        public struct AbilityBaseData
        {
            // 表示される名前
            public string name;
            // 説明を表示 最大値、最小値もここで表示させる予定 最大値最小値のバリデーションは行わない
            public string description;
            // 親クラスを指定
            public string parentStr;

        }

        public struct Operation
        {
            public string name;
            public string description;
        }

        public struct Slot
        {
            public string name;
            public string description;
        }

        public static readonly AbilityBaseData[] AbilityBaseList =
        {
            new AbilityBaseData {name = "maxHealth",            parentStr = "generic", description = "最大体力(2で割った数がハートの数)\r\nデフォルト:20.0 最小値:0.0 最大値:1.7*10^308"},
            new AbilityBaseData {name = "followRange",          parentStr = "generic", description = "索敵範囲の広さ(1ブロック単位、※Mobによって違い有り)\r\nデフォルト:※32.0 最小値:0.0 最大値:2048.0"},
            new AbilityBaseData {name = "knockbackResistance",  parentStr = "generic", description = "ノックバック耐性(1.0 = 100%)\r\nデフォルト:0.0 最小値:0.0 最大値:1.0"},
            new AbilityBaseData {name = "movementSpeed",        parentStr = "generic", description = "移動速度(ブロック/秒)\r\nデフォルト:0.7 最小値:0.0 最大値:1.7*10^308"},
            new AbilityBaseData {name = "attackDamage",         parentStr = "generic", description = "攻撃力(2で割った数がハートの数)\r\nデフォルト:1.0 最小値:0.0 最大値:1.7*10^308"},
            new AbilityBaseData {name = "armor",                parentStr = "generic", description = "防具の防御力\r\nデフォルト:0.0 最小値:0.0 最大値:30.0"},
            new AbilityBaseData {name = "armorToughness",       parentStr = "generic", description = "防具の耐久値\r\nデフォルト:0.0 最小値:0.0 最大値:20.0"},
            new AbilityBaseData {name = "attackSpeed",          parentStr = "generic", description = "攻撃速度(4.0の場合、フルチャージは0.25秒)\r\nデフォルト:4.0 最小値:0.0 最大値:1024.0"},
            new AbilityBaseData {name = "luck",                 parentStr = "generic", description = "幸運の値\r\nデフォルト:0.0 最小値:-1024.0 最大値:1024.0"},
            new AbilityBaseData {name = "jumpStrength",         parentStr = "horse",   description = "馬のジャンプ力\r\nデフォルト:0.7 最小値:0.0 最大値:2.0"},
            new AbilityBaseData {name = "spawnReinforcements",  parentStr = "zombie",  description = "ゾンビが攻撃されたとき、ほかのゾンビを召喚する確率\r\nデフォルト:0.0 最小値:0.0 最大値:1.0"}
        };

        public static readonly Operation[] OperationList =
        {
            new Operation {name = "0", description = "元の値に加算"},
            new Operation {name = "1", description = "元の値に値×100%を加算"},
            new Operation {name = "2", description = "元の値に値×100%を乗算"}
        };

        public static readonly Slot[] SlotList =
        {
            new Slot {name = "None", description = ""},
            new Slot {name = "mainhand", description = ""},
            new Slot {name = "offhand", description = ""},
            new Slot {name = "feet", description = ""},
            new Slot {name = "legs", description = ""},
            new Slot {name = "chest", description = ""},
            new Slot {name = "head", description = ""},
        };


        private string abilityName = "";
        private int abilityTypeIndex = 0;
        private float abilityValue = 0.0f;
        private int operationIndex = 0;
        private int slotIndex = 0;
        private string UUIDMost = "1";
        private string UUIDLeast = "1";

        public string GetAbilityName()
        {
            return abilityName;
        }
        public int GetAbilityTypeIndex()
        {
            return abilityTypeIndex;
        }
        public float GetValue()
        {
            return abilityValue;
        }
        public int GetOperationIndex()
        {
            return operationIndex;
        }
        public int GetSlotIndex()
        {
            return slotIndex;
        }
        public string GetUUIDMost()
        {
            return UUIDMost;
        }
        public string GetUUIDLeast()
        {
            return UUIDLeast;
        }

        public void SetAbilityName(string str)
        {
            abilityName = str;
        }
        public void SetAbilityTypeIndex(int index)
        {
            abilityTypeIndex = index;
        }
        public void SetValue(float value)
        {
            abilityValue = value;
        }
        public void SetOperationIndex(int index)
        {
            operationIndex = index;
        }
        public void SetSlotIndex(int index)
        {
            slotIndex = index;
        }
        public void SetUUIDMost(string str)
        {
            UUIDMost = str;
        }
        public void SetUUIDLeast(string str)
        {
            UUIDLeast = str;
        }

        public override string ToString()
        {
            return abilityName;
        }
    }
}
