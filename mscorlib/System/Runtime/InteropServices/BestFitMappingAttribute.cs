using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет необходимость преобразования символов Юникода в наиболее подходящие символы ANSI.</summary>
	// Token: 0x02000710 RID: 1808
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
	public sealed class BestFitMappingAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.BestFitMappingAttribute" /> и присваивает ему значение свойства <see cref="P:System.Runtime.InteropServices.BestFitMappingAttribute.BestFitMapping" />.</summary>
		/// <param name="BestFitMapping">Значение <see langword="true" /> показывает, что режим наилучшего сопоставления включен; в противном случае используется значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</param>
		// Token: 0x060040C1 RID: 16577 RVA: 0x000E1620 File Offset: 0x000DF820
		public BestFitMappingAttribute(bool BestFitMapping)
		{
			this._bestFitMapping = BestFitMapping;
		}

		/// <summary>Возвращает текущие настройки наилучшего сопоставления при преобразовании знаков Юникода в знаки ANSI.</summary>
		/// <returns>Значение <see langword="true" />, если наилучшее сопоставление включено; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060040C2 RID: 16578 RVA: 0x000E162F File Offset: 0x000DF82F
		public bool BestFitMapping
		{
			get
			{
				return this._bestFitMapping;
			}
		}

		// Token: 0x04002AED RID: 10989
		internal bool _bestFitMapping;

		/// <summary>Включает и отключает возникновение исключений для неотображаемых символов Юникода, преобразующихся в знаки вопроса ("?") ANSI.</summary>
		// Token: 0x04002AEE RID: 10990
		public bool ThrowOnUnmappableChar;
	}
}
