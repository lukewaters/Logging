// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Framework.Logging
{
    public class TestLoggerFactory : ILoggerFactory
    {
        private readonly TestSink _sink;
        private readonly bool _enabled;
        private readonly bool _sensitiveLoggingEnabled;

        public TestLoggerFactory(TestSink sink, bool enabled, bool sensitiveLoggingEnabled)
        {
            _sink = sink;
            _enabled = enabled;
            _sensitiveLoggingEnabled = sensitiveLoggingEnabled;
        }

        public ILogger Create(string name)
        {
            return new TestLogger(name, _sink, _enabled, _sensitiveLoggingEnabled);
        }

        public void AddProvider(ILoggerProvider provider)
        {
        }
    }
}