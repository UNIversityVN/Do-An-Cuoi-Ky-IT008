using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Review_RBT
{
    public class RedBlackTree
    {
        public RedBlackNode? root ; // Gốc của cây

        // Constructor 
        public RedBlackTree()
        {
            root = null;
        }

        // Lấy gốc của cây
        public RedBlackNode? GetRoot()
        {
            return root;
        }

        // Chèn 1 giá trị vào cây ( thành công trả về 1 )
        public int Insert(int value)
        {
            RedBlackNode newNode = new RedBlackNode(value);
            if (root == null)
            {
                root = newNode;
                root.Color = NodeColor.Black; // Gốc luôn phải là màu đen
                return 1;
            }
            else
            {
                if (InsertNode(root, newNode) == 1)
                {
                    FixTreeAfterInsert(newNode);
                    return 1;
                }
                else return 0; // Nếu giá trị đã tồn tại, không chèn
            }
        }

        // Chèn 1 node vào cây (thành công trả về 1)
        public int InsertNode(RedBlackNode current, RedBlackNode newNode)
        {
            if (newNode.Value < current.Value)
            {
                if (current.Left == null)
                {
                    current.Left = newNode;
                    newNode.Parent = current;
                    return 1;
                }
                else
                {
                    return InsertNode(current.Left, newNode);
                }
            }
            else if (newNode.Value > current.Value)
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                    newNode.Parent = current;
                    return 1;
                }
                else
                {
                    return InsertNode(current.Right, newNode);
                }
            }
            else return 0; // Trường hợp giá trị đã tồn tại
        }

        // Xoay trái
        public void RotateLeft(RedBlackNode node)
        {
            RedBlackNode? rightChild = node.Right;
            if (rightChild == null) return;
            node.Right = rightChild.Left;

            if (rightChild.Left != null)
            {
                rightChild.Left.Parent = node;
            }

            rightChild.Parent = node.Parent;

            if (node.Parent == null)
            {
                root = rightChild;
            }
            else if (node == node.Parent.Left)
            {
                node.Parent.Left = rightChild;
            }
            else
            {
                node.Parent.Right = rightChild;
            }

            rightChild.Left = node;
            node.Parent = rightChild;
        }

        public void RotateRight(RedBlackNode node)
        {
            RedBlackNode? leftChild = node.Left;

            // Kiểm tra nếu leftChild là null
            if (leftChild == null) return;

            node.Left = leftChild.Right;

            if (leftChild.Right != null)
            {
                leftChild.Right.Parent = node;
            }

            leftChild.Parent = node.Parent;

            if (node.Parent == null)
            {
                root = leftChild;
            }
            else if (node == node.Parent.Right)
            {
                node.Parent.Right = leftChild;
            }
            else
            {
                node.Parent.Left = leftChild;
            }

            leftChild.Right = node;
            node.Parent = leftChild;
        }

        // Sửa cây sau khi chèn
        private void FixTreeAfterInsert(RedBlackNode node)
        {
            while (node != root && node.Parent != null && node.Parent.Color == NodeColor.Red)
            {
                // Nếu cha của node là con trái của ông nội
                if (node.Parent == node.Parent.Parent?.Left)
                {
                    RedBlackNode? uncle = node.Parent.Parent?.Right;

                    // Trường hợp 1: Bác là màu đỏ -> Đổi màu và leo lên
                    if (uncle != null && uncle.Color == NodeColor.Red)
                    {
                        node.Parent.Color = NodeColor.Black;
                        uncle.Color = NodeColor.Black;
                        if (node.Parent.Parent != null)
                        {
                            node.Parent.Parent.Color = NodeColor.Red;
                            node = node.Parent.Parent; // Leo lên ông nội
                        }
                    }
                    else
                    {
                        // Trường hợp 2: Bác là màu đen và node là con phải -> Xoay trái cha
                        if (node == node.Parent.Right)
                        {
                            node = node.Parent;
                            RotateLeft(node);
                        }
                        // Trường hợp 3: Bác là màu đen và node là con trái -> Xoay phải ông nội
                        node.Parent.Color = NodeColor.Black;
                        if (node.Parent.Parent != null)
                        {
                            node.Parent.Parent.Color = NodeColor.Red;
                            RotateRight(node.Parent.Parent);
                        }
                    }
                }
                // Nếu cha của node là con phải của ông nội (ngược lại với bên trên)
                else
                {
                    RedBlackNode? uncle = node.Parent.Parent?.Left;

                    // Trường hợp 1: Bác là màu đỏ
                    if (uncle != null && uncle.Color == NodeColor.Red)
                    {
                        node.Parent.Color = NodeColor.Black;
                        uncle.Color = NodeColor.Black;
                        if (node.Parent.Parent != null)
                        {
                            node.Parent.Parent.Color = NodeColor.Red;
                            node = node.Parent.Parent; // Leo lên ông nội
                        }
                    }
                    else
                    {
                        // Trường hợp 2: Bác là màu đen và node là con trái
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RotateRight(node);
                        }
                        // Trường hợp 3: Bác là màu đen và node là con phải
                        node.Parent.Color = NodeColor.Black;
                        if (node.Parent.Parent != null)
                        {
                            node.Parent.Parent.Color = NodeColor.Red;
                            RotateLeft(node.Parent.Parent);
                        }
                    }
                }
            }

            if (root != null)
            {
                root.Color = NodeColor.Black; // Đảm bảo gốc luôn là màu đen
            }
        }
    }

}