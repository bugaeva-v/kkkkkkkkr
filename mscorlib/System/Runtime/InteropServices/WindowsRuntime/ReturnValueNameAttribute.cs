using System;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	/// <summary>Задает имя возвращаемого значения метода в компоненте среды выполнения Windows.</summary>
	// Token: 0x02000787 RID: 1927
	[AttributeUsage(AttributeTargets.Delegate | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = false)]
	public sealed class ReturnValueNameAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.WindowsRuntime.ReturnValueNameAttribute" /> и указывает имя возвращаемого значения.</summary>
		/// <param name="name">Имя возвращаемого значения.</param>
		// Token: 0x06004486 RID: 17542 RVA: 0x000E3B3A File Offset: 0x000E1D3A
		public ReturnValueNameAttribute(string name)
		{
			this.m_Name = name;
		}

		/// <summary>Получает имя, указанное для возвращаемого значения метода в компоненте Среда выполнения Windows.</summary>
		/// <returns>Имя возвращаемого значения метода.</returns>
		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06004487 RID: 17543 RVA: 0x000E3B49 File Offset: 0x000E1D49
		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x04002C23 RID: 11299
		private string m_Name;
	}
}
