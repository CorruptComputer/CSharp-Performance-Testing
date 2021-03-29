# C# Performance Testing
## Summary
This project was started out of my own curiosity at work as to why a certain area of our application was performing badly. I have since extended it to add other test cases and small explanations as to why these numbers happen the way they do.

Don't have time to download and run it? Here's the TLDR of the tests:
- Failures Throw VS. Failures Return
  - **TLDR:** Throwing on a recoverable error is a LOT higher of a runtime cost.
- Classes VS. Structs
  - **TLDR:** If you are using a Class as only a data structure without any methods it has a higher runtime cost than Structs.
- String VS. StringBuilder
  - Concatenation (small & large)
    - **TLDR:** StringBuilder is a LOT faster than Strings, even for small iteration counts.
  - Replacements  (small & large)
    - **TLDR:** Strings are about twice as fast than StringBuilders for character replacements.
- For VS. ForEach
  - **TLDR:** There seems to be almost no difference in the runtime of For and ForEach and the time with vary from run to run.
- Property VS. Member
  - **TLDR:** Properties are a decent amount slower than Members due to the additional overhead for the method calls.

## Running
Install .NET 5 for your Operating System, instructions can be found here: https://dotnet.microsoft.com/download/dotnet/5.0

Once you clone the code locally it can be run with `dotnet run` on the command line.

## Contributing
Do you have a test case you would like to add? Send over a PR or open an issue! I would be happy to review and add anything which could be useful to other devs out there trying to tweak the performance of their applications. The areas covered are ones that I had thought of and figured might be the most useful, but I'm sure that there are others out there and would love to know about them.