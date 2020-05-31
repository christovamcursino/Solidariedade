drop database dbSolidariedade;
CREATE database dbSolidariedade;
CREATE USER 'solidariedade'@'localhost' IDENTIFIED BY 'solidariedade';
GRANT ALL PRIVILEGES ON dbSolidariedade.* TO 'solidariedade'@'localhost';

