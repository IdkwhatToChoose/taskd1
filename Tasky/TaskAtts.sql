CREATE TABLE [dbo].[TaskAtts]
(
  [Id] INT NOT NULL PRIMARY KEY,
  [Task] NVARCHAR(MAX) NOT NULL,
  [TaskDescription] NVARCHAR(MAX),
  [TaskCompleted] BIT

)
