
# 📝 TimeBinder API - TodoPomodoro

Uma API desenvolvida em ASP.NET Core com arquitetura baseada em **Domain-Driven Design (DDD)** para gerenciamento de tarefas com **Pomodoro Timer** integrado.

---

## 🚀 Objetivo
Oferecer uma aplicação backend robusta e modular que permita:

- Criar, ler, atualizar e excluir (CRUD) To-Dos, Tasks e Pomodoros.
- Associar Pomodoros a tarefas específicas ou utilizá-los de forma independente.
- Organizar itens por **flags** (categorias) para facilitar a filtragem.
- Aplicar princípios **SOLID**, **Injeção de Dependência** e padrões modernos.

---

## 🧱 Estrutura do Projeto (DDD)
```
TodoPomodoro/
├── TodoPomodoro.API/                  # Controllers e camada de apresentação
├── TodoPomodoro.Application/         # Casos de uso e regras de aplicação
│   ├── Interfaces/
│   └── Services/
├── TodoPomodoro.Domain/              # Entidades, interfaces e lógica de domínio
│   ├── Entities/
│   ├── Enums/
│   ├── Interfaces/
│   └── ValueObjects/
├── TodoPomodoro.Infrastructure/      # Repositórios, contextos e integração com MongoDB
│   ├── Configurations/
│   ├── Contexts/
│   └── Repositories/
├── TodoPomodoro.Shared/              # Helpers, constantes e configs globais
```

---

## 🧠 Regras de Negócio (resumo)
- **ToDo**: Título, descrição e flag obrigatórios. Pode ter múltiplas tarefas.
- **Task**: Sempre vinculada a um ToDo. Pode ter Pomodoros.
- **Pomodoro**: Independente ou associado a ToDo/Task. Duração obrigatória.

Para detalhes, veja o PDF incluído: `Regras_de_Negocio_e_Cronograma_Todo_Pomodoro.pdf`

---

## 🛠️ Tecnologias Utilizadas
- ASP.NET Core 8
- MongoDB (via MongoDB Atlas)
- Swagger (OpenAPI)
- Injeção de Dependência (.NET DI)
- Clean Architecture + DDD

---

## 📅 Cronograma de Desenvolvimento
Acesse o cronograma no PDF ou veja abaixo as fases planejadas:

1. Modelagem e estruturação do projeto.
2. Implementação do CRUD de ToDos e Tasks.
3. Integração do Pomodoro standalone e associado.
4. Regras de negócio e validações.
5. Documentação, testes e deploy.

---

## ✍️ Autor
Desenvolvido por **Lucca Basto** como projeto prático de arquitetura em .NET.

---
