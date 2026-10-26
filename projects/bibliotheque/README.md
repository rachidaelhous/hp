# Gestion de bibliothèque — projet académique

Application de bureau C# / Windows Forms. Sources issues de l’archive de formation fournie par Rachida Elhous.

## Objectif et parcours utilisateur
Centraliser le catalogue, les auteurs et les emprunts. Le menu ouvre les formulaires Livres, Auteurs et Emprunts. L’écran d’emprunt saisit le livre, le nom de l’emprunteur et les dates.

## Ce que montre le code
- Modèles `Livre`, `Auteur`, `Emprunt`.
- Managers BLL pour les validations et les règles métier.
- DAL utilisant ADO.NET (`Microsoft.Data.SqlClient`) et des paramètres SQL.
- Vérification d’un emprunt actif avant l’ajout.
- Calcul de pénalité : 2 unités monétaires par jour de retard, 0 si le retour est à temps.
- Script SQL : Livres, Auteurs, table de liaison AuteursLivres et Emprunts; vue de regroupement des auteurs.

## Lire les éléments importants
1. `GestionBibliotheque.BLL/Managers/EmpruntManager.cs` : règle de retard.
2. `GestionBibliotheque.DAL/EmpruntDAL.cs` : persistance et requêtes paramétrées.
3. `GestionBibliotheque.UI/Forms/FrmEmprunts.cs` : événements et validation des champs.
4. `SQLQuery1.sql` : schéma relationnel.

## Environnement et limites de la version d’origine
Projet Windows Forms ciblant .NET 8 sous Windows, SQL Server et Visual Studio. Copier `App.config.example` vers `App.config` et adapter la connexion; lire le script SQL avant de l’exécuter sur une base de test.

Les sources sont publiées pour étude et n’ont pas été exécutées ici sous Windows. La version remise demande des corrections avant démonstration complète : double point d’entrée dans `Program.cs`, formulaires Livres/Auteurs utilisant encore des listes en mémoire, retour sans affectation de `IdEmprunt`, disponibilité du livre non synchronisée. Ne pas présenter ces flux comme validés de bout en bout.

## Ce que je peux expliquer en entretien
La séparation interface/logique/données, le rôle d’une clé étrangère, l’intérêt des paramètres SQL et le calcul d’un retard. Exemple : retour trois jours après la date prévue → pénalité de 6.

## Suite du travail
Relier les écrans aux managers, synchroniser emprunt/disponibilité dans une transaction et vérifier les cas retour à temps, retard et double emprunt.
