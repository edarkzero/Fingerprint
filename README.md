# README #

Fingerprint
Descripcion
Aplicacion servidor y cliente para autenticacion de usuario y envio de datos via TCP/IP mediante la validacion de huella o usuario y contraseña.
Servidor
Descripcion
La aplicación del lado del servidor esta programada en el lenguage de programacion C# y compilada con visual studio 2013. Se utiliza el SDK (Software Development Kit) llamado “Grianule SDK Fingerprint SDK 2009” para conectar con los dispositivos USB para lectura de huellas y algoritmos de comparacion de huellas. Se usa una base de datos en Microsoft Acess. 
Base de datos
•	User: ID (AutoNumber), Name (VarChar 255), Password (LongChar), Info (LongChar).

•	Enroll: ID (AutoNumber), ID_User (Number), Quality (Number), Template (OLE Object).
Nota: La columna Template del tipo OLE Object de la tabla Enroll se usa para almacenar un conjuntos de bytes que representan el mapa de puntos de la huella.
Aplicacion
•	Interfaz y funciones:

o	Menu principal con opciones para:

	Iniciar, detener y registros de proceso de socket.

	Limpiar tablas de base de datos.

	Cargar imagen donde se sobrepone una ventana de seleccion de imagen con extension *.bmp.

	Salir de la aplicacion y terminar subprocesos.

o	Panel central derecho con opciones:

	Visualizar miniatura de huella cargada.

	Barra deslizable para controlar la sensibilidad en comparacion de patrones (mapa de puntos) de la huella.

	Barra deslizable para controlar la sensibilidad en comparacion de la rotacion de la huella.

o	Panel central izquierdo con visualizacion de imagen cargada, de ser valida la imagen se sobrepone el mapa de puntos extraidos de el patron de huella.

o	Panel inferior con información:

	Barra de carga que representa el nivel de calidad de los patrones analizados en la imagen cargada.

	Barra de carga que representa el puntaje resultante de la comparacion de el patron actual contra el patron candidato encontrada en la base de datos. Las barras rojas indican que esta por debajo de la sensibilidad configurada, de modo contrario son verdes.

o	Interfaz de visualizacion o ingreso de datos de usario.

	Nombre de usuario, campo de texto

	Contraseña de usuario, campo de texto (visible cuando es una nueva huella o nuevo usuario)

	Informacion de usuario, campo de texto multilinea que representa una informacion de cualquier tipo para el usuario.

•	Procesos

A.	Carga de imagen. 

a.	Una vez que el usuario selecciona la imagen a cargar,se toma la ruta de el archivo, se hace una conversion a un array de tipo byte, se llama a la funcion validar imagen de el SDK de huellas

i.	SDK_ValidateImage es true: la imagen es valida, continuar con extraccion de patron.

ii.	SDK_ValidateImage es false: la imagen es invalida, no hacer nada.

b.	Si (a.i) Llamar a función para extraer patron del mapa de bytes SDK_Extract. 

c.	Si (b) Calcular calidad de huella, llamar a funcion SDK_Quality. 

d.	Si (c) Almacenar la informacion procesada en memoria (Objeto instanciado de la clase Template) para uso posterior. 

B.	Identificar imagen en registros.  Si (A) consultar todas las filas en base de datos la tabla Enroll y ejecutar SDK_Identify(Enroll_template,Enroll_quality).

a.	SDK_Identify es true: Consiguio emparejar con algun template de la BDD, Almacenar en memoria las información, consultar en la BDD la tabla User donde exista Enroll_User_ID, almacenar informacion de usario en memoria.

b.	SDK_Identify es false: No consiguio pareja en la BDD, no continuar.


C.	Gestion de usuarios.

a.	SI (B.a) verificar que la consulta de usuario (funcion CheckUser), abrir ventana de usuario que cambia dependiendo del valor devuelto por funcion CheckUser

i.	Si CheckUser es true: modo visualizar informacion de usuario, solo se muestra la informacion de el usuario, a excepcion de su contraseña.

ii.	Si CheckUser es false: modo ingresar informacion de usuario, los campos se deben llenar, se hace click en guardar y procede a insertar en la base de datos cada campo del usuario. La contraseña es procesada antes de la consulta por la funcion PasswordHash(password) que convierte la contraseña indicada a un HASH de una sola via usando el algoritmo SHA256 mas una semilla concatenada a la contraseña para mas seguridad.

D.	Gestion de Socket (Escucha de peticiones de aplicacion cliente)

a.	Utilizando la clase Socket de Visual C# se configura el puerto 11000 y el protocolo TCP, con el IP del servidor, en modo Streaming, con un buffer de 1024 Bytes y el funcionamiento es asincrono. Todo este proceso esta en un proceso separado para no impedir el funcionamiento del proceso principal.

b.	Si el cliente envia informacion con la palabra clave [{sep}] se tomara como si fuese una autenticacion de usuario mediante nombre y contraseña. Se llama a la funcion GetUserDataByClientRequest(stream) donde se procede a descomponer el mensaje en nombre y contraseña, donde la contraseña es se valida que sea un Hash valido, de ser asi, se consulta en la base de datos en la tabla User aquella fila que contenga el nombre y contraseña dado.

i.	GetUserDataByClientRequest(stream) correcto: Responde al cliente con la informacion y nombre de el usuario correspondiente.

ii.	GetUserDataByClientRequest(stream) falla: Responde al cliente con nombre e informacion con la cadena “invalida”.

c.	Si el cliente envia informacion sin la plabla clave [{sep}] se tomara como autenticacion mediante imagen de huella. Se llama a la funcion GetUserDataByClientRequest(null,bytes) donde ahora se tomara el conjunto de bytes recibidos se convierte en un MemoryStream y se transforma en un objeto Image desde un stream de memoria, se valida esa imagen mediante Proceso B y C sin agregar el usuario de ser invalido

i.	GetUserDataByClientRequest(null,bytes) correcto: Responde al cliente con la informacion y nombre de el usuario correspondiente.

ii.	GetUserDataByClientRequest(null,bytes) falla: Responde al cliente con nombre e informacion con la cadena “invalida”.

d.	Cada accion registra en memoria los cambios para ser visualizados en una ventana en la accion de Log de servidor.

Cliente
Descripcion
La aplicación del lado del cliente esta programada en el lenguage de programacion C# y compilada con visual studio 2013. Es usada para autenticarse en la aplicacion servidor y recibe su informacion de usuario.
Aplicación
•	Interfaz y funciones

o	Ventana principal con Campos de acceso para el usuario, Username y Password.

o	El boton “Login” envia una solicitud al servidor con los campos de Username y Password para autenticar y solicitar los datos de el usuario.

o	El boton “Fingerprint” abre una ventana con seleccion de la imagen del usuario que representa su huella, luego se envia una solicitud al servidor con la imagen para autenticar y solicitar los datos de el usuario.

o	El boton “Close” cierra la aplicación.

o	El panel “Server fetched data” reflejara la información de el usuario que responda el servidor, indicados como Name e Information.

•	Procesos

A.	Login de usuario via nombre y contraseña. El usuario debe colocar su nombre y contraseña y hacer click en el boton “login” para poder acceder a sus datos en el servidor. Se usa el texto contenido en los campos Username y Password y almacenados en memoria para ser tratados posteriormente. La contraseña almaecnada es encriptada mediante la funcion PasswordHash(password) para enviarle al servidor la información de una forma mas segura. Se envia la informacion, se espera por respuesta, una vez que se recibe la información es mostrada al usuario en los campos de Name e Information.

B.	Login de usuario via imagen de huella. El usuario debe seleccionar una imagen valida con su huella, se toma la ruta de la imagen, se convierte en un conjunto de bytes y se envia al servidor, se espera por respuesta, una vez que se recibe la información es mostrada al usuario en los campos de Name e Information.

C.	Gestion de socket (Envio de peticiones de aplicacion cliente)

a.	Utilizando la clase Socket de Visual C# se configura el puerto 11000 y el protocolo TCP, con el IP del servidor, en modo Streaming, con un buffer de 1024 Bytes y el funcionamiento es asincrono.

b.	Caso en el que se presiona el boton “Login”.

i.	El cliente envia al servidor la informacion contenida en los campos Password y Name en una cadena unica unida por la palabra clave [{sep}].

ii.	El cliente espera la informacion de respuesta por parte del servidor, dicha respuesta se descompone en dos cadenas usando como separador la palabra clave [{sep}] dando como resultado el nombre e informacion del usuario.



c.	Caso en el que se presiona el boton “Fingerprint”.

i.	Se convierte la imagen en un conjunto de Bytes y se envia al servidor.
ii.	El cliente espera la informacion de respuesta por parte del servidor, dicha respuesta se descompone en dos cadenas usando como separador la palabra clave [{sep}] dando como resultado el nombre e informacion del usuario. 