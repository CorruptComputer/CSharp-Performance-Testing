# C# Performance Testing
## Summary
This project was started out of my own curiosity at work as to why a certain area of our application was performing badly. 

Here are all of the tests currently added:
- Failures Throw VS. Failures Return
- Classes VS. Structs
- String VS. StringBuilder
  - Concatenation (small & large)
  - Replacements (small & large)
- For VS. ForEach
- Property VS. Member
- Key/Value Pair Types

## Running
Install .NET 5 for your Operating System, instructions can be found here: https://dotnet.microsoft.com/download/dotnet/5.0

Once you clone the code locally it can be run with `dotnet run` on the command line.

## Contributing
Do you have a test case you would like to add? Send over a PR or open an issue! I would be happy to review and add anything which could be useful to other devs out there trying to tweak the performance of their applications. The areas covered are ones that I had thought of and figured might be the most useful, but I'm sure that there are others out there and would love to know about them.
