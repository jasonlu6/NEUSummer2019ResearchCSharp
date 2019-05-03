# NEUSummer2019ResearchCSharp
C# Training Code (for understanding C# programming language for Unity AR/VR projects) 

# Command To Run The Scripts: 

1) First, ensure no errors. 

2) Then, to compile, install Mono, using this guide below: 

https://www.mono-project.com/download/stable/

3) Read carefully this guide on how to use mono compilation for C# programs: 

https://kozmicluis.com/compile-c-sharp-command-line/

4) To compile the .cs file (say example.cs), use the following command: 

** `csc` is also an acceptable alternative command!  **

`mcs -out:example.exe example.cs` 

5) Then, once there are no errors, you can directly run it with the `mono` command: 

`mono example.exe` 

** You can also make it redirect to an output file (if the output gets too large!), with the command 
`mono example.exe > output.txt` **

It should successfully run the .cs file with the .exe executable (make sure both files are in the same directory,
with same execution permissions, which can be checked with the `pwd ../` and `ls -lart` commands)

# Further Reference: 

https://www.mono-project.com/docs/getting-started/mono-basics/
