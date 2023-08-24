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
--INSER��O DOS CURSOS
INSERT INTO TB_CURSOS VALUES ('EI', 'ENSINO INFANTIL', 'N')
INSERT INTO TB_CURSOS VALUES ('EF1', 'ENSINO FUNDAMENTAL 1', 'N')
INSERT INTO TB_CURSOS VALUES ('EF2', 'ENSINO FUNDAMENTAL 2', 'N')
INSERT INTO TB_CURSOS VALUES ('INTRO-PY', 'Introdu��o � Programa��o em Python para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('SCRATCH-KIDS', 'Programa��o Criativa com Scratch para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('ROBOT-LOGO', 'Aventuras de Programa��o com Rob�s e Logo', 'S');
INSERT INTO TB_CURSOS VALUES ('WEB-DEV-KIDS', 'Desenvolvimento Web para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('GAME-DEV-JR', 'Cria��o de Jogos para Jovens Programadores', 'S');
INSERT INTO TB_CURSOS VALUES ('APP-INVENTOR', 'Desenv. de Apps com App Inventor para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('ROBOTICS-JR', 'Inicia��o � Rob�tica para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('PYTHON-KIDS', 'Programa��o Divertida com Python para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('CODING-ADVENTURE', 'Aventuras na Codifica��o para Crian�as', 'S');
INSERT INTO TB_CURSOS VALUES ('ANIMATION-KIDS', 'Anima��o Digital para Crian�as', 'S');
GO

--INSER��O DAS DISCIPLINAS
-- Disciplinas para Ensino Infantil
INSERT INTO TB_DISCIPLINAS VALUES ('Linguagem e Comunica��o', 30, 1),
       ('Matem�tica Explorat�ria', 30, 1),
       ('Artes e Express�o Criativa', 30, 1),
       ('Educa��o F�sica', 30, 1),
       ('Ci�ncias Naturais', 30, 1),
       ('Estudos Sociais', 30, 1),
       ('M�sica e Movimento', 30, 1);
GO
-- Disciplinas para Ensino Fundamental 1
INSERT INTO TB_DISCIPLINAS VALUES ('L�ngua Portuguesa', 60, 2),
       ('Matem�tica', 60, 2),
       ('Ci�ncias', 45, 2),
       ('Hist�ria', 45, 2),
       ('Geografia', 45, 2),
       ('Artes', 30, 2),
       ('Educa��o F�sica', 30, 2);
GO
-- Disciplinas para Ensino Fundamental 2
INSERT INTO TB_DISCIPLINAS VALUES ('L�ngua Portuguesa', 75, 3),
       ('Matem�tica', 75, 3),
       ('Ci�ncias', 60, 3),
       ('Hist�ria', 60, 3),
       ('Geografia', 60, 3),
       ('Artes', 45, 3),
       ('Educa��o F�sica', 45, 3);
GO
-- Disciplinas do Curso 1: Introdu��o � Programa��o em Python para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('L�gica de Programa��o', 20, 4),
       ('Vari�veis e Tipos de Dados', 15, 4),
       ('Estruturas de Controle', 25, 4),
       ('La�os de Repeti��o', 20, 4),
       ('Fun��es e Modulariza��o', 15, 4);
GO
-- Disciplinas do Curso 2: Programa��o Criativa com Scratch para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Introdu��o ao Scratch', 15, 5),
       ('Anima��o e Movimento', 20, 5),
       ('Eventos e Intera��o', 25, 5),
       ('Controle de Personagens', 20, 5),
       ('Criatividade e Projetos', 15, 5);
GO
-- Disciplinas do Curso 3: Aventuras de Programa��o com Rob�s e Logo
INSERT INTO TB_DISCIPLINAS VALUES ('Introdu��o � Programa��o', 15, 6),
       ('Comandos e Movimenta��o', 20, 6),
       ('Loop e Repeti��o', 25, 6),
       ('Desafios de L�gica', 20, 6),
       ('Projetos com Rob�s', 15, 6);
GO
-- Disciplinas do Curso 4: Desenvolvimento Web para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Introdu��o ao HTML', 15, 7),
       ('Estiliza��o com CSS', 20, 7),
       ('Interatividade com JavaScript', 25, 7),
       ('Cria��o de P�ginas Web', 20, 7),
       ('Publica��o na Web', 15, 7);
GO
-- Disciplinas do Curso 5: Cria��o de Jogos para Jovens Programadores
INSERT INTO TB_DISCIPLINAS VALUES ('Fundamentos de Jogos', 20, 8),
       ('L�gica de Programa��o para Jogos', 25, 8),
       ('Design de N�veis', 20, 8),
       ('Intera��o e Controle de Jogos', 15, 8),
       ('Publica��o de Jogos', 15, 8);
GO
-- Disciplinas do Curso 6: Desenvolvimento de Apps com App Inventor para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Introdu��o ao App Inventor', 15, 9),
       ('Interface e Telas', 20, 9),
       ('Controle de Componentes', 25, 9),
       ('Sensores e Funcionalidades Avan�adas', 20, 9),
       ('Publica��o de Aplicativos', 15, 9);
GO
-- Disciplinas do Curso 7: Inicia��o � Rob�tica para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Conceitos de Rob�tica', 20, 10),
       ('Montagem de Rob�s', 25, 10),
       ('Programa��o de Movimenta��o', 20, 10),
       ('Solu��o de Desafios', 15, 10),
       ('Apresenta��o de Projetos', 15, 10);
GO
-- Disciplinas do Curso 8: Programa��o Divertida com Python para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Introdu��o ao Python', 15, 11),
       ('Estruturas de Dados', 20, 11),
       ('Manipula��o de Strings', 25, 11),
       ('Jogos e Desafios', 20, 11),
       ('Projetos com Python', 15, 11);
GO
-- Disciplinas do Curso 9: Aventuras na Codifica��o para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Introdu��o � Codifica��o', 15, 12),
       ('Puzzles e Problemas', 20, 12),
       ('L�gica e Racioc�nio', 25, 12),
       ('Desafios de Programa��o', 20, 12),
       ('Criatividade na Codifica��o', 15, 12);
GO
-- Disciplinas do Curso 10: Anima��o Digital para Crian�as
INSERT INTO TB_DISCIPLINAS VALUES ('Fundamentos de Anima��o', 20, 13),
       ('Storyboard e Roteiro', 25, 13),
       ('T�cnicas de Anima��o', 20, 13),
       ('Edi��o e Efeitos Visuais', 15, 13),
       ('Apresenta��o de Anima��es', 15, 13);
GO

--CONFIGURA��O DAS TURMAS
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

	--CRIA��O DA TABELA AUXILIAR PARA POPULAR O RESPONSAVEL
GO

