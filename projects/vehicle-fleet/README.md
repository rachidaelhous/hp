# Vehicle Fleet Factory — projet académique C#

Application Windows Forms de gestion et de simulation d’un parc automobile, issue des sources de formation fournies par Rachida Elhous.

## Objectif
Manipuler des véhicules à essence, électriques et hybrides dans une même collection; présenter leurs caractéristiques et effectuer des calculs pédagogiques.

## Fonctionnalités présentes dans le code
- Écrans distincts pour les modes Manager et Technician.
- Classe abstraite `Vehicle` et classes `GasolineVehicle`, `ElectricVehicle`, `HybridVehicle`.
- Interface `IMileageEfficiency` et redéfinition de `CalculateMileageEfficiency()` selon le type.
- Surcharge `MakeTrip()` / `MakeTrip(double distance)`; rejet d’une distance négative ou nulle dans la seconde méthode.
- Collection de véhicules, sélection dans les formulaires et affichage des résultats.
- Sérialisation XML avec prise en charge des types dérivés et méthodes de lecture/écriture.

## Parcours de lecture
`BLL/Vehicle.cs` → contrat commun et surcharge; les trois classes dérivées → polymorphisme; `BLL/FileManager.cs` → persistance; `UI/VehicleForm.cs` et `UI/TestForm.cs` → interface événementielle.

## Préparation d’une démonstration
Windows, Visual Studio et .NET Framework 4.8. Ouvrir le `.csproj`. Les anciens fichiers de mots de passe et données locales ne sont pas publiés. Un `UI/App.config.example` contient uniquement des espaces réservés : créer une configuration locale et s’assurer qu’elle est copiée dans le fichier de configuration de l’exécutable. Le fichier `DAL/LoginPassword.txt` référencé dans le projet est volontairement absent; retirer cette référence si nécessaire.

## Limites et améliorations
Code de formation non exécuté sous Windows ici. L’authentification par paramètres de configuration est une démonstration, pas une sécurité de production. Harmoniser les chemins XML entre formulaires et `FileManager`; vérifier les conversions de saisie et les unités utilisées par les formules de consommation avant d’en interpréter les résultats physiques. Des ressources locales peuvent nécessiter une réassociation dans Visual Studio.

## Ce que je peux expliquer
Pourquoi une classe abstraite évite de dupliquer les propriétés communes; comment la même méthode déclenche un calcul différent selon l’objet; comment un fichier XML conserve les données entre deux lancements.
