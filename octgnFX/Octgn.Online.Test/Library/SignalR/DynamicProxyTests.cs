﻿namespace Octgn.Online.Test.Library.SignalR
{
    using System;

    using FakeItEasy;
    using NUnit.Framework;

    using Octgn.Online.Library.SignalR;

    public class DynamicProxyTests
    {
        [Test]
        public void Constructor()
        {
            var proxy = DynamicProxy<IDynamicProxyTestInterface>.Get();
            bool test = false;
            proxy.On(x => ()=>x.Hello(default(string))).Calls(() => { test = true; });
            proxy.Instance.Hello("asdf");
            Assert.True(test);

            int i = 0;
            proxy.OnAll().Calls(() => i++);
            proxy.Instance.Hello("a");
            proxy.Instance.Hello2();
            Assert.AreEqual(2,i);
        }
    }

    public interface IDynamicProxyTestInterface
    {
        void Hello(string a);

        void Hello2();
    }
}