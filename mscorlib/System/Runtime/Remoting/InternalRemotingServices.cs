using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
	/// <summary>Определяет служебные методы для использования в инфраструктуре удаленного взаимодействия .NET Framework.</summary>
	// Token: 0x02000562 RID: 1378
	[ComVisible(true)]
	public class InternalRemotingServices
	{
		/// <summary>Отправляет сообщение об удаленном канале на неуправляемый отладчик.</summary>
		/// <param name="s">Строка для размещения в сообщении.</param>
		// Token: 0x060035FF RID: 13823 RVA: 0x000472C8 File Offset: 0x000454C8
		[Conditional("_LOGGING")]
		public static void DebugOutChnl(string s)
		{
			throw new NotSupportedException();
		}

		/// <summary>Получает соответствующий, связанный с SOAP, атрибут для указанного члена класса и параметра метода.</summary>
		/// <param name="reflectionObject">Член класса или параметр метода.</param>
		/// <returns>SOAP-атрибут для заданного элемента класса или параметра метода.</returns>
		// Token: 0x06003600 RID: 13824 RVA: 0x000C254C File Offset: 0x000C074C
		public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
		{
			object syncRoot = InternalRemotingServices._soapAttributes.SyncRoot;
			SoapAttribute result;
			lock (syncRoot)
			{
				SoapAttribute soapAttribute = InternalRemotingServices._soapAttributes[reflectionObject] as SoapAttribute;
				if (soapAttribute != null)
				{
					result = soapAttribute;
				}
				else
				{
					object[] customAttributes = ((ICustomAttributeProvider)reflectionObject).GetCustomAttributes(typeof(SoapAttribute), true);
					if (customAttributes.Length != 0)
					{
						soapAttribute = (SoapAttribute)customAttributes[0];
					}
					else if (reflectionObject is Type)
					{
						soapAttribute = new SoapTypeAttribute();
					}
					else if (reflectionObject is FieldInfo)
					{
						soapAttribute = new SoapFieldAttribute();
					}
					else if (reflectionObject is MethodBase)
					{
						soapAttribute = new SoapMethodAttribute();
					}
					else if (reflectionObject is ParameterInfo)
					{
						soapAttribute = new SoapParameterAttribute();
					}
					soapAttribute.SetReflectionObject(reflectionObject);
					InternalRemotingServices._soapAttributes[reflectionObject] = soapAttribute;
					result = soapAttribute;
				}
			}
			return result;
		}

		/// <summary>Указывает внутреннему отладчику на необходимость проверки условия и отображения сообщения, если условие имеет значение <see langword="false" />.</summary>
		/// <param name="condition">Значение <see langword="true" />, если требуется, чтобы сообщение не отображалось; в противном случае — <see langword="false" />.</param>
		/// <param name="message">Сообщение, отображаемое, если значением <paramref name="condition" /> является <see langword="false" />.</param>
		// Token: 0x06003601 RID: 13825 RVA: 0x000472C8 File Offset: 0x000454C8
		[Conditional("_DEBUG")]
		public static void RemotingAssert(bool condition, string message)
		{
			throw new NotSupportedException();
		}

		/// <summary>Отправляет любое количество сообщений об удаленных каналах на внутренний отладчик.</summary>
		/// <param name="messages">Массив типа <see cref="T:System.Object" />, который содержит любое количество сообщений.</param>
		// Token: 0x06003602 RID: 13826 RVA: 0x000472C8 File Offset: 0x000454C8
		[Conditional("_LOGGING")]
		public static void RemotingTrace(params object[] messages)
		{
			throw new NotSupportedException();
		}

		/// <summary>Задает внутреннюю определяющую информацию для объекта удаленного сервера для каждого вызова метода от клиента на сервер.</summary>
		/// <param name="m">
		///   <see cref="T:System.Runtime.Remoting.Messaging.MethodCall" /> представляет вызов метода на удаленный объект.</param>
		/// <param name="srvID">Внутренние определяющие сведения для объекта удаленного сервера.</param>
		// Token: 0x06003603 RID: 13827 RVA: 0x000C2624 File Offset: 0x000C0824
		[CLSCompliant(false)]
		public static void SetServerIdentity(MethodCall m, object srvID)
		{
			Identity identity = srvID as Identity;
			if (identity == null)
			{
				throw new ArgumentException("srvID");
			}
			RemotingServices.SetMessageTargetIdentity(m, identity);
		}

		// Token: 0x04002523 RID: 9507
		private static Hashtable _soapAttributes = new Hashtable();
	}
}
