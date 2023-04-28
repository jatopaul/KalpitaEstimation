create procedure [dbo].[spDeleteProjectStoryEstimations] 
(  
     @ProjecStoryEstimationid bigint 
)
AS 
BEGIN
    DELETE FROM ProjectStoryEstimations 
    WHERE ProjectStoryEstimationID = @ProjecStoryEstimationid
END


exec [dbo].[spDeleteProjectStoryEstimations] 6;



