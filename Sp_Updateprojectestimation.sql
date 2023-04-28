create PROCEDURE [dbo].spUpdateProjectStoryEstimations 
( 
@ProjecStoryEstimationid bigint,
@Projectid bigint,
@Storyid bigint
,@Verionno bigint,
@Categpryid bigint,
@Cutomtotal decimal,
@Countofmodules decimal,
@ProjectstoryestimationDescription varchar(100)='',
@Addby varchar(100) = '',
@Isdeleted bit
)
as
begin                   
    set xact_abort, nocount on
    begin try


  IF EXISTS(select 1 from ProjectStoryEstimations where ProjectStoryEstimationID = @ProjecStoryEstimationid)



        --Declaration for Error log
        --declare @ErrorNumber int, @ErrorLine int, @ErrorMessage nvarchar(4000), @ErrorSeverity int, @ErrorState int, @StackTrace varchar(max), @RowCnt int;

 

        --------------------------

            BEGIN
               
update   ProjectStoryEstimations

 

                           set   ProjectId = @Projectid
                                ,StoryId = @Storyid,
								VerionNo=@Verionno,
								CategpryId=@Categpryid,
								CutomTotal=@Cutomtotal,
								CountOfModules=@Countofmodules,
								ProjectStoryEstimationDescription=@ProjectstoryestimationDescription,
								AddDate=getdate(),
                                AddBy = @AddBy
                                ,IsDeleted = @IsDeleted
                                ,ModifiedDate = getdate()
                         where   ProjectStoryEstimationID = @ProjecStoryEstimationid

            END
        --------------------------
 

    end try
    begin catch


        if @@trancount > 0 rollback transaction;        
        --Log error through procedure  
        --select @ErrorNumber = error_number(), @ErrorLine = error_line(), @ErrorMessage = error_message(), @ErrorSeverity = error_severity(), @ErrorState = error_state();
        --exec dbo.usp_AddErrorLog @ErrorNumber, @@procid, @StackTrace;

        throw;

    end catch
end
GO
/****** Object:  StoredProcedure [dbo].[usp_AddTicketImages]    Script Date: 07-11-2022 12:33:36 ******/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


exec [dbo].spUpdateProjectStoryEstimations

 
@ProjecStoryEstimationid=8,
@Projectid=1,
   @StoryId = 32
  ,@Verionno = 10
  ,@Categpryid = 20
  ,@Cutomtotal = 10
,@Countofmodules=10,
@ProjectstoryestimationDescription='mmmmmmmmmmmmmmmmmmmmmmmmmmm',
@AddBy='mallusssssssssssssss'
,@IsDeleted = 0;

