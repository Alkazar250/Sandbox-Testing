using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace AlliedSandboxTest
{
    public class TestCase
    {
        [XmlAttribute]
        public string name;
        [XmlElement]
        public string method;
        [XmlArray]
        public List<string> attr;
        [XmlArray]
        public List<string> res;
        public TestCase()
        {
            attr = new List<string>();
            res = new List<string>();
        }
    }

    public class TestSuit
    {
        [XmlAttribute]
        public string name;
        [XmlArray]
        public List<TestCase> testCases;
        public TestSuit()
        {
            testCases = new List<TestCase>();
        }
    }
    [XmlRoot]
    public class Tests
    {
        [XmlArray]
        public List<TestSuit> testSuits;
        public Tests()
        {
            testSuits = new List<TestSuit>();
        }
    }
}
