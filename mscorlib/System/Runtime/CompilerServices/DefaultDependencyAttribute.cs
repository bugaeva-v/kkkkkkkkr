using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Содержит подсказку для среды CLR, указывающую вероятность загрузки зависимости. Этот класс используется в зависимой сборке для указания подсказки, которую следует использовать, если родитель не указал атрибут <see cref="T:System.Runtime.CompilerServices.DependencyAttribute" />.  Этот класс не наследуется.</summary>
	// Token: 0x0200082A RID: 2090
	[AttributeUsage(AttributeTargets.Assembly)]
	[Serializable]
	public sealed class DefaultDependencyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.DefaultDependencyAttribute" /> с указанной привязкой <see cref="T:System.Runtime.CompilerServices.LoadHint" />.</summary>
		/// <param name="loadHintArgument">Одно из значений <see cref="T:System.Runtime.CompilerServices.LoadHint" />, указывающее предпочтение привязки по умолчанию.</param>
		// Token: 0x060046A8 RID: 18088 RVA: 0x000E70DE File Offset: 0x000E52DE
		public DefaultDependencyAttribute(LoadHint loadHintArgument)
		{
			this.loadHint = loadHintArgument;
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.CompilerServices.LoadHint" />, которое указывает, когда сборка загружает зависимость.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Runtime.CompilerServices.LoadHint" />.</returns>
		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x000E70ED File Offset: 0x000E52ED
		public LoadHint LoadHint
		{
			get
			{
				return this.loadHint;
			}
		}

		// Token: 0x04002D76 RID: 11638
		private LoadHint loadHint;
	}
}
