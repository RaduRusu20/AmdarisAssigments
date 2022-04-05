USE DatabaseAssigment;

INSERT INTO dbo.ShoppingCarts VALUES
('sh1'),
('sh2'),
('sh3'),
('sh4'),
('sh5'),
(NULL),
(NULL),
(NULL),
(NULL),
(NULL)
;

INSERT INTO dbo.Customers  VALUES
('Radu', 'Rusu', 'rusu.radu@amdaris.com', 'password', '07521903', 'Simand', 1),
('Andrei', 'Rusu', 'rusu.andrei@amdaris.com', 'somepass', '075445781', NULL, 2),
('Ovidiu', 'Bogosel', 'bogosel.ovidiu@amdaris.com', '123456', '07908912', 'Santana', 3),
('Flavius', 'Rosa', 'rosa.flavius@amdaris.com', 'qwerty','07467132', 'Arad', 4),
('David', 'Filimon', 'filimon.david@amdaris.com', 'nopass','07891329', 'Arad', 5),
('Norbert', 'Bora', 'bora.norbert@amdaris.com', 'ryavd34922', '07901123', NULL, 6),
('Allen', 'Farcas', 'farcas.Allen@amdaris.com', 'KingOfPbInfo99', '07124512', 'Nadlac', 7),
('Alex', 'Rotar', 'rotar.alex@amdaris.com', 'RazerXP600', '07889021', NULL, 8),
('Alex', 'Boazdog', 'bozdog.alex@amdaris.com', 'assigment', '07239081', 'Timisoara', 9),
('Radu', 'Marinescu', 'marinescu.radu@amdaris.com', 'TDD90142', '07890987', 'Timisoara', 10)
;


INSERT INTO dbo.Products VALUES
('minge fotbal', 'rosie', 130.9, 10),
('minge rugby', 'maro', 79.9, 9.5),
('minge voley', 'bicolora', 100, 10),
('ghete fotbal', 'marimea 39', 210.9, 8.9),
('jaloane', NULL, 49.99, 6),
('gantere', '2/set', 87.8, 7.9),
('banda de alergare', 'firma: SportX', 2499.99, 9.3),
('arc', 'nu include sageti', 100, 10),
('paleta ping-pong', 'timo boll edition', 317.79, 10),
('racheta tenis', NULL, 500.89, 9.9)
;


INSERT INTO dbo.ShoppingCartsProducts VALUES
(1, 1),
(1, 2),
(1, 3),
(1, 4),
(2, 1),
(2, 3),
(2, 7),
(3, 1),
(4, 5),
(4, 6),
(5, 3),
(5, 4),
(6, 1),
(6, 2),
(7, 4),
(7, 5),
(7, 7),
(8, 10),
(9, 3),
(10, 1),
(10, 2),
(10, 3)
;