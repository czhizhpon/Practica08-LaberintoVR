
# PRÁCTICA DE LABORATORIO 

## CARRERA: Computación	ASIGNATURA: Programación Hipermedial
### NRO. PRÁCTICA:	8	
### TÍTULO PRÁCTICA: Desarrollo de una aplicación de realidad virtual usando la herramienta Unity y desplegada en un dispositivo móvil Android.
## OBJETIVO ALCANZADO:
- Experimentar con aplicaciones de realidad virtual.
- Experimentar con aplicaciones de realidad aumentada.
- Distinguir la diferencia entre tecnologías de realidad virtual y realidad aumentada.
# ACTIVIDADES DESARROLLADAS
## 1.	Desarrollo de los requerimientos.

### a.	Crear la GVR Camera Rig.

Se agregó a la escena el prefab GvrEditorEmulator a la escena, al igual que el objeto Main Camera, se le asignó como hijo. 

<img src="readme_img/1.png">

### b.	Preparando la escena para la interacción.

Se agregó el prefab GvrReticlePointer a la escena como elemento secundario del objeto MainCamera, junto con el prefab GvrEventSystem a la escena principal.

<img src="readme_img/2.png">

Se aumentó la distancia de la retícula de 10 a 20.

<img src="readme_img/3.png"> 

### c.	Hacer que los objetos del juego sean interactivos

Se realizaron las configuraciones de los objetos Coin, Key y Door, con sus respectivos EventTrigger y Scripts con sus funciones adecuadas.

- Coin:
 
<img src="readme_img/4.png">

- Key:
 
<img src="readme_img/5.png">

- Door:
 
<img src="readme_img/6.png">

### d.	Hacer la interfaz de usuario interactiva

Se realizaron las asignaciones de Scripts necesarios para que el elemento GVR pueda interactuar con el objeto SignPost. También, se configuró EventTrigger con el respectivo Script.

<img src="readme_img/7.png">

Funciones:

Función para crear el prefap CoinPoof, llamado por la función OnCoinClicked.
 
<img src="readme_img/8.png">

Función para la animación del objeto Coin, se optó por un efecto de levitación, haciendo uso de la función Seno y manipulación de la posición en el eje 

<img src="readme_img/9.png">

### e.	Programando el comportamiento de la llave (key).

Se realizaron las funciones respectivas en el Script del objeto Key.

Creación del prefab KeyPoof, llamado por la función OnKeyClicked.

<img src="readme_img/10.png"> 

Animación del objeto Key. Se optó por un efecto de rotación, para el cual, se manipuló el eje z.
 
<img src="readme_img/11.png"> 

### f.	Programando el comportamiento de la puerta (door).

Se realizaron las funciones respectivas en el Script del objeto Door.

Asignación de valores para la rotación de las puertas.

<img src="readme_img/12.png">  

Función para realizar la animación de girar las puertas.

<img src="readme_img/13.png"> 

### g.	Programando el comportamiento del SignPost.

Se programó el Script asignado al objeto prefab SignPost.

<img src="readme_img/14.png"> 

## 2.	La evidencia del correcto diseño de la escena.

### a. Crear la funcionalidad del juego.
Se estructuró el siguiente laberinto:

Parte izquierda, el punto señalado es la posición de la cámara.

<img src="readme_img/15.png"> 
 
Parte derecha, la parte señalada es la ubicación de la llave.
 
<img src="readme_img/16.png"> 
 
En total se colocaron 14 monedas alrededor del mapa.

<img src="readme_img/17.png"> 

## 3.	La evidencia del correcto funcionamiento de la aplicación.

Captura desde un dispositivo Android.
 
<img src="readme_img/18.png">
<br>
<br>
<img src="readme_img/19.png"> 
 
Video de la ejecución del juego.

Enlace: https://youtu.be/Zk8jQSH6AJQ

## 4.	Incluir la información de GitHub (usuario y URL del repositorio de la práctica)

Nombre de usuario: czhizhpon

Enlace: https://github.com/czhizhpon/Practica08-LaberintoVR.git

## RESULTADO(S) OBTENIDO(S):
Se experimentó con aplicaciones de realidad virtual al realizar un juego de laberinto. Se experimentó con aplicaciones de realidad aumentada al diseñar conceptos abstraídos de la realidad, con el objetivo de distingue la diferencia entre ellos.

## CONCLUSIONES:
Cuando se habla de Realidad Virtual y Realidad Aumentada, tenemos dos conceptos familiares pero algunas diferencias. Sin embargo, los dos comparten que el resultado final va dirigido a un usuario. Al tratarse de una persona, se debe tener en consideración factores como elección de colores, la luz, la cantidad de objetos. Esto, con el objetivo de que la experiencia final, sea de agrado y que se puede usar la aplicación con normalidad con el mayor tiempo prolongado posible, garantizando el entretenimiento al usuario final.

## RECOMENDACIONES:
Leer la documentación que ofrece Unity.

*Nombre de estudiante:* Zhizhpon Tacuri Cesar Eduardo


*Firma de estudiante:* <img src="readme_img/20.png" width="100px"> 

