using System;
using System.Threading.Tasks;
using NSubstitute.Core;

namespace NSubstitute.ReturnsExtensions
{
	// Token: 0x02000043 RID: 67
	public static class ReturnsExtensions
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00004498 File Offset: 0x00002698
		public static ConfiguredCall ReturnsNull<T>(this T value) where T : class
		{
			return value.Returns(default(T), new T[0]);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000044BC File Offset: 0x000026BC
		public static ConfiguredCall ReturnsNullForAnyArgs<T>(this T value) where T : class
		{
			return value.ReturnsForAnyArgs(default(T), new T[0]);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000044E0 File Offset: 0x000026E0
		public static ConfiguredCall ReturnsNull<T>(this Task<T> value) where T : class
		{
			return value.Returns(default(T), new T[0]);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004504 File Offset: 0x00002704
		public static ConfiguredCall ReturnsNull<T>(this ValueTask<T> value) where T : class
		{
			return value.Returns(default(T), new T[0]);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004528 File Offset: 0x00002728
		public static ConfiguredCall ReturnsNullForAnyArgs<T>(this Task<T> value) where T : class
		{
			return value.ReturnsForAnyArgs(default(T), new T[0]);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000454C File Offset: 0x0000274C
		public static ConfiguredCall ReturnsNullForAnyArgs<T>(this ValueTask<T> value) where T : class
		{
			return value.ReturnsForAnyArgs(default(T), new T[0]);
		}
	}
}
