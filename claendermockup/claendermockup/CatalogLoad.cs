using System;
using System.Windows.Forms;

namespace claendermockup
{
    internal class CatalogLoad
    {
        public static TreeNode Load()
        {

            TreeNode cosc_cst = new TreeNode("COSC");
            TreeNode eetc_cst = new TreeNode("EETC");
            TreeNode[] CST = new TreeNode[] { cosc_cst, eetc_cst};
            TreeNode CSTNode = new TreeNode("Computer Science & Engineering Technology", CST);

            //College and Catalog Node
            TreeNode LETUNode = new TreeNode("LeTourneau University, Spring 2017 Catalog");

            //Offered Major Nodes
            TreeNode major_CST = new TreeNode("Computer Science & Engineering Technology");

            TreeNode dept_COSC = new TreeNode("COSC");
            major_CST.Nodes.Add(dept_COSC);

            TreeNode COSC_1303 = new TreeNode("Computer Science I");
            dept_COSC.Nodes.Add(COSC_1303);

            TreeNode EETC = new TreeNode("EETC");
            major_CST.Nodes.Add(EETC);


            //add majors to catalog
            LETUNode.Nodes.Add(major_CST);

            return LETUNode;
        }
    }
}