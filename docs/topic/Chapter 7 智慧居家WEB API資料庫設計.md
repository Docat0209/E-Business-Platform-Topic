# 第四章 智慧居家WEB API資料庫設計

## 4-1 建構WEB API前的事前準備
設計WEB API之前必須先好好思考自己到底想做什麼，有一個好的基底與構想，在建構WEB API上面也會快上許多，所以我們需要問自己，這個WEB API的主題是什麼?主要的服務對象是誰?我能從哪裡獲取資料?我要怎麼把資料處存起來?我要怎麼對這些資料進行操作?這些問題是設計的**基底**而我們要在此之上建立**構想**。而本書所建立的WEB API主題是**智慧居家**，對於物聯網主題，大家所想到的十之八九都是智慧居家，但是能夠真正設計出一個流暢的物聯網結構的人到底有多少?這個WEB API服務的對象是擁有智慧電器的家庭，我能夠從這些電器上的感測器獲取我所需要的資料，我可以把資料處存在SQL資料庫，我可以透過手機對這些電器進行操作，讓手機變成電器的萬能遙控器。這樣子就是一個完整的構想，這些構想不只能運用在WEB API上，有許多事情經過這樣子的思考過後，要做的事情便會變得明朗。

在設計WEB API前，首先需要認識SQL資料庫是什麼?資料庫顧名思義他的功能就是他的就是拿來提取與存處資料，而SQL資料庫中的SQL是什麼?SQL(Structured Query Language) 結構化查詢語言，SQL可以透過組合語法來對資料庫進行查詢，對於資料庫的操作來說十分方便，SQL的主要功能便是輔助這個資料庫進行資料處理，其中也包含了許多強大的語法，本書只會提其幾個常用的資料庫語法以及如何建立一個經過正規化的SQL資料庫，讓WEB API可以順利建立。

## 4-2 智慧居家資料庫設計
首先，要先設計一個智慧居家系統所需要的資料庫結構，必須先從使用者的角度來進行，一個使用者使用您提供的服務時，第一件事便是在一個裝置進行**登入**，登入後才能對物聯網中的裝置進行操縱，所以先從一個**帳號**開始下手，一個帳號必須擁有**帳號**與**密碼**，在這個帳號登入後，勢必也會記錄有關這個帳號的相關資料，如**使用者名稱**與**所在地區**等等重要相關資料，透過這些闡述，便能建立出如下圖的資料庫實體-關聯模型，這個模型對於資料庫的建構有非常大的幫助，能夠用圖形搭配文字說明，來建立出一個龐大的資料庫。

![](https://i.imgur.com/fBpHfVw.png)
##### 圖2-1 登入系統實體-關係模型

透過很直觀的方式，便能將實體-關聯模型，轉換成實際上能夠使用的資料庫，在建立資料庫的時候只要把模型上的**實體**與**虛實體**建立成資料表，在資料表中加入對應的**資料行**，並幫這些資料行加上對應的**資料類型**，最後再幫他們連接上**關聯鍵**，便能完美的進行模型與資料表之間的轉換了。

![](https://i.imgur.com/fgScgQx.png)
##### 圖2-2 登入系統資料庫圖表(可參考附錄 4-1)

有了紀錄使用者帳密的資料表後，便是要思考如何將智慧家電的資料放入資料庫中，對於一個使用者來說，擁有智慧居家的地點並非都是同一個**位置**，例如使用者可以控制公司及家中兩個地方的電器，其中每個電器電器又可以細分成不同**區域**，如公司的辦公室或者家中的廚房，這些地方便會有所謂的**裝置**，每個裝置又擁有各自不同的**屬性**和**類型**，最終再將這想法轉換成模型和資料庫，如下圖所示。

![](https://i.imgur.com/6Cnb0Tn.png)
##### 圖2-3 智慧居家實體-關係模型

![](https://i.imgur.com/K23il4S.png)
##### 圖2-4 智慧居家系統資料庫圖表(可參考附錄 4-2)

在這兩個模型中，能夠發現都是以**實體**為中心去建立，這樣的好處便是可以拆分清楚**虛實體**是依附於誰，最後在將**實體**關聯起來，透過這樣循序漸進的方式，才能夠清楚的知道自己在建立什麼。

對於智慧居家來說，每個電器都有屬於自己的**權限**，並不是一個陌生人都能操控你家的電器，因此最後必須將**登入資料庫**與與**智慧居家資料庫**連接起來，透過權限資料表來讓登入資料庫與智慧居家資料庫產生交集。

![](https://i.imgur.com/Kk7zGSl.png)
##### 圖2-5 權限實體-關係模型

![](https://i.imgur.com/Ft1wO4u.png)
##### 圖2-6 智慧居家與帳號資料庫連接

## 4-3 思考方向與未來的擴充性
資料庫的建構便是從一個**對象**去下手，只要能夠以這樣的方面去進行建構，便能快速的建立自己所需要的資料庫，架構想好之後，剩下的便只剩下BCNF正規化了，BCNF正規化是一個很重要的事情，但多人會因為覺得很麻煩而不去做的一件事，在這裡我提供一個我建立BCNF正規化所使用的準則:
1. 避免一個資料表中有非不定值存在
2. 每個資料表都必須有ID且ID為主鍵
3. 關聯鍵其中一方必為主鍵

第一點的不定值，指的是其內容並非能預測的內容，如一個人的名稱，而非不定值如一個人的生理性別，其中的值只有幾種可能性，透過這個準則去拆分資料表，便能把一個資料表中的**遞移相依**全部區分開來了。至於第二點，ID就像是一個識別證，可以在連接關聯的時候，透過ID來判別這筆資料到底是哪筆資料，並且要將ID設為主鍵，這樣能確保資料並不會重複輸入和能夠加速資料庫對ID的處理速度。第三點是在連接關聯鍵的時候的一個小技巧，關聯的其中一方必為主鍵，若是資料表的其中一方為多主鍵，則變成關聯鍵兩方皆為主鍵。透過這三個準則便能輕易的建立出一個符合BCNF的資料庫了，這可以讓未來的新增與修改輕鬆許多。

對於未來的擴充，可以視情況或是在編寫使用者介面，或未來新增新的功能的時候，自行新增資料庫來增加所需的內容，或補齊所欠缺的東西，本章所建立的資料庫，距離可以用來商用的智慧居家資料庫還有一定的距離，不光是因為此範例並非按照真實情況去建立，還有在資安方面，本書所建構的例子並沒有將資安結構考慮進去，「術業有專攻」，在資安方面參考資安專家的建議或是去參考資安類的書籍，但這不會直接導致整體構造的更改，但最重要的還是要隨著使用者的反饋來對自己的程式進行功能新增與修改。
