using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Threading;

namespace System.Data.Common
{
	/// <summary>Предоставляет базовый класс для строго типизированных построителей строк подключения.</summary>
	// Token: 0x0200038E RID: 910
	public class DbConnectionStringBuilder : IDictionary, ICollection, IEnumerable, ICustomTypeDescriptor
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		// Token: 0x06002BAB RID: 11179 RVA: 0x000BBE14 File Offset: 0x000BA014
		public DbConnectionStringBuilder()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> (необязательно) с использованием правил ODBC для значений в кавычках.</summary>
		/// <param name="useOdbcRules">Значение <see langword="true" /> определяет использование {} для разделения полей. Значение <see langword="false" /> — использование кавычек.</param>
		// Token: 0x06002BAC RID: 11180 RVA: 0x000BBE3E File Offset: 0x000BA03E
		public DbConnectionStringBuilder(bool useOdbcRules)
		{
			this._useOdbcRules = useOdbcRules;
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000BBE6F File Offset: 0x000BA06F
		private ICollection Collection
		{
			get
			{
				return this.CurrentValues;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x000BBE6F File Offset: 0x000BA06F
		private IDictionary Dictionary
		{
			get
			{
				return this.CurrentValues;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000BBE78 File Offset: 0x000BA078
		private Dictionary<string, object> CurrentValues
		{
			get
			{
				Dictionary<string, object> dictionary = this._currentValues;
				if (dictionary == null)
				{
					dictionary = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
					this._currentValues = dictionary;
				}
				return dictionary;
			}
		}

		/// <summary>Возвращает или задает элемент с указанным ключом.</summary>
		/// <param name="keyword">Ключ элемента, который требуется получить или задать.</param>
		/// <returns>Элемент с указанным ключом.</returns>
		// Token: 0x1700076A RID: 1898
		object IDictionary.this[object keyword]
		{
			get
			{
				return this[this.ObjectToString(keyword)];
			}
			set
			{
				this[this.ObjectToString(keyword)] = value;
			}
		}

		/// <summary>Возвращает или задает значение, связанное с указанным ключом.</summary>
		/// <param name="keyword">Ключ возвращаемого или задаваемого элемента.</param>
		/// <returns>Значение, связанное с указанным ключом. Если указанный ключ не найден, при попытке его получения возвращается пустая ссылка (<see langword="Nothing" /> в Visual Basic), а при попытке задания создается новый элемент с использованием указанного ключа.  
		/// Передача пустого ключа (<see langword="Nothing" /> в Visual Basic) порождает <see cref="T:System.ArgumentNullException" />. При присвоении значения NULL удаляется пара "ключ-значение".</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="keyword" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</exception>
		/// <exception cref="T:System.NotSupportedException">Свойство задано, а значение <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> доступно только для чтения.  
		/// -или- 
		/// Свойство задано, <paramref name="keyword" /> не существует в коллекции, а <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> имеет фиксированный размер.</exception>
		// Token: 0x1700076B RID: 1899
		[Browsable(false)]
		public virtual object this[string keyword]
		{
			get
			{
				DataCommonEventSource.Log.Trace<int, string>("<comm.DbConnectionStringBuilder.get_Item|API> {0}, keyword='{1}'", this.ObjectID, keyword);
				ADP.CheckArgumentNull(keyword, "keyword");
				object result;
				if (this.CurrentValues.TryGetValue(keyword, out result))
				{
					return result;
				}
				throw ADP.KeywordNotSupported(keyword);
			}
			set
			{
				ADP.CheckArgumentNull(keyword, "keyword");
				bool flag;
				if (value != null)
				{
					string value2 = DbConnectionStringBuilderUtil.ConvertToString(value);
					DbConnectionOptions.ValidateKeyValuePair(keyword, value2);
					flag = this.CurrentValues.ContainsKey(keyword);
					this.CurrentValues[keyword] = value2;
				}
				else
				{
					flag = this.Remove(keyword);
				}
				this._connectionString = null;
				if (flag)
				{
					this._propertyDescriptors = null;
				}
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, отображается ли свойство <see cref="P:System.Data.Common.DbConnectionStringBuilder.ConnectionString" /> в конструкторах Visual Studio.</summary>
		/// <returns>Значение <see langword="true" />, если строка подключения отображается в конструкторах; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000BBF6C File Offset: 0x000BA16C
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x000BBF74 File Offset: 0x000BA174
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DesignOnly(true)]
		[Browsable(false)]
		public bool BrowsableConnectionString
		{
			get
			{
				return this._browsableConnectionString;
			}
			set
			{
				this._browsableConnectionString = value;
				this._propertyDescriptors = null;
			}
		}

		/// <summary>Возвращает или задает строку подключения, связанную с этим <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Текущая строка подключения, созданная из пар "ключ-значение", которые содержатся в <see cref="T:System.Data.Common.DbConnectionStringBuilder" />. Значение по умолчанию - пустая строка.</returns>
		/// <exception cref="T:System.ArgumentException">Предоставлен недопустимый аргумент строки соединения.</exception>
		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000BBF84 File Offset: 0x000BA184
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x000BC03C File Offset: 0x000BA23C
		[RefreshProperties(RefreshProperties.All)]
		public string ConnectionString
		{
			get
			{
				DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.get_ConnectionString|API> {0}", this.ObjectID);
				string text = this._connectionString;
				if (text == null)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in this.Keys)
					{
						string keyword = (string)obj;
						object value;
						if (this.ShouldSerialize(keyword) && this.TryGetValue(keyword, out value))
						{
							string value2 = this.ConvertValueToString(value);
							DbConnectionStringBuilder.AppendKeyValuePair(stringBuilder, keyword, value2, this._useOdbcRules);
						}
					}
					text = stringBuilder.ToString();
					this._connectionString = text;
				}
				return text;
			}
			set
			{
				DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.set_ConnectionString|API> {0}", this.ObjectID);
				DbConnectionOptions dbConnectionOptions = new DbConnectionOptions(value, null, this._useOdbcRules);
				string connectionString = this.ConnectionString;
				this.Clear();
				try
				{
					for (NameValuePair nameValuePair = dbConnectionOptions._keyChain; nameValuePair != null; nameValuePair = nameValuePair.Next)
					{
						if (nameValuePair.Value != null)
						{
							this[nameValuePair.Name] = nameValuePair.Value;
						}
						else
						{
							this.Remove(nameValuePair.Name);
						}
					}
					this._connectionString = null;
				}
				catch (ArgumentException)
				{
					this.ConnectionString = connectionString;
					this._connectionString = connectionString;
					throw;
				}
			}
		}

		/// <summary>Возвращает текущее количество ключей, содержащихся в свойстве <see cref="P:System.Data.Common.DbConnectionStringBuilder.ConnectionString" />.</summary>
		/// <returns>Количество ключей, содержащихся в строке соединения, которую обеспечивает экземпляр <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000BC0E0 File Offset: 0x000BA2E0
		[Browsable(false)]
		public virtual int Count
		{
			get
			{
				return this.CurrentValues.Count;
			}
		}

		/// <summary>Возвращает значение, которое определяет, является ли коллекция <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> доступной только для чтения.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> доступен только для чтения, в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x00006D64 File Offset: 0x00004F64
		[Browsable(false)]
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, имеет ли объект <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> фиксированный размер.</summary>
		/// <returns>Значение <see langword="true" />, если список <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> имеет фиксированный размер. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x00006D64 File Offset: 0x00004F64
		[Browsable(false)]
		public virtual bool IsFixedSize
		{
			get
			{
				return false;
			}
		}

		/// <summary>Возвращает значение, показывающее, является ли доступ к коллекции <see cref="T:System.Collections.ICollection" /> синхронизированным (потокобезопасным).</summary>
		/// <returns>
		///   <see langword="true" />, если доступ к классу <see cref="T:System.Collections.ICollection" /> является синхронизированным (потокобезопасным); в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000BC0ED File Offset: 0x000BA2ED
		bool ICollection.IsSynchronized
		{
			get
			{
				return this.Collection.IsSynchronized;
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, которая содержит ключи из <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000BC0FA File Offset: 0x000BA2FA
		[Browsable(false)]
		public virtual ICollection Keys
		{
			get
			{
				DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.Keys|API> {0}", this.ObjectID);
				return this.Dictionary.Keys;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000BC11C File Offset: 0x000BA31C
		internal int ObjectID
		{
			get
			{
				return this._objectID;
			}
		}

		/// <summary>Получает объект, с помощью которого можно синхронизировать доступ к коллекции <see cref="T:System.Collections.ICollection" />.</summary>
		/// <returns>Объект, который может использоваться для синхронизации доступа к <see cref="T:System.Collections.ICollection" />.</returns>
		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000BC124 File Offset: 0x000BA324
		object ICollection.SyncRoot
		{
			get
			{
				return this.Collection.SyncRoot;
			}
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Collections.ICollection" />, которая содержит значения в <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Коллекция <see cref="T:System.Collections.ICollection" />, которая содержит значения из <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</returns>
		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000BC134 File Offset: 0x000BA334
		[Browsable(false)]
		public virtual ICollection Values
		{
			get
			{
				DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.Values|API> {0}", this.ObjectID);
				ICollection<string> collection = (ICollection<string>)this.Keys;
				IEnumerator<string> enumerator = collection.GetEnumerator();
				object[] array = new object[collection.Count];
				for (int i = 0; i < array.Length; i++)
				{
					enumerator.MoveNext();
					array[i] = this[enumerator.Current];
				}
				return new ReadOnlyCollection<object>(array);
			}
		}

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000BC19D File Offset: 0x000BA39D
		internal virtual string ConvertValueToString(object value)
		{
			if (value != null)
			{
				return Convert.ToString(value, CultureInfo.InvariantCulture);
			}
			return null;
		}

		/// <summary>Добавляет элемент с указанными ключом и значением в объект <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="keyword">Объект <see cref="T:System.Object" /> используется в качестве ключа добавляемого элемента.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> используется в качестве значения добавляемого элемента.</param>
		// Token: 0x06002BC1 RID: 11201 RVA: 0x000BC1AF File Offset: 0x000BA3AF
		void IDictionary.Add(object keyword, object value)
		{
			this.Add(this.ObjectToString(keyword), value);
		}

		/// <summary>Добавляет запись с указанными ключом и значением в <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <param name="keyword">Ключ, добавляемый в <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</param>
		/// <param name="value">Значение заданного ключа.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="keyword" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</exception>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> доступен только для чтения.  
		/// -или- 
		/// <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> имеет фиксированный размер.</exception>
		// Token: 0x06002BC2 RID: 11202 RVA: 0x000BC1BF File Offset: 0x000BA3BF
		public void Add(string keyword, object value)
		{
			this[keyword] = value;
		}

		/// <summary>Обеспечивает эффективный и безопасный способ добавления ключа и значения в существующий объект <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <param name="builder">Объект <see cref="T:System.Text.StringBuilder" />, к которому требуется добавить пару "ключ — значение".</param>
		/// <param name="keyword">Добавляемый ключ.</param>
		/// <param name="value">Значение указанного ключа.</param>
		// Token: 0x06002BC3 RID: 11203 RVA: 0x000BC1C9 File Offset: 0x000BA3C9
		public static void AppendKeyValuePair(StringBuilder builder, string keyword, string value)
		{
			DbConnectionOptions.AppendKeyValuePairBuilder(builder, keyword, value, false);
		}

		/// <summary>Обеспечивает эффективный и безопасный способ добавления ключа и значения в существующий объект <see cref="T:System.Text.StringBuilder" />.</summary>
		/// <param name="builder">Объект <see cref="T:System.Text.StringBuilder" />, к которому требуется добавить пару "ключ — значение".</param>
		/// <param name="keyword">Добавляемый ключ.</param>
		/// <param name="value">Значение указанного ключа.</param>
		/// <param name="useOdbcRules">Значение <see langword="true" /> определяет использование {} для разделения полей. Значение <see langword="false" /> — использование кавычек.</param>
		// Token: 0x06002BC4 RID: 11204 RVA: 0x000BC1D4 File Offset: 0x000BA3D4
		public static void AppendKeyValuePair(StringBuilder builder, string keyword, string value, bool useOdbcRules)
		{
			DbConnectionOptions.AppendKeyValuePairBuilder(builder, keyword, value, useOdbcRules);
		}

		/// <summary>Удаляет содержимое экземпляра <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Объект <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> доступен только для чтения.</exception>
		// Token: 0x06002BC5 RID: 11205 RVA: 0x000BC1DF File Offset: 0x000BA3DF
		public virtual void Clear()
		{
			DataCommonEventSource.Log.Trace("<comm.DbConnectionStringBuilder.Clear|API>");
			this._connectionString = string.Empty;
			this._propertyDescriptors = null;
			this.CurrentValues.Clear();
		}

		/// <summary>Очищает коллекцию объектов <see cref="T:System.ComponentModel.PropertyDescriptor" /> в связанном <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		// Token: 0x06002BC6 RID: 11206 RVA: 0x000BC20D File Offset: 0x000BA40D
		protected internal void ClearPropertyDescriptors()
		{
			this._propertyDescriptors = null;
		}

		/// <summary>Определяет, содержится ли элемент с указанным ключом в объекте <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="keyword">Ключ для размещения в объекте <see cref="T:System.Collections.IDictionary" />.</param>
		/// <returns>Значение <see langword="true" />, если в <see cref="T:System.Collections.IDictionary" /> содержится элемент с данным ключом; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002BC7 RID: 11207 RVA: 0x000BC216 File Offset: 0x000BA416
		bool IDictionary.Contains(object keyword)
		{
			return this.ContainsKey(this.ObjectToString(keyword));
		}

		/// <summary>Определяет, содержит ли объект <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> указанный ключ.</summary>
		/// <param name="keyword">Ключ, который требуется найти в <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> содержит запись с указанным ключом. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="keyword" /> является неопределенной ссылкой (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06002BC8 RID: 11208 RVA: 0x000BC225 File Offset: 0x000BA425
		public virtual bool ContainsKey(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			return this.CurrentValues.ContainsKey(keyword);
		}

		/// <summary>Копирует элементы коллекции <see cref="T:System.Collections.ICollection" /> в массив <see cref="T:System.Array" />, начиная с указанного индекса массива <see cref="T:System.Array" />.</summary>
		/// <param name="array">Одномерный массив <see cref="T:System.Array" />, в который копируются элементы из интерфейса <see cref="T:System.Collections.ICollection" />. Массив <see cref="T:System.Array" /> должен иметь индексацию, начинающуюся с нуля.</param>
		/// <param name="index">Отсчитываемый от нуля индекс в массиве <paramref name="array" />, указывающий начало копирования.</param>
		// Token: 0x06002BC9 RID: 11209 RVA: 0x000BC23E File Offset: 0x000BA43E
		void ICollection.CopyTo(Array array, int index)
		{
			DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.ICollection.CopyTo|API> {0}", this.ObjectID);
			this.Collection.CopyTo(array, index);
		}

		/// <summary>Сравнивает сведения о подключении в этом объекте <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> со сведениями о подключении в предоставленном объекте.</summary>
		/// <param name="connectionStringBuilder">Объект <see cref="T:System.Data.Common.DbConnectionStringBuilder" />, который необходимо сравнить с объектом <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</param>
		/// <returns>
		///   <see langword="true" />, если сведения о подключении в обоих объектах <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> приводят к появлению эквивалентной строки подключения; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06002BCA RID: 11210 RVA: 0x000BC264 File Offset: 0x000BA464
		public virtual bool EquivalentTo(DbConnectionStringBuilder connectionStringBuilder)
		{
			ADP.CheckArgumentNull(connectionStringBuilder, "connectionStringBuilder");
			DataCommonEventSource.Log.Trace<int, int>("<comm.DbConnectionStringBuilder.EquivalentTo|API> {0}, connectionStringBuilder={1}", this.ObjectID, connectionStringBuilder.ObjectID);
			if (base.GetType() != connectionStringBuilder.GetType() || this.CurrentValues.Count != connectionStringBuilder.CurrentValues.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, object> keyValuePair in this.CurrentValues)
			{
				object obj;
				if (!connectionStringBuilder.CurrentValues.TryGetValue(keyValuePair.Key, out obj) || !keyValuePair.Value.Equals(obj))
				{
					return false;
				}
			}
			return true;
		}

		/// <summary>Возвращает перечислитель, который осуществляет итерацию по коллекции.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IEnumerator" />, который используется для прохода по коллекции.</returns>
		// Token: 0x06002BCB RID: 11211 RVA: 0x000BC330 File Offset: 0x000BA530
		IEnumerator IEnumerable.GetEnumerator()
		{
			DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.IEnumerable.GetEnumerator|API> {0}", this.ObjectID);
			return this.Collection.GetEnumerator();
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <returns>Объект <see cref="T:System.Collections.IDictionaryEnumerator" /> для объекта <see cref="T:System.Collections.IDictionary" />.</returns>
		// Token: 0x06002BCC RID: 11212 RVA: 0x000BC352 File Offset: 0x000BA552
		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			DataCommonEventSource.Log.Trace<int>("<comm.DbConnectionStringBuilder.IDictionary.GetEnumerator|API> {0}", this.ObjectID);
			return this.Dictionary.GetEnumerator();
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x000BC374 File Offset: 0x000BA574
		private string ObjectToString(object keyword)
		{
			string result;
			try
			{
				result = (string)keyword;
			}
			catch (InvalidCastException)
			{
				throw new ArgumentException("not a string", "keyword");
			}
			return result;
		}

		/// <summary>Удаляет элемент с указанным ключом из объекта <see cref="T:System.Collections.IDictionary" />.</summary>
		/// <param name="keyword">Ключ элемента, который требуется удалить.</param>
		// Token: 0x06002BCE RID: 11214 RVA: 0x000BC3AC File Offset: 0x000BA5AC
		void IDictionary.Remove(object keyword)
		{
			this.Remove(this.ObjectToString(keyword));
		}

		/// <summary>Удаляет из экземпляра <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> запись с указанным ключом.</summary>
		/// <param name="keyword">Ключ пары «ключ-значение», удаляемой из строки подключения в этом объекте <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если ключ был указан в строке подключения и был удален. Значение <see langword="false" />, если такого ключа не было.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> имеет значение NULL (<see langword="Nothing" /> в Visual Basic).</exception>
		/// <exception cref="T:System.NotSupportedException">
		///   <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> доступен только для чтения, или <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> имеет фиксированный размер.</exception>
		// Token: 0x06002BCF RID: 11215 RVA: 0x000BC3BC File Offset: 0x000BA5BC
		public virtual bool Remove(string keyword)
		{
			DataCommonEventSource.Log.Trace<int, string>("<comm.DbConnectionStringBuilder.Remove|API> {0}, keyword='{1}'", this.ObjectID, keyword);
			ADP.CheckArgumentNull(keyword, "keyword");
			if (this.CurrentValues.Remove(keyword))
			{
				this._connectionString = null;
				this._propertyDescriptors = null;
				return true;
			}
			return false;
		}

		/// <summary>Указывает, существует ли заданный ключ в этом экземпляре <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <param name="keyword">Ключ, который требуется найти в <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</param>
		/// <returns>Значение <see langword="true" />, если <see cref="T:System.Data.Common.DbConnectionStringBuilder" /> содержит запись с указанным ключом. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002BD0 RID: 11216 RVA: 0x000BC225 File Offset: 0x000BA425
		public virtual bool ShouldSerialize(string keyword)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			return this.CurrentValues.ContainsKey(keyword);
		}

		/// <summary>Возвращает строку подключения, связанную с этим <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <returns>Текущее свойство <see cref="P:System.Data.Common.DbConnectionStringBuilder.ConnectionString" />.</returns>
		// Token: 0x06002BD1 RID: 11217 RVA: 0x000BC409 File Offset: 0x000BA609
		public override string ToString()
		{
			return this.ConnectionString;
		}

		/// <summary>Получает значение, соответствующее заданному ключу, из данного объекта <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <param name="keyword">Ключ искомого элемента.</param>
		/// <param name="value">Значение, соответствующее <paramref name="keyword" />.</param>
		/// <returns>Значение <see langword="true" />, если значение <paramref name="keyword" /> найдено в строке подключения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="keyword" /> содержит значение NULL (<see langword="Nothing" /> в Visual Basic).</exception>
		// Token: 0x06002BD2 RID: 11218 RVA: 0x000BC411 File Offset: 0x000BA611
		public virtual bool TryGetValue(string keyword, out object value)
		{
			ADP.CheckArgumentNull(keyword, "keyword");
			return this.CurrentValues.TryGetValue(keyword, out value);
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x000BC42C File Offset: 0x000BA62C
		internal Attribute[] GetAttributesFromCollection(AttributeCollection collection)
		{
			Attribute[] array = new Attribute[collection.Count];
			collection.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06002BD4 RID: 11220 RVA: 0x000BC450 File Offset: 0x000BA650
		private PropertyDescriptorCollection GetProperties()
		{
			PropertyDescriptorCollection propertyDescriptorCollection = this._propertyDescriptors;
			if (propertyDescriptorCollection == null)
			{
				long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbConnectionStringBuilder.GetProperties|INFO> {0}", this.ObjectID);
				try
				{
					Hashtable hashtable = new Hashtable(StringComparer.OrdinalIgnoreCase);
					this.GetProperties(hashtable);
					PropertyDescriptor[] array = new PropertyDescriptor[hashtable.Count];
					hashtable.Values.CopyTo(array, 0);
					propertyDescriptorCollection = new PropertyDescriptorCollection(array);
					this._propertyDescriptors = propertyDescriptorCollection;
				}
				finally
				{
					DataCommonEventSource.Log.ExitScope(scopeId);
				}
			}
			return propertyDescriptorCollection;
		}

		/// <summary>Заполняет указанный <see cref="T:System.Collections.Hashtable" /> сведениями обо всех свойствах данного <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</summary>
		/// <param name="propertyDescriptors">
		///   <see cref="T:System.Collections.Hashtable" />, заполняемый сведениями о данном <see cref="T:System.Data.Common.DbConnectionStringBuilder" />.</param>
		// Token: 0x06002BD5 RID: 11221 RVA: 0x000BC4D8 File Offset: 0x000BA6D8
		protected virtual void GetProperties(Hashtable propertyDescriptors)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbConnectionStringBuilder.GetProperties|API> {0}", this.ObjectID);
			try
			{
				foreach (object obj in TypeDescriptor.GetProperties(this, true))
				{
					PropertyDescriptor propertyDescriptor = (PropertyDescriptor)obj;
					if ("ConnectionString" != propertyDescriptor.Name)
					{
						string displayName = propertyDescriptor.DisplayName;
						if (!propertyDescriptors.ContainsKey(displayName))
						{
							Attribute[] array = this.GetAttributesFromCollection(propertyDescriptor.Attributes);
							PropertyDescriptor value = new DbConnectionStringBuilderDescriptor(propertyDescriptor.Name, propertyDescriptor.ComponentType, propertyDescriptor.PropertyType, propertyDescriptor.IsReadOnly, array);
							propertyDescriptors[displayName] = value;
						}
					}
					else if (this.BrowsableConnectionString)
					{
						propertyDescriptors["ConnectionString"] = propertyDescriptor;
					}
					else
					{
						propertyDescriptors.Remove("ConnectionString");
					}
				}
				if (!this.IsFixedSize)
				{
					Attribute[] array = null;
					foreach (object obj2 in this.Keys)
					{
						string text = (string)obj2;
						if (!propertyDescriptors.ContainsKey(text))
						{
							object obj3 = this[text];
							Type type;
							if (obj3 != null)
							{
								type = obj3.GetType();
								if (typeof(string) == type)
								{
									int num;
									bool flag;
									if (int.TryParse((string)obj3, out num))
									{
										type = typeof(int);
									}
									else if (bool.TryParse((string)obj3, out flag))
									{
										type = typeof(bool);
									}
								}
							}
							else
							{
								type = typeof(string);
							}
							Attribute[] attributes = array;
							if (StringComparer.OrdinalIgnoreCase.Equals("Password", text) || StringComparer.OrdinalIgnoreCase.Equals("pwd", text))
							{
								attributes = new Attribute[]
								{
									BrowsableAttribute.Yes,
									PasswordPropertyTextAttribute.Yes,
									RefreshPropertiesAttribute.All
								};
							}
							else if (array == null)
							{
								array = new Attribute[]
								{
									BrowsableAttribute.Yes,
									RefreshPropertiesAttribute.All
								};
								attributes = array;
							}
							PropertyDescriptor value2 = new DbConnectionStringBuilderDescriptor(text, base.GetType(), type, false, attributes);
							propertyDescriptors[text] = value2;
						}
					}
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000BC764 File Offset: 0x000BA964
		private PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptorCollection properties = this.GetProperties();
			if (attributes == null || attributes.Length == 0)
			{
				return properties;
			}
			PropertyDescriptor[] array = new PropertyDescriptor[properties.Count];
			int num = 0;
			foreach (object obj in properties)
			{
				PropertyDescriptor propertyDescriptor = (PropertyDescriptor)obj;
				bool flag = true;
				foreach (Attribute attribute in attributes)
				{
					Attribute attribute2 = propertyDescriptor.Attributes[attribute.GetType()];
					if ((attribute2 == null && !attribute.IsDefaultAttribute()) || !attribute2.Match(attribute))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					array[num] = propertyDescriptor;
					num++;
				}
			}
			PropertyDescriptor[] array2 = new PropertyDescriptor[num];
			Array.Copy(array, array2, num);
			return new PropertyDescriptorCollection(array2);
		}

		/// <summary>Возвращает имя класса для этого экземпляра компонента.</summary>
		/// <returns>Имя класса объекта или <see langword="null" />, если класс не имеет имени.</returns>
		// Token: 0x06002BD7 RID: 11223 RVA: 0x000BC84C File Offset: 0x000BAA4C
		string ICustomTypeDescriptor.GetClassName()
		{
			return TypeDescriptor.GetClassName(this, true);
		}

		/// <summary>Возвращает имя этого экземпляра компонента.</summary>
		/// <returns>Имя объекта или <see langword="null" />, если объект не имеет имени.</returns>
		// Token: 0x06002BD8 RID: 11224 RVA: 0x000BC855 File Offset: 0x000BAA55
		string ICustomTypeDescriptor.GetComponentName()
		{
			return TypeDescriptor.GetComponentName(this, true);
		}

		/// <summary>Возвращает коллекцию настраиваемых атрибутов для этого экземпляра компонента.</summary>
		/// <returns>
		///   <see cref="T:System.ComponentModel.AttributeCollection" />, содержащий атрибуты для этого объекта.</returns>
		// Token: 0x06002BD9 RID: 11225 RVA: 0x000BC85E File Offset: 0x000BAA5E
		AttributeCollection ICustomTypeDescriptor.GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this, true);
		}

		/// <summary>Возвращает редактор указанного типа для этого экземпляра компонента.</summary>
		/// <param name="editorBaseType">Объект <see cref="T:System.Type" />, который представляет редактор для этого объекта.</param>
		/// <returns>Объект <see cref="T:System.Object" /> заданного типа, являющийся редактором для этого объекта, или <see langword="null" />, если редактор не найден.</returns>
		// Token: 0x06002BDA RID: 11226 RVA: 0x000BC867 File Offset: 0x000BAA67
		object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		/// <summary>Возвращает преобразователь типов для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.TypeConverter" />, который является преобразователем для данного объекта, или значение <see langword="null" /> в случае отсутствия <see cref="T:System.ComponentModel.TypeConverter" /> для данного объекта.</returns>
		// Token: 0x06002BDB RID: 11227 RVA: 0x000BC871 File Offset: 0x000BAA71
		TypeConverter ICustomTypeDescriptor.GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		/// <summary>Возвращает свойство по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющее свойство по умолчанию для данного объекта, или <see langword="null" />, если этот объект не имеет свойств.</returns>
		// Token: 0x06002BDC RID: 11228 RVA: 0x000BC87A File Offset: 0x000BAA7A
		PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		/// <summary>Возвращает свойства для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющий свойства для этого экземпляра компонента.</returns>
		// Token: 0x06002BDD RID: 11229 RVA: 0x000BC883 File Offset: 0x000BAA83
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
		{
			return this.GetProperties();
		}

		/// <summary>Возвращает свойства для этого экземпляра компонента с помощью массива атрибутов в качестве фильтра.</summary>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющая отфильтрованные свойства для этого экземпляра компонента.</returns>
		// Token: 0x06002BDE RID: 11230 RVA: 0x000BC88B File Offset: 0x000BAA8B
		PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
		{
			return this.GetProperties(attributes);
		}

		/// <summary>Возвращает событие по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.EventDescriptor" />, представляющее событие по умолчанию для этого объекта, или <see langword="null" />, если этот объект не имеет событий.</returns>
		// Token: 0x06002BDF RID: 11231 RVA: 0x000BC894 File Offset: 0x000BAA94
		EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		/// <summary>Возвращает события для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />, представляющий события для этого экземпляра компонента.</returns>
		// Token: 0x06002BE0 RID: 11232 RVA: 0x000BC89D File Offset: 0x000BAA9D
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		/// <summary>Возвращает события для этого экземпляра компонента с помощью заданного массива атрибутов в качестве фильтра.</summary>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />, представляющий отфильтрованные события для этого экземпляра компонента.</returns>
		// Token: 0x06002BE1 RID: 11233 RVA: 0x000BC8A6 File Offset: 0x000BAAA6
		EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		/// <summary>Возвращает объект, содержащий свойство, описанное указанным дескриптором свойства.</summary>
		/// <param name="pd">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющий свойство, владельца которого требуется найти.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий владельца заданного свойства.</returns>
		// Token: 0x06002BE2 RID: 11234 RVA: 0x00005696 File Offset: 0x00003896
		object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
		{
			return this;
		}

		// Token: 0x04001B37 RID: 6967
		private Dictionary<string, object> _currentValues;

		// Token: 0x04001B38 RID: 6968
		private string _connectionString = string.Empty;

		// Token: 0x04001B39 RID: 6969
		private PropertyDescriptorCollection _propertyDescriptors;

		// Token: 0x04001B3A RID: 6970
		private bool _browsableConnectionString = true;

		// Token: 0x04001B3B RID: 6971
		private readonly bool _useOdbcRules;

		// Token: 0x04001B3C RID: 6972
		private static int s_objectTypeCount;

		// Token: 0x04001B3D RID: 6973
		internal readonly int _objectID = Interlocked.Increment(ref DbConnectionStringBuilder.s_objectTypeCount);
	}
}
