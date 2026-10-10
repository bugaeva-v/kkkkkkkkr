using System;

namespace Microsoft.SqlServer.Server
{
	/// <summary>Перечисление <see cref="T:Microsoft.SqlServer.Server.TriggerAction" /> используется классом <see cref="T:Microsoft.SqlServer.Server.SqlTriggerContext" /> для обозначения действия, вызвавшего срабатывание триггера.</summary>
	// Token: 0x02000061 RID: 97
	public enum TriggerAction
	{
		/// <summary>Произошло недопустимое действие триггера, не показанное пользователю.</summary>
		// Token: 0x040005C8 RID: 1480
		Invalid,
		/// <summary>Был выполнен оператор Transact-SQL INSERT.</summary>
		// Token: 0x040005C9 RID: 1481
		Insert,
		/// <summary>Был выполнен оператор Transact-SQL UPDATE.</summary>
		// Token: 0x040005CA RID: 1482
		Update,
		/// <summary>Был выполнен оператор Transact-SQL DELETE.</summary>
		// Token: 0x040005CB RID: 1483
		Delete,
		/// <summary>Был выполнен оператор Transact-SQL CREATE TABLE.</summary>
		// Token: 0x040005CC RID: 1484
		CreateTable = 21,
		/// <summary>Был выполнен оператор Transact-SQL ALTER TABLE.</summary>
		// Token: 0x040005CD RID: 1485
		AlterTable,
		/// <summary>Был выполнен оператор Transact-SQL DROP TABLE.</summary>
		// Token: 0x040005CE RID: 1486
		DropTable,
		/// <summary>Был выполнен оператор Transact-SQL CREATE INDEX.</summary>
		// Token: 0x040005CF RID: 1487
		CreateIndex,
		/// <summary>Был выполнен оператор Transact-SQL ALTER INDEX.</summary>
		// Token: 0x040005D0 RID: 1488
		AlterIndex,
		/// <summary>Был выполнен оператор Transact-SQL DROP INDEX.</summary>
		// Token: 0x040005D1 RID: 1489
		DropIndex,
		/// <summary>Был выполнен оператор Transact-SQL CREATE SYNONYM.</summary>
		// Token: 0x040005D2 RID: 1490
		CreateSynonym = 34,
		/// <summary>Был выполнен оператор Transact-SQL DROP SYNONYM.</summary>
		// Token: 0x040005D3 RID: 1491
		DropSynonym = 36,
		/// <summary>Недоступно.</summary>
		// Token: 0x040005D4 RID: 1492
		CreateSecurityExpression = 31,
		/// <summary>Недоступно.</summary>
		// Token: 0x040005D5 RID: 1493
		DropSecurityExpression = 33,
		/// <summary>Был выполнен оператор Transact-SQL CREATE VIEW.</summary>
		// Token: 0x040005D6 RID: 1494
		CreateView = 41,
		/// <summary>Был выполнен оператор Transact-SQL ALTER VIEW.</summary>
		// Token: 0x040005D7 RID: 1495
		AlterView,
		/// <summary>Был выполнен оператор Transact-SQL DROP VIEW.</summary>
		// Token: 0x040005D8 RID: 1496
		DropView,
		/// <summary>Был выполнен оператор Transact-SQL CREATE PROCEDURE.</summary>
		// Token: 0x040005D9 RID: 1497
		CreateProcedure = 51,
		/// <summary>Был выполнен оператор Transact-SQL ALTER PROCEDURE.</summary>
		// Token: 0x040005DA RID: 1498
		AlterProcedure,
		/// <summary>Был выполнен оператор Transact-SQL DROP PROCEDURE.</summary>
		// Token: 0x040005DB RID: 1499
		DropProcedure,
		/// <summary>Был выполнен оператор Transact-SQL CREATE FUNCTION.</summary>
		// Token: 0x040005DC RID: 1500
		CreateFunction = 61,
		/// <summary>Был выполнен оператор Transact-SQL ALTER FUNCTION.</summary>
		// Token: 0x040005DD RID: 1501
		AlterFunction,
		/// <summary>Был выполнен оператор Transact-SQL DROP FUNCTION.</summary>
		// Token: 0x040005DE RID: 1502
		DropFunction,
		/// <summary>Был выполнен оператор Transact-SQL CREATE TRIGGER.</summary>
		// Token: 0x040005DF RID: 1503
		CreateTrigger = 71,
		/// <summary>Был выполнен оператор Transact-SQL ALTER TRIGGER.</summary>
		// Token: 0x040005E0 RID: 1504
		AlterTrigger,
		/// <summary>Был выполнен оператор Transact-SQL DROP TRIGGER.</summary>
		// Token: 0x040005E1 RID: 1505
		DropTrigger,
		/// <summary>Был выполнен оператор Transact-SQL CREATE EVENT NOTIFICATION.</summary>
		// Token: 0x040005E2 RID: 1506
		CreateEventNotification,
		/// <summary>Был выполнен оператор Transact-SQL DROP EVENT NOTIFICATION.</summary>
		// Token: 0x040005E3 RID: 1507
		DropEventNotification = 76,
		/// <summary>Был выполнен оператор Transact-SQL CREATE TYPE.</summary>
		// Token: 0x040005E4 RID: 1508
		CreateType = 91,
		/// <summary>Был выполнен оператор Transact-SQL DROP TYPE.</summary>
		// Token: 0x040005E5 RID: 1509
		DropType = 93,
		/// <summary>Был выполнен оператор Transact-SQL CREATE ASSEMBLY.</summary>
		// Token: 0x040005E6 RID: 1510
		CreateAssembly = 101,
		/// <summary>Был выполнен оператор Transact-SQL ALTER APPLICATION ROLE.</summary>
		// Token: 0x040005E7 RID: 1511
		AlterAssembly,
		/// <summary>Был выполнен оператор Transact-SQL DROP ASSEMBLY.</summary>
		// Token: 0x040005E8 RID: 1512
		DropAssembly,
		/// <summary>Был выполнен оператор Transact-SQL CREATE USER.</summary>
		// Token: 0x040005E9 RID: 1513
		CreateUser = 131,
		/// <summary>Был выполнен оператор Transact-SQL ALTER USER.</summary>
		// Token: 0x040005EA RID: 1514
		AlterUser,
		/// <summary>Был выполнен оператор Transact-SQL DROP USER.</summary>
		// Token: 0x040005EB RID: 1515
		DropUser,
		/// <summary>Был выполнен оператор Transact-SQL CREATE ROLE.</summary>
		// Token: 0x040005EC RID: 1516
		CreateRole,
		/// <summary>Был выполнен оператор Transact-SQL ALTER ROLE.</summary>
		// Token: 0x040005ED RID: 1517
		AlterRole,
		/// <summary>Был выполнен оператор Transact-SQL DROP ROLE.</summary>
		// Token: 0x040005EE RID: 1518
		DropRole,
		/// <summary>Был выполнен оператор Transact-SQL CREATE APPLICATION ROLE.</summary>
		// Token: 0x040005EF RID: 1519
		CreateAppRole,
		/// <summary>Был выполнен оператор Transact-SQL ALTER APPLICATION ROLE.</summary>
		// Token: 0x040005F0 RID: 1520
		AlterAppRole,
		/// <summary>Был выполнен оператор Transact-SQL DROP APPLICATION ROLE.</summary>
		// Token: 0x040005F1 RID: 1521
		DropAppRole,
		/// <summary>Был выполнен оператор Transact-SQL CREATE SCHEMA.</summary>
		// Token: 0x040005F2 RID: 1522
		CreateSchema = 141,
		/// <summary>Был выполнен оператор Transact-SQL ALTER SCHEMA.</summary>
		// Token: 0x040005F3 RID: 1523
		AlterSchema,
		/// <summary>Был выполнен оператор Transact-SQL DROP SCHEMA.</summary>
		// Token: 0x040005F4 RID: 1524
		DropSchema,
		/// <summary>Был выполнен оператор Transact-SQL CREATE LOGIN.</summary>
		// Token: 0x040005F5 RID: 1525
		CreateLogin,
		/// <summary>Был выполнен оператор Transact-SQL ALTER LOGIN.</summary>
		// Token: 0x040005F6 RID: 1526
		AlterLogin,
		/// <summary>Был выполнен оператор Transact-SQL DROP LOGIN.</summary>
		// Token: 0x040005F7 RID: 1527
		DropLogin,
		/// <summary>Был выполнен оператор Transact-SQL CREATE MESSAGE TYPE.</summary>
		// Token: 0x040005F8 RID: 1528
		CreateMsgType = 151,
		/// <summary>Был выполнен оператор Transact-SQL DROP MESSAGE TYPE.</summary>
		// Token: 0x040005F9 RID: 1529
		DropMsgType = 153,
		/// <summary>Был выполнен оператор Transact-SQL CREATE CONTRACT.</summary>
		// Token: 0x040005FA RID: 1530
		CreateContract,
		/// <summary>Был выполнен оператор Transact-SQL DROP CONTRACT.</summary>
		// Token: 0x040005FB RID: 1531
		DropContract = 156,
		/// <summary>Был выполнен оператор Transact-SQL CREATE QUEUE.</summary>
		// Token: 0x040005FC RID: 1532
		CreateQueue,
		/// <summary>Был выполнен оператор Transact-SQL ALTER QUEUE.</summary>
		// Token: 0x040005FD RID: 1533
		AlterQueue,
		/// <summary>Был выполнен оператор Transact-SQL DROP QUEUE.</summary>
		// Token: 0x040005FE RID: 1534
		DropQueue,
		/// <summary>Был выполнен оператор Transact-SQL CREATE SERVICE.</summary>
		// Token: 0x040005FF RID: 1535
		CreateService = 161,
		/// <summary>Был выполнен оператор Transact-SQL ALTER SERVICE.</summary>
		// Token: 0x04000600 RID: 1536
		AlterService,
		/// <summary>Был выполнен оператор Transact-SQL DROP SERVICE.</summary>
		// Token: 0x04000601 RID: 1537
		DropService,
		/// <summary>Был выполнен оператор Transact-SQL CREATE ROUTE.</summary>
		// Token: 0x04000602 RID: 1538
		CreateRoute,
		/// <summary>Был выполнен оператор Transact-SQL ALTER ROUTE.</summary>
		// Token: 0x04000603 RID: 1539
		AlterRoute,
		/// <summary>Был выполнен оператор Transact-SQL DROP ROUTE.</summary>
		// Token: 0x04000604 RID: 1540
		DropRoute,
		/// <summary>Был выполнен оператор Transact-SQL GRANT.</summary>
		// Token: 0x04000605 RID: 1541
		GrantStatement,
		/// <summary>Был выполнен оператор Transact-SQL DENY.</summary>
		// Token: 0x04000606 RID: 1542
		DenyStatement,
		/// <summary>Был выполнен оператор Transact-SQL REVOKE.</summary>
		// Token: 0x04000607 RID: 1543
		RevokeStatement,
		/// <summary>Был выполнен оператор Transact-SQL GRANT OBJECT.</summary>
		// Token: 0x04000608 RID: 1544
		GrantObject,
		/// <summary>Был выполнен оператор Transact-SQL DENY для разрешений на доступ к объекту.</summary>
		// Token: 0x04000609 RID: 1545
		DenyObject,
		/// <summary>Был выполнен оператор Transact-SQL REVOKE OBJECT.</summary>
		// Token: 0x0400060A RID: 1546
		RevokeObject,
		/// <summary>При создании уведомления о событии в базе данных или экземпляре сервера был указан тип события CREATE_REMOTE_SERVICE_BINDING.</summary>
		// Token: 0x0400060B RID: 1547
		CreateBinding = 174,
		/// <summary>При создании уведомления о событии в базе данных или экземпляре сервера был указан тип события ALTER_REMOTE_SERVICE_BINDING.</summary>
		// Token: 0x0400060C RID: 1548
		AlterBinding,
		/// <summary>При создании уведомления о событии в базе данных или экземпляре сервера был указан тип события DROP_REMOTE_SERVICE_BINDING.</summary>
		// Token: 0x0400060D RID: 1549
		DropBinding,
		/// <summary>Был выполнен оператор Transact-SQL CREATE PARTITION FUNCTION.</summary>
		// Token: 0x0400060E RID: 1550
		CreatePartitionFunction = 191,
		/// <summary>Был выполнен оператор Transact-SQL ALTER PARTITION FUNCTION.</summary>
		// Token: 0x0400060F RID: 1551
		AlterPartitionFunction,
		/// <summary>Был выполнен оператор Transact-SQL DROP PARTITION FUNCTION.</summary>
		// Token: 0x04000610 RID: 1552
		DropPartitionFunction,
		/// <summary>Был выполнен оператор Transact-SQL CREATE PARTITION SCHEME.</summary>
		// Token: 0x04000611 RID: 1553
		CreatePartitionScheme,
		/// <summary>Был выполнен оператор Transact-SQL ALTER PARTITION SCHEME.</summary>
		// Token: 0x04000612 RID: 1554
		AlterPartitionScheme,
		/// <summary>Был выполнен оператор Transact-SQL DROP PARTITION SCHEME.</summary>
		// Token: 0x04000613 RID: 1555
		DropPartitionScheme
	}
}
