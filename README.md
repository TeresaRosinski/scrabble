# _Scrabble_

#### _C# Practice, 7.16.20_

#### By _**Teresa Rosinski, Megan Hepner**_



## Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **Program instantiates Word object class** |  | string |
  **Program accepts user input as new object** | "Rabbit | _____ |
  **Program separates string into letters** | "Rabbit" | "R", "A", "B", "B", "I", "T" |
| **Program awards 1 pt for the following letters AEIOULNRST** | "Rabbit" | 4 |
| **Program awards 2 pts for the following letters DG** | "Rabbit" | 0 |
| **Program awards 3 pts for the following letters BCMP** | "Rabbit" | 6 |
| **Program awards 4 pts for the following letters FHVWY** | "Rabbit" | 0 | 
| **Program awards 5 pts for the following letter K** | "Rabbit" | 0 | 
| **Program awards 8 pts for the following letters JX** | "Rabbit" | 0 | 
| **Program awards 10 pts for the following letters QZ** | "Rabbit" | 0 | 
| **Program returns total score of word to user** | "Rabbit" | Your scrabble word is worth 10 points! | 

## Support and contact details

_For question, concerns, or if you would like to make contributions to this work, please contact Megan Hepner, or Teresa Rosinski_

## Technologies Used

VSCode
C#
.NET Core

### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Megan Hepner_** **_Teresa Rosinski_**