using System;
using System.Collections.Generic;

namespace System.Runtime.Serialization.Json
{
	/// <summary>Задает параметры <see cref="T:System.Runtime.Serialization.Json.DataContractJsonSerializer" />.</summary>
	// Token: 0x02000166 RID: 358
	public class DataContractJsonSerializerSettings
	{
		/// <summary>Получает или задает корневое имя выбранного объекта.</summary>
		/// <returns>Имя корневого объекта выбранного объекта.</returns>
		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00049DEC File Offset: 0x00047FEC
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x00049DF4 File Offset: 0x00047FF4
		public string RootName { get; set; }

		/// <summary>Получает или задает коллекцию типов, которые могут присутствовать в графе объекта, сериализованном с помощью этого DataContractJsonSerializerSettings.</summary>
		/// <returns>Коллекция типов, которые могут присутствовать в графе объекта, сериализованном с помощью этого экземпляра класса DataContractJsonSerializerSettings.</returns>
		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x00049DFD File Offset: 0x00047FFD
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x00049E05 File Offset: 0x00048005
		public IEnumerable<Type> KnownTypes { get; set; }

		/// <summary>Получает или задает максимальное количество элементов в графе объекта для сериализации или десериализации.</summary>
		/// <returns>Максимальное количество элементов в графе объекта для сериализации или десериализации.</returns>
		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00049E0E File Offset: 0x0004800E
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00049E16 File Offset: 0x00048016
		public int MaxItemsInObjectGraph
		{
			get
			{
				return this.maxItemsInObjectGraph;
			}
			set
			{
				this.maxItemsInObjectGraph = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, должны ли пропускаться данные, предоставляемые расширением класса, при сериализации или десериализации класса.</summary>
		/// <returns>Значение <see langword="true" /> для пропуска данных, предоставляемых расширением класса, при сериализации или десериализации класса; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00049E1F File Offset: 0x0004801F
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x00049E27 File Offset: 0x00048027
		public bool IgnoreExtensionDataObject { get; set; }

		/// <summary>Получает или задает тип суррогата, который в данный момент активен для заданного экземпляра IDataContractSurrogate.</summary>
		/// <returns>Тип суррогата, который в данный момент активен для заданного экземпляра IDataContractSurrogate.</returns>
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00049E30 File Offset: 0x00048030
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x00049E38 File Offset: 0x00048038
		public IDataContractSurrogate DataContractSurrogate { get; set; }

		/// <summary>Получает или задает параметры сериализатора контракта данных JSON для выдачи сведений о типе.</summary>
		/// <returns>Параметры сериализатора контракта данных JSON для выдачи сведений о типе.</returns>
		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00049E41 File Offset: 0x00048041
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x00049E49 File Offset: 0x00048049
		public EmitTypeInformation EmitTypeInformation { get; set; }

		/// <summary>Получает или задает DateTimeFormat, определяющий формат отображения даты и времени, соответствующий языку и региональным параметрам.</summary>
		/// <returns>DateTimeFormat, определяющий формат отображения даты и времени, соответствующий языку и региональным параметрам.</returns>
		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00049E52 File Offset: 0x00048052
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x00049E5A File Offset: 0x0004805A
		public DateTimeFormat DateTimeFormat { get; set; }

		/// <summary>Получает или задает значение, указывающее, следует ли сериализовать типы, доступные только для чтения.</summary>
		/// <returns>Значение <see langword="true" /> для сериализации доступных только для чтения типов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00049E63 File Offset: 0x00048063
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x00049E6B File Offset: 0x0004806B
		public bool SerializeReadOnlyTypes { get; set; }

		/// <summary>Получает или задает значение, указывающее, следует ли использовать простой формат словаря.</summary>
		/// <returns>Значение <see langword="true" /> для использования простого формата словаря; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00049E74 File Offset: 0x00048074
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x00049E7C File Offset: 0x0004807C
		public bool UseSimpleDictionaryFormat { get; set; }

		// Token: 0x0400097F RID: 2431
		private int maxItemsInObjectGraph = int.MaxValue;
	}
}
