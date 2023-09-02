Fighter BruceLee = new Fighter("Bruce Lee");
Ranger Legolas = new Ranger("Legolas");
Wizard Gandalf = new Wizard("Gandalf");


BruceLee.PerformAttack(Legolas, BruceLee.AttackList[1]);
BruceLee.Rage(Gandalf);
Legolas.PerformAttack(BruceLee, Legolas.AttackList[0]);
Legolas.Dash();
Legolas.PerformAttack(BruceLee, Legolas.AttackList[0]);
Gandalf.PerformAttack(BruceLee, Gandalf.AttackList[0]);
Gandalf.Heal(Legolas);
Gandalf.Heal(Gandalf);