# _Word Counter_

#### _This program returns the number of times a word appears in a given sentence, August 11, 2017_

#### By _**Lois Choi**_

## Description

_This program is for an Epicodus project. A user can enter a sentence and a word they would like to search within that sentence. Then the program returns the number of times that word appears._

| Behavior  | Input  | Output  |
|---|---|---|
| 1. User enters a sentence and searches for a word that does not appear in the sentence (this is the simplest behavior because the program does not need to search for anything and simply returns a 0)  | Sentence: "Hello world" Search: "Goodbye"  | Return: 0   |
| 2. User enters a sentence and searches for word that appears once (this is the next simplest behavior because it require the program to just search for one matching word)  | Sentence: "I like dogs." Search: "like"   |  Return: 1  |
| 3. User enters a sentence and searches for a word that appears multiple times (this is the next behavior because it requires the program to search for multiple words and return the added total)  | Sentence: "He has she has the dog has" Search: "has" | Return: 3  |
| 4. Users can search a word regardless of casing (this is the next behavior because it considers how users may input the search word, but does not necessarily affect the overall program for the first 3 specs - it is an added on precaution to user input)  | Sentence: "He has she has the dog has" Search: "Has" | Return: 3  |

## Setup/Installation Requirements

* _Clone repository_

## Technologies Used

_HTML, CSS, C#, .NET_

### License

*MIT License*

Copyright (c) 2017 **_Lois Choi_**
