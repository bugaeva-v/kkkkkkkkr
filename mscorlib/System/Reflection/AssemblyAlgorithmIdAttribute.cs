using System;
using System.Configuration.Assemblies;

namespace System.Reflection
{
	/// <summary>Определяет алгоритм хеширования всех файлов сборки. Этот класс не наследуется.</summary>
	// Token: 0x0200087D RID: 2173
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyAlgorithmIdAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyAlgorithmIdAttribute" /> с заданным алгоритмом хеширования, используя для представления алгоритма хеширования один из членов <see cref="T:System.Configuration.Assemblies.AssemblyHashAlgorithm" />.</summary>
		/// <param name="algorithmId">Член <see langword="AssemblyHashAlgorithm" />, который представляет алгоритм хеширования.</param>
		// Token: 0x0600484E RID: 18510 RVA: 0x000EDFED File Offset: 0x000EC1ED
		public AssemblyAlgorithmIdAttribute(AssemblyHashAlgorithm algorithmId)
		{
			this.AlgorithmId = algorithmId;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.AssemblyAlgorithmIdAttribute" /> заданным алгоритмом хеширования, используя для представления алгоритма хеширования целое число без знака.</summary>
		/// <param name="algorithmId">Целое число без знака, представляющее алгоритм хеширования.</param>
		// Token: 0x0600484F RID: 18511 RVA: 0x000EDFED File Offset: 0x000EC1ED
		[CLSCompliant(false)]
		public AssemblyAlgorithmIdAttribute(uint algorithmId)
		{
			this.AlgorithmId = algorithmId;
		}

		/// <summary>Возвращает алгоритм хеширования содержимого манифеста сборки.</summary>
		/// <returns>Целое число без знака, представляющее алгоритм хеширования сборки.</returns>
		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06004850 RID: 18512 RVA: 0x000EDFFC File Offset: 0x000EC1FC
		[CLSCompliant(false)]
		public uint AlgorithmId { get; }
	}
}
