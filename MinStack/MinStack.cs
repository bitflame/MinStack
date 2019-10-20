using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinStack
{
    public class MinStack
    {
        Stack<int> stack1;
        Stack<int> stack2;
        public MinStack()
        {
            stack1 = new Stack<int>();
            stack2 = new Stack<int>();
        }
        public void Push(int x)
        {
            stack1.Push(x);
            if (stack2.Count == 0)
            {
                stack2.Push(x);
            } else
            {
                stack2.Push(Math.Min(stack2.Peek(), x));
            }
        }
        public void Pop()
        {
            stack1.Pop();
            stack2.Pop();
        }
        public int Top()
        {
            return stack1.Peek();
        }
        public int GetMin()
        {
            return stack2.Peek();
        }
    }
}
