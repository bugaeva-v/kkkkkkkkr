using System;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data
{
	/// <summary>Представляет ограничение, которое может быть применено к одному или более объектам <see cref="T:System.Data.DataColumn" />.</summary>
	// Token: 0x020000A9 RID: 169
	[DefaultProperty("ConstraintName")]
	[TypeConverter(typeof(ConstraintConverter))]
	public abstract class Constraint
	{
		/// <summary>Имя ограничения в <see cref="T:System.Data.ConstraintCollection" />.</summary>
		/// <returns>Имя <see cref="T:System.Data.Constraint" />.</returns>
		/// <exception cref="T:System.ArgumentException">Именем <see cref="T:System.Data.Constraint" /> является значение NULL или пустая строка.</exception>
		/// <exception cref="T:System.Data.DuplicateNameException">Коллекция <see cref="T:System.Data.ConstraintCollection" /> уже содержит <see cref="T:System.Data.Constraint" /> с тем же именем (сравнение выполняется без учета регистра.).</exception>
		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002B689 File Offset: 0x00029889
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x0002B694 File Offset: 0x00029894
		[DefaultValue("")]
		public virtual string ConstraintName
		{
			get
			{
				return this._name;
			}
			set
			{
				if (value == null)
				{
					value = string.Empty;
				}
				if (string.IsNullOrEmpty(value) && this.Table != null && this.InCollection)
				{
					throw ExceptionBuilder.NoConstraintName();
				}
				CultureInfo culture = (this.Table != null) ? this.Table.Locale : CultureInfo.CurrentCulture;
				if (string.Compare(this._name, value, true, culture) != 0)
				{
					if (this.Table != null && this.InCollection)
					{
						this.Table.Constraints.RegisterName(value);
						if (this._name.Length != 0)
						{
							this.Table.Constraints.UnregisterName(this._name);
						}
					}
					this._name = value;
					return;
				}
				if (string.Compare(this._name, value, false, culture) != 0)
				{
					this._name = value;
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002B757 File Offset: 0x00029957
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x0002B773 File Offset: 0x00029973
		internal string SchemaName
		{
			get
			{
				if (!string.IsNullOrEmpty(this._schemaName))
				{
					return this._schemaName;
				}
				return this.ConstraintName;
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					this._schemaName = value;
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0002B784 File Offset: 0x00029984
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x0002B78C File Offset: 0x0002998C
		internal virtual bool InCollection
		{
			get
			{
				return this._inCollection;
			}
			set
			{
				this._inCollection = value;
				this._dataSet = (value ? this.Table.DataSet : null);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataTable" />, к которому применяется ограничение.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, к которому применяется ограничение.</returns>
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000A5F RID: 2655
		public abstract DataTable Table { get; }

		/// <summary>Возвращает коллекцию определенных пользователем свойств ограничений.</summary>
		/// <returns>Коллекция <see cref="T:System.Data.PropertyCollection" /> пользовательских сведений.</returns>
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0002B7AC File Offset: 0x000299AC
		[Browsable(false)]
		public PropertyCollection ExtendedProperties
		{
			get
			{
				PropertyCollection result;
				if ((result = this._extendedProperties) == null)
				{
					result = (this._extendedProperties = new PropertyCollection());
				}
				return result;
			}
		}

		// Token: 0x06000A61 RID: 2657
		internal abstract bool ContainsColumn(DataColumn column);

		// Token: 0x06000A62 RID: 2658
		internal abstract bool CanEnableConstraint();

		// Token: 0x06000A63 RID: 2659
		internal abstract Constraint Clone(DataSet destination);

		// Token: 0x06000A64 RID: 2660
		internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002B7D1 File Offset: 0x000299D1
		internal void CheckConstraint()
		{
			if (!this.CanEnableConstraint())
			{
				throw ExceptionBuilder.ConstraintViolation(this.ConstraintName);
			}
		}

		// Token: 0x06000A66 RID: 2662
		internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

		// Token: 0x06000A67 RID: 2663
		internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

		// Token: 0x06000A68 RID: 2664
		internal abstract void CheckConstraint(DataRow row, DataRowAction action);

		// Token: 0x06000A69 RID: 2665
		internal abstract void CheckState();

		/// <summary>Возвращает объект <see cref="T:System.Data.DataSet" />, которому принадлежит данное ограничение.</summary>
		// Token: 0x06000A6A RID: 2666 RVA: 0x0002B7E8 File Offset: 0x000299E8
		protected void CheckStateForProperty()
		{
			try
			{
				this.CheckState();
			}
			catch (Exception ex) when (ADP.IsCatchableExceptionType(ex))
			{
				throw ExceptionBuilder.BadObjectPropertyAccess(ex.Message);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataSet" />, которому принадлежит данное ограничение.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataSet" />, которому принадлежит данное ограничение.</returns>
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002B834 File Offset: 0x00029A34
		[CLSCompliant(false)]
		protected virtual DataSet _DataSet
		{
			get
			{
				return this._dataSet;
			}
		}

		/// <summary>Задает объект <see cref="T:System.Data.DataSet" /> ограничения.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" />, которому принадлежит данное ограничение.</param>
		// Token: 0x06000A6C RID: 2668 RVA: 0x0002B83C File Offset: 0x00029A3C
		protected internal void SetDataSet(DataSet dataSet)
		{
			this._dataSet = dataSet;
		}

		// Token: 0x06000A6D RID: 2669
		internal abstract bool IsConstraintViolated();

		/// <summary>Возвращает свойство <see cref="P:System.Data.Constraint.ConstraintName" />, если оно существует, в виде строки.</summary>
		/// <returns>Строковое значение свойства <see cref="P:System.Data.Constraint.ConstraintName" />.</returns>
		// Token: 0x06000A6E RID: 2670 RVA: 0x0002B845 File Offset: 0x00029A45
		public override string ToString()
		{
			return this.ConstraintName;
		}

		// Token: 0x0400077D RID: 1917
		private string _schemaName = string.Empty;

		// Token: 0x0400077E RID: 1918
		private bool _inCollection;

		// Token: 0x0400077F RID: 1919
		private DataSet _dataSet;

		// Token: 0x04000780 RID: 1920
		internal string _name = string.Empty;

		// Token: 0x04000781 RID: 1921
		internal PropertyCollection _extendedProperties;
	}
}
