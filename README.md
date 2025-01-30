# Uninitialized Property Access in C#

This repository demonstrates a common, yet often subtle, error in C#: accessing a property before it has been initialized.  Uninitialized properties will have default values, but relying on these default values can lead to unexpected results and difficult-to-debug issues.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file provides a solution.

## Reproducing the Bug
1. Clone this repository.
2. Compile and run `bug.cs`.
3. Observe the output. The value printed will be the default value of an integer (0), which might not be the intended behavior.

## Solution
The solution is to always initialize properties explicitly, either in the constructor or when the property is first used. This makes code more readable and less error prone.