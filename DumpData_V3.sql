INSERT INTO Categories
    ([Name])
VALUES
    (N'Thời Trang Nam'),
    (N'Thời Trang Nữ'),
    (N'Phụ kiện');
INSERT INTO TypeWires
    ([Name])
VALUES
    ('No'),
    (N'Da'),
    (N'Vải'),
    (N'Kim loại'),
    (N'Nhựa'),
    (N'Cao su'),
    (N'Ceramic');

INSERT INTO Products
    ([Name],[Price],[CategoryID],[TypeWireID],[Images],[ImageDefault])
VALUES
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('V_01', 1000000, 3, 1, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0);
INSERT INTO Products
    ([Name],[Price],[CategoryID],[TypeWireID],[Images],[ImageDefault])
VALUES
    ('DH_01', 1000000, 2, 4, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 2, 2, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 1, 7, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_01', 1000000, 2, 3, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_01', 1000000, 1, 3, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('CA_02', 1000000, 2, 3, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('CA_02', 1000000, 1, 7, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_01', 1000000, 1, 6, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 2, 4, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 1, 3, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0);
INSERT INTO Products
    ([Name],[Price],[CategoryID],[TypeWireID],[Images],[ImageDefault])
VALUES
    ('DH_01', 1000000, 1, 2, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_01', 1000000, 2, 4, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('CA_02', 1000000, 1, 6, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_01', 1000000, 1, 4, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('CA_02', 1000000, 2, 4, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 1, 6, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 1, 5, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('CA_02', 1000000, 1, 3, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 1, 7, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0),
    ('DH_04', 1000000, 1, 3, 'img_watch_1.jpg,img_watch_2.jpg,img_watch_3.jpg,img_watch_4.jpg', 0);



INSERT INTO ProductDetails
    ([ProductID],[TypeGlass],[TypeBorder],[TypeMachine],[Origin],[Brand],[Warranty],[Parameter],[ResistWater],[Func],[Color],[DescriptionProduct])
VALUES
    (1, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (2, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (3, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (4, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (5, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (6, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (7, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (8, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (9, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (10, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.')

INSERT INTO ProductDetails
    ([ProductID],[TypeGlass],[TypeBorder],[TypeMachine],[Origin],[Brand],[Warranty],[Parameter],[ResistWater],[Func],[Color],[DescriptionProduct])
VALUES
    (11, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (12, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (13, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (14, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (15, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (16, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (17, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (18, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (19, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (20, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.')

INSERT INTO ProductDetails
    ([ProductID],[TypeGlass],[TypeBorder],[TypeMachine],[Origin],[Brand],[Warranty],[Parameter],[ResistWater],[Func],[Color],[DescriptionProduct])
VALUES
    (21, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (22, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (23, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (24, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (25, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (26, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (27, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (28, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thụy Sỹ', N'Casio', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (29, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Nhật', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Gold', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.'),
    (30, N'Sapphire (Kính Chống Trầy)', N'Thép Không Gỉ', N'Automatic (Tự Động)', N'Thái Lan', N'Tissot', N'1 Năm', N'29mm x 20mm x 10mm', N'3 ATM', N'Xem Giờ, Xem lịch', N'Sivler', N'Đồng hồ/Timex là điểm nhấn sáng tạo của ngành công nghệ đồng hồ nước Mỹ. Nó đã ra đời và thực hiện tròn sứ mệnh của mình là trở thành mẫu đồng hồ đẳng cấp, thời thượng đi kèm chất lượng và bền bỉ theo thời gian.Cho dù là hàng trăm năm hay hàng nghìn năm, bằng những ưu điểm vượt trội này, nó sẽ “sống mãi” và trở thành tâm điểm trong ngành đồng hồ trang sức trên toàn thế giới.')


INSERT INTO Infos
    ([Logo],[TitleWeb],[NameShop],[Phone],[Address],[Email],[LinkFB])
VALUEs('logo.jpg', N'Watch Shop Online', N'Hommer House', 1268042216, N'123 Nguyễn Tri Phương, P .8 , Quận 10, TP.HCM', 'dangtoan030@gmail.com', 'fb.com/dangviettoan99');

INSERT INTO Fees
    ([Tax],[Transport])
VALUES(0, 30000)

INSERT INTO Policies
    ([Name],[Icon])
VALUES(N'Đổi tra trong vòng 12 giờ', 'change.png'),
    (N'Đổi tra trong vòng 12 giờ', 'change.png'),
    (N'Đổi tra trong vòng 12 giờ', 'change.png');

INSERT INTO Users
    ([Username],[Password])
VALUES('admin', '1234');

INSERT INTO Promotions
    ([Name],[FromDate],[ToDate],[Discount],[isAlways],[Amount])
VALUES
    ('Sale 40%', NULL, NULL, 0.4, 1, 0),
    ('Sale 10%', '5/5/2020', '8/8/2020', 0.1, 0, 0),
    ('Sale 40%', NULL, NULL, 0.1, 1, 0)


INSERT INTO PromotionDetails
    ([PromotionID],[ProductID])
VALUES
    (1, 1),
    (1, 2),
    (1, 3),
    (1, 4),
    (1, 5),
    (1, 6),
    (1, 7),
    (1, 8),
    (1, 9),
    (1, 10)

INSERT INTO PromotionDetails
    ([PromotionID],[ProductID])
VALUES
    (2, 5),
    (2, 2),
    (2, 3),
    (2, 4),
    (2, 1),
    (2, 16),
    (2, 17),
    (2, 18),
    (2, 19),
    (2, 20)

INSERT INTO BillPromotions
    ([PromotionID],[MinTotal],[NumberProduct])
VALUES
    (3, 0, 2)


INSERT INTO Customers
    ([Name],[Phone],[Address])
VALUES('Ivan Welch', '096-956-5629', '8389 Fames St.'),
    ('Austin Ellis', '096-956-5629', '922-5249 Elementum Av.'),
    ('Odysseus Dickson', '096-956-5629', '8765 Nulla Ave'),
    ('Honorato Berry', '096-956-5629', 'P.O. Box 576, 2541 Enim. Avenue'),
    ('Cullen Pickett', '096-956-5629', '8485 Velit St.'),
    ('Rooney Velazquez', '096-956-5629', 'Ap #595-3385 Libero. Street'),
    ('Peter Warner', '096-956-5629', 'Ap #584-3493 Amet St.'),
    ('Judah Reyes', '096-956-5629', 'Ap #389-5144 Dignissim. Av.'),
    ('Justin Mcdaniel', '096-956-5629', 'P.O. Box 641, 8413 Dignissim. Av.'),
    ('Myles Butler', '096-956-5629', 'P.O. Box 145, 1195 Purus. Av.');
INSERT INTO Customers
    ([Name],[Phone],[Address])
VALUES('Brendan Moore', '096-956-5629', '477-7030 Quis Avenue'),
    ('Otto Petty', '096-956-5629', '2447 Netus St.'),
    ('Carter Carpenter', '096-956-5629', '960-9562 Taciti Av.'),
    ('Barry Santiago', '096-956-5629', 'P.O. Box 693, 624 Eu Street'),
    ('Gavin Gould', '096-956-5629', '888-4545 Iaculis Avenue'),
    ('Upton Hess', '096-956-5629', '358-8076 Nulla St.'),
    ('Prescott Ayers', '096-956-5629', 'Ap #969-8061 Cras Road'),
    ('Leo Cabrera', '096-956-5629', '456-149 Felis Street'),
    ('Nathaniel Walters', '096-956-5629', 'P.O. Box 488, 4823 Etiam Rd.'),
    ('Samson Wilder', '096-956-5629', '9301 Vestibulum Ave');

INSERT INTO Orders
    ([DateCreated],[TransportFee],[Status],[CustomerID])
VALUES('04/18/2020', 30000, 4, 4),
    ('12/26/2020', 30000, 2, 12),
    ('01/17/2020', 30000, 1, 3),
    ('05/31/2020', 30000, 2, 7),
    ('07/08/2020', 30000, 1, 9),
    ('05/21/2020', 30000, 1, 12),
    ('04/02/2020', 30000, 2, 13),
    ('07/11/2020', 30000, 2, 10),
    ('04/25/2020', 30000, 1, 5),
    ('03/24/2020', 30000, 1, 8);
INSERT INTO Orders
    ([DateCreated],[TransportFee],[Status],[CustomerID])
VALUES('01/20/2020', 30000, 4, 16),
    ('08/10/2020', 30000, 3, 12),
    ('05/20/2020', 30000, 1, 9),
    ('06/26/2020', 30000, 1, 12),
    ('11/18/2020', 30000, 4, 5),
    ('06/10/2020', 30000, 1, 9),
    ('03/25/2020', 30000, 1, 20),
    ('06/27/2020', 30000, 2, 20),
    ('02/20/2020', 30000, 4, 19),
    ('08/16/2020', 30000, 3, 6);
INSERT INTO Orders
    ([DateCreated],[TransportFee],[Status],[CustomerID])
VALUES('12/23/2020', 30000, 2, 13),
    ('04/15/2020', 30000, 2, 19),
    ('05/04/2020', 30000, 3, 1),
    ('06/26/2020', 30000, 2, 3),
    ('06/27/2020', 30000, 2, 3),
    ('04/19/2020', 30000, 4, 17),
    ('05/11/2020', 30000, 3, 4),
    ('02/17/2020', 30000, 2, 20),
    ('11/19/2020', 30000, 3, 5),
    ('01/16/2020', 30000, 4, 14);

INSERT INTO OrderDetails
    ([OrderID],[ProductID],[Quantity],[Price],[Promotion])
VALUES(1, 2, 5, 299000, 0),
    (2, 15, 4, 299000, 0),
    (3, 22, 5, 299000, 0),
    (4, 6, 4, 299000, 0),
    (5, 22, 4, 299000, 0),
    (6, 27, 1, 299000, 0),
    (7, 25, 1, 299000, 0),
    (8, 29, 5, 299000, 0),
    (9, 18, 4, 299000, 0),
    (10, 8, 3, 299000, 0);
INSERT INTO OrderDetails
    ([OrderID],[ProductID],[Quantity],[Price],[Promotion])
VALUES(11, 9, 4, 299000, 0),
    (12, 6, 1, 299000, 0),
    (13, 3, 3, 299000, 0),
    (14, 19, 1, 299000, 0),
    (15, 7, 1, 299000, 0),
    (16, 23, 1, 299000, 0),
    (17, 29, 2, 299000, 0),
    (18, 3, 3, 299000, 0.4),
    (19, 26, 1, 299000, 0.4),
    (20, 18, 3, 299000, 0.4);
INSERT INTO OrderDetails
    ([OrderID],[ProductID],[Quantity],[Price],[Promotion])
VALUES(21, 10, 3, 299000, 0.4),
    (22, 11, 4, 299000, 0.4),
    (23, 15, 5, 299000, 0.4),
    (24, 12, 3, 299000, 0.4),
    (25, 4, 5, 299000, 0.4),
    (26, 13, 3, 299000, 0.4),
    (27, 25, 4, 299000, 0.4),
    (28, 4, 2, 299000, 0.4),
    (29, 18, 3, 299000, 0.4),
    (30, 29, 3, 299000, 0.4);