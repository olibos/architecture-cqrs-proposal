# Convention de nommage pour les champs priv�s en C#
## Contexte
On a remarqu� que les convotions de nommage ont �volu� et que le champs priv�s sont de moins en moins �crit en camel case.

Les noms de variables en camel case peuvent facilement entrer en conflit avec les variables locales, ce qui peut causer de la confusion et des erreurs. 

En utilisant des noms de variables commen�ant par un underscore, on n'a plus besoin de pr�fixer l'acc�s � ses champs avec le mot cl� `this`.

## D�cision
Nous avons d�cid� d'adopter la convention de nommage suivante pour les champs priv�s :

- Les noms des champs priv�s commencent par un caract�re de soulignement (underscore) suivi d'une lettre minuscule. Par exemple : `_myVariable`.
- Les noms des champs doivent �tre clair & sans abr�viation par rapport au contexte du projet:
	- `_index` plut�t que `_i`
	- `_productPrice` plut�t que `_pPrice`


Cette convention de nommage est conforme aux recommandations de Microsoft pour le d�veloppement en C#.

## Cons�quences
L'adoption de cette convention de nommage permettra une meilleure lisibilit� et une compr�hension plus facile du code par les membres de l'�quipe de d�veloppement. Cela r�duira �galement le risque d'erreurs li�es � une mauvaise interpr�tation des noms de champs priv�s.

## R�f�rences
- [Microsoft's C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)