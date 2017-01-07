CREATE TABLE [dbo].[UnsoldReasonOther]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Text] NVARCHAR(255) NOT NULL,
	[CreatedBy] NVARCHAR(50) NOT NULL,
	[CreatedDate] DateTimeOffset NOT NULL
)
