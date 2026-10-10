using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security;

namespace System.Runtime.Remoting.Activation
{
	/// <summary>Определяет атрибут, который может использоваться на веб-узле вызова, чтобы указать URL-адрес, где происходит активация. Этот класс не наследуется.</summary>
	// Token: 0x020005D5 RID: 1493
	[ComVisible(true)]
	[Serializable]
	public sealed class UrlAttribute : ContextAttribute
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</summary>
		/// <param name="callsiteURL">URL-адрес веб-узла вызова.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="callsiteURL" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060038EB RID: 14571 RVA: 0x000CAF47 File Offset: 0x000C9147
		public UrlAttribute(string callsiteURL) : base(callsiteURL)
		{
			this.url = callsiteURL;
		}

		/// <summary>Получает значение URL-адреса <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</summary>
		/// <returns>Значение URL-адреса <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x000CAF57 File Offset: 0x000C9157
		public string UrlValue
		{
			get
			{
				return this.url;
			}
		}

		/// <summary>Проверяет, относится ли заданный объект к тому же URL-адресу, что и текущий экземпляр.</summary>
		/// <param name="o">Объект для сравнения с текущим объектом <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</param>
		/// <returns>
		///   <see langword="true" />, если объект — атрибут <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" /> с тем же самым значением. Иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060038ED RID: 14573 RVA: 0x000CAF5F File Offset: 0x000C915F
		public override bool Equals(object o)
		{
			return o is UrlAttribute && ((UrlAttribute)o).UrlValue == this.url;
		}

		/// <summary>Получает хэш-значение для текущего <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</summary>
		/// <returns>Хэш-значение для текущего <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060038EE RID: 14574 RVA: 0x000CAF81 File Offset: 0x000C9181
		public override int GetHashCode()
		{
			return this.url.GetHashCode();
		}

		/// <summary>Принудительно создает контекст и объект сервера в контексте по указанному URL-адресу.</summary>
		/// <param name="ctorMsg">Сообщение <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" /> создаваемого объекта сервера.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060038EF RID: 14575 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[ComVisible(true)]
		[SecurityCritical]
		public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
		{
		}

		/// <summary>Возвращает логическое значение, указывающее, удовлетворяет ли указанный контекст <see cref="T:System.Runtime.Remoting.Contexts.Context" /> требованиям <see cref="T:System.Runtime.Remoting.Activation.UrlAttribute" />.</summary>
		/// <param name="ctx">Контекст, в котором проверяется текущий атрибут контекста.</param>
		/// <param name="msg">Вызов конструирования, параметры которого требуется проверить относительно текущего контекста.</param>
		/// <returns>Имеет значение <see langword="true" />, если переданный контекст приемлем; иначе — <see langword="false" />.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x060038F0 RID: 14576 RVA: 0x000040F7 File Offset: 0x000022F7
		[ComVisible(true)]
		[SecurityCritical]
		public override bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			return true;
		}

		// Token: 0x040025FD RID: 9725
		private string url;
	}
}
