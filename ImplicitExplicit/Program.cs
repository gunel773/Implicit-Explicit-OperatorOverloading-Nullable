
using ImplicitExplicit.Domain.Models;

#region task1
//Kelvin ve Celsius(selsi) adli iki temperaturu gosteren klasslarimiz var ve 
//Degree adli property-leri var.
//Celcius uchun implicit operatorunu yazin: (0C = 273K)


Kelvin kelvin = new(500);
Celcius c = (Celcius)kelvin;
Console.WriteLine(c.C);


#endregion
#region  task2 
//Employee tipinden ibaret arrayiniz olacaq.
//Employee classinin icinde Name, Surname, Birthday, Salary propertileri olacaq
//Employelerin icinden metoda iki ferqli tarix ve salary gelir.
//Dogum gunu hemin tarixler arasinda olan ve maashi 2000 - den boyuk olan
//ishcilerin sayini gosteren method yazin.
//Employeelerin dogum gunu tarixlerini constructordan gonderin.

Employee employeess = new Employee();

employeess.EmployeesCount( new DateTime(1998, 01, 01), new DateTime(2005, 01, 01),2000);

#endregion