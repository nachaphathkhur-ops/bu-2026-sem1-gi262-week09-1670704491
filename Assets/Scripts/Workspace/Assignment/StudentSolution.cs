using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        class Action
        {
            public string Name;
            public int Value;
        }

        #region Lecture

        public (int Count, int Popped, int Peek, int CountAfterPeek) LCT01_StackSyntax()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3); // top

            int count = stack.Count; // 3
            int popped = stack.Pop(); // popped = 3
            int peek = stack.Peek(); // peek = 2
            int countAfterPeek = stack.Count; // countAfterPeek = 2

            return (count, popped, peek, countAfterPeek);
        }
        public (int Count, int Dequeued, int Peek, int CountAfterPeek) LCT02_QueueSyntax()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            int count = queue.Count;
            int dequeued =  queue.Dequeue();

            int peek = queue.Peek();
            int countAfterPeek = queue.Count;

            return(count, dequeued, peek, countAfterPeek);
        }

        public string[] LCT03_ActionStack()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Stack<Action> stack = new Stack<Action>();
            stack.Push(action1);
            stack.Push(action2);
            stack.Push(action3);
            int c = stack.Count;
            List<string> actions = new List<string>();
            for (int i = 0; i < c; i++)
            {
                var action = stack.Pop();
                actions.Add(action.Name);

            }
            return actions.ToArray();
        }

        public string[] LCT04_ActionQueue()
        {
            Action action1 = new Action { Name = "Action 1" };
            Action action2 = new Action { Name = "Action 2" };
            Action action3 = new Action { Name = "Action 3" };

            Queue<Action> queue = new Queue<Action>();
            queue.Enqueue(action1);
            queue.Enqueue(action2);
            queue.Enqueue(action3);
            
            int c = queue.Count;
            List<string> actions = new List<string>();
            for(int i = 0; i< c; i++)
            {
                var a = queue.Dequeue();
                actions.Add(a.Name);

            }
            return actions.ToArray();

        }

        #endregion

        #region Assignment

        public string ASN01_ReverseString(string str)
        {
            Stack<char> chars = new Stack<char>();
            foreach (char c in str)
            {
                chars.Push(c);
            }
            char[] reversedChars = new char[str.Length];
            for (int i = 0; i < reversedChars.Length; i++)
            {
                reversedChars[i] = chars.Pop();
            }
            return new string(reversedChars);
        }

        public bool ASN02_StackPalindrome(string str)
        {
            Stack<char> chars = new Stack<char>();
            foreach (char c in str)
            {
               chars.Push(c);
            }
            foreach(char c in str)
            {
                if (c != chars.Pop())
                {
                    return false;
                }
            }
            return true;
        }

        #endregion

        #region Extra

        public bool EX01_ParenthesesChecker(string str)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
