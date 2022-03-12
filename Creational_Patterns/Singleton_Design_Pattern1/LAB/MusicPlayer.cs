using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern1.LAB
{
    public class MusicPlayer
    {

        //In this pattern, we do not want the user to create an object at her own request in any way.
        //We want the user to create an object only once, as she will use it all the time.

        //In order to prevent our constructor method used while creating an object from being used outside of our class and producing a new object, 
        //we have set it as "Private", but I can call it inside my class and use it.
        private MusicPlayer()
        {

        }

        //Why did we make our field static here. Because I can no longer access my elements and methods in my class by creating objects, 
        //but I can access my static methods without creating objects directly.
        //Well, if my class elements that I will use in static are not static, can I access them? NO .
        //Because when the class is called, my static elements are created directly in the "heap" area. For this reason, 
        //the elements to be used must be created directly in the heap area.
        private static MusicPlayer _instance;

        //I called my class and accessed my static method directly.
        public static MusicPlayer Instance()
        {

            //To check, I created an if block. So if the object is not created, 
            //I created it and marked it in its reference. If it is, I get the created object.
            if (_instance == null)
            {
                _instance = new MusicPlayer();
            }

            return _instance;


        }

        //Now I have created my object and I can assign a value to the class element and method I want and use it.
        public string Player()
        {
            return "Music is playing.";
        }





    }
}
