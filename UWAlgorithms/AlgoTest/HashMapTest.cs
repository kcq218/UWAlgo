using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWAlgorithms;

namespace AlgoTest
{
    [TestClass]
    public class HashMapTest
    {
        [TestMethod]
        public void testHashMap()
        {
            var hm = new HashMap<int,int>(10);
            hm.add(10, 10);
            var num = hm.Get(10);
            hm.Remove(10);
            var nill = hm.Get(10);

            Assert.AreEqual(10, num.value);
            Assert.AreEqual(nill, null);
        }

        [TestMethod]
        public void testHashMapReHash()
        {
            var hm = new HashMap<int, int>(2);
            hm.add(10, 10);
            hm.add(11, 11);
            hm.add(12, 12);

            Assert.AreEqual(hm.Exist(10), true);
            Assert.AreEqual(hm.Exist(11), true);
            Assert.AreEqual(hm.Exist(12), true); 
            Assert.AreEqual(hm.Get(10).value, 10);
            Assert.AreEqual(hm.Get(11).value, 11);
            Assert.AreEqual(hm.Get(12).value, 12);
        }
    }
}