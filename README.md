IQueryable Extension , Like , OrderBy
  
1. 
根據查詢內容是否有% 符號來決定Like的方式 , 

ex : 如果使用者輸入 gg% => DB的where要是 like N'gg%'

EndsWith , Contains , StartsWith

2.
根據陣列作相對應的排序
