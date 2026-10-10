using System;

namespace System.IO.Ports
{
	/// <summary>Указывает число стоповых битов, используемых для объекта <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	// Token: 0x02000539 RID: 1337
	public enum StopBits
	{
		/// <summary>Стоповые биты не используются. Это значение не поддерживается свойством <see cref="P:System.IO.Ports.SerialPort.StopBits" />.</summary>
		// Token: 0x04001748 RID: 5960
		None,
		/// <summary>Используется один стоповый бит.</summary>
		// Token: 0x04001749 RID: 5961
		One,
		/// <summary>Используются два стоповых бита.</summary>
		// Token: 0x0400174A RID: 5962
		Two,
		/// <summary>Используется 1,5 стоповых бита.</summary>
		// Token: 0x0400174B RID: 5963
		OnePointFive
	}
}
