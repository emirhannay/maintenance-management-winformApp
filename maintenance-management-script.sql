USE [MaintenanceManagement]
GO
/****** Object:  Table [dbo].[Machine]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MachineFault]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MachineFault](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MachineId] [int] NOT NULL,
	[Priority] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[BeginDate] [datetime] NOT NULL,
	[Explanation] [nvarchar](255) NOT NULL,
	[isStopped] [bit] NOT NULL,
	[Creator] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Maintenance]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Maintenance](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MachineId] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[Explanation] [nvarchar](255) NOT NULL,
	[PartUsed] [nvarchar](100) NULL,
	[PlannedDate] [datetime] NULL,
	[BeginDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[MachineFaultId] [int] NULL,
	[CompletedBy] [int] NULL,
	[Creator] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintenanceMan]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintenanceMan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parameter]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parameter](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParamCode] [nvarchar](50) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
	[Value] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeamLeader]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamLeader](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Machine] ON 

INSERT [dbo].[Machine] ([Id], [Name]) VALUES (1, N'Machine-1')
INSERT [dbo].[Machine] ([Id], [Name]) VALUES (2, N'Machine-2')
INSERT [dbo].[Machine] ([Id], [Name]) VALUES (3, N'Machine-3')
INSERT [dbo].[Machine] ([Id], [Name]) VALUES (4, N'Machine-4')
INSERT [dbo].[Machine] ([Id], [Name]) VALUES (5, N'Machine-5')
SET IDENTITY_INSERT [dbo].[Machine] OFF
GO
SET IDENTITY_INSERT [dbo].[Parameter] ON 

INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (2, N'UserType', N'MaintenanceMan', 1)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (3, N'UserType', N'TEAMLEADER', 2)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (4, N'MachineFaultType', N'ELECTRICAL', 0)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (5, N'MachineFaultType', N'MECHANICAL', 1)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (7, N'MaintenanceManType', N'ELECTRICAL', 0)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (8, N'MaintenanceManType', N'MECHANICAL', 1)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (9, N'MachineFaultPriority', N'Düşük', 0)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (10, N'MachineFaultPriority', N'Orta', 1)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (11, N'MachineFaultPriority', N'Yüksek', 2)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (18, N'MaintenanceType', N'Arızi', 0)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (19, N'MaintenanceType', N'Planlı', 1)
INSERT [dbo].[Parameter] ([Id], [ParamCode], [Label], [Value]) VALUES (20, N'MaintenanceType', N'Periyodik', 2)
SET IDENTITY_INSERT [dbo].[Parameter] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__User__536C85E4C4BA265B]    Script Date: 27.12.2023 22:26:26 ******/
ALTER TABLE [dbo].[User] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MachineFault]  WITH CHECK ADD FOREIGN KEY([Creator])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[MachineFault]  WITH CHECK ADD FOREIGN KEY([MachineId])
REFERENCES [dbo].[Machine] ([Id])
GO
ALTER TABLE [dbo].[Maintenance]  WITH CHECK ADD FOREIGN KEY([CompletedBy])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Maintenance]  WITH CHECK ADD FOREIGN KEY([Creator])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[Maintenance]  WITH CHECK ADD FOREIGN KEY([MachineFaultId])
REFERENCES [dbo].[MachineFault] ([Id])
GO
ALTER TABLE [dbo].[Maintenance]  WITH CHECK ADD FOREIGN KEY([MachineId])
REFERENCES [dbo].[Machine] ([Id])
GO
ALTER TABLE [dbo].[MaintenanceMan]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
ALTER TABLE [dbo].[TeamLeader]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[AddMachineFault]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddMachineFault]
    @MachineId int,
	@Priority int,
	@Type int,
	@BeginDate DateTime,
	@Explanation nvarchar(255),
	@IsStopped bit,
	@Creator int
AS
BEGIN
	INSERT INTO MachineFault(MachineId, [Priority], [Type], BeginDate, Explanation,isStopped,Creator) VALUES (@MachineId,@Priority,@Type,@BeginDate,@Explanation,@IsStopped,@Creator)
END
GO
/****** Object:  StoredProcedure [dbo].[AddMaintenance]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddMaintenance]
    @MachineId int,
	@Type int = NULL,
	@Explanation nvarchar(255),
	@PartUsed nvarchar(255) = NULL,
	@PlannedDate DateTime = NULL,
	@BeginDate DateTime = NULL,
	@EndDate DateTime = NULL,
	@MachineFaultId int = NULL,
	@Creator int
AS
BEGIN
	IF @MachineFaultId IS NOT NULL AND @BeginDate IS NOT NULL AND @EndDate IS NOT NULL AND @MachineFaultId IS NOT NULL AND @PartUsed IS NOT NULL
	BEGIN
		INSERT INTO Maintenance (MachineId, [Type], [Explanation], PartUsed, BeginDate, EndDate, MachineFaultId,Creator) VALUES (@MachineId, 0 ,@Explanation,@PartUsed,@BeginDate,@EndDate,@MachineFaultId, @Creator)
	END

	ELSE IF @PlannedDate IS NOT NULL AND @MachineId IS NOT NULL AND @Type IS NOT NULL AND @Explanation IS NOT NULL
	BEGIN
	INSERT INTO Maintenance (MachineId, [Type], [Explanation], PlannedDate, Creator) VALUES (@MachineId,@Type,@Explanation,@PlannedDate, @Creator)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[AddUser]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE PROCEDURE [dbo].[AddUser]
		@Name NVARCHAR(100),
		@Username NVARCHAR(50),
		@Password NVARCHAR(50),
		@Type INT,
		@MaintenanceManType INT = NULL
	AS
	BEGIN
		IF @Type = 0
		BEGIN
			INSERT INTO [User] ([Name], Username, [Password], [Type])
			VALUES (@Name, @Username, @Password, @Type);
		
		END

		ELSE IF @Type = 1
		BEGIN
			DECLARE @UserId1 INT

			INSERT INTO [User] ([Name], Username, [Password], [Type])
			VALUES (@Name, @Username, @Password, @Type)

			SET @UserId1 = SCOPE_IDENTITY()

			INSERT INTO MaintenanceMan (UserId, Type)
			VALUES (@UserId1, @MaintenanceManType)
		END

		ELSE IF @Type = 2
		BEGIN
			DECLARE @UserId2 INT

			INSERT INTO [User] ([Name], Username, [Password], [Type])
			VALUES (@Name, @Username, @Password, @Type)

			SET @UserId2 = SCOPE_IDENTITY()

			INSERT INTO TeamLeader(UserId) VALUES (@UserId2)
	     END

		 END
GO
/****** Object:  StoredProcedure [dbo].[CompleteEditMaintenance]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CompleteEditMaintenance]
    @MaintenanceId INT,
    @Explanation nvarchar(255) = NULL,
    @PartUsed nvarchar(100) = NULL,
    @BeginDate DATETIME = NULL,
    @EndDate DATETIME = NULL,
    @CompletedBy int = NULL
AS
BEGIN
    IF @MaintenanceId IS NOT NULL
    BEGIN
        UPDATE Maintenance
        SET 
            Explanation = CASE WHEN @Explanation IS NOT NULL THEN @Explanation ELSE Explanation END,
            PartUsed = CASE WHEN @PartUsed IS NOT NULL THEN @PartUsed ELSE PartUsed END,
            BeginDate = CASE WHEN @BeginDate IS NOT NULL THEN @BeginDate ELSE BeginDate END,
            EndDate = CASE WHEN @EndDate IS NOT NULL THEN @EndDate ELSE EndDate END,
            CompletedBy = CASE WHEN @CompletedBy IS NOT NULL THEN @CompletedBy ELSE CompletedBy END
        WHERE 
            Id = @MaintenanceId
    END

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteMachineFaultById]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteMachineFaultById]
		@id INT
	AS
	BEGIN
				DELETE FROM Maintenance  WHERE MachineFaultId = @id
				DELETE FROM MachineFault Where Id = @id			
	END
GO
/****** Object:  StoredProcedure [dbo].[GetActiveMachineFaults]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetActiveMachineFaults]
AS
BEGIN
 SELECT 
    mf.Id,
    mc.[Name] AS MachineName,
    mc.Id AS MachineId,
    mf.BeginDate,
	u.[Name] AS Creator,
    p1.[Label] AS FaultTypeLabel,
    p2.[Label] AS FaultPriorityLabel,
	p1.[Value] AS FaultTypeValue,
	p2.[Value] AS FaultPriorityValue,
    mf.Explanation,
	mf.isStopped
FROM 
    MachineFault AS mf 
INNER JOIN 
    Parameter AS p1 ON mf.[Type] = p1.[Value] AND p1.ParamCode = 'MachineFaultType'
INNER JOIN 
    Parameter AS p2 ON mf.[Priority] = p2.[Value] AND p2.ParamCode = 'MachineFaultPriority'
INNER JOIN 
    Machine AS mc ON mc.Id = mf.MachineId
INNER JOIN 
    [USER] AS u ON u.Id = mf.Creator
LEFT JOIN Maintenance ON Maintenance.MachineFaultId = mf.Id
WHERE 
    Maintenance.EndDate IS NULL
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllMachineFaults]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllMachineFaults]
AS
BEGIN
 SELECT 
    mf.Id,
    mc.[Name] AS MachineName,
    mc.Id AS MachineId,
    mf.BeginDate,
	Maintenance.EndDate,
	u.[Name] AS Creator,
    p1.[Label] AS FaultTypeLabel,
    p2.[Label] AS FaultPriorityLabel,
	p1.[Value] AS FaultTypeValue,
	p2.[Value] AS FaultPriorityValue,
    mf.Explanation,
	mf.isStopped
FROM 
    MachineFault AS mf 
INNER JOIN 
    Parameter AS p1 ON mf.[Type] = p1.[Value] AND p1.ParamCode = 'MachineFaultType'
INNER JOIN 
    Parameter AS p2 ON mf.[Priority] = p2.[Value] AND p2.ParamCode = 'MachineFaultPriority'
INNER JOIN 
    Machine AS mc ON mc.Id = mf.MachineId
INNER JOIN 
    [USER] AS u ON u.Id = mf.Creator
LEFT JOIN Maintenance ON Maintenance.MachineFaultId = mf.Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetCompletedMachineFaultsAccordingToMachine]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetCompletedMachineFaultsAccordingToMachine]
	@MachineId int,
    @DateTimeBegin DATETIME,
    @DateTimeEnd DATETIME
AS
BEGIN

SELECT mf.Id,mf.MachineId,m.Name,p1.Label AS FaultPriorityLabel,p2.Label AS FaultTypeLabel,mf.BeginDate,
mf.Explanation,mf.isStopped,u.Name AS UserName,maint.Explanation AS Solution, DATEDIFF(HOUR,maint.BeginDate,maint.EndDate) AS SolutionTime FROM MachineFault AS mf 
INNER JOIN Parameter AS p1 ON p1.Value = mf.Priority AND p1.ParamCode = 'MachineFaultPriority'
INNER JOIN Parameter AS p2 ON p2.Value = mf.Type AND p2.ParamCode = 'MachineFaultType'
INNER JOIN Machine AS m ON m.Id = mf.MachineId
INNER JOIN [User] AS u ON u.Id = mf.Creator
INNER JOIN Maintenance AS maint ON maint.MachineFaultId = mf.Id
WHERE mf.MachineId = @MachineId AND  CAST(maint.EndDate AS DATE) BETWEEN CAST(@DateTimeBegin AS DATE) AND CAST(@DateTimeEnd AS DATE)

END
GO
/****** Object:  StoredProcedure [dbo].[GetCompletedMaintenancesAccordingToMachine]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCompletedMaintenancesAccordingToMachine]
    @MachineId int,
    @DateTimeBegin DATETIME,
    @DateTimeEnd DATETIME
AS
BEGIN
    SELECT 
        Mac.Id AS MachineId,
        Main.Id AS MaintenanceId,
        Mac.Name,
        p.Label,
        Main.Explanation,
        Main.PartUsed,
        Main.PlannedDate,
        Main.BeginDate,
        Main.EndDate,
        u.Id AS UserId,
        u.Name AS CompletedBy
    FROM 
        Machine AS Mac
    INNER JOIN 
        Maintenance AS Main ON Main.MachineId = Mac.Id
    INNER JOIN 
        Parameter AS p ON p.Value = main.Type
    INNER JOIN 
        [User] AS u ON u.Id = main.CompletedBy 
    WHERE 
        p.ParamCode = 'MaintenanceType'
        AND CAST(Main.EndDate AS DATE) BETWEEN CAST(@DateTimeBegin AS DATE) AND CAST(@DateTimeEnd AS DATE)
        AND Mac.Id = @MachineId
END
GO
/****** Object:  StoredProcedure [dbo].[GetMachineFault]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMachineFault]
		@Id int
AS
BEGIN
	SELECT * FROM MachineFault WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[GetMachineFaultPriority]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMachineFaultPriority]
AS
BEGIN
	SELECT [Value],[Label] FROM Parameter WHERE ParamCode = 'MachineFaultPriority'
END
GO
/****** Object:  StoredProcedure [dbo].[GetMachineFaultType]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMachineFaultType]
AS
BEGIN
	SELECT [Value],[Label] FROM Parameter WHERE ParamCode = 'MachineFaultType'
END
GO
/****** Object:  StoredProcedure [dbo].[GetMachines]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMachines]
AS
BEGIN
	SELECT * FROM Machine
END
GO
/****** Object:  StoredProcedure [dbo].[GetMaintenanceManTypes]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMaintenanceManTypes]
	AS
	BEGIN
	SELECT * FROM Parameter WHERE ParamCode = 'MaintenanceManType'
	END
GO
/****** Object:  StoredProcedure [dbo].[GetMaintenanceType]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMaintenanceType]
AS
BEGIN
	SELECT [Value],[Label] FROM Parameter WHERE ParamCode = 'MaintenanceType'
END
GO
/****** Object:  StoredProcedure [dbo].[GetMaintenanceWithMachineNameAndType]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetMaintenanceWithMachineNameAndType]
AS
BEGIN
	 SELECT Machine.Name As MachineName, Main.*,p.Label  FROM Maintenance AS Main INNER JOIN Machine ON Machine.Id = Main.MachineId INNER JOIN Parameter AS p ON p.Value = Main.Type  WHERE P.ParamCode ='MaintenanceType' AND Main.PlannedDate IS NOT NULL AND Main.EndDate IS NULL AND Main.[Type] != 0
END
GO
/****** Object:  StoredProcedure [dbo].[GetUpcomingMaintenances]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUpcomingMaintenances]
		
AS
BEGIN
	SELECT 
    Machine.Id,
    Machine.Name,
    DATEDIFF(day, SYSDATETIME(), PlannedDate) AS RemainingDays,
    DATEDIFF(hour, SYSDATETIME(), PlannedDate) AS RemainingHours,
    DATEDIFF(MINUTE, SYSDATETIME(), PlannedDate) AS RemainingMinutes,
    Maintenance.PlannedDate,
	Maintenance.Explanation,
	Parameter.Label
	
FROM 
    Maintenance 
INNER JOIN 
    Machine ON Machine.Id = Maintenance.MachineId 
INNER JOIN Parameter ON Parameter.Value = Maintenance.Type
WHERE 
    PlannedDate IS NOT NULL 
    AND (
        (DATEDIFF(SECOND, SYSDATETIME(), PlannedDate) >= 0) 
		AND (DATEDIFF(DAY, SYSDATETIME(), PlannedDate) <= 7) 
        AND (Maintenance.Type = 1 OR Maintenance.Type = 2)
		AND Parameter.ParamCode = 'MaintenanceType'
    )
END
GO
/****** Object:  StoredProcedure [dbo].[GetUser]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUser]
    @Username NVARCHAR(50)   
AS
BEGIN
    SELECT * FROM [User] WHERE
    Username = @Username 
END
GO
/****** Object:  StoredProcedure [dbo].[GetUserTypes]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUserTypes]
	AS
	BEGIN
	SELECT * FROM Parameter WHERE ParamCode = 'UserType'
	END
GO
/****** Object:  StoredProcedure [dbo].[GetUserWithTypeName]    Script Date: 27.12.2023 22:26:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUserWithTypeName]
    @Username NVARCHAR(50)   
AS
BEGIN
    SELECT u.Id,u.[Name],u.Username,u.[Password],u.[Type], p.[Label] AS TypeName
	FROM [User] AS u
	INNER JOIN Parameter AS p
	ON u.[Type] = p.[Value]
	WHERE Username = @Username
	AND p.ParamCode = 'UserType'
END
GO
