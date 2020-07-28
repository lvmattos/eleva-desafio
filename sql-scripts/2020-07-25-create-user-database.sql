--Database portal-escola-q
CREATE USER rwx_EscolaPortal_q WITH PASSWORD = N'988bc03e82bd49e368-576', DEFAULT_SCHEMA=[dbo] ; EXEC sp_addrolemember db_datawriter, rwx_EscolaPortal_q ; EXEC sp_addrolemember db_datareader, rwx_EscolaPortal_q ; GRANT EXECUTE TO rwx_EscolaPortal_q ; GRANT DELETE TO rwx_EscolaPortal_q ; 


--Database Logs
CREATE USER rwx_logs_q WITH PASSWORD = N'988bc03e82bd49eg60-841', DEFAULT_SCHEMA=[dbo] ; EXEC sp_addrolemember db_datawriter, rwx_logs_q ; EXEC sp_addrolemember db_datareader, rwx_logs_q ; GRANT EXECUTE TO rwx_logs_q ; GRANT DELETE TO rwx_logs_q ; 