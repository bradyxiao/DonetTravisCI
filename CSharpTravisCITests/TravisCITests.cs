using NUnit.Framework;
using CSharpTravisCI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTravisCI.Tests
{
    [TestFixture()]
    public class TravisCITests
    {
        [Test()]
        public void AddTest()
        {
            TravisCI travisCI = new TravisCI();
            Assert.AreEqual(4, travisCI.Add(1, 3));
            Console.WriteLine("RESULT " + 4);
        }

        [Test()]
        public void DescTest()
        {
            TravisCI travisCI = new TravisCI();
            Assert.AreEqual(-2, travisCI.Desc(1, 3));
            Console.WriteLine("RESULT " + (-2));
        }
    }
}


/* ============================================================================== 
* Copyright 2016-2019 Tencent Cloud. All Rights Reserved.
* Auth：bradyxiao 
* Date：2019/1/22 15:57:35 
* ==============================================================================*/
