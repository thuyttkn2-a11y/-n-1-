USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLyRapChieuPhim')
BEGIN
    ALTER DATABASE QuanLyRapChieuPhim SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanLyRapChieuPhim;
END
GO

CREATE DATABASE QuanLyRapChieuPhim;
GO

USE QuanLyRapChieuPhim;
GO

-- ============================================================
-- TẠO BẢNG
-- ============================================================

CREATE TABLE Users (
    UserID   INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50)  NOT NULL UNIQUE,
    Password NVARCHAR(50)  NOT NULL,
    FullName NVARCHAR(100) NOT NULL
);

CREATE TABLE Movies (
    MovieID     INT IDENTITY(1,1) PRIMARY KEY,
    MovieName   NVARCHAR(200) NOT NULL,
    Genre       NVARCHAR(100) NOT NULL,
    Duration    INT           NOT NULL,
    Description NVARCHAR(500)
);

CREATE TABLE Rooms (
    RoomID   INT IDENTITY(1,1) PRIMARY KEY,
    RoomName NVARCHAR(50) NOT NULL
);

CREATE TABLE Seats (
    SeatID   INT IDENTITY(1,1) PRIMARY KEY,
    RoomID   INT          NOT NULL,
    SeatCode NVARCHAR(10) NOT NULL,
    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
);

CREATE TABLE Showtimes (
    ShowtimeID INT IDENTITY(1,1) PRIMARY KEY,
    MovieID    INT           NOT NULL,
    RoomID     INT           NOT NULL,
    ShowDate   DATE          NOT NULL,
    ShowTime   TIME          NOT NULL,
    Price      DECIMAL(10,0) NOT NULL,
    FOREIGN KEY (MovieID) REFERENCES Movies(MovieID),
    FOREIGN KEY (RoomID)  REFERENCES Rooms(RoomID)
);

CREATE TABLE Tickets (
    TicketID    INT IDENTITY(1,1) PRIMARY KEY,
    UserID      INT      NOT NULL,
    ShowtimeID  INT      NOT NULL,
    SeatID      INT      NOT NULL,
    BookingDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (UserID)     REFERENCES Users(UserID),
    FOREIGN KEY (ShowtimeID) REFERENCES Showtimes(ShowtimeID),
    FOREIGN KEY (SeatID)     REFERENCES Seats(SeatID)
);
GO

-- ============================================================
-- DỮ LIỆU MẪU
-- ============================================================

-- Tài khoản (dùng để đăng nhập demo)
INSERT INTO Users (Username, Password, FullName) VALUES
('user1', '123456', N'Nguyễn Văn An'),
('user2', '123456', N'Trần Thị Bình');

-- Phim
INSERT INTO Movies (MovieName, Genre, Duration, Description) VALUES
(N'Avengers: Endgame',       N'Hành động',           182, N'Các siêu anh hùng Marvel chiến đấu chống lại Thanos để cứu vũ trụ.'),
(N'The Lion King',           N'Hoạt hình',            118, N'Câu chuyện về chú sư tử Simba trên đường tìm lại vương quốc của mình.'),
(N'Inception',               N'Khoa học viễn tưởng',  148, N'Một tên trộm xâm nhập vào giấc mơ của người khác để đánh cắp bí mật.'),
(N'Interstellar',            N'Khoa học viễn tưởng',  169, N'Hành trình xuyên không gian tìm hành tinh mới cho nhân loại sinh sống.'),
(N'Spider-Man: No Way Home', N'Hành động',            148, N'Peter Parker mở ra đa vũ trụ với sự trợ giúp của Doctor Strange.');

-- Phòng chiếu
INSERT INTO Rooms (RoomName) VALUES (N'Phòng 1'), (N'Phòng 2');

-- Ghế phòng 1
INSERT INTO Seats (RoomID, SeatCode) VALUES
(1,'A1'),(1,'A2'),(1,'A3'),(1,'A4'),(1,'A5'),
(1,'B1'),(1,'B2'),(1,'B3'),(1,'B4'),(1,'B5'),
(1,'C1'),(1,'C2'),(1,'C3'),(1,'C4'),(1,'C5');

-- Ghế phòng 2
INSERT INTO Seats (RoomID, SeatCode) VALUES
(2,'A1'),(2,'A2'),(2,'A3'),(2,'A4'),(2,'A5'),
(2,'B1'),(2,'B2'),(2,'B3'),(2,'B4'),(2,'B5'),
(2,'C1'),(2,'C2'),(2,'C3'),(2,'C4'),(2,'C5');

-- Suất chiếu
INSERT INTO Showtimes (MovieID, RoomID, ShowDate, ShowTime, Price) VALUES
(1, 1, '2025-06-01', '09:00', 90000),
(1, 1, '2025-06-01', '13:00', 90000),
(1, 2, '2025-06-02', '15:00', 100000),
(2, 1, '2025-06-01', '11:00', 80000),
(2, 2, '2025-06-02', '10:00', 80000),
(3, 1, '2025-06-03', '19:00', 110000),
(3, 2, '2025-06-03', '21:00', 110000),
(4, 1, '2025-06-04', '09:00', 95000),
(4, 2, '2025-06-04', '14:00', 95000),
(5, 1, '2025-06-05', '17:00', 100000),
(5, 2, '2025-06-05', '20:00', 100000);
GO

PRINT '=== DATABASE TẠO THÀNH CÔNG! ===';
PRINT 'Tài khoản demo:';
PRINT '  user1 / 123456';
PRINT '  user2 / 123456';
