namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest 
  {
    [Test]
    public void SampleTest()
    {
      Assert.That(Kata.Solve("xyab", "xzca"), Is.EqualTo("ybzc"));
      Assert.That(Kata.Solve("xyabb", "xzca"), Is.EqualTo("ybbzc"));
      Assert.That(Kata.Solve("abcd", "xyz"), Is.EqualTo("abcdxyz"));
      Assert.That(Kata.Solve("xxx", "xzca"), Is.EqualTo("zca"));
    }
  }
}
