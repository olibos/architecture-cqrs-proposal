# Convention de nommage pour les champs privés en C#
## Contexte
On a remarqué que les convotions de nommage ont évolué et que le champs privés sont de moins en moins écrit en camel case.

Les noms de variables en camel case peuvent facilement entrer en conflit avec les variables locales, ce qui peut causer de la confusion et des erreurs. 

En utilisant des noms de variables commençant par un underscore, on n'a plus besoin de préfixer l'accès à ses champs avec le mot clé `this`.

## Décision
Nous avons décidé d'adopter la convention de nommage suivante pour les champs privés :

- Les noms des champs privés commencent par un caractère de soulignement (underscore) suivi d'une lettre minuscule. Par exemple : `_myVariable`.
- Les noms des champs doivent être clair & sans abréviation par rapport au contexte du projet:
	- `_index` plutôt que `_i`
	- `_productPrice` plutôt que `_pPrice`


Cette convention de nommage est conforme aux recommandations de Microsoft pour le développement en C#.

## Conséquences
L'adoption de cette convention de nommage permettra une meilleure lisibilité et une compréhension plus facile du code par les membres de l'équipe de développement. Cela réduira également le risque d'erreurs liées à une mauvaise interprétation des noms de champs privés.

## Références
- [Microsoft's C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)