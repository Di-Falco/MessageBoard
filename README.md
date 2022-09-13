# _Message Board_

#### By _Anthony DiFalco_

#### _A forum where users can log in and post messages under different topics_

---
## Table of Contents
[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)  
[Known Bugs](#known-bugs)  
[License](#License)

---
## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity / Identity_
* _MVC_

---
## Description

This repository contains two files:
* MessageBoard:
  Holds the API for storing forum data such as messages and forum topics
* MessageClient:
  An MVC site which has a user database with Identity and displays all of the posts and topics from the MessageBoard API

---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>  

1. Copy the git repository url: https://github.com/Di-Falco/MessageBoard  
2. Open the terminal and navigate to your desktop.
3. Clone the repository for this project using the `git clone` command and including the copied URL.
4. While still in the terminal, navigate to the `MessageBoard` directory of the newly created file.
5. Move onto SQL Workbench instructions below to re-create database necessary to run this project.
6. Returning to the terminal, navigate to the `MessageClient` directory.
7. Complete the SQL Workbench setup for this directory as well.
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>

1. Create an <font color="green">`appsettings.json`</font> file in the `MessageClient` / `MessageBoard` directory of the project  
   <pre>MessageBoard
   └── MessageBoard / MessageClient
    └── <strong><font color="yellow">appsetting.json</font></strong></pre>
2. Insert the following code [^1]  note: database name is either `message_client` or `message_board` depending on which directory is being set up
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE NAME];uid=root;pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

3. Once <font color="green">`appsettings.json`</font> file has been created, navigate back to SQL Workbench.
</details>

<details>
<summary><strong>To Run</strong></summary>

1. Navigate to:  
   <pre>MessageBoard
   └── <strong><font color="yellow">MessageBoard / MessageClient</font></strong></pre>

2. Run `$ dotnet restore` in the console.  
3. Run `$ dotnet database update` in the console.  
4. Run `$ dotnet run` in the console
5. Repeat steps 1-4 for the other directory 
</details>

This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* Forum topcs have to be seeded to the database, as there is no roles-based authorization yet. The goal moving forward is to add admin roles which can add and delete forum topics. 

---
## [License](/LICENSE)

_Feel free to reach out via [Github](https://github.com/Di-Falco) to provide feedback on this project or to view my other projects._

© 2022 Anthony DiFalco

---
### Footnotes

[^1]: You must include your password in the code block section labeled `YOUR-PASSWORD-HERE`.
Footer
