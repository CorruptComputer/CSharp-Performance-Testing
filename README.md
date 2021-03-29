# C# Performance Testing
## Summary
This project was started out of my own curiosity at work as to why a certain area of our application was performing badly. I have since extended it to add other test cases and small explanations as to why these numbers happen the way they do.

Don't have time to download and run it? Here's the TLDR of the tests:
- Failures Throw VS. Failures Return
  - **TLDR:** Throwing on a recoverable error is a LOT higher of a runtime cost.
    ![image](https://user-images.githubusercontent.com/5573038/112841096-14851380-906e-11eb-87a8-31737b7dea7c.png)
- Classes VS. Structs
  - **TLDR:** If you are using a Class as only a data structure without any methods it has a higher runtime cost than Structs.
    ![image](https://user-images.githubusercontent.com/5573038/112841242-41d1c180-906e-11eb-8712-9b82d490406d.png)
- String VS. StringBuilder
  - Concatenation (small & large)
    - **TLDR:** StringBuilder is a LOT faster than Strings, even for small iteration counts.
      ![image](https://user-images.githubusercontent.com/5573038/112841311-557d2800-906e-11eb-842b-437e5b8c17df.png)
      ![image](https://user-images.githubusercontent.com/5573038/112841358-6168ea00-906e-11eb-8e40-888ec10c3d5b.png)
  - Replacements  (small & large)
    - **TLDR:** Strings are about twice as fast than StringBuilders for character replacements.
      ![image](https://user-images.githubusercontent.com/5573038/112841404-6d54ac00-906e-11eb-8018-ff43b3ecfc38.png)
      ![image](https://user-images.githubusercontent.com/5573038/112841436-78a7d780-906e-11eb-951d-d93d79cc11ee.png)
- For VS. ForEach
  - **TLDR:** There seems to be almost no difference in the runtime of For and ForEach and the time with vary from run to run.
    ![image](https://user-images.githubusercontent.com/5573038/112841511-8eb59800-906e-11eb-9a79-2a40ef468d81.png)
    ![image](https://user-images.githubusercontent.com/5573038/112841536-98d79680-906e-11eb-85c9-339161533d40.png)
- Property VS. Member
  - **TLDR:** Properties are a decent amount slower than Members due to the additional overhead for the method calls.
    ![image](https://user-images.githubusercontent.com/5573038/112841590-aab93980-906e-11eb-87fd-63144ad765b4.png)

The speeds shown in the Screenshot were run on an "Intel(R) Core(TM) i5-5200U CPU @ 2.20GHz" CPU.

## Running
Install .NET 5 for your Operating System, instructions can be found here: https://dotnet.microsoft.com/download/dotnet/5.0

Once you clone the code locally it can be run with `dotnet run` on the command line.

## Contributing
Do you have a test case you would like to add? Send over a PR or open an issue! I would be happy to review and add anything which could be useful to other devs out there trying to tweak the performance of their applications. The areas covered are ones that I had thought of and figured might be the most useful, but I'm sure that there are others out there and would love to know about them.