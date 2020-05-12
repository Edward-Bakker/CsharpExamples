using System.Text;

namespace LinkedListExample
{
    class MyLinkedList
    {
        public MyNode Start { get; set; }
        public int Length { get; private set; }

        public MyLinkedList()
        {
            Length = 0;
        }

        /// <summary>
        /// Adds a node to the start of the list
        /// </summary>
        /// <param name="node">A new node</param>
        public void AddToStart(MyNode node)
        {
            node.Next = Start;
            Start = node;
            Length++;
        }

        /// <summary>
        /// Adds a node to the end of the list
        /// </summary>
        /// <param name="node">A new node</param>
        public void AddToEnd(MyNode node)
        {
            if(Start != null)
            {
                MyNode currentNode = Start;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = node;
                
            }
            else
            {
                Start = node;
            }
            Length++;
        }

        /// <summary>
        /// Gets a node from a certain index
        /// </summary>
        /// <param name="indexToFind">Index to get a node from</param>
        /// <returns>The requested node or null if not found</returns>
        public MyNode GetNodeFromIndex(int indexToFind)
        {
            MyNode currentNode = Start;
            for (int i = 0; i < Length; i++)
            {
                if(i == indexToFind)
                {
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.Next;
                }
            }
            return null;
        }

        /// <summary>
        /// Traverses and prints the list
        /// </summary>
        /// <returns>A string containing the content of the complete list</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (Start != null)
            {
                MyNode currentNode = Start;
                while (currentNode.Next != null)
                {
                    sb.AppendLine(currentNode.Content);
                    currentNode = currentNode.Next;
                }
                sb.AppendLine(currentNode.Content);
            }
            return sb.ToString();
        }





    }
}
