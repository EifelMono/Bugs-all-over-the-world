Terminal Window closes with error on terminate a DocFx process in the terminal

Visual studio Code 1.32.1
DocFx 2.40.12.0


* Create a folder
* Open VSCode
* Open Terminal
* Run:  docfx init -q
* Run:  docfx .\docfx_project\docfx.json --serve -p 4711 
* Terminate with CTRL C the process
* Wait: terminal closes with Error


