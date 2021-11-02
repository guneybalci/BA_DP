using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretionalProtoType
{
    //çok yuklü, proplu classlarınızın içeriği 
    abstract class ProtoTypeGame
    {
        //prop 
        public abstract ProtoTypeGame Clone();
    }
}
