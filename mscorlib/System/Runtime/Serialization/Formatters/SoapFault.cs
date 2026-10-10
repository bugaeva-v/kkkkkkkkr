using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;
using System.Security;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Переносит ошибку и сведения о статусе в сообщении SOAP. Этот класс не наследуется.</summary>
	// Token: 0x02000680 RID: 1664
	[ComVisible(true)]
	[SoapType(Embedded = true)]
	[Serializable]
	public sealed class SoapFault : ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" /> со значениями по умолчанию.</summary>
		// Token: 0x06003DE2 RID: 15842 RVA: 0x0000259F File Offset: 0x0000079F
		public SoapFault()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />, устанавливая свойства для заданных значений.</summary>
		/// <param name="faultCode">Код неисправности для нового экземпляра <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />. Код неисправности идентифицирует тип произошедшей неисправности.</param>
		/// <param name="faultString">Строка неисправности для нового экземпляра <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />. Строка неисправности предоставляет доступное для чтения объяснение неисправности.</param>
		/// <param name="faultActor">URI объекта, который создает неисправность.</param>
		/// <param name="serverFault">Описание исключения CLR.  Эти сведения также содержатся в свойстве <see cref="P:System.Runtime.Serialization.Formatters.SoapFault.Detail" />.</param>
		// Token: 0x06003DE3 RID: 15843 RVA: 0x000D5AA6 File Offset: 0x000D3CA6
		public SoapFault(string faultCode, string faultString, string faultActor, ServerFault serverFault)
		{
			this.faultCode = faultCode;
			this.faultString = faultString;
			this.faultActor = faultActor;
			this.detail = serverFault;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x000D5ACC File Offset: 0x000D3CCC
		internal SoapFault(SerializationInfo info, StreamingContext context)
		{
			SerializationInfoEnumerator enumerator = info.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string name = enumerator.Name;
				object value = enumerator.Value;
				if (string.Compare(name, "faultCode", true, CultureInfo.InvariantCulture) == 0)
				{
					int num = ((string)value).IndexOf(':');
					if (num > -1)
					{
						this.faultCode = ((string)value).Substring(num + 1);
					}
					else
					{
						this.faultCode = (string)value;
					}
				}
				else if (string.Compare(name, "faultString", true, CultureInfo.InvariantCulture) == 0)
				{
					this.faultString = (string)value;
				}
				else if (string.Compare(name, "faultActor", true, CultureInfo.InvariantCulture) == 0)
				{
					this.faultActor = (string)value;
				}
				else if (string.Compare(name, "detail", true, CultureInfo.InvariantCulture) == 0)
				{
					this.detail = value;
				}
			}
		}

		/// <summary>Заполняет заданный <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными для сериализации объекта <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="context">Назначение (см. <see cref="T:System.Runtime.Serialization.StreamingContext" />) для текущей сериализации.</param>
		// Token: 0x06003DE5 RID: 15845 RVA: 0x000D5BAC File Offset: 0x000D3DAC
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("faultcode", "SOAP-ENV:" + this.faultCode);
			info.AddValue("faultstring", this.faultString);
			if (this.faultActor != null)
			{
				info.AddValue("faultactor", this.faultActor);
			}
			info.AddValue("detail", this.detail, typeof(object));
		}

		/// <summary>Получает или задает код неисправности для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary>
		/// <returns>Код неисправности для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003DE6 RID: 15846 RVA: 0x000D5C19 File Offset: 0x000D3E19
		// (set) Token: 0x06003DE7 RID: 15847 RVA: 0x000D5C21 File Offset: 0x000D3E21
		public string FaultCode
		{
			get
			{
				return this.faultCode;
			}
			set
			{
				this.faultCode = value;
			}
		}

		/// <summary>Получает или задает сообщение о неисправности для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary>
		/// <returns>Сообщение о неисправности для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003DE8 RID: 15848 RVA: 0x000D5C2A File Offset: 0x000D3E2A
		// (set) Token: 0x06003DE9 RID: 15849 RVA: 0x000D5C32 File Offset: 0x000D3E32
		public string FaultString
		{
			get
			{
				return this.faultString;
			}
			set
			{
				this.faultString = value;
			}
		}

		/// <summary>Получает или задает задает актор неисправности для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary>
		/// <returns>Актор неисправности для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06003DEA RID: 15850 RVA: 0x000D5C3B File Offset: 0x000D3E3B
		// (set) Token: 0x06003DEB RID: 15851 RVA: 0x000D5C43 File Offset: 0x000D3E43
		public string FaultActor
		{
			get
			{
				return this.faultActor;
			}
			set
			{
				this.faultActor = value;
			}
		}

		/// <summary>Получает или задает дополнительные сведения, необходимые для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</summary>
		/// <returns>Дополнительные сведения, необходимые для <see cref="T:System.Runtime.Serialization.Formatters.SoapFault" />.</returns>
		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06003DEC RID: 15852 RVA: 0x000D5C4C File Offset: 0x000D3E4C
		// (set) Token: 0x06003DED RID: 15853 RVA: 0x000D5C54 File Offset: 0x000D3E54
		public object Detail
		{
			get
			{
				return this.detail;
			}
			set
			{
				this.detail = value;
			}
		}

		// Token: 0x040027AF RID: 10159
		private string faultCode;

		// Token: 0x040027B0 RID: 10160
		private string faultString;

		// Token: 0x040027B1 RID: 10161
		private string faultActor;

		// Token: 0x040027B2 RID: 10162
		[SoapField(Embedded = true)]
		private object detail;
	}
}
