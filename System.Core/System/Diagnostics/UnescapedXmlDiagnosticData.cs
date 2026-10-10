using System;
using System.Security.Permissions;
using Unity;

namespace System.Diagnostics
{
	/// <summary>
	///         Предоставляет escape-последовательность XML-данных для ведения журнала трассировки пользовательских данных.
	///       </summary>
	// Token: 0x0200038C RID: 908
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public class UnescapedXmlDiagnosticData
	{
		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Diagnostics.UnescapedXmlDiagnosticData" /> используя указанную строку данных XML.
		///       </summary>
		/// <param name="xmlPayload">
		///           XML-данные записываются в <see langword="UserData" /> узел схемы событий.
		///         </param>
		// Token: 0x06001B38 RID: 6968 RVA: 0x0000235B File Offset: 0x0000055B
		public UnescapedXmlDiagnosticData(string xmlPayload)
		{
			ThrowStub.ThrowNotSupportedException();
		}

		/// <summary>
		///         Возвращает или задает escape-последовательность строка XML-данных.
		///       </summary>
		/// <returns>
		///         Escape-последовательность XML-строку.
		///       </returns>
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0000235B File Offset: 0x0000055B
		public string UnescapedXml
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}
	}
}
