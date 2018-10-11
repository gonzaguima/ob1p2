# ob1p2
Primera entrega Obligatorio Programación 2. ASP.Net web forms con C#
--------------------------------------------------------------------
Facultad de Ingeniería
Bernard Wand-Polak
Cuareim 1451
11.100 Montevideo, Uruguay
Tel. 2902 15 05 Fax 2908 13 70
www.ort.edu.uy

Computación - Electrónica - Telecomunicaciones - Sistemas de Información
EVALUACIÓN Obligatorio 1 GRUPO Todos FECHA Semana 4
MATERIA Programación 2
CARRERA Analista Programador – Analista en Tecnologías de la Información

CONDICIONES - Puntos: Máximo: 10 Mínimo: 0
- Fecha máxima de entrega: 18/10/2018
LA ENTREGA SE REALIZA EN FORMA ONLINE EN ARCHIVO NO MAYOR A 40 MB EN FORMATO
ZIP, RAR O PDF.
IMPORTANTE:
- Inscribirse
- Formar grupos de hasta dos personas.
- Subir el trabajo a Gestión antes de la hora indicada, ver hoja al final del documento: “RECORDATORIO”

PRIMER OBLIGATORIO

Una empresa constructora nos contrata para informatizar parte de su negocio. Ellos construyen edificios para
oficina y vivienda solo en Montevideo y venden sus apartamentos en forma directa. De los edificios registran
un nombre, que es único y su dirección. En un mismo edificio puede haber apartamentos con diferente destino
(oficina o casa-habitación). De los apartamentos se registra el piso en que se encuentran, su número, el
metraje total (en m2), un precio base por m2, y su orientación (N, NE, E, SE, S, SO, O, NO). Al ingresar
apartamentos a un edificio, se debe controlar que no exista más de un apartamento con el mismo número o la
misma orientación en el mismo piso. De las oficinas interesa registrar la cantidad de puestos de trabajo que
permite ubicar y si posee equipamiento o no. De los apartamentos con destino a casa-habitación registran la
cantidad de dormitorios, la cantidad de baños y si cuentan con garaje.
El precio de venta de los apartamentos se calcula de la siguiente manera:
Si es una oficina, es su precio base por m2 multiplicado por su metraje total y a este monto se le agrega un
monto fijo (común para todas las oficinas) por cada puesto de trabajo que permita ubicar y un 10% adicional en
caso de contar con equipamiento.
Si es con destino vivienda, es su precio base por m2 multiplicado por su metraje total, y a este monto se le
suma un 5% si tienen entre 1 y 2 dormitorios, un 10% si tienen entre 3 y 4 y un 20% si tienen más de 4
dormitorios. Si posee garaje, se le suma un monto fijo que es común a todos los apartamentos de este tipo.
Además, para las orientaciones N, NE y NO, se aplica un recargo del 15% del total calculado.
De los clientes compradores se registra el nombre, apellido, documento, dirección y teléfono de contacto. De
cada cliente se lleva registro de el/los apartamentos que ha comprado, en qué fecha se realizó cada venta, el
vendedor que las hizo y cuál fue el precio pagado por la venta.

Se pide:

Nota: Para esta primera versión de la aplicación no se deberá implementar el login al sistema por lo que no es
necesario contar con la gestión de usuarios para esta primera etapa.
a) Diagrama de clases conceptual del Dominio (Reglas del negocio) que modele la situación anterior.
Se seguirá el estándar UML, por lo que no es válido presentar el diagrama realizado con el diseñador de
clases de Visual Studio.
b) Codificación de clases del dominio necesarias para cumplir con los requerimientos:
1. Realizar alta de edificios. Al ingresar un edificio se ingresan todos sus datos y al menos un
apartamento.
2. Realizar alta de apartamentos. Se selecciona un edificio, el tipo de apartamento, se ingresan
todos sus datos y se da el alta.
3. Listar edificios aplicando filtros. Se ingresa una cantidad mínima y máxima de m2 y una
orientación y se muestran todos los edificios que tienen apartamentos con metrajes entre esos
límites y con la orientación indicada.
4. Listado de apartamentos en un rango de precios dado.
5. Indicar si existen apartamentos (considerando todos los edificios) cuyo metraje esté dentro
de un rango dado. Deberá implementarse de la manera más eficiente posible.
Para la implementación de las clases del dominio utilizar un proyecto biblioteca de clases.
c) Implementar una aplicación web (Web Forms) con ASP.NET / C# de Visual Studio 2015 las
funcionalidades anteriores.
Se deberán incluir las validaciones que correspondan durante los ingresos para garantizar la
consistencia del sistema.
Se recomienda incluir comentarios al código para comprensión de la lógica más importante.
d) Documentación en PDF:
- Diagrama de clases del Dominio del problema.
-Código fuente de las clases implementadas. Solamente se incluirá el código fuente de las clases del
dominio que deberán incluir comentarios.
- La documentación solicitada se entregará en un ÚNICO documento en formato PDF.

RECORDATORIO: IMPORTANTE PARA LA ENTREGA

? Obligatorios (Cap.IV.1, Doc. 220)
La entrega de los obligatorios será en formato digital online, a excepción de algunas materias que se entregarán
en Bedelía y en ese caso recibirá información específica en el dictado de la misma.
Los principales aspectos a destacar sobre la entrega online de obligatorios son:
1. La entrega se realizará desde gestion.ort.edu.uy
2. Previo a la conformación de grupos cada estudiante deberá estar inscripto a la evaluación. Sugerimos
realizarlo con anticipación.
3. Uno de los integrantes del grupo de obligatorio será el administrador del mismo y es quien formará
el equipo y subirá la entrega
4. Cada equipo (2 estudiantes) debe entregar un único archivo en formato zip o rar (los documentos de
texto deben ser pdf, y deben ir dentro del zip o rar)
5. El archivo a subir debe tener un tamaño máximo de 40mb
6. Les sugerimos realicen una 'prueba de subida' al menos un día antes, donde conformarán el 'grupo
de obligatorio'.
7. La hora tope para subir el archivo será las 21:00 del día fijado para la entrega.
8. La entrega se podrá realizar desde cualquier lugar (ej. hogar del estudiante, laboratorios de la
Universidad, etc)
9. Aquellos de ustedes que presenten alguna dificultad con su inscripción o tengan inconvenientes técnicos,
por favor pasar por la oficina del Coordinador o por Coordinación adjunta antes de las 20:00hs. del día
de la entrega
Si tuvieras una situación particular de fuerza mayor, debes dirigirte con suficiente antelación al plazo de entrega,
al Coordinador de Cursos o Secretario Docente.
