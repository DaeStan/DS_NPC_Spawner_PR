using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum NPCType
{
    Farmer,
    Beggar,
    Shopowner,
    Witch
}

public class Beggar : NPCBase, INPC
{
    public void Spell()
    {
        SpellCasted = true;
    }
    public void Speak()
    {
        if (SpellCasted == true)
        {
            Debug.Log("Beggar cannot speak rn...");
            return;
        }
        Debug.Log("Do you have some change to spare?");
     }
}

public class Shopowner : NPCBase, INPC
{
    public void Spell()
    {
        SpellCasted = true;
    }
    public void Speak()
    {
        Debug.Log("Do you wish to purchase something?");
    }
}

public class Farmer : NPCBase, INPC
{
    public void Spell()
    {
        SpellCasted = true;
    }
    public void Speak()
    {
        Debug.Log("You reap what you sow...");
    }
}

public class Witch : NPCBase, INPC
{
    public void Speak()
    {
        Debug.Log("Woooooooooooooooooooooo I cast a spell on youuuuuuuuuuuuuuuuu");
    }
    public void Spell()
    {
        SpellCasted = false;
    }
}
