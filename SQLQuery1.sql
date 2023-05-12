--- Object: Database 'CosmeticRoom' -------------

GO

CREATE TABLE Login (    ID			INT				IDENTITY		PRIMARY KEY,
						UserName	VARCHAR(20)		NOT NULL,
						Password	VARCHAR(20));

Go
INSERT INTO Login VALUES ( 'admin', 'admin');

GO



Go

CREATE TABLE Masters (    MasterID			INT				IDENTITY		PRIMARY KEY,
						  MasterName		NVARCHAR(55)		NOT NULL,
						  Category          NVARCHAR(15)     NOT NULL);
Go



CREATE TABLE [Services] (	ServiceID			INT				IDENTITY		PRIMARY KEY,
						ServiceName			NVARCHAR(100),
						Address				NVARCHAR(50)		NOT NULL,
						Price				INT,
						MasterID			INT				REFERENCES		Masters (MasterID));

GO

CREATE TABLE Clients (	 ClientID			INT				IDENTITY		PRIMARY KEY,
						 ClientName			NVARCHAR (100)	NOT NULL,
						 Gender				NVARCHAR(10)		NOT NULL,
						 PhoneN				VARCHAR(50)		NOT NULL ) ;


GO
				
CREATE TABLE ServiceRegistration (
						RegistrationID			INT				IDENTITY		PRIMARY KEY,
						ClientID				INT				REFERENCES		Clients (ClientID),
						ServiceID				INT				REFERENCES		[Services] (ServiceID),
						DateofServ				DATE);



GO

INSERT INTO Masters		 VALUES		(N'Ульянова Дарья Ильинична', N'Высшая'),
									(N'Лазарева Виктория Владиславовна', N'Первая'),
									(N'Баранова Ева Владиславовна', N'Вторая'),
									(N'Аксенова Софья Фёдоровна', N'Третья');
	

Go

INSERT INTO [Services]	 VALUES		(N'Лазерная шлифовка',					N'ул. Федюнинского 5к1',		'14000', 1),	 
									(N'Лазерный карбоновый пилинг',			N'ул. Федюнинского 5к1',		'3800',  1),
									(N'Лазерная биоревитализация',			N'ул. Парфёновская 9к1',		'2800',  1), 
									(N'Микротоковая терапия',				N'ул. Федюнинского 5к1',		'2800',  4), 
									(N'Дермальный электромикролифтинг',		N'ул. Парфёновская 9к1',		'1900',  4),
									(N'Терапия PRX-T33',					N'ул. Парфёновская 9к1',		'5500',  2),
									(N'Фотоомоложение',						N'ул. Антонова-Овсеенко 21', '8500',  3),
									(N'Устранение мимических морщин(ботокс)',N'ул. Федюнинского 5к1',		'310',3),
									(N'RF-лифтинг всего лица',				N'ул. Антонова-Овсеенко 21', '4000',  2), 
									(N'Вакуумно-роликовый массаж всего тела',N'ул. Антонова-Овсеенко 21', '3500',  2),
									(N'Прессотерапия',						N'ул. Антонова-Овсеенко 21e','1800',  2),
									(N'Контурная пластика',					N'ул. Федюнинского 5к1',		'17000', 2), 
									(N'Чистка лица (ультразвуковой пилинг)', N'ул. Антонова-Овсеенко 21', '3500',  3); 

GO

INSERT INTO Clients VALUES			(N'Лукьянченко Елена Игоревна',		N'Ж',	'+7-954-454-63-73'),
									(N'Лизунова Ольга Васильевна',		N'Ж',	'+7-924-635-36-13'),
									(N'Чернова Екатерина Анатольевна',	N'Ж',	'+7-901-546-23-96'),
									(N'Пшеничникова Мария Владимировна',	N'Ж',	'+7-908-837-94-23'),
									(N'Ахметьянов Азат Ришатович',		N'М',	'+7-912-999-99-99'),
									(N'Егорова Полина Константиновна',	N'Ж',	'+7-900-888-44-43'),
									(N'Николаева Ксения Михайловна',		N'Ж',	'+7-945-545-45-54'),
									(N'Алешин Алексей Иванович',			N'М',	'+7-923-465-56-34'),
									(N'Кондратова Софья Сергеевна',		N'Ж',	'+7-974-734-82-94'),
									(N'Горшков Артемий Савельевич',		N'М',	'+7-943-244-56-46');
								

GO

INSERT INTO ServiceRegistration VALUES  (1, 2, '2023-05-21'),		
										(2, 5, '2023-05-28'),
										(3, 13, '2023-05-28'),		
										(4, 12, '2023-06-1'),		
										(5, 11, '2023-06-5'),
										(6, 10, '2023-06-5'),	
										(7, 3, '2023-06-5'),
										(8, 1, '2023-06-10'),
										(9, 7, '2023-06-10'),
										(9, 5, '2023-06-20');
