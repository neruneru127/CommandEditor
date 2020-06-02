using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor
{
    class HideFlagData
    {
        public struct HideFlagBaseData
        {
            public string name;
            public string description;
            public int value;
        }

        public static readonly HideFlagBaseData[] HideFlagBaseList = new HideFlagBaseData[]
        {
            new HideFlagBaseData{name = "Ench",                 description = "エンチャント",       value = 1},
            new HideFlagBaseData{name = "AttributeModifiers",   description = "追加効果",           value = 2},
            new HideFlagBaseData{name = "Unbreakable",          description = "耐久",               value = 4},
            new HideFlagBaseData{name = "CanDestroy",           description = "破壊可能ブロック",   value = 8},
            new HideFlagBaseData{name = "CanPlaceOn",           description = "設置可能ブロック",   value = 16},
            new HideFlagBaseData{name = "Other",                description = "その他",             value = 32},
        };


        public static int GetValue(string str)
        {
            int retValue = 0;

            foreach(var data in HideFlagBaseList)
            {
                if (data.description.Equals(str))
                {
                    retValue = data.value;
                    break;
                }
            }
            return retValue;
        }
    }
}
