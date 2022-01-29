using System;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    [Test]
    public void CtorShouldInitializeRequiredValues()
    {
        HeroRepository heroRepository = new HeroRepository();
        Assert.IsNotNull(heroRepository.Heroes);
    }

    [Test]
    public void CountMethodShouldWorkProperly()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        Assert.AreEqual
            ("Successfully added hero Gosho with level 7", heroRepository.Create(hero));
        Assert.AreEqual
            ("Successfully added hero Tosho with level 2", heroRepository.Create(hero1));
        Assert.AreEqual
            ("Successfully added hero Ivan with level 6", heroRepository.Create(hero2));
    }

    [Test]
    public void CreateMathodShouldCreatHeroWithValidData()
    {
        Hero hero = new Hero("Gosho", 7);
        HeroRepository heroRepository = new HeroRepository();
        var message = heroRepository.Create(hero);
        var expectedMessage = $"Successfully added hero {hero.Name} with level {hero.Level}";

        Assert.AreEqual(1, heroRepository.Heroes.Count);
        Assert.AreEqual(expectedMessage, message);
    }

    [Test]
    public void CreateMathodShouldThrowExceptionWhenTheHeroAlredyExist()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        Assert.Throws<InvalidOperationException>(() => heroRepository.Create(hero2));
    }

    [Test]
    public void CreateMathodShouldThrowExceptionWhenTheHeroNameIsNull()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        Hero hero3 = null;
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        Assert.Throws<ArgumentNullException>(() => heroRepository.Create(hero3));
    }

    [Test]
    public void RemoveMethodShouldWorkProperlyWithValidData()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        Assert.AreEqual(true, heroRepository.Remove("Gosho"));

    }

    [Test]
    public void RemoveMethodShouldWorkProperlyWithValidDataWhichDontExist()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        Assert.AreEqual(false, heroRepository.Remove("Tutu"));

    }

    [Test]
    public void RemoveMethodShouldThrowExceptionWhenTheNameIsNull()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        
        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(null));

    }

    [Test]
    public void RemoveMethodShouldThrowExceptionWhenTheNameIsEmptyString()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);


        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(""));

    }

    [Test]
    public void RemoveMethodShouldThrowExceptionWhenTheNameIsWhiteSpace()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);


        Assert.Throws<ArgumentNullException>(() => heroRepository.Remove(" "));

    }

    [Test]
    public void GetHeroWithHighestLevelMethodShouldReturnCorrectHero()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        Assert.AreSame(hero, heroRepository.GetHeroWithHighestLevel());

    }

    [Test]
    public void GetHeroMethodShouldReturnCorrectHero()
    {
        Hero hero = new Hero("Gosho", 7);
        Hero hero1 = new Hero("Tosho", 2);
        Hero hero2 = new Hero("Ivan", 6);
        HeroRepository heroRepository = new HeroRepository();
        heroRepository.Create(hero);
        heroRepository.Create(hero1);
        heroRepository.Create(hero2);

        Assert.AreSame(hero, heroRepository.GetHero("Gosho"));

    }

}