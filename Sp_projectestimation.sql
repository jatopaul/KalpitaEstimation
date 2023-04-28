create PROCEDURE [dbo].[spGetProjectStoryEstimations] 

as
begin                   
    set xact_abort, nocount on
    begin try
        --Declaration for Error log
        --declare @ErrorNumber int, @ErrorLine int, @ErrorMessage nvarchar(4000), @ErrorSeverity int, @ErrorState int, @StackTrace varchar(max), @RowCnt int;

 

        --------------------------

            BEGIN
             select * from dbo.ProjectStoryEstimations
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








