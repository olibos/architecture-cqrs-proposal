# Utilisation de la clause de garde dans le code
## Contexte
Dans le développement logiciel, les clauses de garde (ou "guard clauses" en anglais) sont des structures conditionnelles qui permettent de vérifier des conditions préalables avant d'exécuter le reste du code. Elles sont souvent utilisées pour valider les entrées utilisateur ou les arguments de fonction avant de poursuivre avec le traitement principal.

## Décision
Nous décidons d'encourager l'utilisation de clauses de garde dans notre code pour les raisons suivantes :

Amélioration de la lisibilité du code : Les clauses de garde permettent de séparer la validation de l'entrée des autres opérations dans une fonction, rendant le code plus facile à lire et à comprendre.
Réduction des erreurs : En vérifiant les pré-conditions avant d'exécuter le reste du code, nous pouvons réduire les erreurs et les exceptions inattendues qui peuvent survenir si les conditions ne sont pas remplies.
Facilitation de la maintenance : En séparant la validation des autres opérations, nous facilitons la maintenance du code, car il est plus facile de repérer et de corriger les erreurs.
Nous encourageons donc tous les développeurs à utiliser des clauses de garde lorsqu'ils écrivent du code.

## Conséquences
L'utilisation de clauses de garde peut nécessiter un peu plus de temps lors de la rédaction de la fonction, mais cela peut réduire le temps de débogage et de maintenance. De plus, l'utilisation de clauses de garde peut rendre le code plus facile à comprendre pour les autres développeurs, ce qui peut faciliter la collaboration sur le projet.