﻿using Colegio;
using Personas;
Salon salon = new Salon();
Estudiante E1_ = new Estudiante();
Estudiante E2_ = new Estudiante();
Estudiante E3_ = new Estudiante();
Entrenador Eu_ = new Entrenador();
salon.Eu = Eu_;
salon.E1 = E1_;
salon.E2 = E2_;
salon.E3 = E3_;
Console.WriteLine("Inserte nombre el alumno 1: ");
E1_.Name = Console.ReadLine();
Console.WriteLine("Inserte nombre el alumno 2: ");
 E2_.Name = Console.ReadLine();
Console.WriteLine("Inserte nombre el alumno 3: ");
 E3_.Name = Console.ReadLine();
Console.WriteLine("Inserte nombre del entrenador: ");
 Eu_.Name = Console.ReadLine();
salon.PasarAsistencia();
E1_.Estudia();
Eu_.HaceEjercicio();