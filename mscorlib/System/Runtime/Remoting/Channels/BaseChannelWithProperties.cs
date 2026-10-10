using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает основную реализацию для каналов, которые могут предоставить другим приложениям интерфейс словаря к его свойствам.</summary>
	// Token: 0x020005A6 RID: 1446
	[ComVisible(true)]
	public abstract class BaseChannelWithProperties : BaseChannelObjectWithProperties
	{
		/// <summary>Получает словарь <see cref="T:System.Collections.IDictionary" /> свойств канала, связанных с объектом текущего канала.</summary>
		/// <returns>Словарь <see cref="T:System.Collections.IDictionary" /> свойств канала, связанных с объектом текущего канала.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003828 RID: 14376 RVA: 0x000C94DE File Offset: 0x000C76DE
		public override IDictionary Properties
		{
			get
			{
				if (this.SinksWithProperties == null || this.SinksWithProperties.Properties == null)
				{
					return base.Properties;
				}
				return new AggregateDictionary(new IDictionary[]
				{
					base.Properties,
					this.SinksWithProperties.Properties
				});
			}
		}

		/// <summary>Указывает высший приемник в стеке приемников каналов.</summary>
		// Token: 0x040025CE RID: 9678
		protected IChannelSinkBase SinksWithProperties;
	}
}
