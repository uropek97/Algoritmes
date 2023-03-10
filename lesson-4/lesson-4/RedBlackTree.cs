namespace lesson_4
{
    public class RedBlackTree
    {
        public Node? root;


        public class Node
        {
            public int value;
            public Node? left;
            public Node? right;
            public NodeColor color;

            public override string ToString()
            {
                return value.ToString() + ", color: " + color.ToString();
            }
        }
        public enum NodeColor
        {
            Red,
            Black
        }


        public bool Add(int value)
        {
            if(root != null)
            {
                bool result = addNode(root, value);
                root = rebalance(root);
                root.color = NodeColor.Black;
                return result;
            }
            else
            {
                root = new Node();
                root.color = NodeColor.Black;
                root.value = value;
                return true;
            }
        }

        private bool addNode(Node node, int value)
        {
            if (node.value == value)
            {
                return false;
            }
            else
            {
                if (node.value > value)
                {
                    if (node.left != null)
                    {
                        bool result = addNode(node.left, value);
                        node.left = rebalance(node.left);
                        return result;
                    }
                    else
                    {
                        node.left = new Node();
                        node.left.color = NodeColor.Red;
                        node.left.value = value;
                        return true;
                    }
                }
                else
                {
                    if (node.right != null)
                    {
                        bool result = addNode(node.right, value);
                        node.right = rebalance(node.right);
                        return result;
                    }
                    else
                    {
                        node.right = new Node();
                        node.right.color = NodeColor.Red;
                        node.right.value = value;
                        return true;
                    }
                }
            }
        }
        private Node rebalance(Node node)
        {
            Node result = node;
            bool needRebalance;
            do
            {
                needRebalance = false;
                if(result.right != null && result.right.color == NodeColor.Red &&
                    (result.left == null || result.left.color == NodeColor.Black))
                {
                    needRebalance = true;
                    result = rightSwap(result);
                }
                if(result.left != null && result.left.color == NodeColor.Red &&
                    result.left.left != null && result.left.left.color == NodeColor.Red)
                {
                    needRebalance = true;
                    result = leftSwap(result);
                }
                if(result.left != null && result.left.color == NodeColor.Red &&
                    result.right != null && result.right.color == NodeColor.Red)
                {
                    needRebalance = true;
                    colorSwap(result);
                }
            }while(needRebalance);
            return result;
        }

        private Node rightSwap(Node node)
        {
            Node rightChild = node.right!;
            Node between = rightChild.left!;
            rightChild.left = node;
            node.right = between;
            rightChild.color = node.color;
            node.color = NodeColor.Red;
            return rightChild;
        }

        private Node leftSwap(Node node)
        {
            Node leftChild = node.left!;
            Node between = leftChild.right!;
            leftChild.right = node;
            node.left = between;
            leftChild.color = node.color;
            node.color = NodeColor.Red;
            return leftChild;
        }

        private void colorSwap(Node node)
        {
            node.right!.color = NodeColor.Black;
            node.left!.color = NodeColor.Black;
            node.color = NodeColor.Red;
        }
    }
}
