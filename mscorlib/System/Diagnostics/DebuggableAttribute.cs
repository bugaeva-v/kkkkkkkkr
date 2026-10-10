using System;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Изменяет генерацию кода для JIT-отладки во время выполнения. Этот класс не наследуется.</summary>
	// Token: 0x020009B8 RID: 2488
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module, AllowMultiple = false)]
	public sealed class DebuggableAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggableAttribute" />, используя заданные для JIT-компилятора параметры отслеживания и оптимизации.</summary>
		/// <param name="isJITTrackingEnabled">Значение <see langword="true" /> для включения отладки; в противном случае — значение <see langword="false" />.</param>
		/// <param name="isJITOptimizerDisabled">Значение <see langword="true" /> для отключения оптимизатора выполнения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600599D RID: 22941 RVA: 0x00132FA2 File Offset: 0x001311A2
		public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled)
		{
			this.m_debuggingModes = DebuggableAttribute.DebuggingModes.None;
			if (isJITTrackingEnabled)
			{
				this.m_debuggingModes |= DebuggableAttribute.DebuggingModes.Default;
			}
			if (isJITOptimizerDisabled)
			{
				this.m_debuggingModes |= DebuggableAttribute.DebuggingModes.DisableOptimizations;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.DebuggableAttribute" />, используя заданные для JIT-компилятора режимы отладки.</summary>
		/// <param name="modes">Побитовая комбинация значений <see cref="T:System.Diagnostics.DebuggableAttribute.DebuggingModes" />, определяющих режим отладки для JIT-компилятора.</param>
		// Token: 0x0600599E RID: 22942 RVA: 0x00132FD7 File Offset: 0x001311D7
		public DebuggableAttribute(DebuggableAttribute.DebuggingModes modes)
		{
			this.m_debuggingModes = modes;
		}

		/// <summary>Возвращает значение, позволяющее определить, должна ли среда выполнения отслеживать для отладчика сведения во время создания кода.</summary>
		/// <returns>Значение <see langword="true" />, если среда выполнения будет отслеживать для отладчика сведения во время создания кода; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x0600599F RID: 22943 RVA: 0x00132FE6 File Offset: 0x001311E6
		public bool IsJITTrackingEnabled
		{
			get
			{
				return (this.m_debuggingModes & DebuggableAttribute.DebuggingModes.Default) > DebuggableAttribute.DebuggingModes.None;
			}
		}

		/// <summary>Возвращает значение, позволяющее определить, отключен ли оптимизатор среды выполнения.</summary>
		/// <returns>Значение <see langword="true" />, если оптимизатор во время выполнения отключен; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x00132FF3 File Offset: 0x001311F3
		public bool IsJITOptimizerDisabled
		{
			get
			{
				return (this.m_debuggingModes & DebuggableAttribute.DebuggingModes.DisableOptimizations) > DebuggableAttribute.DebuggingModes.None;
			}
		}

		/// <summary>Возвращает для атрибута режим отладки.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Diagnostics.DebuggableAttribute.DebuggingModes" />, описывающих режим отладки для JIT-компилятора. Значение по умолчанию — <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.Default" />.</returns>
		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060059A1 RID: 22945 RVA: 0x00133004 File Offset: 0x00131204
		public DebuggableAttribute.DebuggingModes DebuggingFlags
		{
			get
			{
				return this.m_debuggingModes;
			}
		}

		// Token: 0x04003774 RID: 14196
		private DebuggableAttribute.DebuggingModes m_debuggingModes;

		/// <summary>Задает режим отладки для JIT-компилятора.</summary>
		// Token: 0x020009B9 RID: 2489
		[Flags]
		[ComVisible(true)]
		public enum DebuggingModes
		{
			/// <summary>Начиная с платформы .NET Framework версии 2.0 всегда генерируются сведения о JIT-отслеживании, и этот флаг дает тот же эффект, что и <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.Default" />, за исключением того, что для свойства <see cref="P:System.Diagnostics.DebuggableAttribute.IsJITTrackingEnabled" /> задается значение <see langword="false" />. Однако поскольку JIT-отслеживание всегда включено, значение свойства игнорируется в версии 2.0 или более поздней версии.  
			/// Обратите внимание, что флаг <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.None" />, в отличие от флага <see cref="F:System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations" />, нельзя использовать для отключения JIT-оптимизаций.</summary>
			// Token: 0x04003776 RID: 14198
			None = 0,
			/// <summary>Требует от JIT-компилятора использования поведения по умолчанию, которое включает активацию оптимизаций, отключение поддержки режима "Изменить и продолжить" и использование точек следования хранилища символов при его наличии. Начиная с платформы .NET Framework версии 2.0 всегда генерируются сведения об отслеживании JIT, смещении MSIL для смещения машинного кода внутри метода.</summary>
			// Token: 0x04003777 RID: 14199
			Default = 1,
			/// <summary>Выключение оптимизации кода компилятором делает код более быстрым, коротким и эффективным. Оптимизация изменяет порядок строк кода в файле вывода, что может осложнить процесс отладки. Обычно во время отладки оптимизация должна быть отключена. Для включения отслеживания JIT и отключения оптимизации в версии 2.0 и более поздних используйте это значение в сочетании со значением по умолчанию (Default | DisableOptimizations).</summary>
			// Token: 0x04003778 RID: 14200
			DisableOptimizations = 256,
			/// <summary>Используйте неявные точки следования MSIL, а не точки следования базы данных программы (PDB). Символьная информация обычно включает по меньшей мере одно смещение в терминах языка MSIL для каждой исходной строки. Перед компиляцией метода JIT-компилятор запрашивает у профилирующей службы список MSIL-смещений, которые необходимо сохранить. Эти MSIL-смещения называются точками следования.</summary>
			// Token: 0x04003779 RID: 14201
			IgnoreSymbolStoreSequencePoints = 2,
			/// <summary>Разрешить режим "Изменить и продолжить". "Изменить и продолжить" — это режим, позволяющий вносить изменения в исходный код, в то время как выполнение программы приостановлено. Возможности режима "Изменить и продолжить" зависят от компилятора.</summary>
			// Token: 0x0400377A RID: 14202
			EnableEditAndContinue = 4
		}
	}
}
