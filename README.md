# 📝 Gerenciador de Tarefas — To-Do API

API REST desenvolvida em **C# com .NET**, criada como projeto de estudo para praticar a construção e organização de uma API.

O projeto tem como objetivo desenvolver uma base sobre **Controllers, Requests, Models, Enums e Use Cases**, além de trabalhar com operações CRUD e validações.

> 🚧 Projeto em desenvolvimento

---

## 🚀 Tecnologias utilizadas

* **C#**
* **.NET**
* **ASP.NET Core**
* **Swagger**
* **Visual Studio**

---

## 📌 Funcionalidades

A API permite:

* ✅ Criar uma tarefa
* 📋 Listar todas as tarefas
* 🔎 Buscar uma tarefa pelo ID
* ✏️ Atualizar uma tarefa
* 🗑️ Excluir uma tarefa
* ✔️ Validar dados enviados na requisição
* 🎯 Trabalhar com prioridades e status pré-definidos

---
### 📁 Application

Contém as principais regras e estruturas utilizadas pela aplicação.

* **Enums:** define os valores possíveis para prioridade e status.
* **Models:** representa uma tarefa dentro da aplicação.
* **UseCases:** concentra as ações que podem ser realizadas sobre as tarefas.
  
### 📁 Controllers

Responsável por receber as requisições HTTP e direcioná-las para os Use Cases.

### 📁 Communication

Contém os objetos utilizados para receber os dados enviados pelo usuário através da API.

---

## 🔗 Endpoints

| Método   | Endpoint          | Descrição               |
| -------- | ----------------- | ----------------------- |
| `POST`   | `/api/tasks`      | Criar uma tarefa        |
| `GET`    | `/api/tasks`      | Listar todas as tarefas |
| `GET`    | `/api/tasks/{id}` | Buscar tarefa pelo ID   |
| `PUT`    | `/api/tasks/{id}` | Atualizar uma tarefa    |
| `DELETE` | `/api/tasks/{id}` | Excluir uma tarefa      |

---

## ✅ Validações

A API possui algumas regras para os dados recebidos:

* O nome da tarefa é obrigatório.
* O nome pode ter no máximo 100 caracteres.
* A descrição é opcional e pode ter até 500 caracteres.
* A prioridade deve ser uma das opções disponíveis.
* O status deve ser uma das opções disponíveis.
* A data de vencimento não pode estar no passado no momento da criação.

---

## 📖 Swagger

O projeto utiliza **Swagger** para facilitar a visualização e o teste dos endpoints da API.

Após executar o projeto, basta acessar a interface do Swagger disponibilizada pela aplicação para testar as operações de criação, consulta, atualização e exclusão de tarefas.

---

