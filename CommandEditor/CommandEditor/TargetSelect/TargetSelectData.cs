using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor.TargetSelect
{
    class TargetSelectData
    {
        public struct TargetSelect
        {
            public string name;
            public string description;
        }

        public struct TargetSelectNBT{
            public string name;
            public string description;


        }

        public static readonly TargetSelect[] TargetSelectList =
        {
            new TargetSelect {name = "@a", description = "すべてのプレイヤー"},
            new TargetSelect {name = "@e", description = "すべてのエンティティ"},
            new TargetSelect {name = "@p", description = "最も近いプレイヤー"},
            new TargetSelect {name = "@r", description = "ランダムなプレイヤー"},
            new TargetSelect {name = "@s", description = "実行したエンティティ"}
        };





    }
}
