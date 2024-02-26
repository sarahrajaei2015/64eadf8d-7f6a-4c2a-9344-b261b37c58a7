# Longest Increasing Subsequence Finder

This console application develops a function that takes one string input of any number of integers separated by single whitespace. 
The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. 
If more than 1 sequence exists with the longest length, output the earliest one. You may develop supporting functions as many as you find reasonable.

## Usage

### Run the Application

1. Ensure you have [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) installed.
2. Clone this repository.
3. Open a terminal or command prompt in the project directory.

#### From Command Line

To provide a sequence of numbers directly:

dotnet run "1 2 3 4 2 5 6 7 8 9"

To provide a file containing the sequence:
(There is a directory called TestData in the project which contains list of the files which can be used as an input like following

dotnet run TestCase1.txt 

Input Options

Sequence of Numbers:
Enter a sequence of numbers separated by spaces when prompted.
Example: 1 2 3 4 5

File Input:
Provide a file containing the sequence of numbers.
Example: dotnet run TestCase1.txt
