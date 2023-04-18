// create a human, wizard, ninja, and samurai
Human john = new Human("John", 10, 10, 10, 100);
Wizard gandalf = new Wizard("Gandalf", 5, 25, 10);
Ninja naruto = new Ninja("Naruto", 10, 5, 75);
Samurai musashi = new Samurai("Musashi", 15, 10, 10);

// have the wizard attack the human and heal the human
gandalf.Attack(john); // output: Gandalf attacked John for 75 damage and healed for 75!
gandalf.Heal(john); // output: Gandalf healed John for 75 health!

// have the ninja attack the human and steal from the human
naruto.Attack(john); // output: Naruto attacked John for 75 damage!
naruto.Steal(john); // output: Naruto stole 5 health from John and added it to their own health!

// have the samurai attack the human and meditate
musashi.Attack(john); // output: Musashi attacked John for 45 damage!
musashi.Meditate(); // output: Musashi meditated and healed back to full health!