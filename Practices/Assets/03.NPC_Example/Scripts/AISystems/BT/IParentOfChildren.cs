using System.Collections.Generic;

namespace Practices.NPC_Example.AISystems.BT
{
    public interface IParentOfChildren : IParent
    {
        List<Node> children { get; set; }
    }
}