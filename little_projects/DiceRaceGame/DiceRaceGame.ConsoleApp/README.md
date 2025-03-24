### The console needs to be run on fullscreen for the console log to work properly.

# Low budget Dice Race Game!

![](https://i.imgur.com/gf19ABH.gif)

## Introduction

A Dice Race Game that runs on your console.

## Project

Developed during the Fullstack course at [Academia do Programador](https://www.academiadoprogramador.net) 2025

## Features

- **Random number generation**: The program is able to simulate a dice by randomizing numbers.
- **Graphical response**: Log of the the game board at each round, so you know your position.
- **Input validation**: The user is allowed to enter only valid options/inputs.
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
dotnet run --project DiceRaceGame
```

6. To run the compiled executable; cd into `./prog-academy/little-projects/DiceRaceGame/bin/Release/net-8.0/DiceRaceGame/` on your terminal and type:

> Windows
```
./DiceRaceGame.exe
```

> Linux
```
./DiceRaceGame
```

*Or just run graphically by double clicking it on your file manager.*