# TrabajoPracticoIntegrador
tp integrador 2023 TSSI

UTN 2023

7) Cree una clase con métodos donde utilice los operadores de asignación compuesta +=, ++, &, ||, ?. Adicionalmente agregue un caso donde 
dado el número -7 (base 10) en 32 bits donde desplace el bit mas significativo realizando un desplazamiento aritmético, y calcule el resultado 
final en base 10.



8) ¿Qué es el IL?

Es el lenguaje intermedio entre el codigo nativo y el c#.
Es codigo de bajo nivel y es un conjunto de instrucciones independientes de la plataforma 

9) Explique con sus palabras VES, CTS y CLS.

El VES (Virtual Execution System) define la arquitectura de ejecuccion, es el encargado de porveer una capa de de abstraccion sobre la 
maquina fisica, para que sea segura y eficiente

El CTS (Common Type System) es un componente que se encarga de proveer un conjunto de tipos y convenciones que tienen que ser implementados 
por los compiladores de lenguajes .NET para que los programas escritos en diferentes lenguajes se puedan comunicar entre si y con otros
componenetes

El CLS (Common Language System) es un conjunto de reglas y convenciones para establecer una interoperabildiad comun entre los lenguajes
de programacion. Estas reglas y convenciones garantizan que los prog en .NET sean compatibles y puedan intereactuar entre si sin problemas.

Es decir el VES es la arquitectura, el CLS es el conjunto de reglas y convenciones para garantizar que tengan compatibildiad con el CTS y
otros componentes de la plataforma del .NET

10) Explique con sus palabras que es un Assembly, el early y late Binding.
Assembly puede ser un archivo .exe o .dll o un .cs (este se compilaria en tiempo de ejecucion), en el se encuentran diferentes 
recursos (como clases, interfaces, estructuras, tipo de datos, etc., tambien incluye informacion de metadatos que describe los 
tipos, versiones y cultura, esta info es utilizada en tiempo de ejecucion para la administrar la carga), tiene codigo 
reutilizable que puede ser diferenciado por otros programas o bibliotecas.

Early binding usa la informacion de la clase para resolver el metodo que se esta llamando. Y ocurre en tiempo de compilacion

Late binding usa la info del objeto para resolver al metodo que se esta llamado. Y ocurre en tiempo de ejecucion

11) ¿Qué es GIT? ¿Es centralizado o distribuido? Ejemplifique al menos 3 comandos de
git y explique su funcionamiento.

El git es un sistema de control de versiones para los desarrollos de software a diferencia de los CVS y SVN que son centralizados,
el git es distibuido ya que crea una copia completa del proyecto localmente (con el comando git clone y el link del repositorio).
En git se trabaja por medio de ramas (branch) que siempre esta la main que es la original, se puede trabajar en esa misma branch, 
pero no es una buena practica, por eso crea una nueva con git branch nueva_rama (siendo nueva_rama el nombre que le quieras poner), 
desde esa nueva rama se puede trabajar y desarrollar pero si se quiere vovler a la main pero no llevarse los cambios realizados se
escribe git checkout main (main se puede repemplazar por la rama en la que quieras ir). 

