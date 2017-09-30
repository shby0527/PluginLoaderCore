using System;
using System.Collections.Generic;
using System.Text;

using PluginLoader.Plugin;
using PluginLoader.Attributes;

namespace TestCase
{
    [Plugin("Test", "TestCase", "1.0.0.0")]
    public class TestPlugin : SamplePluginBase
    {
    }
}
