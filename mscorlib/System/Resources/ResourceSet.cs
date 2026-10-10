using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Resources
{
	/// <summary>Хранит все ресурсы, локализованные для одного определенного языка и региональных параметров, игнорируя все другие языки и региональные параметры, включая любые правила отката.</summary>
	// Token: 0x0200086E RID: 2158
	[ComVisible(true)]
	[Serializable]
	public class ResourceSet : IDisposable, IEnumerable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Resources.ResourceSet" /> стандартными свойствами.</summary>
		// Token: 0x060047E4 RID: 18404 RVA: 0x000EC069 File Offset: 0x000EA269
		protected ResourceSet()
		{
			this.CommonInit();
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0000259F File Offset: 0x0000079F
		internal ResourceSet(bool junk)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Resources.ResourceSet" />, используя системное средство чтения по умолчанию <see cref="T:System.Resources.ResourceReader" />, которое открывает и считывает ресурсы из заданного файла.</summary>
		/// <param name="fileName">Файл ресурсов для чтения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="fileName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060047E6 RID: 18406 RVA: 0x000EC077 File Offset: 0x000EA277
		public ResourceSet(string fileName)
		{
			this.Reader = new ResourceReader(fileName);
			this.CommonInit();
			this.ReadResources();
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Resources.ResourceSet" />, используя системное средство чтения по умолчанию <see cref="T:System.Resources.ResourceReader" />, которое считывает ресурсы из заданного потока.</summary>
		/// <param name="stream">Поток <see cref="T:System.IO.Stream" /> ресурсов для чтения. Поток должен указывать на существующий файл ресурсов.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="stream" /> недоступен для чтения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="stream" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060047E7 RID: 18407 RVA: 0x000EC097 File Offset: 0x000EA297
		[SecurityCritical]
		public ResourceSet(Stream stream)
		{
			this.Reader = new ResourceReader(stream);
			this.CommonInit();
			this.ReadResources();
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Resources.ResourceSet" />, используя заданное средство чтения ресурсов.</summary>
		/// <param name="reader">Средство чтения, которое будет использоваться.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="reader" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060047E8 RID: 18408 RVA: 0x000EC0B7 File Offset: 0x000EA2B7
		public ResourceSet(IResourceReader reader)
		{
			if (reader == null)
			{
				throw new ArgumentNullException("reader");
			}
			this.Reader = reader;
			this.CommonInit();
			this.ReadResources();
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x000EC0E0 File Offset: 0x000EA2E0
		private void CommonInit()
		{
			this.Table = new Hashtable();
		}

		/// <summary>Закрывает и освобождает все ресурсы, используемые этим объектом <see cref="T:System.Resources.ResourceSet" />.</summary>
		// Token: 0x060047EA RID: 18410 RVA: 0x000EC0ED File Offset: 0x000EA2ED
		public virtual void Close()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает ресурсы (кроме памяти), связанные с текущим экземпляром, закрывая внутренние управляемые объекты, если имеется соответствующий запрос.</summary>
		/// <param name="disposing">Указывает, следует ли явно закрыть объекты, содержащиеся в текущем экземпляре.</param>
		// Token: 0x060047EB RID: 18411 RVA: 0x000EC0F8 File Offset: 0x000EA2F8
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				IResourceReader reader = this.Reader;
				this.Reader = null;
				if (reader != null)
				{
					reader.Close();
				}
			}
			this.Reader = null;
			this._caseInsensitiveTable = null;
			this.Table = null;
		}

		/// <summary>Удаляет ресурсы (кроме памяти), используемые текущим экземпляром объекта <see cref="T:System.Resources.ResourceSet" />.</summary>
		// Token: 0x060047EC RID: 18412 RVA: 0x000EC0ED File Offset: 0x000EA2ED
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Возвращает предпочтительный объект чтения ресурсов для этого типа объектов <see cref="T:System.Resources.ResourceSet" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для предпочтительного средства чтения ресурсов для этого вида ресурсов <see cref="T:System.Resources.ResourceSet" />.</returns>
		// Token: 0x060047ED RID: 18413 RVA: 0x000EC134 File Offset: 0x000EA334
		public virtual Type GetDefaultReader()
		{
			return typeof(ResourceReader);
		}

		/// <summary>Возвращает предпочтительный класс объектов записи ресурсов для этого вида ресурса <see cref="T:System.Resources.ResourceSet" />.</summary>
		/// <returns>Объект <see cref="T:System.Type" /> для предпочтительного средства записи ресурсов для этого вида ресурсов <see cref="T:System.Resources.ResourceSet" />.</returns>
		// Token: 0x060047EE RID: 18414 RVA: 0x000EC140 File Offset: 0x000EA340
		public virtual Type GetDefaultWriter()
		{
			return typeof(ResourceWriter);
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IDictionaryEnumerator" />, который может выполнить итерацию объекта <see cref="T:System.Resources.ResourceSet" />.</summary>
		/// <returns>Перечислитель <see cref="T:System.Collections.IDictionaryEnumerator" /> для данного набора <see cref="T:System.Resources.ResourceSet" />.</returns>
		/// <exception cref="T:System.ObjectDisposedException">Набор ресурсов был закрыт или удален.</exception>
		// Token: 0x060047EF RID: 18415 RVA: 0x000EC14C File Offset: 0x000EA34C
		[ComVisible(false)]
		public virtual IDictionaryEnumerator GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		/// <summary>Возвращает объект <see cref="T:System.Collections.IEnumerator" /> в таком порядке, чтобы избежать состояния гонки с методом <see langword="Dispose" />. Этот элемент не предназначен для непосредственного использования в коде.</summary>
		/// <returns>Перечислитель для текущего объекта <see cref="T:System.Resources.ResourceSet" />.</returns>
		// Token: 0x060047F0 RID: 18416 RVA: 0x000EC14C File Offset: 0x000EA34C
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumeratorHelper();
		}

		// Token: 0x060047F1 RID: 18417 RVA: 0x000EC154 File Offset: 0x000EA354
		private IDictionaryEnumerator GetEnumeratorHelper()
		{
			Hashtable table = this.Table;
			if (table == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a closed resource set."));
			}
			return table.GetEnumerator();
		}

		/// <summary>Выполняет поиск ресурса <see cref="T:System.String" /> с указанным именем.</summary>
		/// <param name="name">Имя ресурса, для которого выполняется поиск.</param>
		/// <returns>Значение ресурса, если значение равно <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Ресурс, заданный параметром <paramref name="name" />, не является объектом <see cref="T:System.String" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт или удален.</exception>
		// Token: 0x060047F2 RID: 18418 RVA: 0x000EC178 File Offset: 0x000EA378
		public virtual string GetString(string name)
		{
			object objectInternal = this.GetObjectInternal(name);
			string result;
			try
			{
				result = (string)objectInternal;
			}
			catch (InvalidCastException)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Resource '{0}' was not a String - call GetObject instead.", new object[]
				{
					name
				}));
			}
			return result;
		}

		/// <summary>Выполняет поиск ресурса <see cref="T:System.String" /> с указанным именем без учета регистра, если это запрошено.</summary>
		/// <param name="name">Имя ресурса, для которого выполняется поиск.</param>
		/// <param name="ignoreCase">Указывает, следует ли игнорировать регистр знаков в указанном имени.</param>
		/// <returns>Значение ресурса, если значение равно <see cref="T:System.String" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Ресурс, заданный параметром <paramref name="name" />, не является объектом <see cref="T:System.String" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт или удален.</exception>
		// Token: 0x060047F3 RID: 18419 RVA: 0x000EC1C4 File Offset: 0x000EA3C4
		public virtual string GetString(string name, bool ignoreCase)
		{
			object obj = this.GetObjectInternal(name);
			string text;
			try
			{
				text = (string)obj;
			}
			catch (InvalidCastException)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Resource '{0}' was not a String - call GetObject instead.", new object[]
				{
					name
				}));
			}
			if (text != null || !ignoreCase)
			{
				return text;
			}
			obj = this.GetCaseInsensitiveObjectInternal(name);
			string result;
			try
			{
				result = (string)obj;
			}
			catch (InvalidCastException)
			{
				throw new InvalidOperationException(Environment.GetResourceString("Resource '{0}' was not a String - call GetObject instead.", new object[]
				{
					name
				}));
			}
			return result;
		}

		/// <summary>Выполняет поиск объекта ресурсов с указанным именем.</summary>
		/// <param name="name">Имя ресурса с учетом регистра, для которого выполняется поиск.</param>
		/// <returns>Запрошенный ресурс.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт или удален.</exception>
		// Token: 0x060047F4 RID: 18420 RVA: 0x000EC250 File Offset: 0x000EA450
		public virtual object GetObject(string name)
		{
			return this.GetObjectInternal(name);
		}

		/// <summary>Ищет объект ресурса с указанным именем без учета регистра, если это запрашивается.</summary>
		/// <param name="name">Имя ресурса, для которого выполняется поиск.</param>
		/// <param name="ignoreCase">Указывает, следует ли игнорировать регистр знаков в указанном имени.</param>
		/// <returns>Запрошенный ресурс.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="name" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Объект закрыт или удален.</exception>
		// Token: 0x060047F5 RID: 18421 RVA: 0x000EC25C File Offset: 0x000EA45C
		public virtual object GetObject(string name, bool ignoreCase)
		{
			object objectInternal = this.GetObjectInternal(name);
			if (objectInternal != null || !ignoreCase)
			{
				return objectInternal;
			}
			return this.GetCaseInsensitiveObjectInternal(name);
		}

		/// <summary>Считывает все ресурсы и сохраняет их в объекте <see cref="T:System.Collections.Hashtable" />, указанном в свойстве <see cref="F:System.Resources.ResourceSet.Table" />.</summary>
		// Token: 0x060047F6 RID: 18422 RVA: 0x000EC280 File Offset: 0x000EA480
		protected virtual void ReadResources()
		{
			IDictionaryEnumerator enumerator = this.Reader.GetEnumerator();
			while (enumerator.MoveNext())
			{
				object value = enumerator.Value;
				this.Table.Add(enumerator.Key, value);
			}
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x000EC2BC File Offset: 0x000EA4BC
		private object GetObjectInternal(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			Hashtable table = this.Table;
			if (table == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a closed resource set."));
			}
			return table[name];
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x000EC2EC File Offset: 0x000EA4EC
		private object GetCaseInsensitiveObjectInternal(string name)
		{
			Hashtable table = this.Table;
			if (table == null)
			{
				throw new ObjectDisposedException(null, Environment.GetResourceString("Cannot access a closed resource set."));
			}
			Hashtable hashtable = this._caseInsensitiveTable;
			if (hashtable == null)
			{
				hashtable = new Hashtable(StringComparer.OrdinalIgnoreCase);
				IDictionaryEnumerator enumerator = table.GetEnumerator();
				while (enumerator.MoveNext())
				{
					hashtable.Add(enumerator.Key, enumerator.Value);
				}
				this._caseInsensitiveTable = hashtable;
			}
			return hashtable[name];
		}

		/// <summary>Указывает объект <see cref="T:System.Resources.IResourceReader" />, используемый для чтения ресурсов.</summary>
		// Token: 0x04002E03 RID: 11779
		[NonSerialized]
		protected IResourceReader Reader;

		/// <summary>Объект <see cref="T:System.Collections.Hashtable" />, в котором сохраняются ресурсы.</summary>
		// Token: 0x04002E04 RID: 11780
		protected Hashtable Table;

		// Token: 0x04002E05 RID: 11781
		private Hashtable _caseInsensitiveTable;
	}
}
