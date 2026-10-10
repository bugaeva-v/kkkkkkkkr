using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Хранит коллекцию заголовков, используемых в приемниках канала.</summary>
	// Token: 0x020005CA RID: 1482
	[ComVisible(true)]
	[MonoTODO("Serialization format not compatible with .NET")]
	[Serializable]
	public class TransportHeaders : ITransportHeaders
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Channels.TransportHeaders" />.</summary>
		// Token: 0x060038B8 RID: 14520 RVA: 0x000CA891 File Offset: 0x000C8A91
		public TransportHeaders()
		{
			this.hash_table = new Hashtable(CaseInsensitiveHashCodeProvider.DefaultInvariant, CaseInsensitiveComparer.DefaultInvariant);
		}

		/// <summary>Возвращает или задает транспортный заголовок, связанный с указанным ключом.</summary>
		/// <param name="key">Строка <see cref="T:System.String" />, с которой связан запрашиваемый заголовок.</param>
		/// <returns>Транспортный заголовок, связанный с данным ключом или <see langword="null" />, если ключ не найден.</returns>
		// Token: 0x17000810 RID: 2064
		public object this[object key]
		{
			[SecurityCritical]
			get
			{
				return this.hash_table[key];
			}
			[SecurityCritical]
			set
			{
				this.hash_table[key] = value;
			}
		}

		/// <summary>Возвращает перечислитель хранящихся транспортных заголовков.</summary>
		/// <returns>Перечислитель хранящихся транспортных заголовков.</returns>
		// Token: 0x060038BB RID: 14523 RVA: 0x000CA8CB File Offset: 0x000C8ACB
		[SecurityCritical]
		public IEnumerator GetEnumerator()
		{
			return this.hash_table.GetEnumerator();
		}

		// Token: 0x040025F1 RID: 9713
		private Hashtable hash_table;
	}
}
