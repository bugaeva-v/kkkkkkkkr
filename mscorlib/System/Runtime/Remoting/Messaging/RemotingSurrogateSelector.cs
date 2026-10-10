using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Выбирает суррогат удаленного взаимодействия, используемый для сериализации объекта, производного от <see cref="T:System.MarshalByRefObject" />.</summary>
	// Token: 0x02000634 RID: 1588
	[ComVisible(true)]
	public class RemotingSurrogateSelector : ISurrogateSelector
	{
		/// <summary>Возвращает или задает делегат <see cref="T:System.Runtime.Remoting.Messaging.MessageSurrogateFilter" /> для текущего экземпляра <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" />.</summary>
		/// <returns>Делегат <see cref="T:System.Runtime.Remoting.Messaging.MessageSurrogateFilter" /> для текущего экземпляра <see cref="T:System.Runtime.Remoting.Messaging.RemotingSurrogateSelector" />.</returns>
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003BEA RID: 15338 RVA: 0x000D09C9 File Offset: 0x000CEBC9
		// (set) Token: 0x06003BEB RID: 15339 RVA: 0x000D09D1 File Offset: 0x000CEBD1
		public MessageSurrogateFilter Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				this._filter = value;
			}
		}

		/// <summary>Добавляет заданный <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> к цепочке селекторов суррогатов.</summary>
		/// <param name="selector">Следующий проверяемый <see cref="T:System.Runtime.Serialization.ISurrogateSelector" />.</param>
		// Token: 0x06003BEC RID: 15340 RVA: 0x000D09DA File Offset: 0x000CEBDA
		[SecurityCritical]
		public virtual void ChainSelector(ISurrogateSelector selector)
		{
			if (this._next != null)
			{
				selector.ChainSelector(this._next);
			}
			this._next = selector;
		}

		/// <summary>Возвращает следующий <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> в цепочке селекторов суррогатов.</summary>
		/// <returns>Следующий <see cref="T:System.Runtime.Serialization.ISurrogateSelector" /> в цепочке селекторов суррогатов.</returns>
		// Token: 0x06003BED RID: 15341 RVA: 0x000D09F7 File Offset: 0x000CEBF7
		[SecurityCritical]
		public virtual ISurrogateSelector GetNextSelector()
		{
			return this._next;
		}

		/// <summary>Возвращает объект в корне графа объектов.</summary>
		/// <returns>Объект в корне графа объектов.</returns>
		// Token: 0x06003BEE RID: 15342 RVA: 0x000D09FF File Offset: 0x000CEBFF
		public object GetRootObject()
		{
			return this._rootObj;
		}

		/// <summary>Возвращает соответствующий суррогат для заданного типа в заданном контексте.</summary>
		/// <param name="type">
		///   <see cref="T:System.Type" />, для которого запрашивается суррогат.</param>
		/// <param name="context">Источник или назначение сериализации.</param>
		/// <param name="ssout">При возврате этого метода содержит <see cref="T:System.Runtime.Serialization.ISurrogateSelector" />, который соответствует заданному типу объекта. Этот параметр передается неинициализированным.</param>
		/// <returns>Соответствующий суррогат для заданного типа в заданном контексте.</returns>
		// Token: 0x06003BEF RID: 15343 RVA: 0x000D0A08 File Offset: 0x000CEC08
		[SecurityCritical]
		public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout)
		{
			if (type.IsMarshalByRef)
			{
				ssout = this;
				return RemotingSurrogateSelector._objRemotingSurrogate;
			}
			if (RemotingSurrogateSelector.s_cachedTypeObjRef.IsAssignableFrom(type))
			{
				ssout = this;
				return RemotingSurrogateSelector._objRefSurrogate;
			}
			if (this._next != null)
			{
				return this._next.GetSurrogate(type, context, out ssout);
			}
			ssout = null;
			return null;
		}

		/// <summary>Устанавливает объект в корне графа объектов.</summary>
		/// <param name="obj">Объект в корне графа объектов.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="obj" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003BF0 RID: 15344 RVA: 0x000D0A57 File Offset: 0x000CEC57
		public void SetRootObject(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException();
			}
			this._rootObj = obj;
		}

		/// <summary>Настраивает текущий селектор суррогатов для использования формата SOAP.</summary>
		// Token: 0x06003BF1 RID: 15345 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual void UseSoapFormat()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040026D6 RID: 9942
		private static Type s_cachedTypeObjRef = typeof(ObjRef);

		// Token: 0x040026D7 RID: 9943
		private static ObjRefSurrogate _objRefSurrogate = new ObjRefSurrogate();

		// Token: 0x040026D8 RID: 9944
		private static RemotingSurrogate _objRemotingSurrogate = new RemotingSurrogate();

		// Token: 0x040026D9 RID: 9945
		private object _rootObj;

		// Token: 0x040026DA RID: 9946
		private MessageSurrogateFilter _filter;

		// Token: 0x040026DB RID: 9947
		private ISurrogateSelector _next;
	}
}
