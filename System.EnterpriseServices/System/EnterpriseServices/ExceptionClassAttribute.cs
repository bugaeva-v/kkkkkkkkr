using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Устанавливает класс исключения очереди для класса очередей. Этот класс не наследуется.</summary>
	// Token: 0x0200001D RID: 29
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(false)]
	public sealed class ExceptionClassAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ExceptionClassAttribute" />.</summary>
		/// <param name="name">Имя класса исключения для проигрывателя, чтобы выполнить активацию и воспроизведение до направления сообщения в очередь невостребованных писем.</param>
		// Token: 0x06000069 RID: 105 RVA: 0x0000231E File Offset: 0x0000051E
		public ExceptionClassAttribute(string name)
		{
			this.name = name;
		}

		/// <summary>Получает имя класса исключения для проигрывателя, чтобы выполнить активацию и воспроизведение до направления сообщения в очередь невостребованных писем.</summary>
		/// <returns>Имя класса исключения для проигрывателя, чтобы выполнить активацию и воспроизведение до направления сообщения в очередь невостребованных писем.</returns>
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000232D File Offset: 0x0000052D
		public string Value
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x04000054 RID: 84
		private string name;
	}
}
