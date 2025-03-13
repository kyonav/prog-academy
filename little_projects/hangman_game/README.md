# Low budget Hangman Game!

![](./misc/app_running.gif)

## Introduction

A Hangman game that runs on your console.

## Project

Developed during the Fullstack course at [Academia do Programador](https://www.academiadoprogramador.net) 2025

## Features

- **Random word picker**: The program is able to choose from random words inside the list.
- **Limited tries**: Limited tries so you use each of the tries wisely.
- **Instant feedback**

## Requirements

- .NET SDK (recommended .NET 8.0 or higher) for compiling and running the project.

## Compiling and running

1. Clone the repo and download the source code.
2. Open the terminal and navigate to the project folder.
3. Use the command below to restore the project dependencies.

```
dotnet restore
```

4. Compile the project using the command:

```
dotnet build --configuration Release
```

5. Execute the project compiling in real time.

```
dotnet run --project ?
```

6. To run the compiled executable; cd into `./prog-academy/little-projects/hangman_game/bin/Release/net-9.0/little-projects/` on your terminal and type:

> Windows
```
./little-projects.exe
```

> Linux
```
./little-projects
```

*Or just run graphically by double clicking it on your file manager.*

TO-DO: Fix the project namespace.
