USE [FutureTechBizsoftLLP]
GO
/****** Object:  StoredProcedure [dbo].[uspgetsalary]    Script Date: 09-02-2022 16:02:11 ******/
DROP PROCEDURE [dbo].[uspgetsalary]
GO
/****** Object:  StoredProcedure [dbo].[uspgetemployeereport]    Script Date: 09-02-2022 16:02:11 ******/
DROP PROCEDURE [dbo].[uspgetemployeereport]
GO
/****** Object:  StoredProcedure [dbo].[uspgetemployeelist]    Script Date: 09-02-2022 16:02:11 ******/
DROP PROCEDURE [dbo].[uspgetemployeelist]
GO
/****** Object:  StoredProcedure [dbo].[uspgetemployeedepreport]    Script Date: 09-02-2022 16:02:11 ******/
DROP PROCEDURE [dbo].[uspgetemployeedepreport]
GO
/****** Object:  Table [dbo].[Emp_Salary_Tbl]    Script Date: 09-02-2022 16:02:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Emp_Salary_Tbl]') AND type in (N'U'))
DROP TABLE [dbo].[Emp_Salary_Tbl]
GO
/****** Object:  Table [dbo].[Emp_Mas_Tbl]    Script Date: 09-02-2022 16:02:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Emp_Mas_Tbl]') AND type in (N'U'))
DROP TABLE [dbo].[Emp_Mas_Tbl]
GO
/****** Object:  Table [dbo].[Dept_Mas_Tbl]    Script Date: 09-02-2022 16:02:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Dept_Mas_Tbl]') AND type in (N'U'))
DROP TABLE [dbo].[Dept_Mas_Tbl]
GO
/****** Object:  Table [dbo].[City_Mas_Tbl]    Script Date: 09-02-2022 16:02:11 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[City_Mas_Tbl]') AND type in (N'U'))
DROP TABLE [dbo].[City_Mas_Tbl]
GO
/****** Object:  Table [dbo].[City_Mas_Tbl]    Script Date: 09-02-2022 16:02:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City_Mas_Tbl](
	[CITY_CODE] [int] IDENTITY(1,1) NOT NULL,
	[CITY_NAME] [nvarchar](50) NOT NULL,
	[STATE_NAME] [nvarchar](50) NOT NULL,
	[COUNRTY_NAME] [nvarchar](50) NOT NULL,
	[SORT_NO] [int] NOT NULL,
 CONSTRAINT [PK_City_Mas_Tbl] PRIMARY KEY CLUSTERED 
(
	[CITY_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dept_Mas_Tbl]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dept_Mas_Tbl](
	[DEPT_CODE] [int] IDENTITY(1,1) NOT NULL,
	[DEPT_NAME] [nvarchar](50) NOT NULL,
	[SORT_NO] [int] NOT NULL,
 CONSTRAINT [PK_Dept_Mas_Tbl] PRIMARY KEY CLUSTERED 
(
	[DEPT_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp_Mas_Tbl]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_Mas_Tbl](
	[EMP_CODE] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [nvarchar](50) NOT NULL,
	[MIDDLE_NAME] [nvarchar](50) NOT NULL,
	[LAST_NAME] [nvarchar](50) NOT NULL,
	[FULL_NAME] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[JOIN_DATE] [date] NOT NULL,
	[CITY_CODE] [int] NOT NULL,
	[DEPT_CODE] [int] NOT NULL,
 CONSTRAINT [PK_Emp_Mas_Tbl] PRIMARY KEY CLUSTERED 
(
	[EMP_CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Emp_Salary_Tbl]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Emp_Salary_Tbl](
	[SEQ_NO] [int] IDENTITY(1,1) NOT NULL,
	[EMP_CODE] [int] NOT NULL,
	[MONTH] [nvarchar](50) NOT NULL,
	[SALARY] [int] NOT NULL,
	[COMMENTS] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Emp_Salary_Tbl] PRIMARY KEY CLUSTERED 
(
	[SEQ_NO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[City_Mas_Tbl] ON 

INSERT [dbo].[City_Mas_Tbl] ([CITY_CODE], [CITY_NAME], [STATE_NAME], [COUNRTY_NAME], [SORT_NO]) VALUES (1, N'Nagpur', N'maharashtra', N'india', 1)
INSERT [dbo].[City_Mas_Tbl] ([CITY_CODE], [CITY_NAME], [STATE_NAME], [COUNRTY_NAME], [SORT_NO]) VALUES (2, N'Pune', N'maharashtra', N'india', 2)
INSERT [dbo].[City_Mas_Tbl] ([CITY_CODE], [CITY_NAME], [STATE_NAME], [COUNRTY_NAME], [SORT_NO]) VALUES (3, N'mumbai', N'maharashtra', N'india', 3)
INSERT [dbo].[City_Mas_Tbl] ([CITY_CODE], [CITY_NAME], [STATE_NAME], [COUNRTY_NAME], [SORT_NO]) VALUES (4, N'hydrabad', N'telengana', N'india', 4)
INSERT [dbo].[City_Mas_Tbl] ([CITY_CODE], [CITY_NAME], [STATE_NAME], [COUNRTY_NAME], [SORT_NO]) VALUES (5, N'amerpet', N'telangana', N'india', 5)
SET IDENTITY_INSERT [dbo].[City_Mas_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Dept_Mas_Tbl] ON 

INSERT [dbo].[Dept_Mas_Tbl] ([DEPT_CODE], [DEPT_NAME], [SORT_NO]) VALUES (1, N'HR', 1)
INSERT [dbo].[Dept_Mas_Tbl] ([DEPT_CODE], [DEPT_NAME], [SORT_NO]) VALUES (2, N'Admin', 2)
INSERT [dbo].[Dept_Mas_Tbl] ([DEPT_CODE], [DEPT_NAME], [SORT_NO]) VALUES (4, N'Account', 3)
SET IDENTITY_INSERT [dbo].[Dept_Mas_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Emp_Mas_Tbl] ON 

INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (1, N'Riya', N'Avinash', N'Kamble', N'Riya Kamble', CAST(N'1998-06-20' AS Date), CAST(N'2022-02-04' AS Date), 2, 2)
INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (2, N'krutika', N'ramdas', N'wase', N'krutika wase', CAST(N'1997-01-15' AS Date), CAST(N'2022-02-10' AS Date), 1, 1)
INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (3, N'jayshree', N'ajay', N'hadke', N'jayshree hadke', CAST(N'1997-10-10' AS Date), CAST(N'2022-02-01' AS Date), 0, 0)
INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (4, N'SDFGH', N'FGTH', N'RGHT', N'WEGHU', CAST(N'2022-02-25' AS Date), CAST(N'2022-02-02' AS Date), 0, 0)
INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (5, N'pallavi', N'raaj', N'panchal', N'pallavi panchal', CAST(N'1995-07-31' AS Date), CAST(N'2022-02-01' AS Date), 2, 2)
INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (6, N'varsha', N'suresh', N'bokde', N'varsha bokde', CAST(N'1998-02-12' AS Date), CAST(N'2022-02-02' AS Date), 4, 2)
INSERT [dbo].[Emp_Mas_Tbl] ([EMP_CODE], [FIRST_NAME], [MIDDLE_NAME], [LAST_NAME], [FULL_NAME], [DOB], [JOIN_DATE], [CITY_CODE], [DEPT_CODE]) VALUES (7, N'Mayur', N'sahebdas', N'parate', N'Mayur sahebdas parate', CAST(N'2000-03-16' AS Date), CAST(N'2022-02-26' AS Date), 4, 2)
SET IDENTITY_INSERT [dbo].[Emp_Mas_Tbl] OFF
GO
SET IDENTITY_INSERT [dbo].[Emp_Salary_Tbl] ON 

INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (1, 1, N'jan', 3000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (2, 2, N'june', 5000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (3, 3, N'dec', 8000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (4, 4, N'feb', 10000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (5, 0, N'july', 30000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (6, 3, N'APRIL', 40000, N'excellent')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (7, 5, N'JULY', 35000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (8, 7, N'MAY', 30000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (9, 6, N'JULY', 10000, N'good')
INSERT [dbo].[Emp_Salary_Tbl] ([SEQ_NO], [EMP_CODE], [MONTH], [SALARY], [COMMENTS]) VALUES (10, 3, N'FEB', 3000, N'february salary ')
SET IDENTITY_INSERT [dbo].[Emp_Salary_Tbl] OFF
GO
/****** Object:  StoredProcedure [dbo].[uspgetemployeedepreport]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspgetemployeedepreport]
as begin
select d.DEPT_NAME,COUNT(e.EMP_CODE) as TotalEmp FROM Emp_Mas_Tbl e 
right join Dept_Mas_Tbl d on e.DEPT_CODE = d.DEPT_CODE group by d.DEPT_NAME
end


GO
/****** Object:  StoredProcedure [dbo].[uspgetemployeelist]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspgetemployeelist]
as begin
select e.EMP_CODE,FIRST_NAME,MIDDLE_NAME,LAST_NAME,FULL_NAME,DOB,JOIN_DATE,c.CITY_NAME,d.DEPT_NAME,ISNULL(s.SALARY,0) as Salary,c.SORT_NO,d.SORT_NO as depart FROM Emp_Mas_Tbl e 
inner join Dept_Mas_Tbl d on e.DEPT_CODE=d.DEPT_CODE left join City_Mas_Tbl c on e.CITY_CODE = c.CITY_CODE 
left join Emp_Salary_Tbl s on e.EMP_CODE = s.EMP_CODE order by c.SORT_NO,d.SORT_NO asc
end

GO
/****** Object:  StoredProcedure [dbo].[uspgetemployeereport]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspgetemployeereport]
as begin
select e.EMP_CODE,FULL_NAME,ISNULL(s.SALARY,0) as Salary FROM Emp_Mas_Tbl e 
inner join Emp_Salary_Tbl s on e.EMP_CODE = s.EMP_CODE where MONTH =SUBSTRING(DATENAME(month,GETDATE()) ,1,3)
end


GO
/****** Object:  StoredProcedure [dbo].[uspgetsalary]    Script Date: 09-02-2022 16:02:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspgetsalary]
as begin
select SEQ_NO,MONTH,SALARY,COMMENTS,FULL_NAME FROM Emp_Salary_Tbl INNER JOIN Emp_Mas_Tbl ON Emp_Salary_Tbl.EMP_CODE = Emp_Mas_Tbl.EMP_CODE
end
GO
