# Routing 路由

建立一個 ASP NET MVC 專案，使用對應的 url 完成 http 參數存取

## 基本

- 使用瀏覽器輸入 http://{host}/Customer/Detail 開啟一個有表單 form 的頁面 (樣式不拘，可以自己設計)

- Form 有以下參數

    - Name - 使用者名稱
    - Phone - 手機號碼
    - Email - 電子信箱

- 送出表單至 http://{host}/Customer/Check 之後，顯示表單欄位輸入的結果及一個按鈕 Save 的頁面 (樣式不拘，可以自己設計)

- 點擊 Save，使用 POST 到 http://{host}/Data/Save，將輸入的資料存成 txt 檔案至 App_Data 資料夾中 (內容格式及檔案名稱請自己設計)，並回傳一個頁面顯示儲存的檔案名稱 (樣式不拘，可以自己設計)


## 改良

- Phone, Email 欄位驗證