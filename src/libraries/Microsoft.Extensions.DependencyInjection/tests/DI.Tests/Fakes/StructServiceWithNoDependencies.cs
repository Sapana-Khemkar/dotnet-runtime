// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.DependencyInjection.Specification.Fakes;

namespace Microsoft.Extensions.DependencyInjection.Fakes
{
    public struct StructServiceWithNoDependencies: IFakeService
    {
        public StructServiceWithNoDependencies()
        {
        }
    }
}
