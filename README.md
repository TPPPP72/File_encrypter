# File_encrypter

This is a simple file encrypter, you can use it to encode files of any type.  
The program uses **nonequivalence operation** to implement encryption.  

## `encrypt.exe`

### Usage
`encrypt (encode|decode) <file> <password> [output]`

### How to build
This is a C++ project, please config a compiler in your environment variables.  
You can build this project using `build.bat` or cmake with a minimum version of gcc 5.2.

## `encrypter_ui.exe`

### How to build
This is a C# project, coding over the Visual Studio 2022 environment.  
The UI is implemented using the open source project [Sunny UI](https://github.com/yhuse/SunnyUI).  
Before you build this project, please make sure you have install the ui library.
Run the command pm>`Install-Package SunnyUI` to install.  
After all of them, you can build this project just by `Build the solution`.

---
**Pull requests welcome.**
