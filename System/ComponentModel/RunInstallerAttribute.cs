using System;

namespace System.ComponentModel
{
	/// <summary>Указывает, следует ли при установке сборки вызывать установщик пользовательских действий Visual Studio или программу Installutil.exe (средство установки).</summary>
	// Token: 0x020003E9 RID: 1001
	[AttributeUsage(AttributeTargets.Class)]
	public class RunInstallerAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</summary>
		/// <param name="runInstaller">Значение <see langword="true" />, если во время установки сборки следует вызвать установщик, в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060020D1 RID: 8401 RVA: 0x0007176A File Offset: 0x0006F96A
		public RunInstallerAttribute(bool runInstaller)
		{
			this.RunInstaller = runInstaller;
		}

		/// <summary>Возвращает значение, показывающее, следует ли вызывать установщик во время установки сборки.</summary>
		/// <returns>Значение <see langword="true" />, если во время установки сборки следует вызвать установщик, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00071779 File Offset: 0x0006F979
		public bool RunInstaller { get; }

		/// <summary>Определяет, эквивалентно ли значение заданного атрибута <see cref="T:System.ComponentModel.RunInstallerAttribute" /> текущему атрибуту <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</summary>
		/// <param name="obj">Объект для сравнения.</param>
		/// <returns>Значение <see langword="true" />, если указанный объект <see cref="T:System.ComponentModel.RunInstallerAttribute" /> равен текущему объекту <see cref="T:System.ComponentModel.RunInstallerAttribute" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060020D3 RID: 8403 RVA: 0x00071784 File Offset: 0x0006F984
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			RunInstallerAttribute runInstallerAttribute = obj as RunInstallerAttribute;
			return runInstallerAttribute != null && runInstallerAttribute.RunInstaller == this.RunInstaller;
		}

		/// <summary>Создает хэш-код для текущего атрибута <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.RunInstallerAttribute" />.</returns>
		// Token: 0x060020D4 RID: 8404 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		/// <summary>Определяет, является ли этот атрибут используемым по умолчанию.</summary>
		/// <returns>Значение <see langword="true" />, если атрибут является значением по умолчанию для данного класса атрибутов; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020D5 RID: 8405 RVA: 0x000717B1 File Offset: 0x0006F9B1
		public override bool IsDefaultAttribute()
		{
			return this.Equals(RunInstallerAttribute.Default);
		}

		/// <summary>Указывает, что при установке сборки следует вызвать установщик пользовательских действий Visual Studio или программу Installutil.exe (средство установки). Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FE3 RID: 4067
		public static readonly RunInstallerAttribute Yes = new RunInstallerAttribute(true);

		/// <summary>Указывает, что при установке сборки не следует вызывать установщик пользовательских действий Visual Studio или программу Installutil.exe (средство установки). Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FE4 RID: 4068
		public static readonly RunInstallerAttribute No = new RunInstallerAttribute(false);

		/// <summary>Определяет видимость по умолчанию, которая равна <see cref="F:System.ComponentModel.RunInstallerAttribute.No" />. Это статическое (<see langword="static" />) поле доступно только для чтения.</summary>
		// Token: 0x04000FE5 RID: 4069
		public static readonly RunInstallerAttribute Default = RunInstallerAttribute.No;
	}
}
