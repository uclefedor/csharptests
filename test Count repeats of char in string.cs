using NUnit.Framework;

[TestFixture] 
class Tets
{
    [TestCase("Hello", "o", 1)]
    [TestCase("Hello", "l", 2)]
    [TestCase("", "z", 0)]
    public void BasicTetst(string a, string b, int expected)
    {
        Assert.That(Kata.StrCount(a, b), Is.EqualTo(expected));
    }
}
