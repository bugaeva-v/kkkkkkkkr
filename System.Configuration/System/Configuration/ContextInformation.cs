using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Инкапсулирует сведения о контексте, связанные с объектом <see cref="T:System.Configuration.ConfigurationElement" />. Этот класс не наследуется.</summary>
	// Token: 0x0200003B RID: 59
	public sealed class ContextInformation
	{
		// Token: 0x06000212 RID: 530 RVA: 0x000076AE File Offset: 0x000058AE
		internal ContextInformation(Configuration config, object ctx)
		{
			this.ctx = ctx;
			this.config = config;
		}

		/// <summary>Предоставляет объект, содержащий информацию о разделе конфигурации, основанную на указанном имени раздела.</summary>
		/// <param name="sectionName">Имя раздела конфигурации.</param>
		/// <returns>Объект, содержащий определенный раздел в пределах конфигурации.</returns>
		// Token: 0x06000213 RID: 531 RVA: 0x000076C4 File Offset: 0x000058C4
		public object GetSection(string sectionName)
		{
			return this.config.GetSection(sectionName);
		}

		/// <summary>Возвращает контекст среды, в которой определяется свойство конфигурации.</summary>
		/// <returns>Объект определяет среду, в которой было определено свойство конфигурации.</returns>
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000076D2 File Offset: 0x000058D2
		public object HostingContext
		{
			get
			{
				return this.ctx;
			}
		}

		/// <summary>Возвращает значение, указывающее, определяется ли свойство конфигурации на уровне конфигурации компьютера.</summary>
		/// <returns>
		///   <see langword="true" />, если свойство конфигурации определено на уровне конфигурации машины, в противном случае — <see langword="false" />.</returns>
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000076DA File Offset: 0x000058DA
		[MonoInternalNote("should this use HostingContext instead?")]
		public bool IsMachineLevel
		{
			get
			{
				return this.config.ConfigPath == "machine";
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003518 File Offset: 0x00001718
		internal ContextInformation()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x040000DD RID: 221
		private object ctx;

		// Token: 0x040000DE RID: 222
		private Configuration config;
	}
}
