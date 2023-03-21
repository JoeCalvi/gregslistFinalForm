CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE IF NOT EXISTS cars(  
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    make VARCHAR(50) NOT NULL,
    model VARCHAR(50) NOT NULL,
    year INT NOT NULL DEFAULT 2025,
    price DOUBLE NOT NULL DEFAULT 1.00,
    description TEXT,
    imgURL VARCHAR(255) NOT NULL,
    color VARCHAR(15)
) default charset utf8 COMMENT '';

DROP table IF EXISTS cars;

INSERT INTO cars
(make, model, year, price, imgURL, color, description)
VALUES
('honda', 'civic', 1997, 800, 'https://file.kelleybluebookimages.com/kbb/base/house/1997/1997-Honda-Civic-FrontSide_HOCIVLXSED973_506x348.jpg', 'red', 'runs');

CREATE TABLE IF NOT EXISTS houses(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  bedrooms INT NOT NULL,
  bathrooms INT NOT NULL,
  year INT NOT NULL,
  price INT NOT NULL,
  imgURL VARCHAR(255) NOT NULL,
  description TEXT
) default charset utf8 COMMENT '';

DROP TABLE IF EXISTS houses;

INSERT INTO houses
(bedrooms, bathrooms, year, price, imgURL, description)
VALUES
(3, 2, 1990, 300000, 'https://images.squarespace-cdn.com/content/v1/555f43ace4b09cfed988524e/1617750170887-UZUOT0V8VLC37B05HCER/workaholics8.jpg?format=1500w', 'great for hosting parties');

CREATE TABLE IF NOT EXISTS jobs(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  position VARCHAR(50) NOT NULL,
  company VARCHAR(50) NOT NULL,
  location VARCHAR(100) NOT NULL,
  pay VARCHAR(50) NOT NULL,
  imgURL VARCHAR(255) NOT NULL,
  description TEXT
) default charset utf8 COMMENT '';

DROP TABLE IF EXISTS jobs;

INSERT INTO jobs
(position, company, location, pay, imgURL, description)
VALUES
('bagboy', 'albertsons', 'nampa, ID', '$15/hr', 'https://www.movinglivesforward.org/wp-content/uploads/2018/01/albertsons-logo.png', 'fun job, laid back staff' );
