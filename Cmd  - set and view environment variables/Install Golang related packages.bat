:: Following script should open cmd and run as "Administrator"



:: Add %GOROOT% system environment variable
SETX -M GOROOT C:\Go\

:: Install Golang related packages
go get -u -v github.com/nsf/gocode
go get -u -v github.com/rogpeppe/godef
go get -u -v github.com/golang/lint/golint
go get -u -v github.com/lukehoban/go-find-references
go get -u -v sourcegraph.com/sqs/goreturns
go get -u -v golang.org/x/tools/cmd/gorename
go get -u -v github.com/derekparker/delve/cmd/dlv