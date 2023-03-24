using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework; 

[TestFixture]
public class NaughtyOrNiceTest
{
  [Test]
  public void NaughtyTest()
  {
    var naughty = new List<Person> {
      new Person { Name = "Marco", WasNice =  false},
      new Person { Name = "Luc", WasNice =  false},
    };
    var nice = new List<Person> {
      new Person { Name = "Ryan", WasNice =  true},
      new Person { Name = "Barak", WasNice =  true},
    };

    var both = naughty.Concat(nice);

    Assert.AreEqual(0, NaughtyOrNice.GetNiceNames(naughty).Count(), "Wrong number of nice names");
    Assert.AreEqual(0, NaughtyOrNice.GetNaughtyNames(nice).Count(), "Wrong number of naughty names");
    Assert.AreEqual("Ryan,Barak", String.Join(",", NaughtyOrNice.GetNiceNames(nice)));
    Assert.AreEqual("Marco,Luc", String.Join(",", NaughtyOrNice.GetNaughtyNames(naughty)));
    Assert.AreEqual("Ryan,Barak", String.Join(",", NaughtyOrNice.GetNiceNames(both)));
    Assert.AreEqual("Marco,Luc", String.Join(",", NaughtyOrNice.GetNaughtyNames(both)));
  }
}
