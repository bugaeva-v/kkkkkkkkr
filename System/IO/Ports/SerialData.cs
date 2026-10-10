using System;

namespace System.IO.Ports
{
	/// <summary>Указывает тип символа, полученного от последовательного порта в объект <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	// Token: 0x0200052D RID: 1325
	public enum SerialData
	{
		/// <summary>Символ получен и помещен во входной буфер.</summary>
		// Token: 0x04001710 RID: 5904
		Chars = 1,
		/// <summary>Символ конца файла получен и помещен во входной буфер.</summary>
		// Token: 0x04001711 RID: 5905
		Eof
	}
}
