CREATE TABLE users
(ID SMALLINT PRIMARY KEY IDENTITY, name VARCHAR(50) NOT NULL, passwd INT NOT NULL)

INSERT INTO users (name, passwd) VALUES ('rafael', 1234);