using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CretionalProtoType
{
    class Game : ProtoTypeGame, IDisposable
    {
        public Game(int id, string name, string type, bool isActive)
        {
            ID = id;
            GameName = name;
            GameType = type;
            IsActive = isActive;
        }
        public int ID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public bool IsActive { get; set; }
        public override ProtoTypeGame Clone()
        {
            return this.MemberwiseClone() as ProtoTypeGame;
        }
        public void Dispose()
        {
        }
    }
}
