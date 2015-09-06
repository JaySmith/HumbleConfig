﻿using NUnit.Framework;

namespace HumbleConfig.Tests.ConfigurationTests
{
    public class ConfigurationTestsForNoSourcesForNullableValues<TValue> : NullableValueTests<TValue>
    {
        private Configuration _configuration;
        private TValue _value;

        [TestFixtureSetUp]
        public void GivenAConfigurationWithNoSourcesLoaded()
        {
            _configuration = new Configuration();
        }

        [SetUp]
        public void WhenGettingAnAppSetting()
        {
            _value = _configuration.GetAppSettingAsync<TValue>("key").Result;
        }

        [Test]
        public void ThenTheReturnValueIsNull()
        {
            Assert.That(_value, Is.Null);
        }
    }
}