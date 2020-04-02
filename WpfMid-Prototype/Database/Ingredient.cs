using System;
using System.Collections.Generic;

namespace WpfMid_Prototype.Database
{
    class Ingredient
    {
        int amount; //amount of a given measurement
        String measurement; // measure of amount
        String ingredient; //main* ingredient

        List<Ingredient> alternatives;
        //Ingredient[] alternatives; //list of alternative ingredients

        Ingredient(int amt, string measure, string ingr, Ingredient[] alts)
        {
            this.amount = amt;
            this.measurement = measure;
            this.ingredient = ingr;
            //if there are no alternatives presented, then alternatives is created as an empty list.
            if (alts.Length == 0)
            {
                alternatives = new List<Ingredient>();
            } else
            {
                for (int i = 0; i < alts.Length; i++)
                {
                    alternatives.Add(alts[i]);
                }
            }
        }

        ~Ingredient() { }
    }
}
