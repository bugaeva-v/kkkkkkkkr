using System;
using System.Globalization;

namespace System.Collections
{
	/// <summary>Предоставляет хэш-код объекта, используя алгоритм хэширования, при котором не учитывается регистр строк.</summary>
	// Token: 0x02000A23 RID: 2595
	[Obsolete("Please use StringComparer instead.")]
	[Serializable]
	public class CaseInsensitiveHashCodeProvider : IHashCodeProvider
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> с помощью свойства <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока.</summary>
		// Token: 0x06005BD3 RID: 23507 RVA: 0x001354BC File Offset: 0x001336BC
		public CaseInsensitiveHashCodeProvider()
		{
			this._compareInfo = CultureInfo.CurrentCulture.CompareInfo;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" /> с использованием указанного объекта <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, который используется для нового объекта <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005BD4 RID: 23508 RVA: 0x001354D4 File Offset: 0x001336D4
		public CaseInsensitiveHashCodeProvider(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			this._compareInfo = culture.CompareInfo;
		}

		/// <summary>Получает экземпляр класса <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />, который связан со свойством <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока и всегда доступен.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />, который связан со свойством <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока.</returns>
		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x06005BD5 RID: 23509 RVA: 0x001354F6 File Offset: 0x001336F6
		public static CaseInsensitiveHashCodeProvider Default
		{
			get
			{
				return new CaseInsensitiveHashCodeProvider();
			}
		}

		/// <summary>Получает экземпляр класса <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />, который связан со свойством <see cref="P:System.Globalization.CultureInfo.InvariantCulture" /> и всегда доступен.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Collections.CaseInsensitiveHashCodeProvider" />, который связан со свойством <see cref="P:System.Globalization.CultureInfo.InvariantCulture" />.</returns>
		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x001354FD File Offset: 0x001336FD
		public static CaseInsensitiveHashCodeProvider DefaultInvariant
		{
			get
			{
				CaseInsensitiveHashCodeProvider result;
				if ((result = CaseInsensitiveHashCodeProvider.s_invariantCaseInsensitiveHashCodeProvider) == null)
				{
					result = (CaseInsensitiveHashCodeProvider.s_invariantCaseInsensitiveHashCodeProvider = new CaseInsensitiveHashCodeProvider(CultureInfo.InvariantCulture));
				}
				return result;
			}
		}

		/// <summary>Возвращает хэш-код заданного объекта, используя алгоритм хэширования, при котором не учитывается регистр строк.</summary>
		/// <param name="obj">Объект <see cref="T:System.Object" />, для которого необходимо вернуть хэш-код.</param>
		/// <returns>Хэш-код заданного объекта использует алгоритм хэширования, при котором не учитывается регистр строк.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005BD7 RID: 23511 RVA: 0x0013551C File Offset: 0x0013371C
		public int GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			string text = obj as string;
			if (text == null)
			{
				return obj.GetHashCode();
			}
			return this._compareInfo.GetHashCode(text, CompareOptions.IgnoreCase);
		}

		// Token: 0x04003884 RID: 14468
		private static volatile CaseInsensitiveHashCodeProvider s_invariantCaseInsensitiveHashCodeProvider;

		// Token: 0x04003885 RID: 14469
		private readonly CompareInfo _compareInfo;
	}
}
