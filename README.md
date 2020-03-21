# UserInterfaceTesting.Framework.Lion <img src ="UserInterfaceTesting.Framework.Lion/images/lion.jpg" width=119>
This is a User Interface testing Framework using C#, .Net Framework, xUnit and Selenium WebDriver to test UltimateQA Practice site.

## Selenium WebDriver <img src ="UserInterfaceTesting.Framework.Lion/images/selenium.png" width=79>
Selenium WebDriver is a collection of open source APIs which are used to automate the testing of a web application. Selenium WebDriver tool is used to automate web application testing to verify that it works as expected. It supports many browsers such as Firefox, Chrome, IE, and Safari. WebDriver is a web automation framework that allows you to execute your tests against different browsers. It also enables you to use a programming language in creating your test scripts. https://www.seleniumhq.org/projects/webdriver/

## Target framework <img src ="UserInterfaceTesting.Framework.Lion/images/netframework.png" width=99>
.NET Framework 4.6

## UltimateQA Practice site <img src ="UserInterfaceTesting.Framework.Lion/images/ultimateqa.png" width=79>
A free place to practice some scenarios like:
* Testing a large complicated page
* Work with simple HTML elements like buttons
* Fill out forms
* Automate an application that evolves over time

https://www.ultimateqa.com/automation/

## Integrated Development Environment
Microsoft Visual Studio IDE is used to develop this Framework.

### Build Solution
* Build => Build Solution
<img src ="UserInterfaceTesting.Framework.Lion/images/build.png" width=350>

### Run Tests
* Test => Windows => Test Explorer => Run All
<img src ="UserInterfaceTesting.Framework.Lion/images/testexplorer.png" width=500>

### Build Solution with Command Prompt/Windows PowerShell
* Open Folder in File Explorer where you have the "UserInterfaceTesting.Framework.Lion.sln" file
* Open Command Prompt/Windows PowerShell
* Run "msbuild.exe"

#### Notes
* Make sure the 'PATH' of the "Environment Variables" is set for 'MSBuild'.
* PATH: C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\

### Run Tests with Command Prompt/Windows PowerShell
* Open Folder in File Explorer: ..\UserInterfaceTesting.Framework.Lion\bin\Debug
* Open Command Prompt/Windows PowerShell
* Run "dotnet vstest UserInterfaceTesting.Framework.Lion.dll"
