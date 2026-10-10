using System;

namespace System.Diagnostics.Tracing
{
	/// <summary>Определяет тип, передаваемый методу <see cref="M:System.Diagnostics.Tracing.EventSource.Write``1(System.String,System.Diagnostics.Tracing.EventSourceOptions,``0)" />.</summary>
	// Token: 0x020009F0 RID: 2544
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public class EventDataAttribute : Attribute
	{
		/// <summary>Возвращает или задает имя, присваиваемое событию, если его тип или свойство не именованы явно.</summary>
		/// <returns>Имя, назначаемое событию или свойству.</returns>
		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06005ABC RID: 23228 RVA: 0x000479F8 File Offset: 0x00045BF8
		// (set) Token: 0x06005ABD RID: 23229 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public string Name
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
	}
}
