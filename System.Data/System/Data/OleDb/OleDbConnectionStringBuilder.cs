using System;
using System.Collections;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Удобное средство, с помощью которого можно создавать используемые классом <see cref="T:System.Data.OleDb.OleDbConnection" /> строки соединений и управлять их содержимым.</summary>
	// Token: 0x02000160 RID: 352
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbConnectionStringBuilder : DbConnectionStringBuilder
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />.</summary>
		// Token: 0x060012F7 RID: 4855 RVA: 0x0005AC85 File Offset: 0x00058E85
		public OleDbConnectionStringBuilder()
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />. Предоставленная строка подключения содержит данные для сведений о внутреннем подключении экземпляра.</summary>
		/// <param name="connectionString">Основа для сведений о внутреннем подключении объекта. Выполняет анализ пар "ключ/значение".</param>
		/// <exception cref="T:System.ArgumentException">Строка подключения неправильно отформатирована (возможно отсутствует обязательный знак равенства "=" в паре "ключ/значение").</exception>
		// Token: 0x060012F8 RID: 4856 RVA: 0x0005AC85 File Offset: 0x00058E85
		public OleDbConnectionStringBuilder(string connectionString)
		{
			throw ADP.OleDb();
		}

		/// <summary>Возвращает или задает имя источника данных, к которому необходимо подключиться.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.OleDb.OleDbConnectionStringBuilder.DataSource" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x00007EED File Offset: 0x000060ED
		public string DataSource
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает имя UDL-файла для подключения к источнику данных.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.OleDb.OleDbConnectionStringBuilder.FileName" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x00007EED File Offset: 0x000060ED
		public string FileName
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x00007EED File Offset: 0x000060ED
		public object Item
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />.</returns>
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001300 RID: 4864 RVA: 0x00007EED File Offset: 0x000060ED
		public override ICollection Keys
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает значение, передаваемое в строку подключения для ключа служб OLE DB.</summary>
		/// <returns>Значение, соответствующее ключу служб OLE DB в строке подключения. По умолчанию значение равно -13.</returns>
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001302 RID: 4866 RVA: 0x00007EED File Offset: 0x000060ED
		public int OleDbServices
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает логическое значение, которое определяет, возвращаются ли важнейшие сведения (такие как пароль) как часть подключения, если оно открыто или когда-либо находилось в открытом состоянии.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.OleDb.OleDbConnectionStringBuilder.PersistSecurityInfo" /> или <see langword="false" />, если значение не указано.</returns>
		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001304 RID: 4868 RVA: 0x00007EED File Offset: 0x000060ED
		public bool PersistSecurityInfo
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает строку, которая содержит имя поставщика данных, связанного с внутренней строкой подключения.</summary>
		/// <returns>Значение свойства <see cref="P:System.Data.OleDb.OleDbConnectionStringBuilder.Provider" /> или <see langword="String.Empty" />, если значение не указано.</returns>
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001306 RID: 4870 RVA: 0x00007EED File Offset: 0x000060ED
		public string Provider
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Удаляет содержимое экземпляра <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />.</summary>
		// Token: 0x06001307 RID: 4871 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Clear()
		{
			throw ADP.OleDb();
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" /> указанный ключ.</summary>
		/// <param name="keyword">Ключ, который требуется найти в <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" /> содержится элемент с указанным ключом; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение null (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06001308 RID: 4872 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool ContainsKey(string keyword)
		{
			throw ADP.OleDb();
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void GetProperties(Hashtable propertyDescriptors)
		{
			throw ADP.OleDb();
		}

		/// <summary>Удаляет из экземпляра <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" /> запись с указанным ключом.</summary>
		/// <param name="keyword">Ключ пары «ключ-значение», удаляемой из строки подключения в этом объекте <see cref="T:System.Data.OleDb.OleDbConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если ключ существовал в строке подключения и был удален; значение <see langword="false" />, если ключа не было.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение null (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x0600130A RID: 4874 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override bool Remove(string keyword)
		{
			throw ADP.OleDb();
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public bool TryGetValue(string keyword, object value)
		{
			throw ADP.OleDb();
		}
	}
}
