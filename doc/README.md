# Tower of Hanoi Implementation in C#

## About
This is a project implementing both a recursive algorithm and an iterative algorithm to solve the Tower of Hanoi problem. The iterative solution utilizes Stacks.

### Built With
- C#
- .NET 8 SDK
- Command Line Interface (CLI)

## How to install?

### Prerequisites
Ensure you have an up-to-date .NET 8 or later SDK and a C# compiler installed.

### Installation
1. Download the .zip file.

2. Navigate to the project directory:
   ```sh
   cd .\Hanoi
   ```

3. Build the project:
   ```sh
   dotnet build
   ```

## Usage
To execute the program, run one of the following 2 commands from the terminal:

### Recursive Solution
```sh
dotnet run -Recursive [number]
```
This will solve the Tower of Hanoi problem recursively for n disks.

### Iterative Solution
```sh
dotnet run -Iterative [number]
```
This will solve the Tower of Hanoi problem iteratively for n disks.