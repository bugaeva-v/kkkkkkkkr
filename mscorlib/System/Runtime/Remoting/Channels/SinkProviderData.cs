using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Хранит данные поставщика приемника для поставщиков приемников.</summary>
	// Token: 0x020005C9 RID: 1481
	[ComVisible(true)]
	public class SinkProviderData
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" />.</summary>
		/// <param name="name">Имя поставщика приемника, с которым связаны данные в текущем объекте <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" />.</param>
		// Token: 0x060038B4 RID: 14516 RVA: 0x000CA854 File Offset: 0x000C8A54
		public SinkProviderData(string name)
		{
			this.sinkName = name;
			this.children = new ArrayList();
			this.properties = new Hashtable();
		}

		/// <summary>Получает список дочерних <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" /> узелов.</summary>
		/// <returns>Тип <see cref="T:System.Collections.IList" /> дочерних узелов <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" />.</returns>
		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x000CA879 File Offset: 0x000C8A79
		public IList Children
		{
			get
			{
				return this.children;
			}
		}

		/// <summary>Получает имя поставщика приемника, с которым связаны данные в текущем объекте <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" />.</summary>
		/// <returns>Строка <see cref="T:System.String" /> с именем XML-узла, с которым связаны данные в текущем объекте <see cref="T:System.Runtime.Remoting.Channels.SinkProviderData" />.</returns>
		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060038B6 RID: 14518 RVA: 0x000CA881 File Offset: 0x000C8A81
		public string Name
		{
			get
			{
				return this.sinkName;
			}
		}

		/// <summary>Получает словарь, через который обеспечивается доступ к свойствам поставщика приемника.</summary>
		/// <returns>Словарь, через который обеспечивается доступ к свойствам приемника.</returns>
		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x000CA889 File Offset: 0x000C8A89
		public IDictionary Properties
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x040025EE RID: 9710
		private string sinkName;

		// Token: 0x040025EF RID: 9711
		private ArrayList children;

		// Token: 0x040025F0 RID: 9712
		private Hashtable properties;
	}
}
