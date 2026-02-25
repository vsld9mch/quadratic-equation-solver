# Quadratic Equation Solver

## Project Overview
This console application is designed to solve quadratic equations in the form $ax^{2}+bx+c=0$. It provides a robust mathematical tool that automatically distinguishes between quadratic and linear equations based on the input coefficients.

## Features
* **Real Number Support**: Processes all coefficients and roots as real (double) numbers.
* **Smart Detection**: 
    * If $a \neq 0$, the program calculates the discriminant ($\Delta$) and finds up to 2 real roots.
    * If $a = 0$, the program automatically treats and solves it as a linear equation.
* **Batch Processing**: The application runs in a loop, allowing the user to solve exactly 3 equations per session.
* **Technical Requirement Compliance**: All variable names in the source code are prefixed with the author's initials (e.g., `vdi_a`, `vdi_b`).

## Technical Details
* **Language**: C#
* **Target Framework**: .NET 6.0
* **Project Type**: Console Application

## How to Run

1.  **Requirement**: Ensure you have the **.NET 6.0 SDK** installed.
2.  **Download**: Clone or download the project files.
3.  **Navigate**: Open your terminal in the project folder.
4.  **Execute**: Run the following commands:
    ```bash
    dotnet build
    dotnet run
    ```
5.  **Interaction**: Follow the console prompts to enter values for $a$, $b$, and $c$.
