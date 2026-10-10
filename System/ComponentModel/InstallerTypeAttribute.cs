using System;

namespace System.ComponentModel
{
	/// <summary>Задает установщик для типа, устанавливающего компоненты.</summary>
	// Token: 0x020003BE RID: 958
	[AttributeUsage(AttributeTargets.Class)]
	public class InstallerTypeAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InstallerTypeAttribute" /> для заданного типа <see cref="T:System.Type" />, представляющего установщик компонента.</summary>
		/// <param name="installerType">Объект <see cref="T:System.Type" />, представляющий установщик для компонента, с которым связан этот атрибут. Этот класс должен реализовывать интерфейс <see cref="T:System.ComponentModel.Design.IDesigner" />.</param>
		// Token: 0x06001F24 RID: 7972 RVA: 0x0006CCAB File Offset: 0x0006AEAB
		public InstallerTypeAttribute(Type installerType)
		{
			this._typeName = installerType.AssemblyQualifiedName;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InstallerTypeAttribute" />, используя имя типа установщика компонентов.</summary>
		/// <param name="typeName">Имя объекта <see cref="T:System.Type" />, представляющего установщик для компонента, с которым связан этот атрибут. Этот класс должен реализовывать интерфейс <see cref="T:System.ComponentModel.Design.IDesigner" />.</param>
		// Token: 0x06001F25 RID: 7973 RVA: 0x0006CCBF File Offset: 0x0006AEBF
		public InstallerTypeAttribute(string typeName)
		{
			this._typeName = typeName;
		}

		/// <summary>Возвращает тип установщика, связанного с этим атрибутом.</summary>
		/// <returns>Объект <see cref="T:System.Type" />, представляющий тип установщика, связанного с этим атрибутом, или значение <see langword="null" />, если установщик не существует.</returns>
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0006CCCE File Offset: 0x0006AECE
		public virtual Type InstallerType
		{
			get
			{
				return Type.GetType(this._typeName);
			}
		}

		/// <summary>Возвращает значение, показывающее, равно ли значение данного объекта текущему атрибуту <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</summary>
		/// <param name="obj">Объект, проверяемый на равенство.</param>
		/// <returns>Значение <see langword="true" />, если значение данного объекта равно значению текущего; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001F27 RID: 7975 RVA: 0x0006CCDC File Offset: 0x0006AEDC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			InstallerTypeAttribute installerTypeAttribute = obj as InstallerTypeAttribute;
			return installerTypeAttribute != null && installerTypeAttribute._typeName == this._typeName;
		}

		/// <summary>Возвращает хэш-код для данного объекта.</summary>
		/// <returns>Хэш-код для текущего объекта <see cref="T:System.ComponentModel.InstallerTypeAttribute" />.</returns>
		// Token: 0x06001F28 RID: 7976 RVA: 0x000678FA File Offset: 0x00065AFA
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x04000F4A RID: 3914
		private string _typeName;
	}
}
