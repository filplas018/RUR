// See https://aka.ms/new-console-template for more information
using NávrhoveVzory_III_RUR.Models;

Robot Helena = new Robot();

Ovladac.PredejPovel(Helena, new Povel(Aktivita.BROUSENI, "tady", new TimeSpan(0,5,0)));
Ovladac.PredejPovel(Helena, new Povel(Aktivita.REZANI, "tady vedle", new TimeSpan(0,5,0)));

Helena.VypisCinnosti();

