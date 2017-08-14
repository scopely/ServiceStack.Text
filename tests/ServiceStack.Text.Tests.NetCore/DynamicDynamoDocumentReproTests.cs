﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace ServiceStack.Text.Tests.NetCore
{
    [TestFixture]
    public class DynamicDynamoDocumentReproTests
    {
        [Test]
        public void MockDocument_can_read_base_attribtues()
        {
            var json = @"{""Name"":""brandon"",""Attributes"":{""Foo"":{""T"":""tvalue"",""V"":""vvalue""}}}";
            var doc = JsonSerializer.DeserializeFromString<MockDocument>(json);
            Assert.AreEqual("brandon", doc.Name);
            Assert.AreNotEqual(null, doc.Attributes);
            Assert.AreEqual(1, doc.Attributes.Count);
            Assert.AreEqual("tvalue", doc.Attributes["Foo"].T);
            Assert.AreEqual("vvalue", doc.Attributes["Foo"].V);
        }
    }
}
