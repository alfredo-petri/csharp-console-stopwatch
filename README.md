# C# Console Stopwatch

## Description

This is a C# console stopwatch application, developed to practice fundamental programming concepts such as input handling, time manipulation, and control flow structures. The stopwatch allows users to set a countdown using seconds (s) or minutes (m), and provides a simple text-based interface that simulates a timer using Thread.Sleep and System.Console. This project is part of my learning portfolio and is ideal for beginners looking to understand how to work with timers and loops in C#.

## Features

- Countdown based on user input (seconds or minutes)
- Pre-start phase (Ready, Set, Go)
- Console-based interface with dynamic countdown display
- Modular code structure for better readability

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 6.0 or higher recommended)
- A terminal or command prompt
- (Optional) Visual Studio Code or another C# compatible IDE

## How to Run

1. **Clone the repository:**

   ```bash
   git clone https://github.com/alfredo-petri/csharp-console-stopwatch.git
   cd csharp-console-stopwatch
    ```

2. **Build the project:**

    ```bash
    dotnet build
    ````

3. **Run the application:**

    ```bash
    cd StopWatch
    dotnet run
    ```

## Future Improvements

- Input validation for invalid formats (e.g., letters without time values, empty input)
- Error handling to avoid crashes on invalid input
- Support for pause/resume and reset functions
- Option to count up instead of down
- Display elapsed time in a formatted hh:mm:ss style
- Add a more user-friendly interface (e.g., menu system with clear options and instructions)

## License
This project is licensed under the MIT License. See the [LICENSE](https://github.com/alfredo-petri/csharp-console-stopwatch/blob/main/LICENSE) file for details.


