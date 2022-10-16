# Práctica 2: Introducción a los scripts y física en Unity
### Autor: Lorenzo Gabriel Pérez González

## Ejercicio 1: Probar configuraciones de objetos.
### Apartado a: Ninguno de los objetos será físico.
En esta sección, he colocado un cubo y una esfera en la escena. Ambas figuras se encuentran suspendidas en el aire y, dado que no son figuras físicas, no deben de caer, puesto que no les afecta la gravedad. De esta forma, al ejecutar la escena, vemos lo siguiente:

![Objetos no físicos](images/Apartadoa.gif)

### Apartado b: La esfera tiene físicas, el cubo no.
En cambio, si convertimos la esfera en un objeto físico, será vulnerable a la fuerza de la gravedad. Para lograr dicho objetivo, he tenido que seleccionar la esfera y añadirle una componente **Rigidbody** que permitirá asignarle las propiedades físicas, además de aplicarle la casilla de *Use Gravity*. Al ejecutar la escena, vemos algo distinto al apartado anterior:

![Esfera física](images/Apartadob.gif)

### Apartado c: La esfera y el cubo tienen físicas.
Para este apartado, he puesto un objeto encima de otro para ver que ocurre. Si le aplicamos físicas al cubo, obtendremos lo siguiente:

![Objetos físicos](images/Apartadoc.gif)

### Apartado d: La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo.
He asignado una masa de 10 kg al cubo y de 100 kg a la esfera. Decidí poner encima al objeto más pesado. Cuando ejecuté la escena vi que la esfera cae encima del cubo y poco a poco va desplazándose hacia un lado hasta caer sobre el plano y, más tarde, salir de éste.

![Esfera 10 veces más pesada](images/Apartadod.gif)

### Apartado e: La esfera tiene físicas y el cubo es de tipo IsTrigger.
Para este apartado retiré el componente físico al cubo y le asigné un valor positivo a la propiedad IsTrigger dentro del Box Collider. De esta forma, se ve como en la escena, la bola, que está por encima, traspasa al cubo al caer.

![Cubo de tipo IsTrigger](images/Apartadoe.gif)

### Apartado f: La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas.
En este apartado, tan sólo tuve que añadir de nuevo la componente de RigidBody al cubo, dejando marcada la casilla de IsTrigger. Al ejecutar, ambos objetos caen, pero el cubo traspasa el plano.

![Cubo de tipo IsTrigger y físico](images/Apartadof.gif)