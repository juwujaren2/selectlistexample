IF NOT EXISTS (SELECT 1 FROM [dbo].[UnsoldReason])
BEGIN
	INSERT INTO [dbo].[UnsoldReason] ([Text],[CreatedBy],[CreatedDate],[IsActive],[UpdatedBy],[UpdatedDate])
	VALUES
	('Price','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE()),
	('Contract','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE()),
	('Odd Job','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE()),
	('Quote','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE()),
	('Frequency','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE()),
	('Schedule','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE()),
	('Spouse/Partner','[Seed]',GETUTCDATE(),1,'[Seed]',GETUTCDATE())
END