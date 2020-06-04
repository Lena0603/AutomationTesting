﻿using System;
using System.IO;
using System.Reflection;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace VcsWebdriver.Tests
{
    public class TestsDemo
    {
        [Test]
        public static void Tests()
        {
            //var b = Path.GetDirectoryName(
            //    Path.GetDirectoryName((Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))));

            var assemblyName = Assembly.GetExecutingAssembly().Location;
            var directoryName = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(assemblyName)));

        }

        [Test]
        public static void TestExample()    
        {
            // 1 Preconditions
            // 2 Steps
            // 3 Result check

            Assert.AreEqual(2, 3, "Nelygu ! 2 != 3 ");
        }

        [Test]
        public static void TestKeturiYraLyginisSkaicius()
        {
            double liekana = 4 % 2;
            Assert.AreEqual(0, liekana, "Siaubas 4 nera lyginis skaicius");
        }

        [Test]
        public static void TestDevyniYraLyginisSkaicius()
        {
            double liekana = 9 % 2;
            Assert.Zero(liekana, "Siaubas 9 nera lyginis skaicius");
        }

        [Test]
        public static void TestDabarAstonuoliktaValanda()
        {
            DateTime dabar = DateTime.Now;
            Assert.AreEqual(18, dabar.Hour, "Laikas netinkamas");
        }

        [Test]
        public static void TestDivision()
        {
            int skaicius = 995;
            int dalinameIs = 3;
            int liekana = skaicius % dalinameIs;

            Assert.Zero(liekana, $"{skaicius} nesidalina is {dalinameIs}");
        }

        [Test]
        public static void WaitAndPass()
        {
            Thread.Sleep(1000);
            Assert.Pass("Palaukiau 5 sek ir pazaliavau");

        }

        //public static void Actions()
        //{
        //    var builder = new Actions();
        //    builder.KeyDown(Keys.Control);
        //    builder.Click();
        //    builder.KeyUp(Keys.Control);
        //    builder.Build().Perform();
        //}

    }
}
