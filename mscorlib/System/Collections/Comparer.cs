using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security;

namespace System.Collections
{
	/// <summary>Проверяет равенство двух объектов с учетом регистра строк.</summary>
	// Token: 0x02000A0F RID: 2575
	[Serializable]
	public sealed class Comparer : IComparer, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Collections.Comparer" /> с использованием указанного объекта <see cref="T:System.Globalization.CultureInfo" />.</summary>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, который используется для нового объекта <see cref="T:System.Collections.Comparer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="culture" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005B6E RID: 23406 RVA: 0x00134A7E File Offset: 0x00132C7E
		public Comparer(CultureInfo culture)
		{
			if (culture == null)
			{
				throw new ArgumentNullException("culture");
			}
			this._compareInfo = culture.CompareInfo;
		}

		// Token: 0x06005B6F RID: 23407 RVA: 0x00134AA0 File Offset: 0x00132CA0
		private Comparer(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this._compareInfo = (CompareInfo)info.GetValue("CompareInfo", typeof(CompareInfo));
		}

		/// <summary>Передает объекту <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данные, необходимые для сериализации.</summary>
		/// <param name="info">Объект, который требуется заполнить данными.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06005B70 RID: 23408 RVA: 0x00134AD6 File Offset: 0x00132CD6
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			info.AddValue("CompareInfo", this._compareInfo);
		}

		/// <summary>Выполняет сравнение двух объектов одного типа с учетом регистра и возвращает значение, которое показывает, в каком отношении (меньше, равно или больше) находятся два объекта.</summary>
		/// <param name="a">Первый из сравниваемых объектов.</param>
		/// <param name="b">Второй из сравниваемых объектов.</param>
		/// <returns>Знаковое целое число, которое определяет относительные значения параметров <paramref name="a" /> и <paramref name="b" />, как показано в следующей таблице.  
		///   Значение 
		///   Значение 
		///   Меньше нуля 
		///  Значение <paramref name="a" /> меньше <paramref name="b" />.  
		///
		///   Нуль 
		///  <paramref name="a" /> равняется <paramref name="b" />.  
		///
		///   Больше нуля 
		///  Значение <paramref name="a" /> больше значения <paramref name="b" />.</returns>
		/// <exception cref="T:System.ArgumentException">Ни параметр <paramref name="a" />, ни параметр <paramref name="b" /> не реализует интерфейс <see cref="T:System.IComparable" />.  
		///
		/// или - 
		/// Параметры <paramref name="a" /> и <paramref name="b" /> имеют разные типы и не могут сравниваться друг с другом.</exception>
		// Token: 0x06005B71 RID: 23409 RVA: 0x00134AF8 File Offset: 0x00132CF8
		public int Compare(object a, object b)
		{
			if (a == b)
			{
				return 0;
			}
			if (a == null)
			{
				return -1;
			}
			if (b == null)
			{
				return 1;
			}
			string text = a as string;
			string text2 = b as string;
			if (text != null && text2 != null)
			{
				return this._compareInfo.Compare(text, text2);
			}
			IComparable comparable = a as IComparable;
			if (comparable != null)
			{
				return comparable.CompareTo(b);
			}
			IComparable comparable2 = b as IComparable;
			if (comparable2 != null)
			{
				return -comparable2.CompareTo(a);
			}
			throw new ArgumentException("At least one object must implement IComparable.");
		}

		// Token: 0x04003864 RID: 14436
		private CompareInfo _compareInfo;

		/// <summary>Предоставляет экземпляр класса <see cref="T:System.Collections.Comparer" />, который связан со свойством <see cref="P:System.Threading.Thread.CurrentCulture" /> текущего потока. Это поле доступно только для чтения.</summary>
		// Token: 0x04003865 RID: 14437
		public static readonly Comparer Default = new Comparer(CultureInfo.CurrentCulture);

		/// <summary>Представляет экземпляр класса <see cref="T:System.Collections.Comparer" />, который связан со свойством <see cref="P:System.Globalization.CultureInfo.InvariantCulture" />. Это поле доступно только для чтения.</summary>
		// Token: 0x04003866 RID: 14438
		public static readonly Comparer DefaultInvariant = new Comparer(CultureInfo.InvariantCulture);
	}
}
