using System;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Реализует интерфейс <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> для создания сообщения, действующего как ответ на вызов метода удаленного объекта.</summary>
	// Token: 0x0200062D RID: 1581
	[ComVisible(true)]
	public class MethodReturnMessageWrapper : InternalMessageWrapper, IMethodReturnMessage, IMethodMessage, IMessage
	{
		/// <summary>Заключает <see cref="T:System.Runtime.Remoting.Messaging.IMethodReturnMessage" /> в создаваемую оболочку <see cref="T:System.Runtime.Remoting.Messaging.MethodReturnMessageWrapper" />.</summary>
		/// <param name="msg">Сообщение, действующее как исходящий вызов метода удаленного объекта.</param>
		// Token: 0x06003BA2 RID: 15266 RVA: 0x000D0100 File Offset: 0x000CE300
		public MethodReturnMessageWrapper(IMethodReturnMessage msg) : base(msg)
		{
			if (msg.Exception != null)
			{
				this._exception = msg.Exception;
				this._args = new object[0];
				return;
			}
			this._args = msg.Args;
			this._return = msg.ReturnValue;
			if (msg.MethodBase != null)
			{
				this._outArgInfo = new ArgInfo(msg.MethodBase, ArgInfoType.Out);
			}
		}

		/// <summary>Возвращает число аргументов, переданных методу.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов, переданных методу.</returns>
		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x000D016D File Offset: 0x000CE36D
		public virtual int ArgCount
		{
			[SecurityCritical]
			get
			{
				return this._args.Length;
			}
		}

		/// <summary>Возвращает массив аргументов, переданных методу.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы, переданные методу.</returns>
		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x000D0177 File Offset: 0x000CE377
		// (set) Token: 0x06003BA5 RID: 15269 RVA: 0x000D017F File Offset: 0x000CE37F
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

		/// <summary>Возвращает исключение, инициированное во время вызова метода, или <see langword="null" />, если метод не выдал исключение.</summary>
		/// <returns>Исключение <see cref="T:System.Exception" />, выданное во время вызова метода, или <see langword="null" />, если метод не выдал исключение.</returns>
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06003BA6 RID: 15270 RVA: 0x000D0188 File Offset: 0x000CE388
		// (set) Token: 0x06003BA7 RID: 15271 RVA: 0x000D0190 File Offset: 0x000CE390
		public virtual Exception Exception
		{
			[SecurityCritical]
			get
			{
				return this._exception;
			}
			set
			{
				this._exception = value;
			}
		}

		/// <summary>Возвращает флаг, указывающий, принимает ли метод переменное число аргументов.</summary>
		/// <returns>
		///   <see langword="true" />, если метод принимает переменное число аргументов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x000D0199 File Offset: 0x000CE399
		public virtual bool HasVarArgs
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).HasVarArgs;
			}
		}

		/// <summary>Возвращает <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.Runtime.Remoting.Messaging.LogicalCallContext" /> для текущего вызова метода.</returns>
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x000D01AB File Offset: 0x000CE3AB
		public virtual LogicalCallContext LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).LogicalCallContext;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</summary>
		/// <returns>Объект <see cref="T:System.Reflection.MethodBase" /> вызванного метода.</returns>
		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06003BAA RID: 15274 RVA: 0x000D01BD File Offset: 0x000CE3BD
		public virtual MethodBase MethodBase
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).MethodBase;
			}
		}

		/// <summary>Возвращает имя вызванного метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее имя вызванного метода.</returns>
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x000D01CF File Offset: 0x000CE3CF
		public virtual string MethodName
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).MethodName;
			}
		}

		/// <summary>Возвращает объект, содержащий подпись метода.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, содержащий подпись метода.</returns>
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06003BAC RID: 15276 RVA: 0x000D01E1 File Offset: 0x000CE3E1
		public virtual object MethodSignature
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).MethodSignature;
			}
		}

		/// <summary>Возвращает число аргументов в вызове метода, которые помечены как параметры <see langword="ref" /> или <see langword="out" />.</summary>
		/// <returns>Значение <see cref="T:System.Int32" />, представляющее число аргументов в вызове метода, помеченных как параметры <see langword="ref" /> или <see langword="out" />.</returns>
		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x000D01F3 File Offset: 0x000CE3F3
		public virtual int OutArgCount
		{
			[SecurityCritical]
			get
			{
				if (this._outArgInfo == null)
				{
					return 0;
				}
				return this._outArgInfo.GetInOutArgCount();
			}
		}

		/// <summary>Возвращает массив аргументов в вызове метода, которые помечены как параметры <see langword="ref" /> или <see langword="out" />.</summary>
		/// <returns>Массив типа <see cref="T:System.Object" />, представляющий аргументы в вызове метода, помеченные как параметры <see langword="ref" /> или <see langword="out" />.</returns>
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06003BAE RID: 15278 RVA: 0x000D020A File Offset: 0x000CE40A
		public virtual object[] OutArgs
		{
			[SecurityCritical]
			get
			{
				if (this._outArgInfo == null)
				{
					return this._args;
				}
				return this._outArgInfo.GetInOutArgs(this._args);
			}
		}

		/// <summary>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</summary>
		/// <returns>Интерфейс <see cref="T:System.Collections.IDictionary" />, представляющий коллекцию свойств сообщения удаленного взаимодействия.</returns>
		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x000D022C File Offset: 0x000CE42C
		public virtual IDictionary Properties
		{
			[SecurityCritical]
			get
			{
				if (this._properties == null)
				{
					this._properties = new MethodReturnMessageWrapper.DictionaryWrapper(this, this.WrappedMessage.Properties);
				}
				return this._properties;
			}
		}

		/// <summary>Возвращает возвращаемое значение вызова метода.</summary>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий возвращаемое значение вызова метода.</returns>
		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x000D0253 File Offset: 0x000CE453
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x000D025B File Offset: 0x000CE45B
		public virtual object ReturnValue
		{
			[SecurityCritical]
			get
			{
				return this._return;
			}
			set
			{
				this._return = value;
			}
		}

		/// <summary>Возвращает полное имя типа удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее полное имя типа удаленного объекта, к которому осуществляется вызов метода.</returns>
		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x000D0264 File Offset: 0x000CE464
		public virtual string TypeName
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).TypeName;
			}
		}

		/// <summary>Возвращает универсальный код ресурса (URI) удаленного объекта, к которому осуществляется вызов метода.</summary>
		/// <returns>URI удаленного объекта.</returns>
		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x000D0276 File Offset: 0x000CE476
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x000D0288 File Offset: 0x000CE488
		public string Uri
		{
			[SecurityCritical]
			get
			{
				return ((IMethodReturnMessage)this.WrappedMessage).Uri;
			}
			set
			{
				this.Properties["__Uri"] = value;
			}
		}

		/// <summary>Возвращает аргумент метода в виде объекта по указанному индексу.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Аргумент метода в виде объекта.</returns>
		// Token: 0x06003BB5 RID: 15285 RVA: 0x000D029B File Offset: 0x000CE49B
		[SecurityCritical]
		public virtual object GetArg(int argNum)
		{
			return this._args[argNum];
		}

		/// <summary>Возвращает имя аргумента метода по указанному индексу.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента метода.</returns>
		// Token: 0x06003BB6 RID: 15286 RVA: 0x000D02A5 File Offset: 0x000CE4A5
		[SecurityCritical]
		public virtual string GetArgName(int index)
		{
			return ((IMethodReturnMessage)this.WrappedMessage).GetArgName(index);
		}

		/// <summary>Возвращает указанный аргумент, отмеченный как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <param name="argNum">Индекс запрашиваемого аргумента.</param>
		/// <returns>Указанный аргумент, помеченный как параметр <see langword="ref" /> или <see langword="out" />.</returns>
		// Token: 0x06003BB7 RID: 15287 RVA: 0x000D02B8 File Offset: 0x000CE4B8
		[SecurityCritical]
		public virtual object GetOutArg(int argNum)
		{
			return this._args[this._outArgInfo.GetInOutArgIndex(argNum)];
		}

		/// <summary>Возвращает имя указанного аргумента, помеченного как параметр <see langword="ref" /> или <see langword="out" />.</summary>
		/// <param name="index">Индекс запрашиваемого аргумента.</param>
		/// <returns>Имя аргумента или <see langword="null" />, если текущий метод не реализован.</returns>
		// Token: 0x06003BB8 RID: 15288 RVA: 0x000D02CD File Offset: 0x000CE4CD
		[SecurityCritical]
		public virtual string GetOutArgName(int index)
		{
			return this._outArgInfo.GetInOutArgName(index);
		}

		// Token: 0x040026BD RID: 9917
		private object[] _args;

		// Token: 0x040026BE RID: 9918
		private ArgInfo _outArgInfo;

		// Token: 0x040026BF RID: 9919
		private MethodReturnMessageWrapper.DictionaryWrapper _properties;

		// Token: 0x040026C0 RID: 9920
		private Exception _exception;

		// Token: 0x040026C1 RID: 9921
		private object _return;

		// Token: 0x0200062E RID: 1582
		private class DictionaryWrapper : MethodReturnDictionary
		{
			// Token: 0x06003BB9 RID: 15289 RVA: 0x000D02DB File Offset: 0x000CE4DB
			public DictionaryWrapper(IMethodReturnMessage message, IDictionary wrappedDictionary) : base(message)
			{
				this._wrappedDictionary = wrappedDictionary;
				base.MethodKeys = MethodReturnMessageWrapper.DictionaryWrapper._keys;
			}

			// Token: 0x06003BBA RID: 15290 RVA: 0x000D02F6 File Offset: 0x000CE4F6
			protected override IDictionary AllocInternalProperties()
			{
				return this._wrappedDictionary;
			}

			// Token: 0x06003BBB RID: 15291 RVA: 0x000D0300 File Offset: 0x000CE500
			protected override void SetMethodProperty(string key, object value)
			{
				if (key == "__Args")
				{
					((MethodReturnMessageWrapper)this._message)._args = (object[])value;
					return;
				}
				if (key == "__Return")
				{
					((MethodReturnMessageWrapper)this._message)._return = value;
					return;
				}
				base.SetMethodProperty(key, value);
			}

			// Token: 0x06003BBC RID: 15292 RVA: 0x000D0358 File Offset: 0x000CE558
			protected override object GetMethodProperty(string key)
			{
				if (key == "__Args")
				{
					return ((MethodReturnMessageWrapper)this._message)._args;
				}
				if (key == "__Return")
				{
					return ((MethodReturnMessageWrapper)this._message)._return;
				}
				return base.GetMethodProperty(key);
			}

			// Token: 0x040026C2 RID: 9922
			private IDictionary _wrappedDictionary;

			// Token: 0x040026C3 RID: 9923
			private static string[] _keys = new string[]
			{
				"__Args",
				"__Return"
			};
		}
	}
}
