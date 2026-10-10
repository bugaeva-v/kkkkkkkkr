using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Представляет платформу операционной системы.</summary>
	// Token: 0x020006CC RID: 1740
	public readonly struct OSPlatform : IEquatable<OSPlatform>
	{
		/// <summary>Получает объект, представляющий операционную систему Linux.</summary>
		/// <returns>Объект, представляющий операционную систему Linux.</returns>
		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06004002 RID: 16386 RVA: 0x000E04E2 File Offset: 0x000DE6E2
		public static OSPlatform Linux { get; } = new OSPlatform("LINUX");

		/// <summary>Получает объект, представляющий операционную систему OSX.</summary>
		/// <returns>Объект, представляющий операционную систему OSX.</returns>
		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06004003 RID: 16387 RVA: 0x000E04E9 File Offset: 0x000DE6E9
		public static OSPlatform OSX { get; } = new OSPlatform("OSX");

		/// <summary>Получает объект, представляющий операционную систему Windows.</summary>
		/// <returns>Объект, представляющий операционную систему Windows.</returns>
		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06004004 RID: 16388 RVA: 0x000E04F0 File Offset: 0x000DE6F0
		public static OSPlatform Windows { get; } = new OSPlatform("WINDOWS");

		// Token: 0x06004005 RID: 16389 RVA: 0x000E04F7 File Offset: 0x000DE6F7
		private OSPlatform(string osPlatform)
		{
			if (osPlatform == null)
			{
				throw new ArgumentNullException("osPlatform");
			}
			if (osPlatform.Length == 0)
			{
				throw new ArgumentException("Value cannot be empty.", "osPlatform");
			}
			this._osPlatform = osPlatform;
		}

		/// <summary>Создает новый экземпляр <see cref="T:System.Runtime.InteropServices.OSPlatform" />.</summary>
		/// <param name="osPlatform">Имя платформы, представляемой этим экземпляром.</param>
		/// <returns>Объект, представляющий операционную систему <paramref name="osPlatform" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="osPlatform" /> равен пустой строке.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="osPlatform" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004006 RID: 16390 RVA: 0x000E0526 File Offset: 0x000DE726
		public static OSPlatform Create(string osPlatform)
		{
			return new OSPlatform(osPlatform);
		}

		/// <summary>Определяет, равен ли текущий экземпляр указанному экземпляру <see cref="T:System.Runtime.InteropServices.OSPlatform" />.</summary>
		/// <param name="other">Объект для сравнения с текущим экземпляром.</param>
		/// <returns>Значение <see langword="true" />, если объект <paramref name="other" /> равен текущему экземпляру; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06004007 RID: 16391 RVA: 0x000E052E File Offset: 0x000DE72E
		public bool Equals(OSPlatform other)
		{
			return this.Equals(other._osPlatform);
		}

		// Token: 0x06004008 RID: 16392 RVA: 0x000E053C File Offset: 0x000DE73C
		internal bool Equals(string other)
		{
			return string.Equals(this._osPlatform, other, StringComparison.Ordinal);
		}

		/// <summary>Определяет, равен ли текущий экземпляр <see cref="T:System.Runtime.InteropServices.OSPlatform" /> указанному объекту.</summary>
		/// <param name="obj">Значение <see langword="true" />, если <paramref name="obj" /> является экземпляром <see cref="T:System.Runtime.InteropServices.OSPlatform" /> и его имя совпадает с именем текущего объекта; в противном случае значение false.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="obj" /> является экземпляром <see cref="T:System.Runtime.InteropServices.OSPlatform" /> и его имя совпадает с именем текущего объекта.</returns>
		// Token: 0x06004009 RID: 16393 RVA: 0x000E054B File Offset: 0x000DE74B
		public override bool Equals(object obj)
		{
			return obj is OSPlatform && this.Equals((OSPlatform)obj);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код данного экземпляра.</returns>
		// Token: 0x0600400A RID: 16394 RVA: 0x000E0563 File Offset: 0x000DE763
		public override int GetHashCode()
		{
			if (this._osPlatform != null)
			{
				return this._osPlatform.GetHashCode();
			}
			return 0;
		}

		/// <summary>Возвращает строковое представление этого экземпляра <see cref="T:System.Runtime.InteropServices.OSPlatform" />.</summary>
		/// <returns>Строка, представляющая данный экземпляр <see cref="T:System.Runtime.InteropServices.OSPlatform" />.</returns>
		// Token: 0x0600400B RID: 16395 RVA: 0x000E057A File Offset: 0x000DE77A
		public override string ToString()
		{
			return this._osPlatform ?? string.Empty;
		}

		/// <summary>Определяет равенство двух объектов <see cref="T:System.Runtime.InteropServices.OSPlatform" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600400C RID: 16396 RVA: 0x000E058B File Offset: 0x000DE78B
		public static bool operator ==(OSPlatform left, OSPlatform right)
		{
			return left.Equals(right);
		}

		/// <summary>Определяет неравенство двух экземпляров <see cref="T:System.Runtime.InteropServices.OSPlatform" />.</summary>
		/// <param name="left">Первый из сравниваемых объектов.</param>
		/// <param name="right">Второй из сравниваемых объектов.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="left" /> и <paramref name="right" /> не равны; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600400D RID: 16397 RVA: 0x000E0595 File Offset: 0x000DE795
		public static bool operator !=(OSPlatform left, OSPlatform right)
		{
			return !(left == right);
		}

		// Token: 0x04002A04 RID: 10756
		private readonly string _osPlatform;
	}
}
