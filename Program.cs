using System.Text;

namespace Tree {
    class Program {
        public static void Main(string[] args) {
            TreeNode node = new TreeNode("15+10");
            Console.WriteLine(TreeNode.BuildString(BuildNumberTreeBranch(ref node, 15, 10, new Policy(new PolicyItem[] { new AddRethrowPolicyItem(1, 2), new MultPolicyItem(4) }), 3, 1)));
        }

        public static void Game(int kucha, int pobeda, int kolvoHodov, Policy vidy_broskov, int maximalnyHod) {
            int s = (int)Math.Ceiling(pobeda / Math.Pow(maximalnyHod, kolvoHodov));
        }

        public static TreeNode BuildNumberTreeBranch(ref TreeNode node, int kuchaS, int kucha1, Policy vidy_broskov, int stop, int start = 1) {

            foreach (PolicyItem po in vidy_broskov.policyItems) {
                    
                string l;
                string r;

                if (po.GetType() == typeof(MultPolicyItem)) {
                    l = $"{kuchaS * ((MultPolicyItem)po).PossibleHeapThrow}+{kucha1}";
                    node.Add(new TreeNode(l));
                    r = $"{kuchaS}+{kucha1 * ((MultPolicyItem)po).PossibleHeapThrow}";
                    node.Add(new TreeNode(r));
                } else if (po.GetType() == typeof(AddRethrowPolicyItem)) {
                    l = $"{kuchaS + ((AddRethrowPolicyItem)po).PossibleHeapThrow}+{kucha1 + ((AddRethrowPolicyItem)po).PossibleSecondHeapThrow}";
                    node.Add(new TreeNode(l));
                    r = $"{kuchaS + ((AddRethrowPolicyItem)po).PossibleSecondHeapThrow}+{kucha1 + ((AddRethrowPolicyItem)po).PossibleHeapThrow}";
                    node.Add(new TreeNode(r));
                } else if (po.GetType() == typeof(AddPolicyItem)) {
                    l = $"{kuchaS + ((AddPolicyItem)po).PossibleHeapThrow}{kucha1}";
                    node.Add(new TreeNode(l));
                    r = $"{kuchaS}{kucha1 + ((AddPolicyItem)po).PossibleHeapThrow}";
                    node.Add(new TreeNode(r));

                }
                  
            }
            
            start++;

            if (start >= stop) return node; 

            for (int i = 0; i < node.Children.Values.Count; i++) {
                BuildNumberTreeBranch(ref node, int.Parse(node.Children.Values.ToArray()[i].ID.Split("+")[0]), int.Parse(node.Children.Values.ToArray()[i].ID.Split("+")[1]), vidy_broskov, stop, start);
            }

            return node;
        }

        public static void TraverseTree(TreeNode tree, int lim) {

        }

    
    }
}
