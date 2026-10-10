using System;

namespace System.Data
{
	/// <summary>Указывает, как записывать XML-данные и реляционную схему из объекта <see cref="T:System.Data.DataSet" />.</summary>
	// Token: 0x02000148 RID: 328
	public enum XmlWriteMode
	{
		/// <summary>Записывает текущее содержимое объекта <see cref="T:System.Data.DataSet" /> в виде XML-данных с реляционной структурой как встроенную схему XSD. Если объект <see cref="T:System.Data.DataSet" /> имеет только схему без данных, записывается только встроенная схема. Если объект <see cref="T:System.Data.DataSet" /> не имеет текущей схемы, запись не производится.</summary>
		// Token: 0x04000B60 RID: 2912
		WriteSchema,
		/// <summary>Записывает текущее содержимое объекта <see cref="T:System.Data.DataSet" /> как XML-данные без схемы XSD. Если никакие данные не загружены в объект <see cref="T:System.Data.DataSet" />, запись не производится.</summary>
		// Token: 0x04000B61 RID: 2913
		IgnoreSchema,
		/// <summary>Записывает весь <see cref="T:System.Data.DataSet" /> как DiffGram, включая исходные и текущие значения. Для создания формата DiffGram, содержащего только измененные значения, следует вызвать метод <see cref="M:System.Data.DataSet.GetChanges" />, а затем — метод <see cref="M:System.Data.DataSet.WriteXml(System.IO.Stream)" /> как DiffGram для возвращенного объекта <see cref="T:System.Data.DataSet" />.</summary>
		// Token: 0x04000B62 RID: 2914
		DiffGram
	}
}
