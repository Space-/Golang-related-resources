Go語言特性
    Google開發並負責維護的開源專案!
    靜態、編譯型, 自帶GC和併發處理的語言, 能編譯出目標平台的可執行檔案, 編譯速度也快.
    全平台適用, Arm都能執行
    上手容易, 我覺得跟C比較真的頗容易, 但跟JS比我覺得還是差一些
    原生支援併發 (goroutine), 透過channel進行通信
    關鍵字少, 30個左右吧
    用字首大小寫, 判別是否是public / private
    沒用到的import 或者是 變數, 都會在編譯時期給予警告
    沒有繼承!
    適合寫些工具, 像是hugo、fzf、Drone、Docker
    適合其他語言大部分的業務, RestAPI, RPC, WebSocket
    內含測試框架
    不必在煩惱 到底要i++還是++i了, 因為在Go裡沒有++i, 也不能透過i++賦值給其他的變數