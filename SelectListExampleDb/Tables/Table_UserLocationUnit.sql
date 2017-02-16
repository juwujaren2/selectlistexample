CREATE TABLE [dbo].[UserLocationUnit](
	[UserLocationUnitId] [int] IDENTITY(1,1) NOT NULL,
	[LongName] [nvarchar](50) NOT NULL,
	[ShortName] [nvarchar](20) NOT NULL,
	[UserLocation] [nvarchar](50) NOT NULL,
	[ManagerFirstName] [nvarchar](50) NOT NULL,
	[ManagerLastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_UserLocationUnit] PRIMARY KEY CLUSTERED 
(
	[UserLocationUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

