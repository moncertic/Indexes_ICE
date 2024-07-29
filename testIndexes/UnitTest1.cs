using indexes_Ice;
using Newtonsoft.Json.Linq;
using System;
using System.Reflection;

namespace testIndexes
{
    [TestClass]
    public class UnitTest1
    {
    
      
       
            [TestMethod]
            public void TestID()
            {
            Ingredients ing = new Ingredients(50, "BUNP011", "cheese", "Cheese Burger", "seseme");
            ing[0] = "JUM121";
            Assert.AreEqual(ing[0], "JUM121");


            }
            [TestMethod]
            public void TestUpdateName()
            {

            Ingredients ing = new Ingredients(50, "BUNP011", "cheese", "Cheese Burger", "seseme");
            ing[3] = "fish burger";

                Assert.AreEqual(ing[3], "fish burger");

            }

        [TestMethod]

        public void TestUpdateToppings() 
        {

            Ingredients ing = new Ingredients(50, "BUNP011", "cheese", "Cheese Burger", "seseme");                                                              
            ing[2] = "pickles";
            Assert.AreEqual(ing[2], "pickles");



        }

        [TestMethod]
        public void TestPrice()
        {

            Ingredients ing = new Ingredients(50, "BUNP011", "cheese", "Cheese Burger", "seseme");
            ing[1] = "roasted";
            Assert.AreEqual(ing[1], "roasted");



        }

        [TestMethod]
        public void TestBunType()
        {

            Ingredients ing = new Ingredients(50, "BUNP011", "cheese", "Cheese Burger", "seseme");
            ing[4] = 40.00;
            Assert.AreEqual(ing[4], 40.00);
        }
    }
    }

