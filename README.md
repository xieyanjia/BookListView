# BookListView

這是一個簡單圖書瀏覽與借閱管理系統。您可以透過不同的檢視模式（如大圖示、詳細資料等）輕鬆瀏覽書籍，並透過雙擊將想看的書籍加入右側的借閱清單中。

## 專案功能簡介

1. 多功能檢視模式：支援 5 種不同的書籍檢視方式，包含大圖示、詳細資料、小圖示、清單以及大圖示加詳細資料。

2. 動態資料呈現：系統啟動時會自動載入預設的書籍資料（書名、作者、類別），並為每本書籍配置對應的封面圖示。

3. 互動式借閱功能：

   - 雙擊書籍時，系統會跳出確認對話框詢問是否借閱。

   - 防重複借閱機制：系統會自動檢查，若該書籍已存在於「借書清單」中，則不會重複加入。


## 執行說明

1. 啟動程式：在 Visual Studio 中開啟本專案，按下鍵盤的 F5 鍵或點擊上方的 「開始」 按鈕來執行程式。

2. 切換瀏覽模式：點擊畫面上方的下拉選單（預設為「大圖示」），您可以自由切換成「詳細資料」、「小圖示」、「清單」或「大圖示加詳細資料」，書籍清單會立即改變外觀。

   - 提示：切換到「詳細資料」模式時，可以看到清晰的書名、作者與類別欄位。

3. 借閱書籍：在您想要借閱的書籍上連點滑鼠左鍵兩下（或選取書籍後按 Enter 鍵）。

4. 確認借閱：畫面上會彈出確認視窗，詢問「確定要借閱嗎？」，請點擊「是」。

5. 查看清單：確認後，該書籍的名稱就會成功加入到右側的「借書清單」中。

   - 注意：如果您對同一本書再次連點兩下，系統會自動偵測並攔截，不會重複加入清單。
  
<img width="844" height="486" alt="image" src="https://github.com/user-attachments/assets/bc5a135b-b5e5-47bc-b16d-80b528686fb0" />

<img width="833" height="470" alt="image" src="https://github.com/user-attachments/assets/eefe0f36-22ec-458d-9a4b-796893aa65e4" />

<img width="833" height="471" alt="image" src="https://github.com/user-attachments/assets/d5174654-25c4-43d1-bfae-517da51d7cd7" />

<img width="833" height="473" alt="image" src="https://github.com/user-attachments/assets/661eb1bf-248f-4e05-8797-49a03e46babf" />

<img width="834" height="475" alt="image" src="https://github.com/user-attachments/assets/c349afdd-519e-4630-ae0f-f862b8c5b1f3" />

<img width="845" height="486" alt="image" src="https://github.com/user-attachments/assets/158a2f63-86cb-445c-be94-5586edb6df1c" />

<img width="843" height="485" alt="image" src="https://github.com/user-attachments/assets/e36fa17f-069f-411e-8c72-95c8e80f6422" />

