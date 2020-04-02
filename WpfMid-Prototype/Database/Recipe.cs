using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMid_Prototype.Database
{

    class Recipe
    {
        //List of fields roughly in order of submission on the upload recipe page
        //Page 1 - Basic Information
        String name; // recipe name
        int difficulty; // 1-5 star representation
        int prepTime; // in minutes
        int cookTime; // in minutes
        int portions; // number of servings
        List<string> dietaryRestricitons; // list of constraints
        String authorNotes; // general notes from the author

        //Page 2 - Ingredients and Appliances
        List<Ingredient> ingredients; // list of main* ingredients in the recipe
        List<String> appliances; // list of appliances used in the recipe.

        //Page 3 - Instructions
        List<Instruction> instructions; // list of instructions for the recipe

        //Page 4 - Preview
        bool published; // indicates if the recipe has been published (True) or is not yet finished (False)

        //constructor to create a full recipe all at once
        Recipe(string name, int diff, int prep, int cook, int portions, List<string> constraints, string aNotes, List<Ingredient> ingr, List<String> apps, List<Instruction> instr, bool pub)
        {
            this.name = name;
            this.difficulty = diff;
            this.prepTime = prep;
            this.cookTime = cook;
            this.portions = portions;
            this.dietaryRestricitons = constraints;
            this.authorNotes = aNotes;
            this.ingredients = ingr;
            this.appliances = apps;
            this.instructions = instr;
            this.published = pub;
        }

        //constructor to create a blank recipe (for piecemeal creation via upload)
        Recipe() { }

        //setters
        void setName(string name) { this.name = name; }
        void setDifficulty(int diff) { this.difficulty = diff; }
        void setPrepTime(int time) { this.prepTime = time; }
        void setCookTime(int time) { this.cookTime = time; }
        void setPortions(int portly) { this.portions = portly; }
        void setDietaryRestrictions(List<String> constraints) { this.dietaryRestricitons = constraints; }
        void setAuthorNotes(string notes) { this.authorNotes = notes; }
        void setIngredients(List<Ingredient> ingr) { this.ingredients = ingr; }
        void setInstructions(List<Instruction> instr) { this.instructions = instr; }
        void setPublished(bool pub) { this.published = pub; }

        //getters
        string getName() { return this.name; }
        int getDiff() { return this.difficulty; }
        int getPrepTime() { return this.prepTime; }
        int getCookTime() { return this.cookTime; }
        int getPortions() { return this.portions; }
        List<string> getDietaryRestrictions() { return this.dietaryRestricitons;  }
        string getAuthorNotes() { return this.authorNotes; }
        List<Ingredient> GetIngredients() { return this.ingredients; }
        List<Instruction> GetInstructions() { return this.instructions; }
        bool getPublished() { return this.published; }

        ~Recipe() { }
    }
}
