using System;

namespace System
{
	/// <summary>Предоставляет статические методы для создания объектов кортежей.</summary>
	// Token: 0x02000197 RID: 407
	public static class Tuple
	{
		/// <summary>Создает новый кортеж из одного компонента.</summary>
		/// <param name="item1">Значение единственного компонента кортежа.</param>
		/// <typeparam name="T1">Тип единственного компонента кортежа.</typeparam>
		/// <returns>Кортеж, значение которого равняется (<paramref name="item1" />).</returns>
		// Token: 0x06001035 RID: 4149 RVA: 0x00042604 File Offset: 0x00040804
		public static Tuple<T1> Create<T1>(T1 item1)
		{
			return new Tuple<T1>(item1);
		}

		/// <summary>Создает новый кортеж из двух компонентов (пару).</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <returns>Кортеж из двух компонентов, значение которого равняется (<paramref name="item1" />, <paramref name="item2" />).</returns>
		// Token: 0x06001036 RID: 4150 RVA: 0x0004260C File Offset: 0x0004080C
		public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			return new Tuple<T1, T2>(item1, item2);
		}

		/// <summary>Создает новый кортеж из трех компонентов.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
		/// <returns>Кортеж из трех компонентов, значение которого равняется (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />).</returns>
		// Token: 0x06001037 RID: 4151 RVA: 0x00042615 File Offset: 0x00040815
		public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			return new Tuple<T1, T2, T3>(item1, item2, item3);
		}

		/// <summary>Создает новый кортеж из четырех компонентов.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
		/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
		/// <returns>Кортеж из четырех компонентов, значение которого равняется (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />).</returns>
		// Token: 0x06001038 RID: 4152 RVA: 0x0004261F File Offset: 0x0004081F
		public static Tuple<T1, T2, T3, T4> Create<T1, T2, T3, T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}

		/// <summary>Создает новый кортеж из пяти компонентов.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
		/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
		/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
		/// <returns>Кортеж из пяти компонентов, значение которого равняется (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />).</returns>
		// Token: 0x06001039 RID: 4153 RVA: 0x0004262A File Offset: 0x0004082A
		public static Tuple<T1, T2, T3, T4, T5> Create<T1, T2, T3, T4, T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		}

		/// <summary>Создает новый кортеж из шести компонентов.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <param name="item6">Значение шестого компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
		/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
		/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
		/// <typeparam name="T6">Тип шестого компонента кортежа.</typeparam>
		/// <returns>Кортеж из шести компонентов, значение которого равняется (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />, <paramref name="item6" />).</returns>
		// Token: 0x0600103A RID: 4154 RVA: 0x00042637 File Offset: 0x00040837
		public static Tuple<T1, T2, T3, T4, T5, T6> Create<T1, T2, T3, T4, T5, T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		}

		/// <summary>Создает новый кортеж из семи компонентов.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <param name="item6">Значение шестого компонента кортежа.</param>
		/// <param name="item7">Значение седьмого компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
		/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
		/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
		/// <typeparam name="T6">Тип шестого компонента кортежа.</typeparam>
		/// <typeparam name="T7">Тип седьмого компонента кортежа.</typeparam>
		/// <returns>Кортеж из семи компонентов, значение которого равняется (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />, <paramref name="item6" />, <paramref name="item7" />).</returns>
		// Token: 0x0600103B RID: 4155 RVA: 0x00042646 File Offset: 0x00040846
		public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<T1, T2, T3, T4, T5, T6, T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
		}

		/// <summary>Создает новый кортеж из восьми компонентов.</summary>
		/// <param name="item1">Значение первого компонента кортежа.</param>
		/// <param name="item2">Значение второго компонента кортежа.</param>
		/// <param name="item3">Значение третьего компонента кортежа.</param>
		/// <param name="item4">Значение четвертого компонента кортежа.</param>
		/// <param name="item5">Значение пятого компонента кортежа.</param>
		/// <param name="item6">Значение шестого компонента кортежа.</param>
		/// <param name="item7">Значение седьмого компонента кортежа.</param>
		/// <param name="item8">Значение восьмого компонента кортежа.</param>
		/// <typeparam name="T1">Тип первого компонента кортежа.</typeparam>
		/// <typeparam name="T2">Тип второго компонента кортежа.</typeparam>
		/// <typeparam name="T3">Тип третьего компонента кортежа.</typeparam>
		/// <typeparam name="T4">Тип четвертого компонента кортежа.</typeparam>
		/// <typeparam name="T5">Тип пятого компонента кортежа.</typeparam>
		/// <typeparam name="T6">Тип шестого компонента кортежа.</typeparam>
		/// <typeparam name="T7">Тип седьмого компонента кортежа.</typeparam>
		/// <typeparam name="T8">Тип восьмого компонента кортежа.</typeparam>
		/// <returns>Кортеж из восьми компонентов со значением (<paramref name="item1" />, <paramref name="item2" />, <paramref name="item3" />, <paramref name="item4" />, <paramref name="item5" />, <paramref name="item6" />, <paramref name="item7" />, <paramref name="item8" />).</returns>
		// Token: 0x0600103C RID: 4156 RVA: 0x00042657 File Offset: 0x00040857
		public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<T1, T2, T3, T4, T5, T6, T7, T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new Tuple<T8>(item8));
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00033E4B File Offset: 0x0003204B
		internal static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0004266F File Offset: 0x0004086F
		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2), h3);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0004267E File Offset: 0x0004087E
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2), Tuple.CombineHashCodes(h3, h4));
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00042693 File Offset: 0x00040893
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), h5);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000426A5 File Offset: 0x000408A5
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), Tuple.CombineHashCodes(h5, h6));
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x000426BE File Offset: 0x000408BE
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), Tuple.CombineHashCodes(h5, h6, h7));
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x000426D9 File Offset: 0x000408D9
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), Tuple.CombineHashCodes(h5, h6, h7, h8));
		}
	}
}
