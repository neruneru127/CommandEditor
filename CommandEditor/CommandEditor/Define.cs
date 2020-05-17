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



    }
}
