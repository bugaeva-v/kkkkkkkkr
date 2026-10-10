using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, следует ли создавать оболочку для выражений, не являющихся производными от класса <see cref="T:System.Exception" />, в виде объекта <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" />. Этот класс не наследуется.</summary>
	// Token: 0x02000801 RID: 2049
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class RuntimeCompatibilityAttribute : Attribute
	{
		/// <summary>Получает или задает значение, указывающее, следует ли создавать оболочку для исключений, не являющихся производными от класса <see cref="T:System.Exception" />, в виде объекта <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" />.</summary>
		/// <returns>
		///   <see langword="true" />, если для исключений, не являющихся производными от класса <see cref="T:System.Exception" />, следует создавать оболочку в виде объекта <see cref="T:System.Runtime.CompilerServices.RuntimeWrappedException" />; <see langword="false" /> в противном случае.</returns>
		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x000E585D File Offset: 0x000E3A5D
		// (set) Token: 0x06004616 RID: 17942 RVA: 0x000E5865 File Offset: 0x000E3A65
		public bool WrapNonExceptionThrows { get; set; }
	}
}
