# Algorithms practice ground

Practice for algorithm-style interviews, one directory per language.

| Directory     | Run tests                                            |
| ------------- | ---------------------------------------------------- |
| `csharp/`     | `dotnet test` inside `csharp/`                       |
| `typescript/` | `pnpm install`, then `pnpm -r test` at the repo root |

The repo root is a pnpm workspace: `pnpm lint` runs oxlint and `pnpm fmt` runs oxfmt across it.

TypeScript solutions sit beside their tests as `src/<topic>/<name>.ts` and `<name>.test.ts`.
