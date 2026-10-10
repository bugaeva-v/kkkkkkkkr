using System;
using System.Collections;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет коллекцию свойств, которые можно добавить в объекты <see cref="T:System.Data.DataColumn" />, <see cref="T:System.Data.DataSet" /> или <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x02000115 RID: 277
	[Serializable]
	public class PropertyCollection : Hashtable, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.PropertyCollection" />.</summary>
		// Token: 0x06000F9A RID: 3994 RVA: 0x0003FD90 File Offset: 0x0003DF90
		public PropertyCollection()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.PropertyCollection" />.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Источник и назначение данного сериализованного потока.</param>
		// Token: 0x06000F9B RID: 3995 RVA: 0x0003FD98 File Offset: 0x0003DF98
		protected PropertyCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Создает неполную копию объекта <see cref="T:System.Data.PropertyCollection" />.</summary>
		/// <returns>Возвращает <see cref="T:System.Object" />, неполную копию объекта <see cref="T:System.Data.PropertyCollection" />.</returns>
		// Token: 0x06000F9C RID: 3996 RVA: 0x0003FDA4 File Offset: 0x0003DFA4
		public override object Clone()
		{
			PropertyCollection propertyCollection = new PropertyCollection();
			foreach (object obj in this)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				propertyCollection.Add(dictionaryEntry.Key, dictionaryEntry.Value);
			}
			return propertyCollection;
		}
	}
}
