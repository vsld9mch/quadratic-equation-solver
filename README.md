# Quadratic Equation Solver

## Project Overview
[cite_start]This project is a console application designed to solve quadratic equations in the form $ax^{2}+bx+c=0$[cite: 5]. [cite_start]The program is built to handle both quadratic and linear cases, providing a robust mathematical tool for root calculation[cite: 18, 20].

## Key Features
* [cite_start]**Support for Real Numbers**: The program accepts and processes coefficients as real numbers[cite: 8].
* [cite_start]**Hybrid Logic**: It automatically detects if the equation is quadratic or linear (if $a=0$) and applies the appropriate solving method[cite: 18, 20].
* [cite_start]**Discriminant Analysis**: Uses the Delta ($\Delta$) value to determine if the equation has 2, 1, or 0 real roots[cite: 21].
* [cite_start]**Batch Processing**: Each session allows the user to solve exactly **3 equations** through a programmed loop[cite: 12].
* [cite_start]**Technical Compliance**: Variable names follow a specific requirement by starting with the author's initials (e.g., `vdi_a`, `vdi_b`, `vdi_c`)[cite: 9, 10].

## Technical Stack
* **Language**: C#
* [cite_start]**Framework**: .NET 6.0 [cite: 24]
* [cite_start]**Output**: Console Application [cite: 24]

## How to Run

### Prerequisites
* [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) installed on your machine.

### Instructions
1.  **Clone the repository**:
    ```bash
    git clone <your-repository-url>
    ```
2.  **Navigate to the project directory**:
    ```bash
    cd Project1
    ```
3.  **Build the project**:
    ```bash
    dotnet build
    ```
4.  **Run the application**:
    ```bash
    dotnet run
    ```

Once running, follow the on-screen prompts to enter the coefficients $a$, $b$, and $c$. [cite_start]The program will provide solutions for three consecutive equations before closing[cite: 12].
