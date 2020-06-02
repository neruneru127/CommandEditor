using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor
{
    class Define
    {
        /// <summary>
        /// コマンドの種類 "/"に続く文字列をそのまま設定
        /// </summary>
        public enum COMMAND_TYPE 
        {
            give,
            summon
        };

        // 拡張子-----------------------

        /// <summary>
        /// プロジェクトファイルの拡張子
        /// </summary>
        public static readonly string EXTENSION_PROJECT = ".nelcpj";


        /// <summary>
        /// ターゲットセレクタ用のNBT拡張子
        /// </summary>
        public static readonly string EXTENSION_TARGET_NBT = ".neltgtnbt";

        // データの種類----------------
        public static readonly string ENCHANT_HEADER = "Enchantments";
        public static readonly string ENCHANT_ID = "id";
        public static readonly string ENCHANT_LEVEL = "lvl";

        public static readonly string ABILITY_HEADER = "AttributeModifiers";
        public static readonly string ABILITY_NAME = "AttributeName";
        public static readonly string ABILITY_TYPE = "Name";
        public static readonly string ABILITY_AMOUT = "Amount";
        public static readonly string ABILITY_OPERATION = "Operation";
        public static readonly string ABILITY_UUID_LEAST = "UUIDLeast";
        public static readonly string ABILITY_UUID_MOST = "UUIDMost";
        public static readonly string ABILITY_SLOT = "Slot";

        public static readonly string ITEM_HEADER = "display";
        public static readonly string ITEM_NAME = "Name";
        public static readonly string ITEM_DESCRIPTION = "Lore";
        public static readonly string ITEM_HIDE_FLAG = "HideFlags";

        public static readonly string REPAIR_HEADER = "RepairCost";

        // その他----------------------
        public static readonly string COLON = ":";
        public static readonly string COMMA = ",";
        public static readonly string DOT = ".";
        public static readonly string SPACE = " ";
        public static readonly string DOUBLE_QUOT = "\"";
        public static readonly string ESCAPE = "\\";

        public static readonly string START_BRACKET = "{";
        public static readonly string END_BRACKET = "}";
        public static readonly string START_LIST_BRACKET = "[";
        public static readonly string END_LIST_BRACKET = "]";

    }
}
