using System;

namespace System.EnterpriseServices
{
	/// <summary>Задает механизм проверки подлинности для удаленного вызова процедуры (RPC). Применимо, только если для объекта <see cref="T:System.EnterpriseServices.ActivationOption" /> устанавлено значение <see langword="Server" />.</summary>
	// Token: 0x02000011 RID: 17
	[Serializable]
	public enum AuthenticationOption
	{
		/// <summary>Проверяет подлинность учетных данных в начале каждого вызова.</summary>
		// Token: 0x0400003E RID: 62
		Call = 3,
		/// <summary>Проверяет подлинность учетных данных только при установке соединения.</summary>
		// Token: 0x0400003F RID: 63
		Connect = 2,
		/// <summary>Использует уровень проверки подлинности по умолчанию для заданной службы проверки подлинности. В COM+ этот параметр обеспечивается свойством <see langword="DefaultAuthenticationLevel" /> в коллекции <see langword="LocalComputer" />.</summary>
		// Token: 0x04000040 RID: 64
		Default = 0,
		/// <summary>Проверяет подлинность учетных данных и неизменность данных вызова при передаче.</summary>
		// Token: 0x04000041 RID: 65
		Integrity = 5,
		/// <summary>Проверка подлинности не выполняется.</summary>
		// Token: 0x04000042 RID: 66
		None = 1,
		/// <summary>Проверяет подлинность учетных данных и целостность полученных данных вызова.</summary>
		// Token: 0x04000043 RID: 67
		Packet = 4,
		/// <summary>Проверяет подлинность учетных данных и шифрует пакет, включая данные, а также удостоверение и подпись отправителя.</summary>
		// Token: 0x04000044 RID: 68
		Privacy = 6
	}
}
