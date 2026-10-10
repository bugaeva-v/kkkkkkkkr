using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Хранит имена и типы параметров, необходимых при сериализации SOAP RPC (удаленный вызов процедуры).</summary>
	// Token: 0x02000682 RID: 1666
	[ComVisible(true)]
	[Serializable]
	public class SoapMessage : ISoapMessage
	{
		/// <summary>Получает или задает имена параметров вызванного метода.</summary>
		/// <returns>Имена параметров вызванного метода.</returns>
		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003DF7 RID: 15863 RVA: 0x000D5CC4 File Offset: 0x000D3EC4
		// (set) Token: 0x06003DF8 RID: 15864 RVA: 0x000D5CCC File Offset: 0x000D3ECC
		public string[] ParamNames
		{
			get
			{
				return this.paramNames;
			}
			set
			{
				this.paramNames = value;
			}
		}

		/// <summary>Получает или задает значения параметров вызванного метода.</summary>
		/// <returns>Значения параметров для вызванного метода.</returns>
		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003DF9 RID: 15865 RVA: 0x000D5CD5 File Offset: 0x000D3ED5
		// (set) Token: 0x06003DFA RID: 15866 RVA: 0x000D5CDD File Offset: 0x000D3EDD
		public object[] ParamValues
		{
			get
			{
				return this.paramValues;
			}
			set
			{
				this.paramValues = value;
			}
		}

		/// <summary>Данное свойство является зарезервированным. Вместо этого следует использовать свойства <see cref="P:System.Runtime.Serialization.Formatters.SoapMessage.ParamNames" /> и/или <see cref="P:System.Runtime.Serialization.Formatters.SoapMessage.ParamValues" />.</summary>
		/// <returns>Типы параметров вызванного метода.</returns>
		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06003DFB RID: 15867 RVA: 0x000D5CE6 File Offset: 0x000D3EE6
		// (set) Token: 0x06003DFC RID: 15868 RVA: 0x000D5CEE File Offset: 0x000D3EEE
		public Type[] ParamTypes
		{
			get
			{
				return this.paramTypes;
			}
			set
			{
				this.paramTypes = value;
			}
		}

		/// <summary>Получает или задает имя вызванного метода.</summary>
		/// <returns>Имя вызванного метода.</returns>
		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003DFD RID: 15869 RVA: 0x000D5CF7 File Offset: 0x000D3EF7
		// (set) Token: 0x06003DFE RID: 15870 RVA: 0x000D5CFF File Offset: 0x000D3EFF
		public string MethodName
		{
			get
			{
				return this.methodName;
			}
			set
			{
				this.methodName = value;
			}
		}

		/// <summary>Получает или задает имя пространства имен XML, в котором расположен объект, содержащий вызванный метод.</summary>
		/// <returns>Имя пространства имен XML, в котором расположен объект, содержащий вызванный метод.</returns>
		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003DFF RID: 15871 RVA: 0x000D5D08 File Offset: 0x000D3F08
		// (set) Token: 0x06003E00 RID: 15872 RVA: 0x000D5D10 File Offset: 0x000D3F10
		public string XmlNameSpace
		{
			get
			{
				return this.xmlNameSpace;
			}
			set
			{
				this.xmlNameSpace = value;
			}
		}

		/// <summary>Получает или задает экстренные данные вызванного метода.</summary>
		/// <returns>Экстренные данные вызванного метода.</returns>
		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003E01 RID: 15873 RVA: 0x000D5D19 File Offset: 0x000D3F19
		// (set) Token: 0x06003E02 RID: 15874 RVA: 0x000D5D21 File Offset: 0x000D3F21
		public Header[] Headers
		{
			get
			{
				return this.headers;
			}
			set
			{
				this.headers = value;
			}
		}

		// Token: 0x040027B7 RID: 10167
		internal string[] paramNames;

		// Token: 0x040027B8 RID: 10168
		internal object[] paramValues;

		// Token: 0x040027B9 RID: 10169
		internal Type[] paramTypes;

		// Token: 0x040027BA RID: 10170
		internal string methodName;

		// Token: 0x040027BB RID: 10171
		internal string xmlNameSpace;

		// Token: 0x040027BC RID: 10172
		internal Header[] headers;
	}
}
