using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Activation;
using System.Security;

namespace System.Runtime.Remoting.Contexts
{
	/// <summary>Предоставляет реализацию по умолчанию интерфейсов <see cref="T:System.Runtime.Remoting.Contexts.IContextAttribute" /> и <see cref="T:System.Runtime.Remoting.Contexts.IContextProperty" />.</summary>
	// Token: 0x0200058F RID: 1423
	[AttributeUsage(AttributeTargets.Class)]
	[ComVisible(true)]
	[Serializable]
	public class ContextAttribute : Attribute, IContextAttribute, IContextProperty
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Runtime.Remoting.Contexts.ContextAttribute" /> с указанным именем.</summary>
		/// <param name="name">Имя атрибута контекста.</param>
		// Token: 0x060037B7 RID: 14263 RVA: 0x000C8A3C File Offset: 0x000C6C3C
		public ContextAttribute(string name)
		{
			this.AttributeName = name;
		}

		/// <summary>Возвращает имя атрибута контекста.</summary>
		/// <returns>Имя атрибута контекста.</returns>
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x000C8A4B File Offset: 0x000C6C4B
		public virtual string Name
		{
			[SecurityCritical]
			get
			{
				return this.AttributeName;
			}
		}

		/// <summary>Возвращает логическое значение, указывающее, равен ли данный экземпляр заданному объекту.</summary>
		/// <param name="o">Объект, сравниваемый с данным экземпляром.</param>
		/// <returns>Принимает значение <see langword="true" />, если параметр <paramref name="o" /> не равен  <see langword="null" />, а имена объекта, заданного этим параметром, и данного объекта совпадают; иначе — <see langword="false" />.</returns>
		// Token: 0x060037B9 RID: 14265 RVA: 0x000C8A53 File Offset: 0x000C6C53
		public override bool Equals(object o)
		{
			return o != null && o is ContextAttribute && !(((ContextAttribute)o).AttributeName != this.AttributeName);
		}

		/// <summary>Вызывается, если контекст заморожен.</summary>
		/// <param name="newContext">Замораживаемый контекст.</param>
		// Token: 0x060037BA RID: 14266 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[SecurityCritical]
		public virtual void Freeze(Context newContext)
		{
		}

		/// <summary>Возвращает хэш-код данного экземпляра атрибута <see cref="T:System.Runtime.Remoting.Contexts.ContextAttribute" />.</summary>
		/// <returns>Хэш-код данного экземпляра атрибута <see cref="T:System.Runtime.Remoting.Contexts.ContextAttribute" />.</returns>
		// Token: 0x060037BB RID: 14267 RVA: 0x000C8A7F File Offset: 0x000C6C7F
		public override int GetHashCode()
		{
			if (this.AttributeName == null)
			{
				return 0;
			}
			return this.AttributeName.GetHashCode();
		}

		/// <summary>Добавляет текущее контекстное свойство в указанное сообщение.</summary>
		/// <param name="ctorMsg">Сообщение <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />, к которому добавляется контекстное свойство.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="ctorMsg" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060037BC RID: 14268 RVA: 0x000C8A96 File Offset: 0x000C6C96
		[SecurityCritical]
		public virtual void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
		{
			if (ctorMsg == null)
			{
				throw new ArgumentNullException("ctorMsg");
			}
			ctorMsg.ContextProperties.Add(this);
		}

		/// <summary>Возвращает логическое значение, указывающее, удовлетворяет ли параметр контекста требованиям атрибута контекста.</summary>
		/// <param name="ctx">Контекст, в котором необходимо выполнить проверку.</param>
		/// <param name="ctorMsg">Сообщение <see cref="T:System.Runtime.Remoting.Activation.IConstructionCallMessage" />, к которому добавляется контекстное свойство.</param>
		/// <returns>Имеет значение <see langword="true" />, если заданный контекст приемлем; иначе —  <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Либо <paramref name="ctx" />, либо <paramref name="ctorMsg" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060037BD RID: 14269 RVA: 0x000C8AB4 File Offset: 0x000C6CB4
		[SecurityCritical]
		public virtual bool IsContextOK(Context ctx, IConstructionCallMessage ctorMsg)
		{
			if (ctorMsg == null)
			{
				throw new ArgumentNullException("ctorMsg");
			}
			if (ctx == null)
			{
				throw new ArgumentNullException("ctx");
			}
			if (!ctorMsg.ActivationType.IsContextful)
			{
				return true;
			}
			IContextProperty property = ctx.GetProperty(this.AttributeName);
			return property != null && this == property;
		}

		/// <summary>Возвращает логическое значение, указывающее, совместимо ли контекстное свойство с новым контекстом.</summary>
		/// <param name="newCtx">Новый контекст, в котором было создано свойство.</param>
		/// <returns>Имеет значение <see langword="true" />, если контекстное свойство приемлемо в новом контексте; иначе —  <see langword="false" />.</returns>
		// Token: 0x060037BE RID: 14270 RVA: 0x000040F7 File Offset: 0x000022F7
		[SecurityCritical]
		public virtual bool IsNewContextOK(Context newCtx)
		{
			return true;
		}

		/// <summary>Указывает имя атрибута контекста.</summary>
		// Token: 0x040025B1 RID: 9649
		protected string AttributeName;
	}
}
