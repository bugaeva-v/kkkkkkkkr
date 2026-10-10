using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace System.Runtime.Remoting.Messaging
{
	/// <summary>Предоставляет набор свойств, которые переносятся с помощью выполняемой ветви кода. Этот класс не наследуется.</summary>
	// Token: 0x02000600 RID: 1536
	[ComVisible(true)]
	[SecurityCritical]
	[Serializable]
	public sealed class CallContext
	{
		// Token: 0x06003A32 RID: 14898 RVA: 0x0000259F File Offset: 0x0000079F
		private CallContext()
		{
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x0000AF5E File Offset: 0x0000915E
		internal static object SetCurrentCallContext(LogicalCallContext ctx)
		{
			return null;
		}

		// Token: 0x06003A34 RID: 14900 RVA: 0x000CC500 File Offset: 0x000CA700
		internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			LogicalCallContext logicalCallContext = mutableExecutionContext.LogicalCallContext;
			mutableExecutionContext.LogicalCallContext = callCtx;
			return logicalCallContext;
		}

		/// <summary>Очищает область данных с заданным именем.</summary>
		/// <param name="name">Имя очищаемой области данных.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A35 RID: 14901 RVA: 0x000CC525 File Offset: 0x000CA725
		[SecurityCritical]
		public static void FreeNamedDataSlot(string name)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext.LogicalCallContext.FreeNamedDataSlot(name);
			mutableExecutionContext.IllogicalCallContext.FreeNamedDataSlot(name);
		}

		/// <summary>Извлекает объект, связанный с заданным именем, из логического контекста вызова.</summary>
		/// <param name="name">Имя элемента в логическом контексте вызова.</param>
		/// <returns>Объект в логическом контексте вызова с заданным именем.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A36 RID: 14902 RVA: 0x000CC548 File Offset: 0x000CA748
		[SecurityCritical]
		public static object LogicalGetData(string name)
		{
			return Thread.CurrentThread.GetExecutionContextReader().LogicalCallContext.GetData(name);
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x000CC570 File Offset: 0x000CA770
		private static object IllogicalGetData(string name)
		{
			return Thread.CurrentThread.GetExecutionContextReader().IllogicalCallContext.GetData(name);
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003A38 RID: 14904 RVA: 0x000CC598 File Offset: 0x000CA798
		// (set) Token: 0x06003A39 RID: 14905 RVA: 0x000CC5BF File Offset: 0x000CA7BF
		internal static IPrincipal Principal
		{
			[SecurityCritical]
			get
			{
				return Thread.CurrentThread.GetExecutionContextReader().LogicalCallContext.Principal;
			}
			[SecurityCritical]
			set
			{
				Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.Principal = value;
			}
		}

		/// <summary>Возвращает или задает контекст хоста, связанный с текущим потоком.</summary>
		/// <returns>Контекст хоста, связанный с текущим потоком.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003A3A RID: 14906 RVA: 0x000CC5D8 File Offset: 0x000CA7D8
		// (set) Token: 0x06003A3B RID: 14907 RVA: 0x000CC614 File Offset: 0x000CA814
		public static object HostContext
		{
			[SecurityCritical]
			get
			{
				ExecutionContext.Reader executionContextReader = Thread.CurrentThread.GetExecutionContextReader();
				object hostContext = executionContextReader.IllogicalCallContext.HostContext;
				if (hostContext == null)
				{
					hostContext = executionContextReader.LogicalCallContext.HostContext;
				}
				return hostContext;
			}
			[SecurityCritical]
			set
			{
				ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
				if (value is ILogicalThreadAffinative)
				{
					mutableExecutionContext.IllogicalCallContext.HostContext = null;
					mutableExecutionContext.LogicalCallContext.HostContext = value;
					return;
				}
				mutableExecutionContext.IllogicalCallContext.HostContext = value;
				mutableExecutionContext.LogicalCallContext.HostContext = null;
			}
		}

		/// <summary>Извлекает объект с заданным именем из <see cref="T:System.Runtime.Remoting.Messaging.CallContext" />.</summary>
		/// <param name="name">Имя элемента в контексте вызова.</param>
		/// <returns>Объект в контексте вызова с заданным именем.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A3C RID: 14908 RVA: 0x000CC668 File Offset: 0x000CA868
		[SecurityCritical]
		public static object GetData(string name)
		{
			object obj = CallContext.LogicalGetData(name);
			if (obj == null)
			{
				return CallContext.IllogicalGetData(name);
			}
			return obj;
		}

		/// <summary>Сохраняет заданный объект и связывает его с заданным именем.</summary>
		/// <param name="name">Имя, с которым связывается новый элемент в контексте вызова.</param>
		/// <param name="data">Объект, сохраняемый в контексте вызова.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A3D RID: 14909 RVA: 0x000CC687 File Offset: 0x000CA887
		[SecurityCritical]
		public static void SetData(string name, object data)
		{
			if (data is ILogicalThreadAffinative)
			{
				CallContext.LogicalSetData(name, data);
				return;
			}
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext.LogicalCallContext.FreeNamedDataSlot(name);
			mutableExecutionContext.IllogicalCallContext.SetData(name, data);
		}

		/// <summary>Сохраняет заданный объект в логическом контексте вызова и связывает его с заданным именем.</summary>
		/// <param name="name">Имя, с которым связывается новый элемент в логическом контексте вызова.</param>
		/// <param name="data">Объект, который будет сохранен в логическом контексте вызова; этот объект должен быть сериализуемым.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A3E RID: 14910 RVA: 0x000CC6BB File Offset: 0x000CA8BB
		[SecurityCritical]
		public static void LogicalSetData(string name, object data)
		{
			ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
			mutableExecutionContext.IllogicalCallContext.FreeNamedDataSlot(name);
			mutableExecutionContext.LogicalCallContext.SetData(name, data);
		}

		/// <summary>Возвращает заголовки, которые отправляются вместе с вызовом метода.</summary>
		/// <returns>Заголовки, которые отправляются вместе с вызовом метода.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A3F RID: 14911 RVA: 0x000CC6DF File Offset: 0x000CA8DF
		[SecurityCritical]
		public static Header[] GetHeaders()
		{
			return Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.InternalGetHeaders();
		}

		/// <summary>Задает заголовки, которые отправляются вместе с вызовом метода.</summary>
		/// <param name="headers">Массив <see cref="T:System.Runtime.Remoting.Messaging.Header" /> из заголовков, которые необходимо отправить вместе с вызовом метода.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003A40 RID: 14912 RVA: 0x000CC6F5 File Offset: 0x000CA8F5
		[SecurityCritical]
		public static void SetHeaders(Header[] headers)
		{
			Thread.CurrentThread.GetMutableExecutionContext().LogicalCallContext.InternalSetHeaders(headers);
		}
	}
}
