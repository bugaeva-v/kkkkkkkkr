using System;

namespace System.Configuration
{
	/// <summary>Определяет <see cref="T:System.Configuration.CallbackValidator" /> объект, используемый для проверки кода. Этот класс не наследуется.</summary>
	// Token: 0x0200000D RID: 13
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class CallbackValidatorAttribute : ConfigurationValidatorAttribute
	{
		/// <summary>Возвращает или задает имя вызванного метода.</summary>
		/// <returns>Имя вызываемого метода.</returns>
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000230B File Offset: 0x0000050B
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002313 File Offset: 0x00000513
		public string CallbackMethodName
		{
			get
			{
				return this.callbackMethodName;
			}
			set
			{
				this.callbackMethodName = value;
				this.instance = null;
			}
		}

		/// <summary>Возвращает или задает тип проверяющего элемента управления.</summary>
		/// <returns>
		///   <see cref="T:System.Type" /> экземпляра атрибута проверяющего элемента управления.</returns>
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002323 File Offset: 0x00000523
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000232B File Offset: 0x0000052B
		public Type Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
				this.instance = null;
			}
		}

		/// <summary>Возвращает экземпляр проверяющего элемента управления.</summary>
		/// <returns>Текущий экземпляр <see cref="T:System.Configuration.ConfigurationValidatorBase" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение свойства <see cref="P:System.Configuration.CallbackValidatorAttribute.Type" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <see cref="P:System.Configuration.CallbackValidatorAttribute.CallbackMethodName" /> один параметр свойства не установлен в режим "public static void".</exception>
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000233B File Offset: 0x0000053B
		public override ConfigurationValidatorBase ValidatorInstance
		{
			get
			{
				return this.instance;
			}
		}

		// Token: 0x04000031 RID: 49
		private string callbackMethodName = "";

		// Token: 0x04000032 RID: 50
		private Type type;

		// Token: 0x04000033 RID: 51
		private ConfigurationValidatorBase instance;
	}
}
