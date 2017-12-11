using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toolbox;
namespace DaySeven
{
    public class DaySevenSolution
    {
        public static string[] input = TBox.GetStringsFromFile(@"C:\Users\josa\Documents\Visual Studio 2017\Projects\AdventOfCode\DaySeven\Input.txt");
        public static List<TreeNode> treeNodes = new List<TreeNode>();
        public static Dictionary<string, int> uniqueNodes = new Dictionary<string, int>();
        public static string PartOne()
        {
            FillTreeNodeList();
#region old
            //int index = 0;

            //while (treeNodes.Count > 1)
            //{
            //    if (treeNodes[index%treeNodes.Count].HasChildren)
            //    {
            //        TreeNode nodeWithChildren = treeNodes[index%treeNodes.Count];
            //        TreeNode foundNode = null;

            //        for (int i = 0; i < treeNodes.Count; i++)
            //        {
            //            if(index != i && foundNode == null)
            //            {
            //                foundNode = RecursiveFindChild(treeNodes[i], nodeWithChildren.name);
            //            }

            //        }
            //        if(foundNode != null)
            //        {
            //            foundNode.children = nodeWithChildren.children;
            //            treeNodes.Remove(nodeWithChildren);
            //        }

            //        index++;
            //    } else
            //    {
            //        TreeNode tn = treeNodes[index%treeNodes.Count];
            //        foreach(TreeNode t in treeNodes)
            //        {
            //            if (t.HasChildren)
            //            {
            //                TreeNode foundNode = RecursiveFindChild(t, tn.name);
            //                if (foundNode != null)
            //                {
            //                    foundNode.id = tn.id;
            //                }

            //            }
            //        }
            //        treeNodes.Remove(tn);
            //    }
            //}

#endregion
            foreach(TreeNode t in treeNodes)
            {
                if (t.HasChildren)
                {
                    if (uniqueNodes.ContainsKey(t.name))
                    {
                        uniqueNodes[t.name]++;
                    }
                    else
                    {
                        uniqueNodes.Add(t.name, 1);
                    }
                    foreach (TreeNode tC in t.children)
                    {
                        if (uniqueNodes.ContainsKey(tC.name))
                        {
                            uniqueNodes[tC.name]++;
                        } else
                        {
                            uniqueNodes.Add(tC.name,1);
                        }
                    }
                }
                else
                {
                    if (uniqueNodes.ContainsKey(t.name))
                    {
                        uniqueNodes[t.name]++;
                    } else
                    {
                        uniqueNodes.Add(t.name, 1);
                    }
                }
            }

            string returnNode = "";
            foreach (var item in uniqueNodes)
            {
                if(item.Value == 1)
                {
                    returnNode = item.Key;
                }
            }

            return returnNode;
        }

        public static TreeNode RecursiveFindChild(TreeNode tn, string q)
        {
            if(tn.name == q)
            {
                return tn;
            }
            else
            {
                foreach (TreeNode n in tn.children)
                {
                    TreeNode ret = RecursiveFindChild(n, q);
                    if (ret != null) return ret;
                }
            }
            return null;
        }

        public static void FillTreeNodeList()
        {
            foreach (string s in input)
            {
                string str = s;
                str = str.Replace(">", "");
                str = str.Replace(" ", "");
                str = str.Replace("(", ",");
                str = str.Replace(")", "");
                string[] splitted = str.Split(new char[] {'-',','});

                if(splitted.Length > 2)
                {
                    List<TreeNode> children = new List<TreeNode>();
                    for (int i = 2; i < splitted.Length; i++)
                    {
                        children.Add(new TreeNode(splitted[i]));
                    }
                    treeNodes.Add(new TreeNode(splitted[0], int.Parse(splitted[1]), children));
                } else
                {
                    treeNodes.Add(new TreeNode(splitted[0],int.Parse(splitted[1])));
                }

            }
        }
    }

    public class TreeNode
    {
        public List<TreeNode> children = new List<TreeNode>();
        public string name = "";
        public int id;
        public TreeNode(string name, int id, List<TreeNode> children)
        {
            this.id = id;
            this.name = name;
            this.children = children;
        }
        public TreeNode(string name)
        {
            this.name = name;
        }
        public TreeNode(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public bool HasChildren
        {
            get
            {
                return children.Count > 0;
            }
        }
        public override string ToString()
        {
            return name;
        }
    }
}
