// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Functions
{
    public static partial class MathTests
    {
        // Tests MathF.Asin(float) over 5000 iterations for the domain -1, +1

        private const float asinSingleDelta = 0.0004f;
        private const float asinSingleExpectedResult = 1.57079590f;

        public static void AsinSingleTest()
        {
            var result = 0.0f; var value = -1.0f;

            for (var iteration = 0; iteration < iterations; iteration++)
            {
                value += asinSingleDelta;
                result += MathF.Asin(value);
            }

            var diff = MathF.Abs(asinSingleExpectedResult - result);

            if (diff > singleEpsilon)
            {
                throw new Exception($"Expected Result {asinSingleExpectedResult,10:g9}; Actual Result {result,10:g9}");
            }
        }
    }
}
