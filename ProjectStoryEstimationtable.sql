/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProjectStoryEstimationID]
      ,[ProjectId]
      ,[StoryId]
      ,[VerionNo]
      ,[CategpryId]
      ,[CutomTotal]
      ,[CountOfModules]
      ,[AddDate]
      ,[AddBy]
      ,[IsDeleted]
      ,[ModifiedDate]
  FROM [dbo].[ProjectStoryEstimation]

  sp_help ProjectStoryEstimation;
  drop table 


--Alter the column name to new one in sql server
EXEC sp_rename 'dbo.ProjectStoryEstimation.ProjecStoryEstimationID', 'ProjectStoryEstimationID', 'COLUMN'