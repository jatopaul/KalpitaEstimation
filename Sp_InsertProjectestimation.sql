--while adding the post don't add the primary key column name inside the begin and end part (about the parameters)


create PROCEDURE [dbo].spPostProjectStoryEstimations 
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
        --Declaration for Error log
        --declare @ErrorNumber int, @ErrorLine int, @ErrorMessage nvarchar(4000), @ErrorSeverity int, @ErrorState int, @StackTrace varchar(max), @RowCnt int;

 

        --------------------------

            BEGIN
                INSERT INTO ProjectStoryEstimations(ProjectId, StoryId, VerionNo, CategpryId, CutomTotal, CountOfModules,ProjectStoryEstimationDescription,AddDate,AddBy,IsDeleted,ModifiedDate)
                VALUES (@Projectid,@Storyid, @Verionno,@Categpryid,@Cutomtotal,@Countofmodules,@ProjectstoryestimationDescription,GETDATE(), @AddBy,@Isdeleted,GETDATE() )
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

--running the insert(post) method we need to add the primary key's value else it won't work.
exec [dbo].spPostProjectStoryEstimations @ProjecStoryEstimationid=4,@Projectid=10,@Storyid=10,@Verionno=46,@Categpryid=88, @Cutomtotal=88,@Countofmodules=99,@ProjectstoryestimationDescription='abhii',
                              @AddBy= 'me', 
                            @Isdeleted= 0;

