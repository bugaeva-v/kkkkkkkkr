using System;

namespace System.Data
{
	/// <summary>Используется в конструкторах данных Visual Basic .NET для представления параметра в объект Command и при необходимости его сопоставления со столбцами <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000106 RID: 262
	public interface IDbDataParameter : IDataParameter
	{
		/// <summary>Указывает точность числовых параметров.</summary>
		/// <returns>Максимальное число разрядов, используемых для представления свойства Value объекта Parameter поставщика данных. Значение по умолчанию — 0. Оно указывает, что точность значения Value задает поставщик данных.</returns>
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000F6C RID: 3948
		// (set) Token: 0x06000F6D RID: 3949
		byte Precision { get; set; }

		/// <summary>Указывает масштаб числовых параметров.</summary>
		/// <returns>Число десятичных разрядов, до которых вычисляется значение <see cref="P:System.Data.OleDb.OleDbParameter.Value" />. Значение по умолчанию — 0.</returns>
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000F6E RID: 3950
		// (set) Token: 0x06000F6F RID: 3951
		byte Scale { get; set; }

		/// <summary>Размер параметра.</summary>
		/// <returns>Максимальная длина данных (в байтах) в столбце. Значение по умолчанию определяется исходя из значения параметра.</returns>
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000F70 RID: 3952
		// (set) Token: 0x06000F71 RID: 3953
		int Size { get; set; }
	}
}
