using System;
using System.Collections.ObjectModel;

namespace System.Runtime.Serialization
{
	/// <summary>Представляет параметры, которые могут устанавливаться для <see cref="T:System.Runtime.Serialization.XsdDataContractExporter" />.</summary>
	// Token: 0x020000D3 RID: 211
	public class ExportOptions
	{
		/// <summary>Возвращает или задает суррогат сериализации.</summary>
		/// <returns>Реализация интерфейса <see cref="T:System.Runtime.Serialization.IDataContractSurrogate" />, которую можно использовать для настройки экспорта представления схемы XML для конкретного типа.</returns>
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x00032BA2 File Offset: 0x00030DA2
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00032BAA File Offset: 0x00030DAA
		public IDataContractSurrogate DataContractSurrogate
		{
			get
			{
				return this.dataContractSurrogate;
			}
			set
			{
				this.dataContractSurrogate = value;
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00032BA2 File Offset: 0x00030DA2
		internal IDataContractSurrogate GetSurrogate()
		{
			return this.dataContractSurrogate;
		}

		/// <summary>Возвращает коллекцию типов, которые могли быть обнаружены в процессе сериализации или десериализации.</summary>
		/// <returns>Коллекция <see langword="KnownTypes" />, содержащая типы, которые могли быть обнаружены в процессе сериализации или десериализации. Представления схемы XML экспортируются для всех типов, заданных в этой коллекции <see cref="T:System.Runtime.Serialization.XsdDataContractExporter" />.</returns>
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00032BB3 File Offset: 0x00030DB3
		public Collection<Type> KnownTypes
		{
			get
			{
				if (this.knownTypes == null)
				{
					this.knownTypes = new Collection<Type>();
				}
				return this.knownTypes;
			}
		}

		// Token: 0x04000517 RID: 1303
		private Collection<Type> knownTypes;

		// Token: 0x04000518 RID: 1304
		private IDataContractSurrogate dataContractSurrogate;
	}
}
