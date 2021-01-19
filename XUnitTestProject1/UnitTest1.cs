using System;
using Xunit;
using Lab06_OOP.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void testIguana()
        {
            Iguana george = new Iguana() { numHorns = 1 };
            string expected = "I'm just better than you";
            george.beCool();
            george.eat();

            Assert.Equal(expected, george.beCool());
            Assert.True(george.likesFrank);

            //next assert checks inheritance on reptile
            Assert.False(george.Poisonous);
            //next assert checks inheritance from lizard
            Assert.Equal(1, george.numHorns);
        }
        [Fact]
        public void testSnake()
        {
            Snake dangernoodle = new Snake() { Poisonous = true, Carnivore = "yes" };

            Assert.Equal("yes", dangernoodle.Carnivore);
            Assert.True(dangernoodle.Poisonous);
        }
        [Fact]
        public void testDolphin()
        {
            Dolphin franklin = new Dolphin() { Waterboi = true, shouldRide = "absolutely" };
            franklin.makeMilk();
            string expected = "Make that milk";
            string expectedInterface = "absolutely";

            Assert.Equal(expected, franklin.makeMilk());
            Assert.True(franklin.Waterboi);
            //test below checks for interface + ridable
            Assert.Equal(expectedInterface, franklin.shouldRide);
        }
        [Fact]
        public void testBat()
        {
            Bat skellaluna = new Bat() { Waterboi = false, canFly = true };
            skellaluna.SCREE();
            skellaluna.CleanFur();
            skellaluna.sleep();
            string expected = "scree but less";
            string expectedSleep = "Bats sleep during the day!";

            Assert.Equal(expected, skellaluna.SCREE());
            Assert.False(skellaluna.Waterboi);
            Assert.Equal(expectedSleep, skellaluna.sleep());
            //test below utilizes the interface flyboi
            Assert.True(skellaluna.canFly);
        }
        [Fact]
        public void testLizard()
        {
            Lizard josh = new Lizard() { Poisonous = true, Waterboi = false, LaysEgg = false };

            Assert.True(josh.Poisonous);
            Assert.False(josh.Waterboi);
            Assert.False(josh.LaysEgg);
            Assert.True(josh.Poisonous);
        }

    }
}
