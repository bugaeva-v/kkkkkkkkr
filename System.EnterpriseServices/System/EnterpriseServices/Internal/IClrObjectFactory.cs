using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Активирует прокси COM+ приложений с включенным SOAP со стороны клиента.</summary>
	// Token: 0x0200005E RID: 94
	[Guid("ecabafd2-7f19-11d2-978e-0000f8757e2a")]
	public interface IClrObjectFactory
	{
		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя файл конфигурации сборки.</summary>
		/// <param name="assembly">Имя активируемой сборки.</param>
		/// <param name="type">Имя активируемого типа.</param>
		/// <param name="mode">Не используется.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы и параметры привязки и активации установлены в <see langword="null" />, или значение <see langword="null" />, если параметр <paramref name="type" /> не найден.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Класс не зарегистрирован.</exception>
		// Token: 0x06000169 RID: 361
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateFromAssembly(string assembly, string type, string mode);

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя почтовый ящик удаленной сборки. На данный момент не реализован, при вызове генерирует исключение <see cref="T:System.Runtime.InteropServices.COMException" />.</summary>
		/// <param name="Mailbox">Почтовый ящик в веб-службе.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>При вызове этого метода генерируется исключение.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Протокол SMTP не реализован.</exception>
		// Token: 0x0600016A RID: 362
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateFromMailbox(string Mailbox, string Mode);

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя URL-адрес виртуального корня удаленной сборки.</summary>
		/// <param name="VrootUrl">URL-адрес виртуального корня удаленного объекта.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы и параметры привязки и активации установлены в <see langword="null" />, или значение <see langword="null" />, если сборка, определяемая параметром <paramref name="VrootUrl" />, не найдена.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Не удается открыть маркер потока.</exception>
		// Token: 0x0600016B RID: 363
		[DispId(2)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateFromVroot(string VrootUrl, string Mode);

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя код WSDL веб-службы XML.</summary>
		/// <param name="WsdlUrl">URL-адрес WSDL веб-службы.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы и параметры привязки и активации установлены в <see langword="null" />, или значение <see langword="null" />, если сборка, определяемая параметром <paramref name="WsdlUrl" />, не найдена.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Не удается открыть маркер потока.</exception>
		// Token: 0x0600016C RID: 364
		[DispId(3)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object CreateFromWsdl(string WsdlUrl, string Mode);
	}
}
