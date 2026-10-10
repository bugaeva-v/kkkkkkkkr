using System;

namespace System.Threading
{
	/// <summary>Содержит константы, определяющие бесконечные интервалы времени ожидания. Этот класс не наследуется.</summary>
	// Token: 0x0200029B RID: 667
	public static class Timeout
	{
		/// <summary>Константа, используемая для задания бесконечного периода ожидания для методов, принимающих параметр <see cref="T:System.TimeSpan" />.</summary>
		// Token: 0x04001A4F RID: 6735
		public static readonly TimeSpan InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);

		/// <summary>Константа, используемая для задания бесконечного периода ожидания для методов управления потоками, принимающих параметр <see cref="T:System.Int32" />.</summary>
		// Token: 0x04001A50 RID: 6736
		public const int Infinite = -1;

		// Token: 0x04001A51 RID: 6737
		internal const uint UnsignedInfinite = 4294967295U;
	}
}
