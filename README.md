# EjemplosSOLID

1-Single Responsability:
Para este principio tome como ejemplo algo que me habian marcado en el examen final donde dentro de la clase Cotizacion, el metodo imprimir ademas de devolver la informacion para ser impresa, le da formato a la misma, por lo que opte por crear una clase que se especialice en darle formato a las Cotizaciones, dejando al metodo imprimir con una sola responsabilidad. Ademas de que facilita agregar nuevos formatos en casos requeridos

2-Open/Closed:
Para este principio di como ejemplo una carrera con diferentes tipos de corredor, en caso de querer agregar un nuevo tipo de corredor se tendria que modificar directamente la implementacion de la clase carrera. Con la solucion este no es necesario, simplemente se agrega un nuevo corredor que implemente la interfaz y listo.

3-Liskov Sustitution:
Para este principio use un caso del armado de un juego donde jugador y enemigo heredan de Personaje. Esto genera un conflicto ya que no todos los personajes pueden curarse como en el caso de enemigo. La solucion fue crear interfaces directamente relacionadas con las acciones para poder dividir las acciones entre los diferentes tipos de personajes.

4-Interface Segregation:
Para este principio nuevamente un ejemplo con tipos de personajes, pero esta ves implementa de una interfaz personaje donde nuevamente no todos los tipos de personajes pueden hacer las acciones de ese personaje. La solucion fue dividir la enorme interfaz en interfaces mas pequeñas para poder dividir las acciones entre los personajes.

5-Dependency Inversion:
Para este principio use un ejemplo de la creacion de una orden de compra que luego crea y descarga un archivo de excel, pero en caso de querer cambiar el tipo de archivo en un futuro habria que modificar directamente la clase. La solucion fue la creacion de una intefaz para poder crear archivos de cualquier tipo segun sea adecuado.
