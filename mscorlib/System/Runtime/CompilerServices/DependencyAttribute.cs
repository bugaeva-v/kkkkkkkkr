using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, когда зависимость загружается ссылающейся сборкой. Этот класс не наследуется.</summary>
	// Token: 0x0200082B RID: 2091
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	[Serializable]
	public sealed class DependencyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.DependencyAttribute" /> заданным значением <see cref="T:System.Runtime.CompilerServices.LoadHint" />.</summary>
		/// <param name="dependentAssemblyArgument">Зависимая сборка для привязки.</param>
		/// <param name="loadHintArgument">Одно из значений перечисления <see cref="T:System.Runtime.CompilerServices.LoadHint" />.</param>
		// Token: 0x060046AA RID: 18090 RVA: 0x000E70F5 File Offset: 0x000E52F5
		public DependencyAttribute(string dependentAssemblyArgument, LoadHint loadHintArgument)
		{
			this.dependentAssembly = dependentAssemblyArgument;
			this.loadHint = loadHintArgument;
		}

		/// <summary>Возвращает значение зависимой сборки.</summary>
		/// <returns>Имя зависимой сборки.</returns>
		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x000E710B File Offset: 0x000E530B
		public string DependentAssembly
		{
			get
			{
				return this.dependentAssembly;
			}
		}

		/// <summary>Возвращает значение <see cref="T:System.Runtime.CompilerServices.LoadHint" />, которое указывает, когда сборка должна загружать зависимость.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Runtime.CompilerServices.LoadHint" />.</returns>
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x000E7113 File Offset: 0x000E5313
		public LoadHint LoadHint
		{
			get
			{
				return this.loadHint;
			}
		}

		// Token: 0x04002D77 RID: 11639
		private string dependentAssembly;

		// Token: 0x04002D78 RID: 11640
		private LoadHint loadHint;
	}
}
