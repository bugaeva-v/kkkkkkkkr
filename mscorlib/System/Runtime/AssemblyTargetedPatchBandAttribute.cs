using System;

namespace System.Runtime
{
	/// <summary>Задает сведения диапазона исправления для выполнения целевых исправлений платформы .NET Framework.</summary>
	// Token: 0x0200054C RID: 1356
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTargetedPatchBandAttribute : Attribute
	{
		/// <summary>Получает диапазон исправления.</summary>
		/// <returns>Сведения о диапазоне исправления.</returns>
		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x000C1F75 File Offset: 0x000C0175
		public string TargetedPatchBand { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.AssemblyTargetedPatchBandAttribute" />.</summary>
		/// <param name="targetedPatchBand">Диапазон исправления.</param>
		// Token: 0x060035A8 RID: 13736 RVA: 0x000C1F7D File Offset: 0x000C017D
		public AssemblyTargetedPatchBandAttribute(string targetedPatchBand)
		{
			this.TargetedPatchBand = targetedPatchBand;
		}
	}
}
