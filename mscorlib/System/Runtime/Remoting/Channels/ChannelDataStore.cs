using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Хранит данные канала для каналов удаленного взаимодействия.</summary>
	// Token: 0x020005A7 RID: 1447
	[ComVisible(true)]
	[Serializable]
	public class ChannelDataStore : IChannelDataStore
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Channels.ChannelDataStore" /> с URI, на который отображается текущий канал.</summary>
		/// <param name="channelURIs">Массив URI, на который отображается текущий канал.</param>
		// Token: 0x06003829 RID: 14377 RVA: 0x000C951E File Offset: 0x000C771E
		public ChannelDataStore(string[] channelURIs)
		{
			this._channelURIs = channelURIs;
		}

		/// <summary>Возвращает и задает массив URI, на который отображается текущий канал.</summary>
		/// <returns>Массив URI, на который отображается текущий канал.</returns>
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x0600382A RID: 14378 RVA: 0x000C952D File Offset: 0x000C772D
		// (set) Token: 0x0600382B RID: 14379 RVA: 0x000C9535 File Offset: 0x000C7735
		public string[] ChannelUris
		{
			[SecurityCritical]
			get
			{
				return this._channelURIs;
			}
			set
			{
				this._channelURIs = value;
			}
		}

		/// <summary>Возвращает или задает объект данных, связанный с указанным ключом для используемого канала.</summary>
		/// <param name="key">Ключ, с которым связан объект данных.</param>
		/// <returns>Указанный объект данных для используемого канала.</returns>
		// Token: 0x170007F0 RID: 2032
		public object this[object key]
		{
			[SecurityCritical]
			get
			{
				if (this._extraData == null)
				{
					return null;
				}
				foreach (DictionaryEntry dictionaryEntry in this._extraData)
				{
					if (dictionaryEntry.Key.Equals(key))
					{
						return dictionaryEntry.Value;
					}
				}
				return null;
			}
			[SecurityCritical]
			set
			{
				if (this._extraData == null)
				{
					this._extraData = new DictionaryEntry[]
					{
						new DictionaryEntry(key, value)
					};
					return;
				}
				DictionaryEntry[] array = new DictionaryEntry[this._extraData.Length + 1];
				this._extraData.CopyTo(array, 0);
				array[this._extraData.Length] = new DictionaryEntry(key, value);
				this._extraData = array;
			}
		}

		// Token: 0x040025CF RID: 9679
		private string[] _channelURIs;

		// Token: 0x040025D0 RID: 9680
		private DictionaryEntry[] _extraData;
	}
}
