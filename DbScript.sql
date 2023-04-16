CREATE TABLESPACE "ts_AppAmigos"
  OWNER postgres
  LOCATION 'C:\Users\Diogo Carneiro\Desktop\IPMAIA\Licenciatura\3ºano\webgeo';

  
create database AppAmigos
	with 
	template = postgis_30_sample
	tablespace = ts_AppAmigos
	encoding = 'UTF8'
	