# WebGeoTrab

# Software

# Requerimentos 
## Word 
- User cases
- Print do Diagrama ER.
## UserCases
criação de um utilizador 
O utilizador adiciona amigos
adiciona uma localização 
ver lista de localizações 
recebe notificação de amigos próximos 
ver lista de amigos 
altera a localização 
## Diagrama ER
### Tabelas 
- Utilizador
  - id
  - Nome
  - DataNascimento
  - id_Utilizador_Amigos(PK_Utilizador_Amigos)
- Utilizador_Amigos
  - id_Utilizador(PK_Utilizador)
  - id_Amigos(PK_Amigos)
- Amigos
  - id
  - id_Utilizador_Amigos(PK_Utilizador_Amigos)
- Localizcao
  - Id
  - Ativo
  - DataAtual
  - DataExpira
  - id_Utilizador(PK_Utilizador)
- Notificação
  - id 
  - Enviado
  - id_Utilizador (PK_Utilizador)
  - id_Mensagem(PK_Mensagem)
- Mensagem
  - id
  - Titulo
  - Mensagem
## Zip 
- script SQL
- Word   
