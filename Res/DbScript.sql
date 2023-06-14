CREATE TABLESPACE "ts_AppAmigos"
  OWNER postgres
  LOCATION 'C:\Users\Diogo Carneiro\Desktop\IPMAIA\Licenciatura\3ºano\webgeo';

  
create database AppAmigos
	with 
	template = postgis_30_sample
	tablespace = ts_AppAmigos
	encoding = 'UTF8'
	
CREATE EXTENSION postgis;

CREATE TABLE Utilizador (
    id SERIAL PRIMARY KEY,
	idLocalizacao SERIAL NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    DataNascimento DATE NOT NULL
);

CREATE TABLE Localizacao (
    Id SERIAL PRIMARY KEY,
    Ativo BOOLEAN NOT NULL,
    DataAtual TIMESTAMP NOT NULL,
    DataExpira TIMESTAMP NOT NULL,
    Localizacao GEOMETRY(Point, 4326) NOT NULL
);

CREATE TABLE Notificacao (
    id SERIAL PRIMARY KEY,
    Enviado BOOLEAN NOT NULL
);

CREATE TABLE Mensagem (
    id SERIAL PRIMARY KEY,
    Titulo VARCHAR(255) NOT NULL,
    Mensagem TEXT NOT NULL
);