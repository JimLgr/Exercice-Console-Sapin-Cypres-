using Sapin;
using Cypres;
/// <summary>
/// Ce programme demande une taille de sapin et une taille de Cyprès et l'affiche dans une console
/// </summary>
int inputLen = ClassSapin.DemanderTaille();
ClassSapin.DessinerSapin(inputLen);

int inputLenCypres = ClassCypres.DemanderTaille();
ClassCypres.DessinerCypres(inputLenCypres);



