# Aplicação de Gerenciamento Escolar - Documentação Técnica

A aplicação simula um sistema de gerenciamento de alunos e usuários de uma escola infantil. Possui um formulário de matrícula de aluno com quatro etapas:

1. **Dados do Aluno**: Coleta informações sobre o aluno que está sendo matriculado.
2. **Dados do Responsável**: Captura os dados do responsável pelo aluno.
3. **Dados de Matrícula no Curso Curricular**: Registra informações relacionadas ao curso curricular, abrangendo diferentes níveis como Infantil, Fundamental 1 e 2, e Ensino Médio.
4. **Dados de Matrícula em um Curso Extracurricular de Programação**: Armazena informações específicas sobre a matrícula em um curso extracurricular na área de programação.

## Tecnologias Utilizadas

- Plataforma: .NET Core 7.0
- Padrão de Arquitetura: MVC (Model-View-Controller)
- Camada de Repositório: Dapper (preferido devido ao desempenho)
- Segurança da Senha: Utilização do algoritmo SHA256 para criptografar as senhas

## Arquitetura do Projeto

A aplicação foi desenvolvida seguindo os princípios da arquitetura limpa, o que proporciona maior clareza e facilita futuras refatorações e manutenções do código. 

### DTOs e Adapter

As DTOs (Data Transfer Objects) são manipuladas utilizando o padrão Adapter, que oferece maior consistência no mapeamento e transferência de dados entre as diferentes camadas da aplicação. Embora seja uma alternativa, a utilização de um Mapper também poderia ser considerada.

## Recursos Adicionais

- No menu "Secretaria", onde é possível buscar por alunos matriculados, existem botões para visualizar os dados cadastrados e o histórico do aluno. Caso o aluno possua histórico, foi adicionada a funcionalidade de gerar um PDF do mesmo.
- Para a criação do PDF, foi empregada a biblioteca DinkToPdf. Isso permite a manipulação de tabelas em formato HTML, com a capacidade de aplicar estilos personalizados.

## Banco de Dados

Junto ao projeto, foi fornecida uma pasta contendo as queries para o Microsoft SQL Server, que são necessárias para a utilização adequada da aplicação.

## Observações Finais

Esta aplicação de gerenciamento escolar foi desenvolvida com foco na eficiência e escalabilidade. A escolha das tecnologias e a adoção de padrões de projeto visam garantir um código organizado e de fácil manutenção.