using System;

namespace System
{
	/// <summary>Отмечает элементы программы, которые больше не используются. Этот класс не наследуется.</summary>
	// Token: 0x02000169 RID: 361
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
	[Serializable]
	public sealed class ObsoleteAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObsoleteAttribute" /> стандартными свойствами.</summary>
		// Token: 0x06000E60 RID: 3680 RVA: 0x0003AD39 File Offset: 0x00038F39
		public ObsoleteAttribute()
		{
			this._message = null;
			this._error = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObsoleteAttribute" /> указанным сообщением об обходном пути.</summary>
		/// <param name="message">Строка текста, описывающая альтернативные обходные пути.</param>
		// Token: 0x06000E61 RID: 3681 RVA: 0x0003AD4F File Offset: 0x00038F4F
		public ObsoleteAttribute(string message)
		{
			this._message = message;
			this._error = false;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ObsoleteAttribute" /> сообщением об обходном пути и логическим значением, позволяющим определить, следует ли считать использование устаревшего элемента ошибкой.</summary>
		/// <param name="message">Строка текста, описывающая альтернативные обходные пути.</param>
		/// <param name="error">
		///   <see langword="true" />, если использование устаревшего элемента приводит к ошибке компилятора; <see langword="false" />, если выдается предупреждение компилятора.</param>
		// Token: 0x06000E62 RID: 3682 RVA: 0x0003AD65 File Offset: 0x00038F65
		public ObsoleteAttribute(string message, bool error)
		{
			this._message = message;
			this._error = error;
		}

		/// <summary>Возвращает сообщение об обходном пути, содержащее описание альтернативных элементов программы.</summary>
		/// <returns>Текстовая строка с описанием обходного пути.</returns>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0003AD7B File Offset: 0x00038F7B
		public string Message
		{
			get
			{
				return this._message;
			}
		}

		/// <summary>Возвращает логическое значение, позволяющее определить, будет ли компилятор считать использование устаревшего элемента программы ошибкой.</summary>
		/// <returns>Значение <see langword="true" />, если использование устаревшего элемента считается ошибкой; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x0003AD83 File Offset: 0x00038F83
		public bool IsError
		{
			get
			{
				return this._error;
			}
		}

		// Token: 0x040012A5 RID: 4773
		private string _message;

		// Token: 0x040012A6 RID: 4774
		private bool _error;
	}
}
