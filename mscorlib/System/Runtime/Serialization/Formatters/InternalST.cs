using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

namespace System.Runtime.Serialization.Formatters
{
	/// <summary>Сообщения трассировки журналов при компиляции инфраструктуры сериализации платформы .NET Framework.</summary>
	// Token: 0x0200067E RID: 1662
	[SecurityCritical]
	[ComVisible(true)]
	public sealed class InternalST
	{
		// Token: 0x06003DD9 RID: 15833 RVA: 0x0000259F File Offset: 0x0000079F
		private InternalST()
		{
		}

		/// <summary>Печатает сообщения трассировки SOAP.</summary>
		/// <param name="messages">Массив сообщений трассировки для печати.</param>
		// Token: 0x06003DDA RID: 15834 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[Conditional("_LOGGING")]
		public static void InfoSoap(params object[] messages)
		{
		}

		/// <summary>Проверяет, включена ли трассировка SOAP.</summary>
		/// <returns>Значение равно <see langword="true" />, если трассировка включена; в противном случае — значение равно <see langword="false" />.</returns>
		// Token: 0x06003DDB RID: 15835 RVA: 0x000D59BC File Offset: 0x000D3BBC
		public static bool SoapCheckEnabled()
		{
			return BCLDebug.CheckEnabled("Soap");
		}

		/// <summary>Обрабатывает указанный массив сообщений.</summary>
		/// <param name="messages">Массив сообщений трассировки для обработки.</param>
		// Token: 0x06003DDC RID: 15836 RVA: 0x000D59C8 File Offset: 0x000D3BC8
		[Conditional("SER_LOGGING")]
		public static void Soap(params object[] messages)
		{
			if (!(messages[0] is string))
			{
				messages[0] = messages[0].GetType().Name + " ";
				return;
			}
			int num = 0;
			object obj = messages[0];
			messages[num] = ((obj != null) ? obj.ToString() : null) + " ";
		}

		/// <summary>Утверждает указанное сообщение.</summary>
		/// <param name="condition">Логическое значение для использование при утверждении.</param>
		/// <param name="message">Сообщение, используемое при утверждении.</param>
		// Token: 0x06003DDD RID: 15837 RVA: 0x00004BF9 File Offset: 0x00002DF9
		[Conditional("_DEBUG")]
		public static void SoapAssert(bool condition, string message)
		{
		}

		/// <summary>Устанавливает значение поля.</summary>
		/// <param name="fi">
		///   <see cref="T:System.Reflection.FieldInfo" />, где содержатся данные о целевом поле.</param>
		/// <param name="target">Поле для осуществления изменения.</param>
		/// <param name="value">Задаваемое значение.</param>
		// Token: 0x06003DDE RID: 15838 RVA: 0x000D5A16 File Offset: 0x000D3C16
		public static void SerializationSetValue(FieldInfo fi, object target, object value)
		{
			if (fi == null)
			{
				throw new ArgumentNullException("fi");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			FormatterServices.SerializationSetValue(fi, target, value);
		}

		/// <summary>Загружает указанную сборку для отладки.</summary>
		/// <param name="assemblyString">Имя загружаемой сборки.</param>
		/// <returns>Обработчик <see cref="T:System.Reflection.Assembly" /> для отладки.</returns>
		// Token: 0x06003DDF RID: 15839 RVA: 0x000D5A50 File Offset: 0x000D3C50
		public static Assembly LoadAssemblyFromString(string assemblyString)
		{
			return FormatterServices.LoadAssemblyFromString(assemblyString);
		}
	}
}
