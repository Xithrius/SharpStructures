namespace SharpStructures;

public class SinglyLinkedList<T>
{
    private class Node<T>
    {
        internal T Data { get;  }
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

    public T? GetData(int index)
    {
        return Front == null ? default : Front.Data;
    }
    
    // public int? this[int index]
    // {
    //     get => GetData(0);
    //     set => Front = new Node<T>(value);
    // }
    
    public void Append(T data)
    {
        var newNode = new Node<T>(data);
        
        if (Front == null)
            Front = newNode;
        else
            Front.Next = newNode;

        Length++;
    }
}