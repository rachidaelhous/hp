-- ==============================================
-- Script SQL : GestionBibliotheque
-- ==============================================
CREATE DATABASE GestionBibliotheque;
GO
USE GestionBibliotheque;
GO
-- ==============================================
-- Table : Auteurs
-- ==============================================
CREATE TABLE Auteurs (
 IdAuteur INT IDENTITY(1,1) PRIMARY KEY,
 Nom NVARCHAR(100) NOT NULL,
 Prenom NVARCHAR(100) NOT NULL,
 Nationalite NVARCHAR(100)
);
GO
-- ==============================================
-- Table : Livres
-- ==============================================
CREATE TABLE Livres (
 IdLivre INT IDENTITY(1,1) PRIMARY KEY,
 Titre NVARCHAR(200) NOT NULL,
 AnneePublication INT,
 ISBN NVARCHAR(20),
 Disponible BIT NOT NULL DEFAULT 1
);
GO
-- ==============================================
-- Table de liaison : AuteursLivres
-- (Relation plusieurs-à-plusieurs entre Auteurs et Livres)
-- ==============================================
CREATE TABLE AuteursLivres (
 IdAuteur INT NOT NULL,
 IdLivre INT NOT NULL,
 PRIMARY KEY (IdAuteur, IdLivre),
 FOREIGN KEY (IdAuteur) REFERENCES Auteurs(IdAuteur),
 FOREIGN KEY (IdLivre) REFERENCES Livres(IdLivre)
);
GO
-- ==============================================
-- Table : Emprunts
-- ==============================================
CREATE TABLE Emprunts (
 IdEmprunt INT IDENTITY(1,1) PRIMARY KEY,
 IdLivre INT NOT NULL,
 NomEmprunteur NVARCHAR(100) NOT NULL,
 DateEmprunt DATE NOT NULL,
 DateRetourPrevue DATE NOT NULL,
 DateRetourReelle DATE NULL,
 Penalite DECIMAL(6,2) DEFAULT 0,
 FOREIGN KEY (IdLivre) REFERENCES Livres(IdLivre)
);
GO
-- ==============================================
-- Vues pratiques (facultatives pour WinForms)
-- ==============================================
-- Liste des livres avec leurs auteurs
CREATE VIEW Vue_LivresAuteurs AS
SELECT
 L.IdLivre,
 L.Titre,
 STRING_AGG(A.Nom + ' ' + A.Prenom, ', ') AS Auteurs,
 L.Disponible
FROM Livres L
JOIN AuteursLivres AL ON L.IdLivre = AL.IdLivre
JOIN Auteurs A ON A.IdAuteur = AL.IdAuteur
GROUP BY L.IdLivre, L.Titre, L.Disponible;
GO