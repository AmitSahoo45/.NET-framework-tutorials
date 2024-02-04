### Explaination

1. 
```sql
CREATE PROCEDURE sp_CalculateF1DriverAvgSpeeds
AS
BEGIN
     ALTER TABLE TempF1Drivers ADD AvgScore FLOAT(53) DEFAULT 0.0 NOT NULL;

     DECLARE @sql NVARCHAR(MAX);
     SET @sql = N'UPDATE TempF1Drivers SET AvgScore = ( ( S1 + S2 + S3 ) / 3)';
     EXEC sp_executesql @sql;

END;
```

using Dynamic SQL: `DECLARE @sql NVARCHAR(MAX); SET @sql = N'UPDATE TempF1Drivers SET AvgScore = ( ( S1 + S2 + S3 ) / 3)'; EXEC sp_executesql @sql;`
I am trying to execute a string as a command in a stored procedure. 

In SQL Server, you cannot directly execute a string as a command within a stored procedrue without using a dynamic sql. 
This is because the SQL Server engine needs to know all the commands at compile time, and it doesn't allow executing strings as commands during runtime.