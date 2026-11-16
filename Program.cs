Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);

alexander.TakeDamage(10);
alexander.Heal(10);

Console.WriteLine(">>> Участники готовы <<<");
Console.WriteLine();
Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());
Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");
Hero probe = new Hero("   Проверка   ", 120);
Console.WriteLine($"Начало: [{probe.Name}] {probe.Health}/{probe.MaxHealth}");

probe.TakeDamage(20);
probe.Heal(5);
Console.WriteLine($"Обычные действия: {probe.Health}");

probe.Heal(2147483647);
Console.WriteLine($"Большое лечение: {probe.Health}");

probe.TakeDamage(2147483647);
Console.WriteLine($"Большой урон: {probe.Health}; жив: {probe.IsAlive()}");

probe.Heal(20);
probe.Heal(0);
probe.Heal(-10);
probe.TakeDamage(0);
probe.TakeDamage(-10);
Console.WriteLine($"После восстановления и неверных вызовов: {probe.Health}");

probe.GainExperience(40);
probe.GainExperience(0);
probe.GainExperience(-10);
probe.GainExperience(2147483647);
Console.WriteLine($"Опыт: {probe.Experience}; уровень: {probe.Level}");

Console.WriteLine($"Основной Александр: {alexander.Health}/{alexander.MaxHealth}");

Console.WriteLine();
Console.WriteLine("проверка Product");

Product iitems = new Product("Брак", - 5);
Console.WriteLine($"Создание с -5 {iitems.Quantity}");

Product items = new Product("Чебурек", 100);
Console.WriteLine($"До пополнения: {items.Quantity}");
items.Restock(3);
Console.WriteLine($"После пополнения на 3: {items.Quantity}");
items.Restock(-2);
Console.WriteLine($"После пополнения на -2: {items.Quantity}");