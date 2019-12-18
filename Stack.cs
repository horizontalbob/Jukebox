using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Jukebox
{
    class Stack
    {

        private StackNode top;
        private int size;


        public Stack()
        {
            top = null;
            size = 0;
        }

        private bool isEmpty()
        {
            return top == null;
        }

        public void Push(StackNode sn)
        {
            sn.Prev = top;
            top = sn;
            size++;
        }

        public StackNode Peek()
        {
            return top;
        }

        public StackNode Pop()
        {
            var removed = top;
            if (!isEmpty())
            {
                top = removed.Prev;
                size--;
            }
            return removed;
        }

        public string List()
        {
            if (isEmpty())
            {
                return "Stack is empty";
            }

            string output = "Contents of Stack\nNodes: " + size + Environment.NewLine;
            var current = top;

            while (current != null)
            {
                PropertyInfo[] properties = current.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    output += $"{ SplitCamelCase(property.Name) } : { property.GetValue(current, null) } |";
                }
                output += Environment.NewLine;
                    current = current.Prev;
            }

            return output;
        }

        public string List(string memberName)
        {
            if (isEmpty())
            {
                return "Stack is empty";
            }

            string output  = "";
            var    current = top;

            while (current != null)
            {
                PropertyInfo[] properties = current.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.Name == memberName)
                    {
                        output += $"{SplitCamelCase(property.Name)} : {property.GetValue(current, null)} |";
                    }
                }
                output += Environment.NewLine;
                current = current.Prev;
            }

            return output;
        }

        public string Info(StackNode node)
        {
            var @return = "";
            if (node != null)
            {
                PropertyInfo[] properties = node.GetType().GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    @return += $"|| {SplitCamelCase(property.Name)} : {property.GetValue(node, null)} ||";
                }
            }

            return @return == string.Empty ? "Nothing on spindle." : @return;
        }

        public bool Contains(string find)
        {
            if (isEmpty())
            {
                return false;
            }

            StackNode current = top;
            while (current != null)
            {
                if (find == current.Name)
                {
                    return true;
                }
                current = current.Prev;
            }
            return false;

        }

        public string SplitCamelCase(string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, "([A-Z])", " $1", System.Text.RegularExpressions.RegexOptions.Compiled).Trim();
        }

        public int Count()
        {
            return this.size;
        }

        public void RemoveAtIndex(int index)
        {
            Stack spindle2 = new Stack();
            for (var i = this.size; i > index+1; i--)
            {
                spindle2.Push(this.Pop());
            }
            this.Pop();
            while(spindle2.Count() != 0)
            {
                this.Push(spindle2.Pop());
            }
        }

    }//class

}
