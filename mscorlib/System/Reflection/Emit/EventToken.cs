using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	/// <summary>Представляет <see langword="Token" />, возвращаемый метаданными для представления события.</summary>
	// Token: 0x02000923 RID: 2339
	[ComVisible(true)]
	[Serializable]
	public readonly struct EventToken : IEquatable<EventToken>
	{
		// Token: 0x06005007 RID: 20487 RVA: 0x000FAA61 File Offset: 0x000F8C61
		internal EventToken(int val)
		{
			this.tokValue = val;
		}

		/// <summary>Проверяет, является ли данный объект экземпляром <see langword="EventToken" /> и равен ли он этому экземпляру.</summary>
		/// <param name="obj">Объект, который следует сравнить с данным экземпляром.</param>
		/// <returns>Возвращается <see langword="true" />, если <paramref name="obj" /> является экземпляром <see langword="EventToken" /> и совпадает с текущим экземпляром; в противном случае возвращается <see langword="false" />.</returns>
		// Token: 0x06005008 RID: 20488 RVA: 0x000FAA6C File Offset: 0x000F8C6C
		public override bool Equals(object obj)
		{
			bool flag = obj is EventToken;
			if (flag)
			{
				EventToken eventToken = (EventToken)obj;
				flag = (this.tokValue == eventToken.tokValue);
			}
			return flag;
		}

		/// <summary>Определяет равенство текущего экземпляра и указанного объекта <see cref="T:System.Reflection.Emit.EventToken" />.</summary>
		/// <param name="obj">
		///   <see cref="T:System.Reflection.Emit.EventToken" /> для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если значение параметра <paramref name="obj" /> равно значению текущего экземпляра; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06005009 RID: 20489 RVA: 0x000FAA9D File Offset: 0x000F8C9D
		public bool Equals(EventToken obj)
		{
			return this.tokValue == obj.tokValue;
		}

		/// <summary>Определяет равенство двух структур <see cref="T:System.Reflection.Emit.EventToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.EventToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.EventToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения параметров <paramref name="a" /> и <paramref name="b" /> равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600500A RID: 20490 RVA: 0x000FAAAD File Offset: 0x000F8CAD
		public static bool operator ==(EventToken a, EventToken b)
		{
			return object.Equals(a, b);
		}

		/// <summary>Указывает, действительно ли не равны две структуры <see cref="T:System.Reflection.Emit.EventToken" />.</summary>
		/// <param name="a">Объект <see cref="T:System.Reflection.Emit.EventToken" />, используемый для сравнения с <paramref name="b" />.</param>
		/// <param name="b">Объект <see cref="T:System.Reflection.Emit.EventToken" />, используемый для сравнения с <paramref name="a" />.</param>
		/// <returns>
		///   <see langword="true" />, если значения <paramref name="a" /> и <paramref name="b" /> не равны; в противном случае — <see langword="false" />.</returns>
		// Token: 0x0600500B RID: 20491 RVA: 0x000FAAC0 File Offset: 0x000F8CC0
		public static bool operator !=(EventToken a, EventToken b)
		{
			return !object.Equals(a, b);
		}

		/// <summary>Создает хэш-код для данного события.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x0600500C RID: 20492 RVA: 0x000FAAD6 File Offset: 0x000F8CD6
		public override int GetHashCode()
		{
			return this.tokValue;
		}

		/// <summary>Возвращает маркер метаданных для данного события.</summary>
		/// <returns>Только для чтения. Возвращает маркер метаданных для данного события.</returns>
		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x0600500D RID: 20493 RVA: 0x000FAAD6 File Offset: 0x000F8CD6
		public int Token
		{
			get
			{
				return this.tokValue;
			}
		}

		// Token: 0x0400315B RID: 12635
		internal readonly int tokValue;

		/// <summary>По умолчанию <see langword="EventToken" /> с <see cref="P:System.Reflection.Emit.EventToken.Token" /> используется значение 0.</summary>
		// Token: 0x0400315C RID: 12636
		public static readonly EventToken Empty;
	}
}
