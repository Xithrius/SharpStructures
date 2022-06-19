namespace SharpStructures;

public class SinglyLinkedList<T>
{
    private class Node<T>
    {
        internal T Data { get; set; }
        internal Node<T>? Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node<T>? Front { get; set; }
    public int Length { get; private set; }

    public SinglyLinkedList()
    {
        Front = null;
        Length = 0;
    }

    public SinglyLinkedList(T data)
    {
        Front = new Node<T>(data);
        Length = 1;
    }

    public void Append(T data)
    {
        Length++;
        
        var node = new Node<T>(data);
        
        if (Front == null)
        {
            Front = node;
        }
        else
        {
            var n = Front;

            while (n != null)
            {
                n = Front?.Next;
            }

            if (n != null)
                n.Next = node;
        }
    }

    public object? GetData(int index)
    {
        var i = 0;
        
        for (var node = Front; node != null; node = node.Next)
        {
            if (i == index)
            {
                return node.Data;
            }
        }

        return null;
    }

    public void SetData(int index, T data)
    {
        var i = 0;

        for (var node = Front; node != null; node = node.Next)
        {
            if (i == index)
            {
                node.Data = data;
            }
        }
    }
}