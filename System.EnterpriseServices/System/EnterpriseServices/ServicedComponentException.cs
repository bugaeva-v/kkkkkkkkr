using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Это исключение возникает при обнаружении ошибки в обслуживаемом компоненте.</summary>
	// Token: 0x02000049 RID: 73
	[ComVisible(false)]
	[Serializable]
	public sealed class ServicedComponentException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ServicedComponentException" />.</summary>
		// Token: 0x0600013A RID: 314 RVA: 0x000025B5 File Offset: 0x000007B5
		public ServicedComponentException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ServicedComponentException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, отображаемое для клиента при возникновении исключения.</param>
		// Token: 0x0600013B RID: 315 RVA: 0x000024D4 File Offset: 0x000006D4
		public ServicedComponentException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.ServicedComponentException" />.</summary>
		/// <param name="message">Сообщение, отображаемое для клиента при возникновении исключения.</param>
		/// <param name="innerException">Метод <see cref="P:System.Exception.InnerException" /> (при наличии), вызвавший текущее исключение.</param>
		// Token: 0x0600013C RID: 316 RVA: 0x000024EA File Offset: 0x000006EA
		public ServicedComponentException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
