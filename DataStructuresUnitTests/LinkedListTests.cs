using System;
using NUnit.Framework;
using Data_Structures;


namespace DataStructuresUnitTests {
    
    [TestFixture]
    public class Tests {
        
        LinkedList ll;
        private string[] data = {"asdf", "zxcv", "qwerty", "abc", "xyz", "aeiou", "foo", "bar", "hello", "world"};
    
        [SetUp]
        public void Init() {
            ll = new LinkedList();
            foreach (var s in data) {
                ll.AddToEnd(s);
            }
        }

        [Test]
        public void Find() {
            Assert.AreEqual(true, ll.Find("asdf"));
            Assert.AreEqual(true, ll.Find("foo"));
            Assert.AreEqual(true, ll.Find("world"));
            Assert.AreEqual(false, ll.Find("false"));
        }
        
        [Test]
        public void GetNodeAt() {
            Assert.AreEqual("qwerty", ll.GetNodeAt(2).Data);
            Assert.AreEqual(null, ll.GetNodeAt(-1));
            Assert.AreEqual(null, ll.GetNodeAt(10));
        }
        
        [Test]
        public void Count() {
            Assert.AreEqual(10, ll.Count());
        }

        [Test]
        public void AddToStart() {
            ll.AddToStart("start");
            
            Assert.AreEqual(11, ll.Count());
            Assert.AreEqual("start", ll.GetNodeAt(0).Data);
        }

        [Test]
        public void AddToEnd() {
            ll.AddToEnd("end");
            
            Assert.AreEqual(11, ll.Count());
            Assert.AreEqual("end", ll.GetNodeAt(11).Data);
        }

        [Test]
        public void AddNodeAt() {
            ll.AddNodeAt("indexFour", 4);
            
            Assert.AreEqual("indexFour", ll.GetNodeAt(4).Data);
            Assert.AreEqual("aeiou", ll.GetNodeAt(6).Data);
        }
        
        [Test]
        public void DeleteNodeAt() {
            ll.DeleteNodeAt(4);
            
            Assert.AreEqual(false, ll.Find("xyz"));
            Assert.AreEqual("aeiou", ll.GetNodeAt(4).Data);
        }
    }
}