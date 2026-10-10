using System;

namespace System.IO.Ports
{
	/// <summary>Указывает ошибки, возникающие в объекте <see cref="T:System.IO.Ports.SerialPort" />.</summary>
	// Token: 0x0200052E RID: 1326
	public enum SerialError
	{
		/// <summary>Переполнение входного буфера. Во входном буфере нет места, или после символа конца файла (EOF) получен еще один символ.</summary>
		// Token: 0x04001713 RID: 5907
		RXOver = 1,
		/// <summary>Переполнение буфера символов. Следующий символ потерян.</summary>
		// Token: 0x04001714 RID: 5908
		Overrun,
		/// <summary>Оборудованием обнаружена ошибка четности.</summary>
		// Token: 0x04001715 RID: 5909
		RXParity = 4,
		/// <summary>Оборудованием обнаружена ошибка кадрирования.</summary>
		// Token: 0x04001716 RID: 5910
		Frame = 8,
		/// <summary>Приложение пытается передать символ, однако выходной буфер заполнен.</summary>
		// Token: 0x04001717 RID: 5911
		TXFull = 256
	}
}
