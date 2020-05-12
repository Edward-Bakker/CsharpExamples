using System;

namespace LinkedListExample
{
    class MyNode
    {
        public string Content { get; private set; }
        public MyNode Next { get; set; }

        public MyNode(String content)
        {
            this.Content = content;
        }
    }
}
