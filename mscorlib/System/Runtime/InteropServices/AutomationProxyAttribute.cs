using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Указывает, будет ли выполняться маршалинг типа с использованием маршалера автоматизации или настраиваемого прокси-сервера и заглушки.</summary>
	// Token: 0x0200070A RID: 1802
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Interface, Inherited = false)]
	public sealed class AutomationProxyAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.AutomationProxyAttribute" />.</summary>
		/// <param name="val">Значение <see langword="true" />, если маршалинг класса должна выполняться с помощью автоматического модуля маршалинга, и значение. <see langword="false" />, если нужно использовать модуль маршалинга заглушки прокси-сервера.</param>
		// Token: 0x060040AF RID: 16559 RVA: 0x000E153B File Offset: 0x000DF73B
		public AutomationProxyAttribute(bool val)
		{
			this._val = val;
		}

		/// <summary>Возвращает значение, показывающее тип используемого модуля маршалинга.</summary>
		/// <returns>Значение <see langword="true" />, если маршалинг класса должна выполняться с помощью автоматического модуля маршалинга, и значение. <see langword="false" />, если нужно использовать модуль маршалинга заглушки прокси-сервера.</returns>
		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060040B0 RID: 16560 RVA: 0x000E154A File Offset: 0x000DF74A
		public bool Value
		{
			get
			{
				return this._val;
			}
		}

		// Token: 0x04002AE1 RID: 10977
		internal bool _val;
	}
}
