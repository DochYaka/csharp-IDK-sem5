Player player = new Player(name: "Gideon", health: new Health());

Cigarette cigarette = new LongCigarette(range: 10, shotSpeed: 5, 
    smoke: new PoisonSmoke(periodicDamage: 5, spreading: 1, damage: 10));

player.Inspect(cigarette);