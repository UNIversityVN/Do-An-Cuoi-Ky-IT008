using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project___Review_RBT
{
    public enum NodeColor
    {
        Red,Black
    }

    public class RedBlackNode
    {
        public int Value { get; set; } 
        public NodeColor Color { get; set; } 
        public RedBlackNode? Parent { get; set; } 
        public RedBlackNode? Left { get; set; } 
        public RedBlackNode? Right { get; set; } 
    
        public RedBlackNode(int val)
        {
            Value = val;
            Color = NodeColor.Red;
            Parent = null;
            Left = null;
            Right = null;
        }
        // Kiểm tra xem nút có phải là nút lá không
        public bool IsLeaf()
        {
            return this.Left == null && this.Right == null;
        }

        // Kiểm tra xem nút có phải là con trái của cha nó không
        public bool IsLeftChild()
        {
            return this.Parent != null && this == this.Parent.Left;
        }

        // Kiểm tra xem nút có phải là con phải của cha nó không
        public bool IsRightChild()
        {
            return this.Parent != null && this == this.Parent.Right;
        }

        // Trả về giá trị đã định dạng (hiển thị 5 ký tự)
        public string FormattedValue => Value.ToString("D5");
    }
}
    