select *  from EmployeeType
select * from Category
select  * from MenuItem

/*Employee types */
INSERT INTO EmployeeType VALUES('MN','Manager');
INSERT INTO EmployeeType VALUES('KC','Kitchen');
INSERT INTO EmployeeType VALUES('BR','Bar');
INSERT INTO EmployeeType VALUES('WA','Waiter');

/*Category types*/
INSERT INTO Category VALUES('LM','LUNCH',6,'Lunch main');
INSERT INTO Category VALUES('LS','LUNCH',6,'Lunch special');
INSERT INTO Category VALUES ('LB','LUNCH',6,'Lunch bites');
INSERT INTO Category VALUES ('DS','DINNER',6,'Starters');
INSERT INTO Category VALUES ('DM','DINNER',6,'Mains');
INSERT INTO Category VALUES ('DD','DINNER',6,'Desserts');
INSERT INTO Category VALUES ('SD','DRINKS',6,'Soft Drinks');
INSERT INTO Category VALUES('HD','DRINKS',6,'HOT DRINKS');
INSERT INTO Category VALUES ('WD','DRINKS',21,'Wines');
INSERT INTO Category VALUES ('BD','DRINKS',21,'Beers');

/* Menu items*/
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock) VALUES('LM','SALADE NIÇOISE',9.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LM','FRENCH OMLETTE',8,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock) VALUES('LM','FENNEL DAUPHINOISE',9.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LM','QUICHE OF THE DAY',8.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LS','CROQUE MONSIEUR - TOAST',8.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LS','CROQUE MADAME - TOAST',9.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LS','HOMEMADE SOUP OF THE DAY',6.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LS','HOMEMADE ONIONSOUP',7.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LB','TORTILLA CHIPS',7.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LB','CRUDITÉS WITH OLIVE-ANCHOVY AIOLI',5.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LB','TOAST BELGIAN PRÉPARÉ',5.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('LB','BREAD',4.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DS','HOMEMADE SOUP OF THE DAY',6.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DS','HOMEMADE ONIONSOUP',7.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DS','BEEF CARPACCIO',8.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DS','ESCARGOTS',8.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DS','GOATCHEESE',9.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DM','TENDERLOIN FROM BLACK ANGUS',27.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DM','BUTCHER STEAK',19.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DM','LAMB CHOPS',25.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DM','RATATOUILLE',18.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DM','FRENCH FISH STEW',22.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DM','WHOLE LOBSTER',32.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DD','CRÈME BRÛLÉE',7.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DD','CHOCOLATE CRUMBLE',8.75,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DD','DAME BLANCHE',7.95,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('DD','CHEESE',12.50,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Coca Cola',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Sprite',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Fanta Orange',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Bitter Lemon',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Tonic',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Ginger Ale',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('SD','Lipton Ice Tea',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock) VALUES('HD','Coffee',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('HD','Tea',2.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('HD','Fresh mint tea',3.40,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('HD','Espresso',3,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('HD','Cappuccino',3.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('BD','Heineken Small',2.40,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('BD','Heineken Medium',3.50,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('BD','Palm',3.90,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('BD','Duvel',3.90,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('BD','Corona',4.90,80);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('WD','Sauvignon Blanc by the Bottle',16.90,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('WD','Sauvignon Blanc by the Glass',2.90,160);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('WD','Merlot by the Bottle',16.90,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('WD','Merlot by the Glass',2.90,160);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('WD','Rosé  by the Bottle',16.90,40);
INSERT INTO MenuItem(CategoryID,ItemName,Price,Stock)  VALUES('WD','Rosé  by the Glass',2.90,160);
