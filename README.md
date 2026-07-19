# Game Launcher

A learning project — a simplified game launcher (à la Steam/Epic) built to learn C#, EF Core, and application architecture from scratch.

## Goal

Personal exercise to learn:
- Entity Framework Core (Code First) with SQLite
- Layered application architecture (data access / business logic / UI)
- A cross-platform desktop UI framework (Avalonia)

Requirements are loosely inspired by a university course assignment, but freely adapted by me where it serves learning better.

## Concept

Users browse a list of game titles and can add them to a personal library (their collection of favorites). No login system.

## Entities

- **Game** — title, description, PEGI rating, studio, category
- **Library** — a named collection belonging to a user, containing games
- **User** — name, username, email; owns a library

A game can appear in multiple libraries, and a library holds multiple games.

## Core functionality

- Full CRUD (create/read/update/delete) on all entities
- Search, filter, and sort in database level
- Data persists

## Tech stack

- **.NET 10 / C#**
- **EF Core** (Code First) + **SQLite** for persistence
- **Avalonia UI** for the desktop frontend (chosen over MAUI, which doesn't support Linux as a build target)
- **xUnit** for testing

## Architecture

Three layers, each a separate project:

```
    GameLauncher/
    ├── src/
    │   ├── GameLauncher.DAL/   # EF Core entities, DbContext, migrations
    │   ├── GameLauncher.BL/    # Repositories, facades, DTOs — business logic
    │   └── GameLauncher.App/   # Avalonia UI, ViewModels, Views
    ├── tests/
    │   ├── GameLauncher.DAL.Tests/
    │   └── GameLauncher.BL.Tests/
    └── docs/                   # ER diagram, notes
```

## Development environment

- Linux (Arch)
- VS Code + C# Dev Kit
- Git + GitHub

## Status

Actively in progress — building incrementally, one concept at a time.
