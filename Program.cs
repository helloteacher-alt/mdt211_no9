using System;

namespace mdt211_no9
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            AddNode(ref root);

            Node ptr = root;
            Console.WriteLine(ptr.Name);


            static void InputSkill()
            {
                Console.Write("Input skill name: ");
                string skillName = Console.ReadLine();
            }
        }
        /*static void AddDependacy()
        {
            Console.Write("Add dependacy for{0} ? (Y/N) ");
        }*/

        static void AddNode(ref Node node)
        {
            Console.Write("Input skill name:");
            string skillName = Console.ReadLine();
            if (skillName != "?")
            {
                Console.Write("Add dependacy for {0}? (Y/N):", skillName);
                char answer = char.Parse(Console.ReadLine());

                if (answer == 'Y')
                {
                    
                }
                else if (answer == 'N')
                {
                    
                }
                node = new OtherNameNode(skillName);
                AddNode(ref (node as OtherNameNode).left);
                AddNode(ref (node as OtherNameNode).right);
            }

            else
            {
                int countSkill = 0;
                while (skillName != "?")
                {
                    string skill = Console.ReadLine();
                    countSkill++;
                }
                Console.WriteLine(countSkill);
            }
        }

    }
}
    
    
