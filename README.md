# TicketsApi

## Descripción
La presente API tiene como función permitir crear, eliminar, editar y recuperar tickets, recupera todos o permite filtrar por uno específico por su identificador único.
Los ticket tienen un identificador, un usuario, una fecha de creación, una fecha de actualización y un estatus (abierto/cerrado). Ha sido desarrollada en Net Core con el lenguaje C#, su base de datos es SQL Server, como ORM se contó con Entity Framework.

## Ejecución en local
Para la ejecución en local de esta interfaz se debe crear de la base de datos, para esto se ha dispuesto la carpeta "Data Base Queries" con los Scripts para dicho fin, se encuentran enumerados con el orden de ejecución. Seguido a esto se debe iniciar el proyecto "TicketsApi" en Visual Studio, aparecerá una vista de Swagger en el navegador con los metodos Get, Post, Put y Delete. Al acceder a cada uno de los metodos se encuentra un botón de "TryOut" que despliega a la vez otro con nombre "Execute", desde este punto se puede ejecutar la API sin necesidad de utilizar Postman o similares, sin embargo, tambien se pueden utilizar herramientas como esta. 

A continuación se detalla la función de cada método y la forma de envío de información en el contenido o cuerpo cuando el método lo requiere:

### GET  api/Tickets
Recupera todos los tickets existentes. No requiere envío de información en el contenido o cuerpo.

### GET  api/Tickets/{id}
Recupera un ticket en específico, el identificador del ticket deseado debe ser enviado en la URL. Si no se encuentra un ticket con dicho error devolverá un error 404.
No requiere envío de información en el contenido o cuerpo.

### POST api/Tickets
Crea un nuevo ticket. 
JSON en cuerpo:
{
  "userId": 0,
  "statusId": 0,
  "description": "string",
  "status": {
    "idStatus": 0,
    "status1": "string"
  },
  "user": {
    "idUser": 0,
    "userName": "string",
    "userLastName": "string"
  }
}

### PUT api/Tickets
Edita un ticket existente, el identificador del ticket deseado debe ser enviado en la URL. Si no se encuentra un ticket con dicho identificador devolverá un error 404.

JSON en cuerpo:
{
  "userId": 0,
  "statusId": 0,
  "description": "string",
  "status": {
    "idStatus": 0,
    "status1": "string"
  },
  "user": {
    "idUser": 0,
    "userName": "string",
    "userLastName": "string"
  }
}

### DELETE api/Tickets/{id}
Elimina un ticket existente, el identificador del ticket a eliminar debe ser enviado en la URL. Si no se encuentra un ticket con dicho identificador devolverá un error 404.
No requiere envío de información en el contenido o cuerpo.



