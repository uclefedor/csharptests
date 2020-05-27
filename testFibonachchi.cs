using System;
using NUnit.Framework;

[TestFixture]
public class Test
{
[Test]
	  public void test1() 
    {
      Assert.AreEqual(3, Fibonachchi.CalcFib(4));
      Assert.AreEqual(3736710778780434371, Fibonachchi.CalcFib(100));
    }
  }
}
