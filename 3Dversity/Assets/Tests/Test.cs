﻿using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Test
    {
        [Test]
        public void GameObject_CreatedWithGiven_WillHaveTheName(){
            var go = new GameObject("MyGameObject");
            Assert.AreEqual("MyGameObject", go.name);
        }
    }
}
