using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEditor
{
    class EntityData
    {
        public struct EntityBaseData
        {
            public string name;
            public string description;
        }

        public EntityBaseData[] EntityBaseList =
        {
            new EntityBaseData{name = "", description = ""}


        };

    }
}
