using System;

namespace System.ComponentModel.Design
{
	/// <summary>Указывает ключевое слово контекста для класса или члена. Этот класс не наследуется.</summary>
	// Token: 0x02000454 RID: 1108
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[Serializable]
	public sealed class HelpKeywordAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</summary>
		// Token: 0x060023F4 RID: 9204 RVA: 0x00003D9F File Offset: 0x00001F9F
		public HelpKeywordAttribute()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</summary>
		/// <param name="keyword">Значение ключевого слова справки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="keyword" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023F5 RID: 9205 RVA: 0x00081825 File Offset: 0x0007FA25
		public HelpKeywordAttribute(string keyword)
		{
			if (keyword == null)
			{
				throw new ArgumentNullException("keyword");
			}
			this.HelpKeyword = keyword;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> на основе заданного типа.</summary>
		/// <param name="t">Тип, из которого будет получено ключевое слово справки.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="t" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060023F6 RID: 9206 RVA: 0x00081842 File Offset: 0x0007FA42
		public HelpKeywordAttribute(Type t)
		{
			if (t == null)
			{
				throw new ArgumentNullException("t");
			}
			this.HelpKeyword = t.FullName;
		}

		/// <summary>Возвращает ключевое слово справки, предоставленное в данном атрибуте.</summary>
		/// <returns>Ключевое слово справки, предоставленное в данном атрибуте.</returns>
		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0008186A File Offset: 0x0007FA6A
		public string HelpKeyword { get; }

		/// <summary>Определяет, равны ли два экземпляра <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</summary>
		/// <param name="obj">Объект <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />, с которым сравнивается текущий объект <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" /> равен текущему объекту <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060023F8 RID: 9208 RVA: 0x00081872 File Offset: 0x0007FA72
		public override bool Equals(object obj)
		{
			return obj == this || (obj != null && obj is HelpKeywordAttribute && ((HelpKeywordAttribute)obj).HelpKeyword == this.HelpKeyword);
		}

		/// <summary>Возвращает хэш-код данного экземпляра.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />.</returns>
		// Token: 0x060023F9 RID: 9209 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет, имеет ли ключевое слово справки значение <see langword="null" />.</summary>
		/// <returns>Значение <see langword="true" />, если ключевое слово справки имеет значение <see langword="null" />, в обратном случае — значение <see langword="false" />.</returns>
		// Token: 0x060023FA RID: 9210 RVA: 0x0008189D File Offset: 0x0007FA9D
		public override bool IsDefaultAttribute()
		{
			return this.Equals(HelpKeywordAttribute.Default);
		}

		/// <summary>Представляет значение по умолчанию для объекта <see cref="T:System.ComponentModel.Design.HelpKeywordAttribute" />. Это поле доступно только для чтения.</summary>
		// Token: 0x040010CB RID: 4299
		public static readonly HelpKeywordAttribute Default = new HelpKeywordAttribute();
	}
}
