using System.Linq;
using NUnit.Framework;

namespace SharpStructures.Test;

public class Tests
{
    [Test]
    public void TestConstructorEmptyConstructor()
    {
        var list = new SinglyLinkedList<int>();

        Assert.AreEqual(0, list.Length);
    }
    
    [Test]
    public void TestConstructorNonEmptyConstructor([Range(1, 5)]int data)
    {
        var list = new SinglyLinkedList<int>(data);
        
        Assert.AreEqual(1, list.Length);
    }

    [Test]
    public void TestGetDataEmptyConstructor()
    {
        var list = new SinglyLinkedList<int>();
        
        Assert.AreEqual(null, list.GetData(0));
    }

    [Test]
    public void TestGetDataNonEmptyConstructor([Range(1, 5)] int data)
    {
        var list = new SinglyLinkedList<int>(data);
        
        Assert.AreEqual(data, list.GetData(0));
    }

    // [Test]
    // public void TestIndexerEmptyConstructor()
    // {
    //     var list = new SinglyLinkedList<int>();
    //     
    //     Assert.AreEqual(null, list[0]);
    // }
    //
    // [Test]
    // public void TestIndexerNonEmptyConstructor([Range(1, 5)] int data)
    // {
    //     var list = new SinglyLinkedList<int>(data);
    //     
    //     Assert.AreEqual(data, list[0]);
    // }

    [Test]
    public void TestAppendEmptyConstructorLength([Range(1, 5)] int data)
    {
        var list = new SinglyLinkedList<int>();
        
        list.Append(data);
        
        Assert.AreEqual(1, list.Length);
    }

    [Test]
    public void TestAppendNonEmptyConstructorLength([Range(1, 5)] int data)
    {
        var list = new SinglyLinkedList<int>(data);
        
        list.Append(data);
        
        Assert.AreEqual(2, list.Length);
    }

    [Test]
    public void TestAppendRangeEmptyConstructorLength([Range(1, 5)] int repeat)
    {
        var list = new SinglyLinkedList<int>();

        for (var i = 0; i < repeat; i++)
        {
            list.Append(i);
        }
        
        Assert.AreEqual(repeat, list.Length);
    }

    [Test]
    public void TestAppendRangeNonEmptyConstructorLength([Range(1, 5)] int repeat)
    {
        var list = new SinglyLinkedList<int>(repeat);

        for (var i = 0; i < repeat; i++)
        {
            list.Append(i);
        }
        
        Assert.AreEqual(repeat + 1, list.Length);
    }
}