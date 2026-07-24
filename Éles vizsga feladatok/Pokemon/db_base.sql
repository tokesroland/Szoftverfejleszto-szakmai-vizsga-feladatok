CREATE DATABASE IF NOT EXISTS pokedex
CHARACTER SET utf8mb4
COLLATE utf8mb4_hungarian_ci;

USE pokedex;

CREATE TABLE IF NOT EXISTS pokemonok (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nev VARCHAR(50) NOT NULL,
    tipus VARCHAR(30) NOT NULL,
    tamadas INT NOT NULL,
    vedekezes INT NOT NULL,
    generacio INT NOT NULL
);

INSERT INTO pokemonok (nev, tipus, tamadas, vedekezes, generacio) VALUES
('Bulbasaur', 'Grass', 49, 49, 1),
('Charmander', 'Fire', 52, 43, 1),
('Squirtle', 'Water', 48, 65, 1),
('Pikachu', 'Electric', 55, 40, 1),
('Mewtwo', 'Psychic', 110, 90, 1),
('Lucario', 'Fighting', 110, 70, 4),
('Gengar', 'Ghost', 65, 60, 1),
('Eevee', 'Normal', 55, 50, 1),
('Snorlax', 'Normal', 110, 65, 1),
('Greninja', 'Water', 95, 67, 6);
