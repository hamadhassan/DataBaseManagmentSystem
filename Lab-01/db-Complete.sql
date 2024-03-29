USE [TestDB_2021-CS-33]
GO
/****** Object:  Table [dbo].[tbPersonalInfo]    Script Date: 1/17/2023 4:43:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbPersonalInfo](
	[Roll Number] [varchar](12) NOT NULL,
	[Name] [varchar](50) NULL,
	[Gender] [varchar](6) NULL,
	[Date of Birth] [datetime] NULL,
	[Section] [varchar](max) NULL,
	[Major] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[tbPersonalInfo] ([Roll Number], [Name], [Gender], [Date of Birth], [Section], [Major]) VALUES (N'2021-CS-33', N'Muhammad Hamad Hassan', N'Male', CAST(N'2001-09-16T00:00:00.000' AS DateTime), N'A', N'Computer Science ')
INSERT [dbo].[tbPersonalInfo] ([Roll Number], [Name], [Gender], [Date of Birth], [Section], [Major]) VALUES (N'2021-CS-04', N'Kabir Ahmed', N'Male', CAST(N'2001-09-16T00:00:00.000' AS DateTime), N'A', N'Computer Science ')
INSERT [dbo].[tbPersonalInfo] ([Roll Number], [Name], [Gender], [Date of Birth], [Section], [Major]) VALUES (N'2021-CS-01', N'Syed Hashir Hasnain', N'Male', CAST(N'2001-09-16T00:00:00.000' AS DateTime), N'A', N'Computer Science ')
GO
