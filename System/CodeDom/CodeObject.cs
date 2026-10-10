using System;
using System.Collections;
using System.Collections.Specialized;

namespace System.CodeDom
{
	/// <summary>Обеспечивает основной базовый класс для большинства объектов модели объектов документов кода (CodeDOM).</summary>
	// Token: 0x020002EB RID: 747
	[Serializable]
	public class CodeObject
	{
		/// <summary>Получает определяемые пользователем данные для текущего объекта.</summary>
		/// <returns>
		///   <see cref="T:System.Collections.IDictionary" />, содержащий пользовательские данные для текущего объекта.</returns>
		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x0005E720 File Offset: 0x0005C920
		public IDictionary UserData
		{
			get
			{
				IDictionary result;
				if ((result = this._userData) == null)
				{
					result = (this._userData = new ListDictionary());
				}
				return result;
			}
		}

		// Token: 0x04000D3B RID: 3387
		private IDictionary _userData;
	}
}
