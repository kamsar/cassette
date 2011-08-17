﻿using Should;
using Xunit;
using Moq;

namespace Cassette.Stylesheets
{
    public class StylesheetModuleFactory_Tests
    {
        [Fact]
        public void CreateModule_ReturnsStylesheetModuleWithDirectorySet()
        {
            var factory = new StylesheetModuleFactory();
            var module = factory.CreateModule("test");
            module.Directory.ShouldEqual("test");
        }
    }
}
