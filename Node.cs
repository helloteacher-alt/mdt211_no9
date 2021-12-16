using System;
using System.Collections.Generic;
using System.Text;

namespace mdt211_no9
{
    class Node
    {
        public string Name;
        public Node(string nameValue)
        {
            Name = nameValue;
        }
    }

    class OtherNameNode : Node
    {
        public Node left;
        public Node right;
        public OtherNameNode(string nameValue) : base(nameValue)
        {

        }
    }

    class NameNodeUpgrade : Node
    {
        public NameNodeUpgrade(string nameValue) : base(nameValue)
        {

        }
    }
}
