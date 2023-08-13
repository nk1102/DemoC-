using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoC_
{
	public  class BinaryTree
	{
		public class TreeNode
		{
			public int val;
			public TreeNode left;
			public TreeNode right;

			public TreeNode(int x)
			{
				val = x;

			}
		}
		public List<TreeNode> AllPossibleFBT(int N)
		{
			if (N % 2 == 0) return new List<TreeNode>();
			Dictionary<int, List<TreeNode>> map = new Dictionary<int, List<TreeNode>>();
			map.Add(1, new List<TreeNode> { new TreeNode(0) });

			for (int i = 3; i <= N; i += 2)
			{
				List<TreeNode> list = new List<TreeNode>();
				for (int j = 1; j < i - 1; j += 2)
				{
					int l = j, r = i - 1 - j;
					List<TreeNode> leftList = map[l];
					List<TreeNode> rightList = map[r];

					foreach (TreeNode leftNode in leftList)
					{
						foreach (TreeNode rightNode in rightList)
						{
							TreeNode root = new TreeNode(0)
							{
								left = leftNode,
								right = rightNode
							};
							list.Add(root);
						}
					}
				}
				map[i] = list;
			}
			return map[N];
		}
	}
}
