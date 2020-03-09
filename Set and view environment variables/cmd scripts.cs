對"current user", 新增環境變數
SETX xxx aa
(ex: SETX GOROOT C:\)


對"all users", 新增環境變數
SETX -M xxx aa
or
SETX xxx aa -M
(ex: SETX -M GOROOT C:\USER\)

-----------------------------------------


Clear environment variable (for "current user")
setx <variable> ""

Clear environment variable (for "all users")(系統變數)
setx -m <variable> ""


:: Delete User Environment Variable:
reg delete "HKCU\Environment" /v <variable> /f
(ex: reg delete "HKCU\Environment" /v MyVariableName /f)

:: Delete System-Wide Environment Variable:
REG delete "HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /F /V <variable>
(ex: REG delete "HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Environment" /F /V MyVariableName)


在某個環境變數（如PATH）後新增新的值（如d:\xxx）
set PATH=%PATH%;d:\xxx



-----------------------------------------


:: my script - to set up Golang environment path:
:: View Golang Path (到 https://golang.org/dl/  下載並安裝完 GOlang 之後, 預設就會建立好 GOPATH 這個環境變數, 變數設定的預設路徑為 "%USERPROFILE%\go", 可藉由 ECHO %USERPROFILE%\go 指令進行查看)
:: (另外還會在你當前使用者的 "PATH 環境變數" 後面添加%GOPATH%;  可以透過開啟cmd 並輸入 ECHO %PATH% 進行查看)
ECHO %GOPATH%

:: 開啟 cmd 輸入 go, 如果成功跑出相關訊息, 代表設定完成, Done !!!
---------------------------

:: Following script should open cmd and run as "Administrator"

:: Add %GOROOT% system environment variable
SETX -M GOROOT C:\Go\

:: Done !!!
---------------------------

References:
https://oranwind.org/go-ide-visual-studio-code/

https://shaochien.gitbooks.io/command-line-and-environment-variable-tutorial/content/environment-variable.html

https://codertw.com/%E5%89%8D%E7%AB%AF%E9%96%8B%E7%99%BC/388765/