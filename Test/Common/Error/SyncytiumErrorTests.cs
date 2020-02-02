using Syncytium.NetCore.Common.Error;
using NUnit.Framework;

namespace Syncytium.NetCore.Common.Error.Tests
{
    public class SyncytiumErrorTests
    {
        [Test]
        public void Empty()
        {
            SyncytiumError error = new SyncytiumError();
            Assert.AreEqual(error.ToJSON().ToString(Newtonsoft.Json.Formatting.None), "{\"Message\":\"\",\"Parameters\":[]}");
            Assert.Pass();
        }

        [Test]
        public void Message()
        {
            SyncytiumError error = new SyncytiumError("MonError");
            Assert.AreEqual(error.ToJSON().ToString(Newtonsoft.Json.Formatting.None), "{\"Message\":\"MonError\",\"Parameters\":[]}");
            Assert.Pass();
        }

        [Test]
        public void MessageAndParameters()
        {
            SyncytiumError error = new SyncytiumError("MonError", 12, "titi");
            Assert.AreEqual(error.ToJSON().ToString(Newtonsoft.Json.Formatting.None), "{\"Message\":\"MonError\",\"Parameters\":[12,\"titi\"]}");
            Assert.Pass();
        }
    }
}