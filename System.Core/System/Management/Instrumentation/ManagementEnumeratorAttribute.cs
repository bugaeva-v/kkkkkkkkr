using System;
using System.Security.Permissions;
using Unity;

namespace System.Management.Instrumentation
{
	/// <summary>
	///         Атрибут ManagementEnumerator помечает метод, который возвращает все экземпляры класса WMI.
	///
	///         Примечание. Работа над библиотеками .NET инструментария WMI завершена. В дальнейшем не предвидится никаких разработок, улучшений или обновлений в отношении не связанных с безопасностью проблем, влияющих на эти библиотеки.
	///          Для всех новых разработок следует использовать API-интерфейсы MI.
	///       </summary>
	// Token: 0x02000381 RID: 897
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false)]
	[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
	public sealed class ManagementEnumeratorAttribute : ManagementNewInstanceAttribute
	{
		/// <summary>
		///         Возвращает или задает значение, определяющее тип вывода, который возвращает метод, помеченный атрибутом ManagementEnumerator.
		///       </summary>
		/// <returns>
		///         A <see cref="T:System.Type" /> значение, указывающее тип вывода, метод помечен атрибутом <see cref="ManagementEnumerator" /> будет выводить атрибут.
		///       </returns>
		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0005A05A File Offset: 0x0005825A
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x00003A59 File Offset: 0x00001C59
		public Type Schema
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
			set
			{
			}
		}
	}
}
