using System;
using System.Collections.Generic;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000043 RID: 67
	public class MetaType
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00008D0B File Offset: 0x00006F0B
		public IEnumerable<MetaEvent> Events
		{
			get
			{
				return this.events;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00008D13 File Offset: 0x00006F13
		public IEnumerable<MetaMethod> Methods
		{
			get
			{
				return this.methods;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00008D1B File Offset: 0x00006F1B
		public IEnumerable<MetaProperty> Properties
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008D23 File Offset: 0x00006F23
		public void AddEvent(MetaEvent @event)
		{
			this.events.Add(@event);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00008D31 File Offset: 0x00006F31
		public void AddMethod(MetaMethod method)
		{
			this.methods.Add(method);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008D3F File Offset: 0x00006F3F
		public void AddProperty(MetaProperty property)
		{
			this.properties.Add(property);
		}

		// Token: 0x0400008F RID: 143
		private readonly ICollection<MetaEvent> events = new TypeElementCollection<MetaEvent>();

		// Token: 0x04000090 RID: 144
		private readonly ICollection<MetaMethod> methods = new TypeElementCollection<MetaMethod>();

		// Token: 0x04000091 RID: 145
		private readonly ICollection<MetaProperty> properties = new TypeElementCollection<MetaProperty>();
	}
}
