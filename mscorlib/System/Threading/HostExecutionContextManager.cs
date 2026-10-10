using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Permissions;

namespace System.Threading
{
	/// <summary>Обеспечивает функциональность, позволяющие хосту общеязыковой среды выполнения участвовать в перемещении или миграции контекста выполнения.</summary>
	// Token: 0x020002EF RID: 751
	public class HostExecutionContextManager
	{
		/// <summary>Перехватывает контекст выполнения хоста из текущего потока.</summary>
		/// <returns>Объект <see cref="T:System.Threading.HostExecutionContext" />, представляющий контекст выполнения хоста для текущего потока.</returns>
		// Token: 0x060020B0 RID: 8368 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual HostExecutionContext Capture()
		{
			throw new NotImplementedException();
		}

		/// <summary>Восстанавливает контекст выполнения хоста в предыдущее состояние.</summary>
		/// <param name="previousState">Предыдущее (возвращаемое) состояние контекста.</param>
		/// <exception cref="T:System.InvalidOperationException">Свойство <paramref name="previousState" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// <paramref name="previousState" /> не был создан для текущего потока.  
		///
		/// или - 
		/// <paramref name="previousState" /> не является последним состоянием <see cref="T:System.Threading.HostExecutionContext" />.</exception>
		// Token: 0x060020B1 RID: 8369 RVA: 0x000479F8 File Offset: 0x00045BF8
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[MonoTODO]
		public virtual void Revert(object previousState)
		{
			throw new NotImplementedException();
		}

		/// <summary>Задает текущий контекст выполнения хоста в указываемое значение.</summary>
		/// <param name="hostExecutionContext">Задаваемый объект <see cref="T:System.Threading.HostExecutionContext" />.</param>
		/// <returns>Объект для восстановления <see cref="T:System.Threading.HostExecutionContext" /> в предыдущее состояние.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="hostExecutionContext" /> не был получен во время операции отслеживания.  
		///
		/// или - 
		/// <paramref name="hostExecutionContext" /> использовался в качестве аргумента в предыдущем вызове метода <see cref="M:System.Threading.HostExecutionContextManager.SetHostExecutionContext(System.Threading.HostExecutionContext)" />.</exception>
		// Token: 0x060020B2 RID: 8370 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
		public virtual object SetHostExecutionContext(HostExecutionContext hostExecutionContext)
		{
			throw new NotImplementedException();
		}
	}
}
