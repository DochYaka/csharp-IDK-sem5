// Player player = new Player(name: "Gideon", health: new Health());

// Cigarette cigarette = new LongCigarette(range: 10, shotSpeed: 5, 
//     smoke: new PoisonSmoke(periodicDamage: 5, spreading: 1, damage: 10));

// player.Inspect(cigarette);

Ingredient powder = 
    new Ingredient("Порох", 1, true, "Чёрный, взрывоопасный");

Ingredient sera = 
    new Ingredient("Сера", 1, true, "Жёлтая, взрывоопасный");

Ingredient water = 
    new Ingredient("Вода", 1, true, "Морская, солёная");

Inventory inventory = new Inventory();

inventory.AddItem(water);
inventory.AddItem(powder);
inventory.AddItem(sera);

inventory.CheckInventory();


Recipe recipe1 = new Recipe("Взрывная вода",
new List<Ingredient>{new Ingredient("Вода", 1), new Ingredient("Порох", 1), new Ingredient("Сера", 1)},
2,
new Ingredient("Взрывная вода", 1));

RecipeBook recipeBook = new RecipeBook();

recipeBook.AddRecipe(recipe1);

// recipeBook.CheckRecipe();

var boomwater = recipeBook.CheckRecipe("Взрывная вода");

Craft craft = new Craft(recipeBook, inventory);
craft.craft("Взрывная вода");