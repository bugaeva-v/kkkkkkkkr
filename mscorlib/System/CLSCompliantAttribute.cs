using System;

namespace System
{
	/// <summary>Указывает, соответствует ли элемент программы спецификации CLS. Этот класс не наследуется.</summary>
	// Token: 0x02000104 RID: 260
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	[Serializable]
	public sealed class CLSCompliantAttribute : Attribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.CLSCompliantAttribute" /> логическим значением, указывающим, является ли заданный программный элемент CLS-совместимым.</summary>
		/// <param name="isCompliant">
		///   <see langword="true" />, если он CLS-совместим; в противном случае — <see langword="false" />.</param>
		// Token: 0x060007DB RID: 2011 RVA: 0x0002253D File Offset: 0x0002073D
		public CLSCompliantAttribute(bool isCompliant)
		{
			this._compliant = isCompliant;
		}

		/// <summary>Возвращает логическое значение, указывающее, является ли заданный программный элемент CLS-совместимым.</summary>
		/// <returns>
		///   <see langword="true" />, если программный элемент CLS-совместим; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0002254C File Offset: 0x0002074C
		public bool IsCompliant
		{
			get
			{
				return this._compliant;
			}
		}

		// Token: 0x04001077 RID: 4215
		private bool _compliant;
	}
}
