CREATE TABLE [dbo].[UnsoldReason]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Text] NVARCHAR(255) NOT NULL,
	[IsActive] BIT NOT NULL DEFAULT((0)),
	[CreatedBy] NVARCHAR(50) NOT NULL,
	[CreatedDate] DateTimeOffset NOT NULL,
	[UpdatedBy] NVARCHAR(50) NOT NULL,
	[UpdatedDate] DateTimeOffset NOT NULL
)
