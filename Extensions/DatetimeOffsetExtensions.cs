﻿using Shouldly;
using System;

namespace AndcultureCode.CSharp.Sitefinity.Testing.Extensions
{
    public static class DatetimeOffsetExtensions
    {
        public static void ShouldEqualAsUnixTime(this DateTimeOffset? thisDatetimeOffset, DateTimeOffset? datetimeOffsetToEqual)
        {
            thisDatetimeOffset.Value.ToUnixTimeSeconds().ShouldBe(datetimeOffsetToEqual.Value.ToUnixTimeSeconds());
        }
    }
}
