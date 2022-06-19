using NUnit.Framework;

namespace SharpStructures;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestInstantiation()
    {
        var list = new SinglyLinkedList();
    }
}