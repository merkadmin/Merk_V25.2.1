USE [master]
RESTORE DATABASE [MerkFinance] FROM 
	DISK = N'D:\01_Programming_Work\01_Personal\Merk-V25.1.0\DBScript\Backup Files\MerkFinance-2024021701.bak' WITH FILE = 1,
	MOVE N'MerkFinance' TO N'D:\01_Programming_Work\01_Personal\00_Databases\MerkFinance.mdf',
	MOVE N'MerkFinance_log' TO N'D:\01_Programming_Work\01_Personal\00_Databases\MerkFinance.ldf',
	NOUNLOAD, REPLACE,  STATS = 5
GO