/*
SELECT * FROM TB_ALUNOS
SELECT * FROM TB_MATRICULAS
SELECT * FROM TB_CURSOS
SELECT * FROM TB_DISCIPLINAS
SELECT * FROM TB_HISTORICOS
SELECT * FROM TB_TURMAS

SELECT * FROM TB_USUARIOS

DROP TABLE TB_ALUNOS
DROP TABLE TB_MATRICULAS
DROP TABLE TB_CURSOS
DROP TABLE TB_DISCIPLINAS
DROP TABLE TB_HISTORICOS
DROP TABLE TB_TURMAS


--DELETE TB_CURSOS
DBCC CHECKIDENT ('TB_CURSOS', RESEED, 0);

--DELETE TB_DISCIPLINAS
DBCC CHECKIDENT ('TB_DISCIPLINAS', RESEED, 0);

--DELETE TB_TURMAS
DBCC CHECKIDENT ('TB_TURMAS', RESEED, 0);

--DELETE TB_USUARIOS
DBCC CHECKIDENT ('TB_USUARIOS', RESEED, 0);

--DELETE TB_ALUNOS

--DELETE TB_MATRICULAS_CURSOS_EXTRACURRICULARES

--DELETE TB_HISTORICOS

--DELETE TB_RESPONSAVEIS
DBCC CHECKIDENT ('TB_RESPONSAVEIS', RESEED, 0);

*/

INSERT INTO TB_USUARIOS VALUES ('34698947425', 'Administrador', 'Administrador Geral', '0Y01o1FLz3F3JusD8XbdGcM8xh/YJ5xQ7+rpJb8v70A=', 'Adm')
GO
--INSERÇÃO DOS CURSOS
INSERT INTO TB_CURSOS VALUES ('EI', 'ENSINO INFANTIL', 'N')
INSERT INTO TB_CURSOS VALUES ('EF1', 'ENSINO FUNDAMENTAL 1', 'N')
INSERT INTO TB_CURSOS VALUES ('EF2', 'ENSINO FUNDAMENTAL 2', 'N')
INSERT INTO TB_CURSOS VALUES ('INTRO-PY', 'Introdução à Programação em Python para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('SCRATCH-KIDS', 'Programação Criativa com Scratch para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('ROBOT-LOGO', 'Aventuras de Programação com Robôs e Logo', 'S');
INSERT INTO TB_CURSOS VALUES ('WEB-DEV-KIDS', 'Desenvolvimento Web para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('GAME-DEV-JR', 'Criação de Jogos para Jovens Programadores', 'S');
INSERT INTO TB_CURSOS VALUES ('APP-INVENTOR', 'Desenv. de Apps com App Inventor para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('ROBOTICS-JR', 'Iniciação à Robótica para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('PYTHON-KIDS', 'Programação Divertida com Python para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('CODING-ADVENTURE', 'Aventuras na Codificação para Crianças', 'S');
INSERT INTO TB_CURSOS VALUES ('ANIMATION-KIDS', 'Animação Digital para Crianças', 'S');
GO

--INSERÇÃO DAS DISCIPLINAS
-- Disciplinas para Ensino Infantil
INSERT INTO TB_DISCIPLINAS VALUES ('Linguagem e Comunicação', 30, 1),
       ('Matemática Exploratória', 30, 1),
       ('Artes e Expressão Criativa', 30, 1),
       ('Educação Física', 30, 1),
       ('Ciências Naturais', 30, 1),
       ('Estudos Sociais', 30, 1),
       ('Música e Movimento', 30, 1);
GO
-- Disciplinas para Ensino Fundamental 1
INSERT INTO TB_DISCIPLINAS VALUES ('Língua Portuguesa', 60, 2),
       ('Matemática', 60, 2),
       ('Ciências', 45, 2),
       ('História', 45, 2),
       ('Geografia', 45, 2),
       ('Artes', 30, 2),
       ('Educação Física', 30, 2);
GO
-- Disciplinas para Ensino Fundamental 2
INSERT INTO TB_DISCIPLINAS VALUES ('Língua Portuguesa', 75, 3),
       ('Matemática', 75, 3),
       ('Ciências', 60, 3),
       ('História', 60, 3),
       ('Geografia', 60, 3),
       ('Artes', 45, 3),
       ('Educação Física', 45, 3);
GO
-- Disciplinas do Curso 1: Introdução à Programação em Python para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Lógica de Programação', 20, 4),
       ('Variáveis e Tipos de Dados', 15, 4),
       ('Estruturas de Controle', 25, 4),
       ('Laços de Repetição', 20, 4),
       ('Funções e Modularização', 15, 4);
GO
-- Disciplinas do Curso 2: Programação Criativa com Scratch para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Introdução ao Scratch', 15, 5),
       ('Animação e Movimento', 20, 5),
       ('Eventos e Interação', 25, 5),
       ('Controle de Personagens', 20, 5),
       ('Criatividade e Projetos', 15, 5);
GO
-- Disciplinas do Curso 3: Aventuras de Programação com Robôs e Logo
INSERT INTO TB_DISCIPLINAS VALUES ('Introdução à Programação', 15, 6),
       ('Comandos e Movimentação', 20, 6),
       ('Loop e Repetição', 25, 6),
       ('Desafios de Lógica', 20, 6),
       ('Projetos com Robôs', 15, 6);
GO
-- Disciplinas do Curso 4: Desenvolvimento Web para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Introdução ao HTML', 15, 7),
       ('Estilização com CSS', 20, 7),
       ('Interatividade com JavaScript', 25, 7),
       ('Criação de Páginas Web', 20, 7),
       ('Publicação na Web', 15, 7);
GO
-- Disciplinas do Curso 5: Criação de Jogos para Jovens Programadores
INSERT INTO TB_DISCIPLINAS VALUES ('Fundamentos de Jogos', 20, 8),
       ('Lógica de Programação para Jogos', 25, 8),
       ('Design de Níveis', 20, 8),
       ('Interação e Controle de Jogos', 15, 8),
       ('Publicação de Jogos', 15, 8);
GO
-- Disciplinas do Curso 6: Desenvolvimento de Apps com App Inventor para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Introdução ao App Inventor', 15, 9),
       ('Interface e Telas', 20, 9),
       ('Controle de Componentes', 25, 9),
       ('Sensores e Funcionalidades Avançadas', 20, 9),
       ('Publicação de Aplicativos', 15, 9);
GO
-- Disciplinas do Curso 7: Iniciação à Robótica para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Conceitos de Robótica', 20, 10),
       ('Montagem de Robôs', 25, 10),
       ('Programação de Movimentação', 20, 10),
       ('Solução de Desafios', 15, 10),
       ('Apresentação de Projetos', 15, 10);
GO
-- Disciplinas do Curso 8: Programação Divertida com Python para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Introdução ao Python', 15, 11),
       ('Estruturas de Dados', 20, 11),
       ('Manipulação de Strings', 25, 11),
       ('Jogos e Desafios', 20, 11),
       ('Projetos com Python', 15, 11);
GO
-- Disciplinas do Curso 9: Aventuras na Codificação para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Introdução à Codificação', 15, 12),
       ('Puzzles e Problemas', 20, 12),
       ('Lógica e Raciocínio', 25, 12),
       ('Desafios de Programação', 20, 12),
       ('Criatividade na Codificação', 15, 12);
GO
-- Disciplinas do Curso 10: Animação Digital para Crianças
INSERT INTO TB_DISCIPLINAS VALUES ('Fundamentos de Animação', 20, 13),
       ('Storyboard e Roteiro', 25, 13),
       ('Técnicas de Animação', 20, 13),
       ('Edição e Efeitos Visuais', 15, 13),
       ('Apresentação de Animações', 15, 13);
GO

--CONFIGURAÇÃO DAS TURMAS
	INSERT INTO TB_TURMAS(TURMA, ID_CURSO, SERIE)
	  SELECT DISTINCT 
		 CONVERT(VARCHAR,YEAR(GETDATE()))+'_'+SUBSTRING(C.CURSO, 1,4)+'_'+'1' AS TURMA
		,C.ID AS ID_CURSO
		,1 AS SERIE 
	FROM TB_CURSOS C
	WHERE C.CURSO = 'EI'  -- Incrementa o contador
AND NOT EXISTS (SELECT 1 FROM TB_TURMAS TT WHERE TT.ID_CURSO = C.ID AND TT.SERIE = 1 AND TT.TURMA = CONVERT(VARCHAR,YEAR(GETDATE()))+'_'+SUBSTRING(C.CURSO, 1,4)+'_'+'1')
GO

DECLARE @V_CONTADOREF1 INT = 1
WHILE @V_CONTADOREF1 <= 5
	BEGIN
INSERT INTO TB_TURMAS(TURMA, ID_CURSO, SERIE)
	  SELECT DISTINCT 
		  CONVERT(VARCHAR,YEAR(GETDATE()))+'_'+SUBSTRING(C.CURSO, 1,4)+'_'+CONVERT(VARCHAR, @V_CONTADOREF1) AS TURMA
		,C.ID AS ID_CURSO
		,@V_CONTADOREF1 AS SERIE 
	FROM TB_CURSOS C
	WHERE C.CURSO = 'EF1'
AND NOT EXISTS (SELECT 1 FROM TB_TURMAS TT WHERE TT.ID_CURSO = C.ID AND TT.SERIE = @V_CONTADOREF1 AND TT.TURMA = CONVERT(VARCHAR,YEAR(GETDATE()))+'_'+SUBSTRING(C.CURSO, 1,4)+'_'+CONVERT(VARCHAR, @V_CONTADOREF1))
	    SET @V_CONTADOREF1 = @V_CONTADOREF1 + 1
	END
GO

DECLARE @V_CONTADOREF2 INT = 6
WHILE @V_CONTADOREF2 <= 9
	BEGIN
	INSERT INTO TB_TURMAS(TURMA, ID_CURSO, SERIE)
	  SELECT DISTINCT 
		 CONVERT(VARCHAR,YEAR(GETDATE()))+'_'+SUBSTRING(C.CURSO, 1,4)+'_'+CONVERT(VARCHAR, @V_CONTADOREF2) AS TURMA
		,C.ID AS ID_CURSO
		,@V_CONTADOREF2 AS SERIE 
	FROM TB_CURSOS C
	WHERE C.CURSO = 'EF2'  -- Incrementa o contador
AND NOT EXISTS (SELECT 1 FROM TB_TURMAS TT WHERE TT.ID_CURSO = C.ID AND TT.SERIE = @V_CONTADOREF2 AND TT.TURMA = CONVERT(VARCHAR,YEAR(GETDATE()))+'_'+SUBSTRING(C.CURSO, 1,4)+'_'+CONVERT(VARCHAR, @V_CONTADOREF2))
	    SET @V_CONTADOREF2 = @V_CONTADOREF2 + 1
	END

	--CRIAÇÃO DA TABELA AUXILIAR PARA POPULAR O RESPONSAVEL
GO

