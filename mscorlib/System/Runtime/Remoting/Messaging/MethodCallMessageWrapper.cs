using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" /> для создания сообщения запроса, действующего как вызов метода для удаленного объекта.</summary>
	// Token: 0x02000627 RID: 1575
	[ComVisible(true)]
	public class MethodCallMessageWrapper : InternalMessageWrapper, IMethodCallMessage, IMethodMessage, IMessage
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Remoting.Messaging.MethodCallMessageWrapper" />, создавая оболочку для интерфейса <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" />.</summary>
		/// <param name="msg">Сообщение, действующее как исходящий вызов метода удаленного объекта.</param>
		// Token: 0x06003B44 RID: 15172 RVA: 0x000CEE29 File Offset: 0x000CD029
		public MethodCallMessageWrapper(IMethodCallMessage msg) : base(msg)
		{
			this._args = ((IMethodCallMessage)this.WrappedMessage).Args;
			this._inArgInfo = new ArgInfo(msg.MethodBase, ArgInfoType.In);
		}

		/// <summary>Возвращает число аргументов, переданных методу.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов, переданных методу.</returns>
		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x000CEE5A File Offset: 0x000CD05A
		public virtual int ArgCount
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).ArgCount;
			}
		}

		/// <summary>Возвращает массив аргументов, переданных методу.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы, переданные методу.</returns>
		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06003B46 RID: 15174 RVA: 0x000CEE6C File Offset: 0x000CD06C
		// (set) Token: 0x06003B47 RID: 15175 RVA: 0x000CEE74 File Offset: 0x000CD074
		public virtual object[] Args
		{
			[SecurityCritical]
			get
			{
				return this._args;
			}
			set
			{
				this._args = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, принимает ли метод переменное число аргументов.</summary>
		/// <returns>
		///   <see langword="true" />, если метод принимает переменное число аргументов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x000CEE7D File Offset: 0x000CD07D
		public virtual bool HasVarArgs
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).HasVarArgs;
			}
		}

		/// <summary>Возвращает число аргументов в вызове метода, которые не помечены как параметры <see langword="out" />.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов в вызове метода, не помеченных как параметры <see langword="out" />.</returns>
		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x000CEE8F File Offset: 0x000CD08F
		public virtual int InArgCount
		{
			[SecurityCritical]
			get
			{
				return this._inArgInfo.GetInOutArgCount();
			}
		}

		/// <summary>Возвращает массив аргументов в вызове метода, которые не помечены как параметры <see langword="out" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы в вызове метода, не помеченные как параметры <see langword="out" />.</returns>
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x000CEE9C File Offset: 0x000CD09C
		public virtual object[] InArgs
		{
			[SecurityCritical]
			get
			{
				return this._inArgInfo.GetInOutArgs(this._args);
			}
		}

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</returns>
		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x000CEEAF File Offset: 0x000CD0AF
		public virtual LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).LogicalCallContext;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</returns>
		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06003B4C RID: 15180 RVA: 0x000CEEC1 File Offset: 0x000CD0C1
		public virtual MethodBase MethodBase
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).MethodBase;
			}
		}

		/// <summary>Возвращает имя вызванного метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее имя вызванного метода.</returns>
		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x000CEED3 File Offset: 0x000CD0D3
		public virtual string MethodName
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).MethodName;
			}
		}

		/// <summary>Возвращает объект, содержащий подпись метода.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий подпись метода.</returns>
		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06003B4E RID: 15182 RVA: 0x000CEEE5 File Offset: 0x000CD0E5
		public virtual object MethodSignature
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).MethodSignature;
			}
		}

		/// <summary>
		///   <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</returns>
		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x000CEEF7 File Offset: 0x000CD0F7
		public virtual IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				if (this._properties == null)
				{
					this._properties = new MethodCallMessageWrapper.DictionaryWrapper(this, this.WrappedMessage.Properties);
				}
				return this._properties;
			}
		}

		/// <summary>Возвращает полное имя типа удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее полное имя типа удаленного объекта, к которому осуществляется вызов метода.</returns>
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003B50 RID: 15184 RVA: 0x000CEF1E File Offset: 0x000CD11E
		public virtual string TypeName
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).TypeName;
			}
		}

		/// <summary>Возвращает универсальный код ресурса (URI) удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>URI удаленного объекта.</returns>
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003B51 RID: 15185 RVA: 0x000CEF30 File Offset: 0x000CD130
		// (set) Token: 0x06003B52 RID: 15186 RVA: 0x000CEF44 File Offset: 0x000CD144
		public virtual string Uri
		{
			[SecurityCritical]
			get
			{
				return ((IMethodCallMessage)this.WrappedMessage).Uri;
			}
			set
			{
				IInternalMessage internalMessage = this.WrappedMessage as IInternalMessage;
				if (internalMessage != null)
				{
					internalMessage.Uri = value;
					return;
				}
				this.Properties["__Uri"] = value;
			}
		}

		/// <summary>Возвращает аргумент метода в виде объекта по указанному индексу.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Аргумент метода в виде объекта.</returns>
		// Token: 0x06003B53 RID: 15187 RVA: 0x000CEF79 File Offset: 0x000CD179
		[SecurityCritical]
		public virtual object GetArg(int argNum)
		{
			return this._args[argNum];
		}

		/// <summary>Возвращает имя аргумента метода по указанному индексу.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента метода.</returns>
		// Token: 0x06003B54 RID: 15188 RVA: 0x000CEF83 File Offset: 0x000CD183
		[SecurityCritical]
		public virtual string GetArgName(int index)
		{
			return ((IMethodCallMessage)this.WrappedMessage).GetArgName(index);
		}

		/// <summary>Возвращает аргумент метода по указанному индексу, не помеченный как параметр <see langword="out" />.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Аргумент метода, который не помечен как параметр <see langword="out" />.</returns>
		// Token: 0x06003B55 RID: 15189 RVA: 0x000CEF96 File Offset: 0x000CD196
		[SecurityCritical]
		public virtual object GetInArg(int argNum)
		{
			return this._args[this._inArgInfo.GetInOutArgIndex(argNum)];
		}

		/// <summary>Возвращает имя аргумента метода, не помеченного как параметр out, по указанному индексу.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента метода, который не помечен как параметр out.</returns>
		// Token: 0x06003B56 RID: 15190 RVA: 0x000CEFAB File Offset: 0x000CD1AB
		[SecurityCritical]
		public virtual string GetInArgName(int index)
		{
			return this._inArgInfo.GetInOutArgName(index);
		}

		// Token: 0x040026A0 RID: 9888
		private object[] _args;

		// Token: 0x040026A1 RID: 9889
		private ArgInfo _inArgInfo;

		// Token: 0x040026A2 RID: 9890
		private MethodCallMessageWrapper.DictionaryWrapper _properties;

		// Token: 0x02000628 RID: 1576
		private class DictionaryWrapper : MCMDictionary
		{
			// Token: 0x06003B57 RID: 15191 RVA: 0x000CEFB9 File Offset: 0x000CD1B9
			public DictionaryWrapper(IMethodMessage message, IDictionary wrappedDictionary) : base(message)
			{
				this._wrappedDictionary = wrappedDictionary;
				base.MethodKeys = MethodCallMessageWrapper.DictionaryWrapper._keys;
			}

			// Token: 0x06003B58 RID: 15192 RVA: 0x000CEFD4 File Offset: 0x000CD1D4
			protected override IDictionary AllocInternalProperties()
			{
				return this._wrappedDictionary;
			}

			// Token: 0x06003B59 RID: 15193 RVA: 0x000CEFDC File Offset: 0x000CD1DC
			protected override void SetMethodProperty(string key, object value)
			{
				if (key == "__Args")
				{
					((MethodCallMessageWrapper)this._message)._args = (object[])value;
					return;
				}
				base.SetMethodProperty(key, value);
			}

			// Token: 0x06003B5A RID: 15194 RVA: 0x000CF00A File Offset: 0x000CD20A
			protected override object GetMethodProperty(string key)
			{
				if (key == "__Args")
				{
					return ((MethodCallMessageWrapper)this._message)._args;
				}
				return base.GetMethodProperty(key);
			}

			// Token: 0x040026A3 RID: 9891
			private IDictionary _wrappedDictionary;

			// Token: 0x040026A4 RID: 9892
			private static string[] _keys = new string[]
			{
				"__Args"
			};
		}
	}
}
