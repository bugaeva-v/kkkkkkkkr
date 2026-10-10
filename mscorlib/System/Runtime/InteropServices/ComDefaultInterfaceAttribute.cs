using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет интерфейс по умолчанию, предоставляемый COM. Этот класс не наследуется.</summary>
	// Token: 0x020006E8 RID: 1768
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	[ComVisible(true)]
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.ComDefaultInterfaceAttribute" />, используя указанный объект <see cref="T:System.Type" /> в качестве интерфейса по умолчанию, предоставленного COM.</summary>
		/// <param name="defaultInterface">Значение <see cref="T:System.Type" />, показывающее интерфейс по умолчанию, предоставляемый для COM.</param>
		// Token: 0x06004067 RID: 16487 RVA: 0x000E0F85 File Offset: 0x000DF185
		public ComDefaultInterfaceAttribute(Type defaultInterface)
		{
			this._val = defaultInterface;
		}

		/// <summary>Получает объект <see cref="T:System.Type" />, определяющий интерфейс по умолчанию, предоставляемый для COM.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, определяющий интерфейс по умолчанию, предоставляемый для COM.</returns>
		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x000E0F94 File Offset: 0x000DF194
		public Type Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002A34 RID: 10804
		internal Type _val;
	}
}
