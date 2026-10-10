using System;
using System.Runtime.InteropServices;

namespace System.Deployment.Internal
{
	/// <summary>Предоставляет доступ к данным из объекта <see cref="T:System.ActivationContext" />.</summary>
	// Token: 0x0200027D RID: 637
	[ComVisible(false)]
	public static class InternalActivationContextHelper
	{
		/// <summary>Возвращает содержимое манифеста приложения из объекта <see cref="T:System.ActivationContext" />.</summary>
		/// <param name="appInfo">Объект, содержащий манифест.</param>
		/// <returns>Манифест приложения, которое содержит объект <see cref="T:System.ActivationContext" />.</returns>
		// Token: 0x06001D48 RID: 7496 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static object GetActivationContextData(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает манифест последнего развертывания компонента из объекта <see cref="T:System.ActivationContext" />.</summary>
		/// <param name="appInfo">Объект, содержащий манифест.</param>
		/// <returns>Манифест последнего развертывания компонента из объекта <see cref="T:System.ActivationContext" />.</returns>
		// Token: 0x06001D49 RID: 7497 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static object GetApplicationComponentManifest(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает массив байтов, содержащий необработанное содержимое манифеста приложения.</summary>
		/// <param name="appInfo">Объект, от которого получают байты.</param>
		/// <returns>Массив, содержащий манифест приложения в виде необработанных данных.</returns>
		// Token: 0x06001D4A RID: 7498 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("2.0 SP1 member")]
		public static byte[] GetApplicationManifestBytes(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает манифест первого развертывания компонента из объекта <see cref="T:System.ActivationContext" />.</summary>
		/// <param name="appInfo">Объект, содержащий манифест.</param>
		/// <returns>Манифест первого развертывания компонента из объекта <see cref="T:System.ActivationContext" />.</returns>
		// Token: 0x06001D4B RID: 7499 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static object GetDeploymentComponentManifest(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает массив байтов, содержащий необработанное содержимое манифеста развертывания.</summary>
		/// <param name="appInfo">Объект, от которого получают байты.</param>
		/// <returns>Массив, содержащий манифест развертывания в виде необработанных данных.</returns>
		// Token: 0x06001D4C RID: 7500 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("2.0 SP1 member")]
		public static byte[] GetDeploymentManifestBytes(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Возвращает или определяет значение, которое сообщает, выполняется ли объект <see cref="T:System.ActivationContext" /> впервые.</summary>
		/// <param name="appInfo">Изучаемый объект.</param>
		/// <returns>
		///   <see langword="true" />, если <see cref="T:System.ActivationContext" /> сигнализирует о том, что выполнение происходит впервые; иначе <see langword="false" />.</returns>
		// Token: 0x06001D4D RID: 7501 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static bool IsFirstRun(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}

		/// <summary>Информирует <see cref="T:System.ActivationContext" /> о том, что следует подготовиться к выполнению.</summary>
		/// <param name="appInfo">Информируемый объект.</param>
		// Token: 0x06001D4E RID: 7502 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public static void PrepareForExecution(ActivationContext appInfo)
		{
			throw new NotImplementedException();
		}
	}
}
