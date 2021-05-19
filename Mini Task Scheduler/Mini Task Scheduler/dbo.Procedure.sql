CREATE PROCEDURE [dbo].[addmessage]
	@title nvarchar,
	@trigger nvarchar(10),
	@action nvarchar(10),
	@setDate nvarchar(20),
	@setAlarm Datetime,
	@recurD int,
	@recurW int,
	@mon int,
	@tue int,
	@wed int,
	@thu int,
	@fri int,
	@sat int,
	@sun int,
	@triggerview nvarchar(100),
	@messtitle nvarchar(20),
	@message nvarchar(50),
	@created nvarchar(25)
AS
	insert into message
	values (@title,@trigger,@action,@setDate,@setAlarm,@recurD,@recurW,@mon,@tue,@wed,@thu,@fri,@sat,@sun);
RETURN 0
