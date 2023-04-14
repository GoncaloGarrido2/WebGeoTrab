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
  - Idade
  - id_Vizinhos(PK_Vizinhos)
- Vizinhos
  - id
  - Distancia
  - id_utilizador(PK_Utilizador)
- LocalizcaoAtual
  - Id
  - id_Utilizador(PK_Utilizador)
  - DataExpira
- Notificação
  - id 
  - id_Utilizador (PK_Utilizador)
  - Visuaçizado
  - id_Mensagem(PK_Mensagem)
- Mensagem
  - id
  - Titulo
  - Mensagem
## Zip 
- script SQL
- Word  
