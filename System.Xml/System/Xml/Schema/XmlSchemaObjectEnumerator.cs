using System;
using System.Collections;
using Unity;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет перечислитель для коллекции <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" />.
	///       </summary>
	// Token: 0x020005CC RID: 1484
	public class XmlSchemaObjectEnumerator : IEnumerator
	{
		// Token: 0x06003B9E RID: 15262 RVA: 0x0014E5FD File Offset: 0x0014C7FD
		internal XmlSchemaObjectEnumerator(IEnumerator enumerator)
		{
			this.enumerator = enumerator;
		}

		/// <summary>
		///         Устанавливает перечислитель в начало коллекции.
		///       </summary>
		// Token: 0x06003B9F RID: 15263 RVA: 0x0014E60C File Offset: 0x0014C80C
		public void Reset()
		{
			this.enumerator.Reset();
		}

		/// <summary>
		///         Переходит к следующему элементу в коллекции.
		///       </summary>
		/// <returns>
		///         <see langword="false" /> в конец коллекции.
		///       </returns>
		// Token: 0x06003BA0 RID: 15264 RVA: 0x0014E619 File Offset: 0x0014C819
		public bool MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>
		///         Возвращает текущую <see cref="T:System.Xml.Schema.XmlSchemaObject" /> в коллекции.
		///       </summary>
		/// <returns>
		///         Текущий контекст <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///       </returns>
		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x0014E626 File Offset: 0x0014C826
		public XmlSchemaObject Current
		{
			get
			{
				return (XmlSchemaObject)this.enumerator.Current;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.Schema.XmlSchemaObjectEnumerator.Reset" />.
		///       </summary>
		// Token: 0x06003BA2 RID: 15266 RVA: 0x0014E60C File Offset: 0x0014C80C
		void IEnumerator.Reset()
		{
			this.enumerator.Reset();
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.Schema.XmlSchemaObjectEnumerator.MoveNext" />.
		///       </summary>
		/// <returns>
		///         Следующий объект <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///       </returns>
		// Token: 0x06003BA3 RID: 15267 RVA: 0x0014E619 File Offset: 0x0014C819
		bool IEnumerator.MoveNext()
		{
			return this.enumerator.MoveNext();
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="P:System.Xml.Schema.XmlSchemaObjectEnumerator.Current" />.
		///       </summary>
		/// <returns>
		///         Текущий <see cref="T:System.Xml.Schema.XmlSchemaObject" />.
		///       </returns>
		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x0014E638 File Offset: 0x0014C838
		object IEnumerator.Current
		{
			get
			{
				return this.enumerator.Current;
			}
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlSchemaObjectEnumerator()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04002B88 RID: 11144
		private IEnumerator enumerator;
	}
}
