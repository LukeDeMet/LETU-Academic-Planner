using System;
using System.Windows.Forms;

namespace claendermockup
{
    internal class CatalogLoad
    {
        public static TreeNode Load()
        {

            TreeNode node2 = new TreeNode("DON'T DO IT");
            TreeNode node3 = new TreeNode("UNLESS YOUR HATE YOURSELF");
            TreeNode[] array = new TreeNode[] { node2, node3 };
            TreeNode BSMENode = new TreeNode("Engineering, Mechanical", array);

            TreeNode cosc_cst = new TreeNode("COSC");
            TreeNode eetc_cst = new TreeNode("EETC");
            TreeNode[] CST = new TreeNode[] { cosc_cst, eetc_cst };
            TreeNode CSTNode = new TreeNode("Computer Science & Engineering Technology", CST);
            CSTNode.Text = "5";
            return

            CSTNode;
        }
    }
}