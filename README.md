# Conway's Game of Life

> A TDD Approach

## Rules

The universe of the Game of Life is an infinite, two-dimensional orthogonal grid of square cells, each of which is in one of two possible states, alive or dead, (or populated and unpopulated, respectively). Every cell interacts with its eight neighbours, which are the cells that are horizontally, vertically, or diagonally adjacent. At each step in time, the following transitions occur:

1. Any live cell with fewer than two live neighbors dies, as if by under population.
2. Any live cell with two or three live neighbors lives on to the next generation.
3. Any live cell with more than three live neighbors dies, as if by overpopulation.
4. Any dead cell with exactly three live neighbors becomes a live cell, as if by reproduction.

The initial pattern constitutes the seed of the system. The first generation is created by applying the above rules simultaneously to every cell in the seed; births and deaths occur simultaneously, and the discrete moment at which this happens is sometimes called a tick. Each generation is a pure function of the preceding one. The rules continue to be applied repeatedly to create further generations.

## Prerequisites (any action)

Application should run on Mac, Linux, or Windows provided that [Dot Net Core](https://www.microsoft.com/net/learn/get-started/macos) is intalled.

## Running the thing

0. Do you have the prerequistites?
1. Clone this repo locally.
2. Navigate Existence.ConsoleVersion from within your command line of choice.
3. Run: dotnet run
4. Watch the application run through iterative generation (one per second) until you provide the kill command within your terminal!

### Grid Seed

> 3x3 grid seed sample

```csharp

    int[,] seed = {{0,1,0},{1,1,0},{0,1,1}}

    //Visulized as:
    //   -  x  -
    //   x  x  -
    //   -  x  x

```

### Running Tests

0. Have you met the prerequisites?
1. Navigate to the local copy of "Existence.Test" directory in your favorite command line.
2. Run 'test' command

``` shell
    dotnet test
```

#### Sample Command Line Output
Total tests: 6. Passed: 0. Failed: 6. Skipped: 0.
Test Run Failed.
Test execution time: 1.0740 Seconds
