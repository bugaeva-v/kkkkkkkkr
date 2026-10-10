using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Определяет тип подключения к объекту класса.</summary>
	// Token: 0x020006CD RID: 1741
	[Flags]
	public enum RegistrationConnectionType
	{
		/// <summary>После того, как приложение подключится к объекту класса с помощью <see langword="CoGetClassObject" />, объект класса удаляется из открытого представления, чтобы ни одно другое представление не могло к нему подключиться. Это значение обычно используется для приложений с однооконным интерфейсом (SDI).</summary>
		// Token: 0x04002A09 RID: 10761
		SingleUse = 0,
		/// <summary>Несколько приложений могут подключиться к объекту класса с помощью вызовов объекта <see langword="CoGetClassObject" />.</summary>
		// Token: 0x04002A0A RID: 10762
		MultipleUse = 1,
		/// <summary>Регистрируют независимые фабрики классов CLSCTX_LOCAL_SERVER и CLSCTX_INPROC_SERVER.</summary>
		// Token: 0x04002A0B RID: 10763
		MultiSeparate = 2,
		/// <summary>Приостанавливает запросы на регистрацию и активацию для заданного значения CLSID до вызова <see langword="CoResumeClassObjects" />.</summary>
		// Token: 0x04002A0C RID: 10764
		Suspended = 4,
		/// <summary>Этот объект класса представляет собой процесс-заменитель, используемый для выполнения серверов DLL.</summary>
		// Token: 0x04002A0D RID: 10765
		Surrogate = 8
	}
}
