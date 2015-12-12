namespace LinkedList
{
    public class LinkedListNode
    {
        public static int Data { get; private set; }
        public static LinkedListNode Next { get; private set; }

        public LinkedListNode(int data, LinkedListNode next)
        {
            Data = data;
            Next = next;
        }
    }
}