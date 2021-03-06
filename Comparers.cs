﻿#if XUNIT_NULLABLE
#nullable enable
#endif

using System;
using System.Collections;
using System.Collections.Generic;
using Xunit.Sdk;

namespace Xunit
{
#if XUNIT_VISIBILITY_INTERNAL
	internal
#else
	public
#endif
	partial class Assert
	{
		static IComparer<T> GetComparer<T>()
			where T : IComparable
		{
			return new AssertComparer<T>();
		}

#if XUNIT_NULLABLE
		static IEqualityComparer<T> GetEqualityComparer<T>(IEqualityComparer? innerComparer = null)
#else
		static IEqualityComparer<T> GetEqualityComparer<T>(IEqualityComparer innerComparer = null)
#endif
		{
			return new AssertEqualityComparer<T>(innerComparer);
		}
	}
}
