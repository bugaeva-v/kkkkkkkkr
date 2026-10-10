using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices.Internal
{
	/// <summary>Активирует прокси COM+ приложений с включенным SOAP со стороны клиента.</summary>
	// Token: 0x0200005A RID: 90
	[Guid("ecabafd1-7f19-11d2-978e-0000f8757e2a")]
	public class ClrObjectFactory : IClrObjectFactory
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.Internal.ClrObjectFactory" />.</summary>
		// Token: 0x0600015A RID: 346 RVA: 0x00002078 File Offset: 0x00000278
		[MonoTODO]
		public ClrObjectFactory()
		{
			throw new NotImplementedException();
		}

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя файл конфигурации сборки.</summary>
		/// <param name="AssemblyName">Имя активируемой сборки.</param>
		/// <param name="TypeName">Имя активируемого типа.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы и параметры привязки и активации установлены в <see langword="null" />, или значение <see langword="null" />, если параметр <paramref name="TypeName" /> не найден.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Класс не зарегистрирован.</exception>
		// Token: 0x0600015B RID: 347 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public object CreateFromAssembly(string AssemblyName, string TypeName, string Mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя почтовый ящик удаленной сборки. На данный момент не реализован, при вызове генерирует исключение <see cref="T:System.Runtime.InteropServices.COMException" />.</summary>
		/// <param name="Mailbox">Почтовый ящик в веб-службе.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>При вызове этого метода генерируется исключение.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Протокол SMTP не реализован.</exception>
		// Token: 0x0600015C RID: 348 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public object CreateFromMailbox(string Mailbox, string Mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя URL-адрес виртуального корня удаленной сборки.</summary>
		/// <param name="VrootUrl">URL-адрес виртуального корня активируемого объекта.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы и параметры привязки и активации установлены в <see langword="null" />, или значение <see langword="null" />, если сборка, определяемая параметром <paramref name="VrootUrl" />, не найдена.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Не удается открыть маркер потока.</exception>
		// Token: 0x0600015D RID: 349 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public object CreateFromVroot(string VrootUrl, string Mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Активирует удаленную сборку через службу удаленного взаимодействия .NET, используя код WSDL веб-службы XML.</summary>
		/// <param name="WsdlUrl">URL-адрес WSDL веб-службы.</param>
		/// <param name="Mode">Не используется.</param>
		/// <returns>Экземпляр класса <see cref="T:System.Object" />, представляющий тип, для которого язык и региональные параметры, аргументы и параметры привязки и активации установлены в <see langword="null" />, или значение <see langword="null" />, если сборка, определяемая параметром <paramref name="WsdlUrl" />, не найдена.</returns>
		/// <exception cref="T:System.Security.SecurityException">Вызывающий код в цепочке вызовов не имеет необходимого разрешения на доступ к неуправляемому коду.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Не удается открыть маркер потока.</exception>
		// Token: 0x0600015E RID: 350 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public object CreateFromWsdl(string WsdlUrl, string Mode)
		{
			throw new NotImplementedException();
		}
	}
}
