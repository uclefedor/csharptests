using System;
using NUnit.Framework;
[TestFixture]
public class Test
{
[Test]
	public void test1() 
  {
    Assert.AreEqual(8,Kata.rowSumOddNumbers(2));
    Assert.AreEqual(74088,Kata.rowSumOddNumbers(42));
	}
  
}
