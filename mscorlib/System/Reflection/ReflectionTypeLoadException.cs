using System;
using System.Runtime.Serialization;
using System.Security;
using System.Text;

namespace System.Reflection
{
	/// <summary>Исключение вызывается методом <see cref="M:System.Reflection.Module.GetTypes" />, если какой-либо из классов модуля не может быть загружен. Этот класс не наследуется.</summary>
	// Token: 0x020008BE RID: 2238
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.ReflectionTypeLoadException" /> с данными классами и сопоставленными исключениями.</summary>
		/// <param name="classes">Массив объектов типа <see langword="Type" />, содержащий классы, которые были определены в модуле и загружены. Этот массив может содержать пустые ссылки (в Visual Basic — <see langword="Nothing" />).</param>
		/// <param name="exceptions">Массив объектов типа <see langword="Exception" />, содержащий исключения, которые были созданы загрузчиком класса. Пустые ссылки (в Visual Basic — <see langword="Nothing" />) в массиве <paramref name="classes" /> соответствуют исключениям в этом массиве <paramref name="exceptions" />.</param>
		// Token: 0x06004A0C RID: 18956 RVA: 0x000EF55D File Offset: 0x000ED75D
		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions) : base(null)
		{
			this.Types = classes;
			this.LoaderExceptions = exceptions;
			base.HResult = -2146232830;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.ReflectionTypeLoadException" /> заданными классами, сопоставленными им исключениями и описаниями этих исключений.</summary>
		/// <param name="classes">Массив объектов типа <see langword="Type" />, содержащий классы, которые были определены в модуле и загружены. Этот массив может содержать пустые ссылки (в Visual Basic — <see langword="Nothing" />).</param>
		/// <param name="exceptions">Массив объектов типа <see langword="Exception" />, содержащий исключения, которые были созданы загрузчиком класса. Пустые ссылки (в Visual Basic — <see langword="Nothing" />) в массиве <paramref name="classes" /> соответствуют исключениям в этом массиве <paramref name="exceptions" />.</param>
		/// <param name="message">Строка <see langword="String" /> описания причины создания исключения.</param>
		// Token: 0x06004A0D RID: 18957 RVA: 0x000EF57F File Offset: 0x000ED77F
		public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions, string message) : base(message)
		{
			this.Types = classes;
			this.LoaderExceptions = exceptions;
			base.HResult = -2146232830;
		}

		// Token: 0x06004A0E RID: 18958 RVA: 0x000EF5A1 File Offset: 0x000ED7A1
		private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.LoaderExceptions = (Exception[])info.GetValue("Exceptions", typeof(Exception[]));
		}

		/// <summary>Обеспечивает реализацию класса <see cref="T:System.Runtime.Serialization.ISerializable" /> для сериализованных объектов.</summary>
		/// <param name="info">Сведения и данные, необходимые для выполнения сериализации и десериализации объекта.</param>
		/// <param name="context">Контекст для сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <see langword="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004A0F RID: 18959 RVA: 0x000EF5CB File Offset: 0x000ED7CB
		[SecurityCritical]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("Types", null, typeof(Type[]));
			info.AddValue("Exceptions", this.LoaderExceptions, typeof(Exception[]));
		}

		/// <summary>Возвращает массив классов, которые были определены в модуле и загружены.</summary>
		/// <returns>Массив объектов типа <see langword="Type" />, содержащий классы, которые были определены в модуле и загружены. Некоторые объекты этого массива могут быть значениями <see langword="null" />.</returns>
		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06004A10 RID: 18960 RVA: 0x000EF606 File Offset: 0x000ED806
		public Type[] Types { get; }

		/// <summary>Получает массив исключений, создаваемых загрузчиком классов.</summary>
		/// <returns>Массив типа <see langword="Exception" />, который содержит исключения, создаваемые загрузчиком классов. Значения Null в массиве <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> этого экземпляра выравниваются в соответствии с исключениями в этом массиве.</returns>
		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06004A11 RID: 18961 RVA: 0x000EF60E File Offset: 0x000ED80E
		public Exception[] LoaderExceptions { get; }

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06004A12 RID: 18962 RVA: 0x000EF616 File Offset: 0x000ED816
		public override string Message
		{
			get
			{
				return this.CreateString(true);
			}
		}

		// Token: 0x06004A13 RID: 18963 RVA: 0x000EF61F File Offset: 0x000ED81F
		public override string ToString()
		{
			return this.CreateString(false);
		}

		// Token: 0x06004A14 RID: 18964 RVA: 0x000EF628 File Offset: 0x000ED828
		private string CreateString(bool isMessage)
		{
			string text = isMessage ? base.Message : base.ToString();
			Exception[] loaderExceptions = this.LoaderExceptions;
			if (loaderExceptions == null || loaderExceptions.Length == 0)
			{
				return text;
			}
			StringBuilder stringBuilder = new StringBuilder(text);
			foreach (Exception ex in loaderExceptions)
			{
				if (ex != null)
				{
					stringBuilder.AppendLine();
					stringBuilder.Append(isMessage ? ex.Message : ex.ToString());
				}
			}
			return stringBuilder.ToString();
		}
	}
}
