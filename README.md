
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

TimeBinder/
├── TimeBinder.sln
├── docker-compose.yml
├── .dockerignore
│
├── TimeBinder.Domain/
│   ├── Entities/
│   │   ├── ToDo.cs
│   │   ├── Task.cs
│   │   └── Pomodoro.cs
│   ├── Enums/
│   │   ├── ToDoStatus.cs
│   │   ├── TaskProgressStatus.cs
│   │   └── PomodoroStatus.cs
│   ├── Interfaces/
│   │   ├── IToDoRepository.cs
│   │   ├── ITaskRepository.cs
│   │   └── IPomodoroRepository.cs
│   └── Exceptions/
│       └── BusinessRuleException.cs
│
├── TimeBinder.Application/
│   ├── UseCases/
│   │   ├── ToDo/
│   │   │   ├── CriarToDoService.cs
│   │   │   └── (outros serviços ToDo)
│   │   ├── Task/
│   │   │   ├── CriarTaskService.cs
│   │   │   └── (outros serviços Task)
│   │   └── Pomodoro/
│   │       ├── CriarPomodoroService.cs
│   │       └── (outros serviços Pomodoro)
│   ├── Interfaces/
│   │   ├── INotificationService.cs
│   │   └── ITimeService.cs
│   ├
│   │
│   └── Mappers/
│       └── (mapeamentos internos)
│
├── TimeBinder.Infrastructure/
│   ├── Configurations/
│   │   └── MongoConfiguration.cs
│   ├── Contexts/
│   │   └── MongoDbContext.cs
│   ├── Repositories/
│   │   ├── ToDoRepository.cs
│   │   ├── TaskRepository.cs
│   │   └── PomodoroRepository.cs
│   └── Services/
│       ├── NotificationService.cs
│       └── TimeService.cs
│
├── TimeBinder.API/
│   ├── Controllers/
│   │   ├── ToDoController.cs
│   │   ├── TaskController.cs
│   │   └── PomodoroController.cs
│   ├── DTOs/
│   │   ├── Request/
│   │   │   ├── CreateToDoRequest.cs
│   │   │   ├── CreateTaskRequest.cs
│   │   │   └── CreatePomodoroRequest.cs
│   │   └── Response/
│   │       ├── ToDoResponse.cs
│   │       ├── TaskResponse.cs
│   │       └── PomodoroResponse.cs
│   ├── Mappers/
│   │   └── DtoToEntityMapper.cs
│   ├── Middleware/
│   │   └── ExceptionHandlingMiddleware.cs
│   ├── Program.cs
│   ├── appsettings.json
│   ├── appsettings.Development.json
│   └── Properties/
│       └── launchSettings.json
│   └── Dockerfile
│
└── TimeBinder.Tests/
    ├── Domain/
    │   └── TaskTests.cs
    ├── Application/
    │   └── FinalizarTaskServiceTests.cs
    ├── Infrastructure/
    │   └── TaskRepositoryTests.cs
    └── API/
        └── ToDoControllerTests.cs


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
