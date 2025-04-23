# pedidosApp

## Preguntas de Comprensión

### 1. ¿Qué ventaja ofrece usar una interfaz en lugar de una clase concreta?: 

La ventaja principal de usar una interfaz es que permite el desacoplamiento.
Si usáramos una clase base (abstracta), sería más útil cuando las clases compartieran atributos o lógica común, lo cual no ocurre aquí. Por eso, una interfaz es más adecuada
para definir un contrato sin imponer una implementación.

### 2. ¿Por qué separamos la lógica de selección de entrega del objeto Pedido?: 

la separamos para implementar la entrega de cada pedido de diferente forma de acuerdo a las características del producto (acá usamos polimorfismo)

### 3. ¿Cuál de los principios SOLID consideras más importante en este ejercicio? ¿Por
qué?: 

El principio más importante en este caso es el de Responsabilidad Única (S), por que porque cada clase tiene una sola tarea: Pedido maneja datos del pedido,
EntregaFactory decide la entrega, y RegistroPedidos guarda los pedidos. 

### 4. Si se quiere añadir una entrega por "bicicleta" para pedidos ecológicos, ¿qué clases cambiarías?:

agregaria una clase "bicicleta" que implemente la interfaz IMetodoEntrega, y modificaría EntregaFactory para incluir la lógica que retorne esta entrega si el pedido es ecológico.

### 5. ¿Cómo favorece el uso de estos patrones el mantenimiento del sistema?: 

nos permite modular de una mejor manera el proyecto, y así lo hacemos más escalable

### 6. ¿En qué casos reales usarías el patrón Singleton?:

"usaría singleton por ejemplo en una app de banco  cuando necesito una única instancia global accesible en toda la app,
En una app bancaria podría usarse para manejar la sesión actual del usuario o el historial de operaciones.



## CAPTURAS DE PANTALLA APP:
![image](https://github.com/user-attachments/assets/c38002d1-7065-4434-91db-24529ecb0ed6)


como el tipo de producto es tecnologia y tambien como es urgente, entonces la entrega es por Dron
![image](https://github.com/user-attachments/assets/839bf21a-e24a-4d86-ac5b-9301d04daa7f)

### Funcionamiento
El usuario ingresa los datos del pedido en un formulario  (cliente, tipo de producto, urgencia, peso y distancia).  
Al hacer clic en "Calcular", se asigna automáticamente el método de entrega según las reglas del negocio, y se muestra el tipo de entrega y el costo.  
Cada pedido se guarda en una lista 







