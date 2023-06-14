-- Inserção de dados na tabela Localizacao
INSERT INTO Localizacao (Ativo, DataAtual, DataExpira, Localizacao)
VALUES
    (true, '2023-06-14 14:30:00', '2023-06-14 15:30:00', ST_GeomFromText('POINT(-23.5489 -46.6388)', 4326)),
    (true, '2023-06-14 15:00:00', '2023-06-14 16:00:00', ST_GeomFromText('POINT(-23.5477 -46.6369)', 4326)),
    (false, '2023-06-14 15:30:00', '2023-06-14 16:30:00', ST_GeomFromText('POINT(-23.5470 -46.6392)', 4326));

-- Inserção de dados na tabela Utilizador
INSERT INTO Utilizador (idLocalizacao, Nome, DataNascimento)
VALUES
    (1, 'João', '1990-01-01'),
    (2, 'Maria', '1985-06-15'),
    (3, 'Pedro', '1995-12-31');

-- Inserção de dados na tabela Notificacao
INSERT INTO Notificacao (Enviado)
VALUES
    (true),
    (false),
    (false);

-- Inserção de dados na tabela Mensagem
INSERT INTO Mensagem (Titulo, Mensagem)
VALUES
    ('Promoção', 'Aproveite nossa promoção de final de ano!'),
    ('Oferta', 'Compre agora e ganhe um brinde!'),
    ('Lançamento', 'Conheça nosso novo produto!');