using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Устанавливает значение параметра по умолчанию, которое используется, если параметр вызывается из языка, поддерживающего параметры по умолчанию. Этот класс не наследуется.</summary>
	// Token: 0x02000184 RID: 388
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class DefaultParameterValueAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.DefaultParameterValueAttribute" /> значением параметра по умолчанию.</summary>
		/// <param name="value">Объект, представляющий значение параметра по умолчанию.</param>
		// Token: 0x06000A65 RID: 2661 RVA: 0x0002D4D9 File Offset: 0x0002B6D9
		public DefaultParameterValueAttribute(object value)
		{
			this.value = value;
		}

		/// <summary>Возвращает значение, присваиваемое параметру по умолчанию.</summary>
		/// <returns>Объект, представляющий значение параметра по умолчанию.</returns>
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0002D4E8 File Offset: 0x0002B6E8
		public object Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x040006E7 RID: 1767
		private object value;
	}
}
