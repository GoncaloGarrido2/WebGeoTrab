# WebGeoTrab

# Software

# Requerimentos 
## Word 
- User cases
- Print do Diagrama ER.
## UserCases
criação de um utilizador 
- O utilizador adiciona amigos;
- Adiciona uma localização;
- Ver lista de localizações; 
- Recebe notificação de amigos próximos; 
- Ver lista de amigos; 
- Altera a localização; <br><br>
O aplicativo de rede social permite que o utilizador adicione amigos, compartilhe a localização e receba notificações quando amigos próximos estiverem por perto. O utilizador pode ver a lista de amigos e locais compartilhados, além de poder alterar sua própria localização. O objetivo do aplicativo é manter o utilizador conectado e informado sobre a localização dos amigos e familiares.
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
