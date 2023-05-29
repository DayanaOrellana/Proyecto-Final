using Proyecto_Final.Vehiculos;
Automovil autom1 = new Automovil();



autom1.marca = "Toyota";
autom1.modelo = "Corolla";
autom1.color = "Rojo";
autom1.anio = 2015;
autom1.placa = "PJM 001456";
autom1.tipo = "Familiar";

Console.WriteLine("La marca del Automovil es {0}", autom1.marca);
Console.WriteLine("El modelo es {0}", autom1.modelo);
Console.WriteLine("El color disponible es {0}", autom1.color);
Console.WriteLine("El anño disponible es {0}", autom1.anio);
Console.WriteLine("La placa del Automovil es {0}", autom1.placa);
Console.WriteLine("El tipo de automovil es {0}", autom1.tipo);

autom1.bocina();
autom1.acelerar();
autom1.encender();
//autom1.apagar();
autom1.frenar();
autom1.Pasajeros();
autom1.Seguridad();
autom1.Combustible();
autom1.motor();

Console.WriteLine();

Camioneta cam= new Camioneta();


cam.marca = "Honda";
cam.modelo = "CRV";
cam.color = "Blanca";
cam.anio = 2011;
cam.placa = "PJM 985467";
cam.tipo = "Familiar";

Console.WriteLine("La marca de la Camioneta es {0}", cam.marca);
Console.WriteLine("El modelo es {0}", cam.modelo);
Console.WriteLine("El color disponible es{0}", cam.color);
Console.WriteLine("El anño disponible es {0}", cam.anio);
Console.WriteLine("La placa de la Camioneta es {0}", cam.placa);
Console.WriteLine("El tipo de Camioneta es {0}", cam.tipo);

cam.bocina();
cam.acelerar();
cam.encender();
//cam.apagar();
cam.frenar();
cam.Pasajeros();
cam.Seguridad();
cam.Viajes();
cam.Rutas();

Console.WriteLine();

Convertible con = new Convertible();


con.marca = "BMW";
con.modelo = "Serie 8";
con.color = "Cafe";
con.anio = 2021;
con.placa = "PJM 985467";
con.tipo = "Carreras";

Console.WriteLine("La marca del Convertible es {0}", con.marca);
Console.WriteLine("El modelo es {0}", con.modelo);
Console.WriteLine("El color disponible es {0}", con.color);
Console.WriteLine("El anño disponible es {0}", con.anio);
Console.WriteLine("La placa del Convertible es {0}", con.placa);
Console.WriteLine("El tipo de Convertible es {0}", con.tipo);

con.bocina();
con.acelerar();
con.encender();
//con.apagar();
con.frenar();
con.Pasajeros();
con.Techo();
con.Libertad();
con.Carroceria();

Console.WriteLine();


_4x4 ful = new _4x4();


ful.marca = "RAM";
ful.modelo = "Pick-up";
ful.color = "Blanca";
ful.anio = 2022;
ful.placa = "PJM 985467";
ful.tipo = "Recargada";

Console.WriteLine("La marca de la 4x4 es {0}", ful.marca);
Console.WriteLine("El modelo es {0}", ful.modelo);
Console.WriteLine("El color disponible es {0}", ful.color);
Console.WriteLine("El anño disponible es {0}", ful.anio);
Console.WriteLine("La placa de la 4x4 es {0}", ful.placa);
Console.WriteLine("El tipo de la 4x4 es {0}", ful.tipo);

ful.bocina();
ful.acelerar();
ful.encender();
//ful.apagar();
ful.frenar();
ful.Pasajeros();
ful.Seguridad();
ful.Aceleracion();
ful.Motor();

Console.WriteLine();


