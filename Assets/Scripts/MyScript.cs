using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
namespace BeyondTheBasics                                           //namespaces, class definitons and method names are written in PascalCase
{
    public class MyScript : MonoBehaviour
    {
        #region Variable Declarations     
        public int number;                                          // fields, parameters in a method are written in camelCase
        public float floatingpointNumber;
        //public var randomNumber = Random.Range(0, 5);             // var can only declared as local variable
        
        #endregion
        #region Private Methods
        void Start()
        {

            AnonymousTypeMethod();


        }
        
        private void AnonymousTypeMethod()
        {
            var randomNumber = Random.Range(0, 5);                  // As you can see var is declared and initialized as local field. This however is implicit typing 
                                                                    // The type of the variable will change according to the type of data stored in the field.
            var bossList = new[]{ new { name = "Anubis", HitPoints = 100 },
                              new { name = "Killer", HitPoints = 100 },
                              new { name = "Chariot", HitPoints = 100 }
                            };

            var bossQuery =
                from boss in bossList
                orderby boss.name
                select boss;
                
            foreach(var boss in bossList)
            Debug.Log(boss.name);
        }

        #endregion
    }// MyScript

}