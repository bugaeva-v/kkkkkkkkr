using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Задает, что типы, видимые обычно только в пределах текущей сборки, являются видимыми для заданной сборки.</summary>
	// Token: 0x02000836 RID: 2102
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	public sealed class InternalsVisibleToAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.InternalsVisibleToAttribute" /> с именем заданной дружественной сборки.</summary>
		/// <param name="assemblyName">Имя дружественной сборки.</param>
		// Token: 0x060046B8 RID: 18104 RVA: 0x000E7142 File Offset: 0x000E5342
		public InternalsVisibleToAttribute(string assemblyName)
		{
			this._assemblyName = assemblyName;
		}

		/// <summary>Получает имя дружественной сборки, для которой будут сделаны доступными все типы и члены типов, помеченные ключевым словом <see langword="internal" />.</summary>
		/// <returns>Строка, представляющая имя дружественной сборки.</returns>
		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x000E7158 File Offset: 0x000E5358
		public string AssemblyName
		{
			get
			{
				return this._assemblyName;
			}
		}

		/// <summary>Это свойство не реализовано.</summary>
		/// <returns>Это свойство не возвращает значение.</returns>
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x000E7160 File Offset: 0x000E5360
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x000E7168 File Offset: 0x000E5368
		public bool AllInternalsVisible
		{
			get
			{
				return this._allInternalsVisible;
			}
			set
			{
				this._allInternalsVisible = value;
			}
		}

		// Token: 0x04002D7C RID: 11644
		private string _assemblyName;

		// Token: 0x04002D7D RID: 11645
		private bool _allInternalsVisible = true;
	}
}
